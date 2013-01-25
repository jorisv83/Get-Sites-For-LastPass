using System;
using System.Collections.Generic;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GetCoolBlueSitesForLastPass
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGetURLS_Click(object sender, EventArgs e)
        {
            using (WebClient client = new WebClient()) // WebClient class inherits IDisposable
            {
                string strHtmlCode = client.DownloadString(this.txtCoolBlueWebsiteURL.Text);
                List<string> listFoundUrls = new List<string>();

                GetSites(strHtmlCode, ref listFoundUrls);

                bool bExtra = false;
                foreach (string s in listFoundUrls)
                {
                    if (s == "gsmstore.be")
                    {
                        bExtra = true;
                        strHtmlCode = client.DownloadString(string.Concat("http://www.", s));
                    }
                }

                if (bExtra)
                    GetSites(strHtmlCode, ref listFoundUrls);

                this.lblFoundResult.Text = string.Concat("Found ", listFoundUrls.Count, " sites");

                foreach (string s in listFoundUrls)
                {
                    this.txtResult.Text += string.Concat(s.Trim(), ", ");
                }

                if (!listFoundUrls.Contains(this.txtCoolBlueWebsiteURL.Text.Replace("http://www.", "").Replace("http://", "").Replace(",", "").Trim()))
                    this.txtResult.Text = string.Concat(this.txtCoolBlueWebsiteURL.Text.Replace("http://www.", "").Replace("http://", "").Replace(",", "").Trim(), ", ", this.txtResult.Text);

                if (this.txtResult.Text.EndsWith(", "))
                    this.txtResult.Text = this.txtResult.Text.Trim().Trim(',').Trim();
            }
        }

        private void GetSites(string strHtmlCode, ref List<string> listFoundUrls)
        {
            string strRegex1 = ".*<a href=\"(.*)\" class=\"nopopup coolbluebar_shopcategory_shop_link\" title=\"(.*)\">.*";
            string strRegex11 = ".*<a href=\"(.*)\" class=\"coolbluebar_shopcategory_shop_link display_block outline_none decoration_none\".*";
            string strRegex2 = "a\\[.*=\".*\"\\],";
            string strFoundUrl = "";


            Regex urlRegex = new Regex(strRegex1);
            MatchCollection mc = urlRegex.Matches(strHtmlCode);

            foreach (Match m in mc)
            {
                if (m.Groups.Count == 3)
                {
                    strFoundUrl = m.Groups[1].Value.ToLower().Replace("http://www.", "").Replace("http://", "").Replace(",", "").Trim();
                    if (!listFoundUrls.Contains(strFoundUrl))
                        listFoundUrls.Add(strFoundUrl);
                }
            }

            urlRegex = new Regex(strRegex11);
            mc = urlRegex.Matches(strHtmlCode);

            foreach (Match m in mc)
            {
                if (m.Groups.Count == 2)
                {
                    strFoundUrl = m.Groups[1].Value.ToLower().Replace("http://www.", "").Replace("http://", "").Replace(",", "").Trim();
                    if (!listFoundUrls.Contains(strFoundUrl))
                        listFoundUrls.Add(strFoundUrl);
                }
            }

            urlRegex = new Regex(strRegex2);
            mc = urlRegex.Matches(strHtmlCode);
            foreach (Match m in mc)
            {
                strFoundUrl = m.Value;
                string[] strArrSplit = strFoundUrl.Split(new string[] { ", a[href*=\"" }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string s in strArrSplit)
                {
                    strFoundUrl = s.Replace("a[href*=\"", "").Replace("\"]", "");
                    strFoundUrl = strFoundUrl.ToLower().Replace("http://www.", "").Replace("http://", "").Replace(",", "").Trim();
                    if (!listFoundUrls.Contains(strFoundUrl))
                        listFoundUrls.Add(strFoundUrl);
                }
            }
        }

        private void btnCopyToClipboard_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.txtResult.Text))
                Clipboard.SetText(this.txtResult.Text);
            else
                MessageBox.Show("Nothing to paste to the clipboard...", "Nothing to paste", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

    }
}
