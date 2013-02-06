namespace GetSitesForLastPass
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.grpBoxResult = new System.Windows.Forms.GroupBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnGetURLS = new System.Windows.Forms.Button();
            this.lblCoolBlueWebsiteURL = new System.Windows.Forms.Label();
            this.btnCopyToClipboard = new System.Windows.Forms.Button();
            this.cbWebsiteURL = new System.Windows.Forms.ComboBox();
            this.grpBoxSource = new System.Windows.Forms.GroupBox();
            this.grpBoxControl = new System.Windows.Forms.GroupBox();
            this.grpBoxResult.SuspendLayout();
            this.grpBoxSource.SuspendLayout();
            this.grpBoxControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxResult
            // 
            this.grpBoxResult.Controls.Add(this.txtResult);
            this.grpBoxResult.Location = new System.Drawing.Point(193, 12);
            this.grpBoxResult.Name = "grpBoxResult";
            this.grpBoxResult.Size = new System.Drawing.Size(253, 203);
            this.grpBoxResult.TabIndex = 0;
            this.grpBoxResult.TabStop = false;
            this.grpBoxResult.Text = "Result";
            // 
            // txtResult
            // 
            this.txtResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResult.Location = new System.Drawing.Point(6, 20);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResult.Size = new System.Drawing.Size(241, 177);
            this.txtResult.TabIndex = 0;
            // 
            // btnGetURLS
            // 
            this.btnGetURLS.Location = new System.Drawing.Point(9, 19);
            this.btnGetURLS.Name = "btnGetURLS";
            this.btnGetURLS.Size = new System.Drawing.Size(155, 37);
            this.btnGetURLS.TabIndex = 1;
            this.btnGetURLS.Text = "Go !!!";
            this.btnGetURLS.UseVisualStyleBackColor = true;
            this.btnGetURLS.Click += new System.EventHandler(this.btnGetURLS_Click);
            // 
            // lblCoolBlueWebsiteURL
            // 
            this.lblCoolBlueWebsiteURL.AutoSize = true;
            this.lblCoolBlueWebsiteURL.Location = new System.Drawing.Point(6, 24);
            this.lblCoolBlueWebsiteURL.Name = "lblCoolBlueWebsiteURL";
            this.lblCoolBlueWebsiteURL.Size = new System.Drawing.Size(76, 13);
            this.lblCoolBlueWebsiteURL.TabIndex = 2;
            this.lblCoolBlueWebsiteURL.Text = "Select website";
            // 
            // btnCopyToClipboard
            // 
            this.btnCopyToClipboard.Location = new System.Drawing.Point(9, 65);
            this.btnCopyToClipboard.Name = "btnCopyToClipboard";
            this.btnCopyToClipboard.Size = new System.Drawing.Size(155, 37);
            this.btnCopyToClipboard.TabIndex = 4;
            this.btnCopyToClipboard.Text = "Copy result to clipboard";
            this.btnCopyToClipboard.UseVisualStyleBackColor = true;
            this.btnCopyToClipboard.Click += new System.EventHandler(this.btnCopyToClipboard_Click);
            // 
            // cbWebsiteURL
            // 
            this.cbWebsiteURL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWebsiteURL.FormattingEnabled = true;
            this.cbWebsiteURL.Items.AddRange(new object[] {
            "http://www.coolblue.be",
            "http://opendesktop.org",
            "http://fallout3.nexusmods.com"});
            this.cbWebsiteURL.Location = new System.Drawing.Point(9, 40);
            this.cbWebsiteURL.Name = "cbWebsiteURL";
            this.cbWebsiteURL.Size = new System.Drawing.Size(155, 21);
            this.cbWebsiteURL.TabIndex = 5;
            // 
            // grpBoxSource
            // 
            this.grpBoxSource.Controls.Add(this.lblCoolBlueWebsiteURL);
            this.grpBoxSource.Controls.Add(this.cbWebsiteURL);
            this.grpBoxSource.Location = new System.Drawing.Point(12, 12);
            this.grpBoxSource.Name = "grpBoxSource";
            this.grpBoxSource.Size = new System.Drawing.Size(175, 79);
            this.grpBoxSource.TabIndex = 6;
            this.grpBoxSource.TabStop = false;
            this.grpBoxSource.Text = "Source";
            // 
            // grpBoxControl
            // 
            this.grpBoxControl.Controls.Add(this.btnGetURLS);
            this.grpBoxControl.Controls.Add(this.btnCopyToClipboard);
            this.grpBoxControl.Location = new System.Drawing.Point(12, 97);
            this.grpBoxControl.Name = "grpBoxControl";
            this.grpBoxControl.Size = new System.Drawing.Size(175, 118);
            this.grpBoxControl.TabIndex = 7;
            this.grpBoxControl.TabStop = false;
            this.grpBoxControl.Text = "Control";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 225);
            this.Controls.Add(this.grpBoxControl);
            this.Controls.Add(this.grpBoxSource);
            this.Controls.Add(this.grpBoxResult);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Get all domain names";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpBoxResult.ResumeLayout(false);
            this.grpBoxResult.PerformLayout();
            this.grpBoxSource.ResumeLayout(false);
            this.grpBoxSource.PerformLayout();
            this.grpBoxControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxResult;
        private System.Windows.Forms.Button btnGetURLS;
        private System.Windows.Forms.Label lblCoolBlueWebsiteURL;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnCopyToClipboard;
        private System.Windows.Forms.ComboBox cbWebsiteURL;
        private System.Windows.Forms.GroupBox grpBoxSource;
        private System.Windows.Forms.GroupBox grpBoxControl;
    }
}

