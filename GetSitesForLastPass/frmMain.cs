using System;
using System.Collections.Generic;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GetSitesForLastPass
{
    public partial class frmMain : Form
    {
        /// -------------------------------------------
        /// Constructor
        /// -------------------------------------------

        public frmMain()
        {
            InitializeComponent();
        }

        // -------------------------------------------
        // Form events
        // -------------------------------------------

        /// <summary>
        /// Form load event
        /// </summary>
        private void Form1_Load(object sender, EventArgs e)
        {
            this.cbWebsiteURL.SelectedIndex = 0;
        }

        /// <summary>
        /// Get domains button click event
        /// </summary>
        private void btnGetURLS_Click(object sender, EventArgs e)
        {
            this.grpBoxResult.Text = "Result";

            using (WebClient client = new WebClient())
            {
                string strHtmlCode = client.DownloadString(this.cbWebsiteURL.Text);
                List<string> listFoundUrls = new List<string>();
                bool bExtra = false;

                //Check which site is selected...                
                if (this.cbWebsiteURL.SelectedIndex == 0) //==> Get CoolBlue domains
                {
                    GetCoolBlueSites(strHtmlCode, ref listFoundUrls);
                    //Extra check...                    
                    foreach (string s in listFoundUrls)
                    {
                        if (s == "gsmstore.be")
                        {
                            bExtra = true;
                            strHtmlCode = client.DownloadString(string.Concat("http://www.", s));
                            break;
                        }
                    }
                    if (bExtra)
                        GetCoolBlueSites(strHtmlCode, ref listFoundUrls);
                }
                else if (this.cbWebsiteURL.SelectedIndex == 1) //==> Get openDesktop domains
                {
                    GetOpenDesktopSites(strHtmlCode, ref listFoundUrls);
                }
                else if (this.cbWebsiteURL.SelectedIndex == 2) //==> Get nexus domains
                {
                    GetNexusSites(strHtmlCode, ref listFoundUrls);
                }
                else
                {
                    MessageBox.Show("Could not process this site...", "Could not continue", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                WriteResults(ref listFoundUrls);
            }
        }

        /// <summary>
        /// Copy result to clipboard button click event
        /// </summary>
        private void btnCopyToClipboard_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.txtResult.Text))
                Clipboard.SetText(this.txtResult.Text);
            else
                MessageBox.Show("Nothing to paste to the clipboard...", "Nothing to paste", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        // -------------------------------------------
        // Private methods
        // -------------------------------------------

        /// <summary>
        /// Method to write all the URL's in the list to the results textBox
        /// </summary>
        /// <param name="listFoundUrls">The list of found URL's</param>
        private void WriteResults(ref List<string> listFoundUrls)
        {
            this.grpBoxResult.Text = string.Concat("Result - Found ", listFoundUrls.Count, " sites");

            this.txtResult.Text = "";

            listFoundUrls.Sort();

            foreach (string s in listFoundUrls)
            {
                this.txtResult.Text += string.Concat(s.Trim(), ", ");
            }

            if (!listFoundUrls.Contains(this.CleanURL(this.cbWebsiteURL.Text)))
                this.txtResult.Text = string.Concat(this.CleanURL(this.cbWebsiteURL.Text), ", ", this.txtResult.Text);

            if (this.txtResult.Text.EndsWith(", "))
                this.txtResult.Text = this.txtResult.Text.Trim().Trim(',').Trim();
        }

        /// <summary>
        /// Method to download all the CoolBlue sites from the given HTML source
        /// </summary>
        /// <param name="strHtmlCode">The HTML source</param>
        /// <param name="listFoundUrls">The list of found URL's</param>
        private void GetCoolBlueSites(string strHtmlCode, ref List<string> listFoundUrls)
        {
            string strRegex1 = ".*<a href=\"(.*)\" class=\"nopopup coolbluebar_shopcategory_shop_link\" title=\"(.*)\">.*";
            string strRegex11 = ".*<a href=\"(.*)\" class=\"coolbluebar_shopcategory_shop_link display_block outline_none decoration_none\".*";
            string strRegex2 = "a\\[.*=\".*\"\\],";
            string strFoundUrl = "";

            ExecuteRegexAndAddToList(strHtmlCode, strRegex1, ref listFoundUrls);
            ExecuteRegexAndAddToList(strHtmlCode, strRegex11, ref listFoundUrls);

            Regex urlRegex = new Regex(strRegex2);
            MatchCollection mc = urlRegex.Matches(strHtmlCode);
            foreach (Match m in mc)
            {
                strFoundUrl = m.Value;
                string[] strArrSplit = strFoundUrl.Split(new string[] { ", a[href*=\"" }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string s in strArrSplit)
                {
                    strFoundUrl = this.CleanURL(s);
                    if (!listFoundUrls.Contains(strFoundUrl))
                        listFoundUrls.Add(strFoundUrl);
                }
            }
        }

        /// <summary>
        /// Get all the domains from the opendesktop website
        /// </summary>
        /// <param name="strHtmlCode">The HTML source</param>
        /// <param name="listFoundUrls">The list of found URL's</param>
        private void GetOpenDesktopSites(string strHtmlCode, ref List<string> listFoundUrls)
        {
            string strRegex1 = "&nbsp;<a href=\"(http.*)\">(.*)</a>.*<br />";
            string strRegex2 = "<a class=\"maintopnaviopenpc\" href=\"(http.*)\">";
            string strFoundUrl = "";

            ExecuteRegexAndAddToList(strHtmlCode, strRegex1, ref listFoundUrls);

            Regex urlRegex = new Regex(strRegex1);
            MatchCollection mc = urlRegex.Matches(strHtmlCode);
            foreach (Match m in mc)
            {
                strFoundUrl = m.Value;
                string[] strArrSplit = strFoundUrl.Split(new string[] { "&nbsp;&nbsp;&nbsp;" }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string s in strArrSplit)
                {
                    ExecuteRegexAndAddToList(s, strRegex2, ref listFoundUrls);
                }
            }
        }

        /// <summary>
        /// Get all the domains from the nexus website
        /// </summary>
        /// <param name="strHtmlCode">The HTML source</param>
        /// <param name="listFoundUrls">The list of found URL's</param>
        private void GetNexusSites(string strHtmlCode, ref List<string> listFoundUrls)
        {
            string strRegex1 = "<li><a href=\"(.*)\">.*</li>";
            string strRegex2 = ".*<a href=\"(http.*nexusmods.com)\">.*";
            string strFoundUrl = "";

            Regex urlRegex = new Regex(strRegex1);
            MatchCollection mc = urlRegex.Matches(strHtmlCode);
            foreach (Match m in mc)
            {
                strFoundUrl = m.Value;
                string[] strArrSplit = strFoundUrl.Split(new string[] { "</li><li>" }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string s in strArrSplit)
                {
                    ExecuteRegexAndAddToList(s, strRegex2, ref listFoundUrls);
                }
            }
        }

        /// <summary>
        /// Method to clean a URL string to use with lastpass
        /// </summary>
        /// <param name="strUrl">The URL string</param>
        /// <returns>A cleaned URL</returns>
        private string CleanURL(string strUrl)
        {
            return strUrl.ToLower().Trim()
                .Replace("a[href*=\"", "")
                .Replace("\"]", "")
                .Replace("http://www.", "")
                .Replace("http://", "")
                .Replace("https://www.", "")
                .Replace("https://", "")
                .Replace(",", "")
                .Trim('.').Trim();
        }

        /// <summary>
        /// Executes a regular expression and adds the resulting found groups to a given list
        /// </summary>
        /// <param name="strHtmlCode">The text to apply the regex on</param>
        /// <param name="strRegularExpression">The expression</param>
        /// <param name="listFoundUrls">The list with the results</param>
        private void ExecuteRegexAndAddToList(string strHtmlCode, string strRegularExpression, ref List<string> listFoundUrls)
        {
            Regex urlRegex = new Regex(strRegularExpression);
            MatchCollection mc = urlRegex.Matches(strHtmlCode);
            string strFoundUrl;

            foreach (Match m in mc)
            {
                /*if (m.Groups.Count == 3)
                {*/
                strFoundUrl = this.CleanURL(m.Groups[1].Value);
                if (!listFoundUrls.Contains(strFoundUrl))
                    listFoundUrls.Add(strFoundUrl);
                //}
            }
        }

    }
}
