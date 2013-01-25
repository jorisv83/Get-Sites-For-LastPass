namespace GetCoolBlueSitesForLastPass
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
            this.btnGetURLS = new System.Windows.Forms.Button();
            this.txtCoolBlueWebsiteURL = new System.Windows.Forms.TextBox();
            this.lblCoolBlueWebsiteURL = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.lblFoundResult = new System.Windows.Forms.Label();
            this.btnCopyToClipboard = new System.Windows.Forms.Button();
            this.grpBoxResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxResult
            // 
            this.grpBoxResult.Controls.Add(this.txtResult);
            this.grpBoxResult.Location = new System.Drawing.Point(173, 12);
            this.grpBoxResult.Name = "grpBoxResult";
            this.grpBoxResult.Size = new System.Drawing.Size(264, 203);
            this.grpBoxResult.TabIndex = 0;
            this.grpBoxResult.TabStop = false;
            this.grpBoxResult.Text = "Result";
            // 
            // btnGetURLS
            // 
            this.btnGetURLS.Location = new System.Drawing.Point(12, 68);
            this.btnGetURLS.Name = "btnGetURLS";
            this.btnGetURLS.Size = new System.Drawing.Size(155, 53);
            this.btnGetURLS.TabIndex = 1;
            this.btnGetURLS.Text = "Go !!!";
            this.btnGetURLS.UseVisualStyleBackColor = true;
            this.btnGetURLS.Click += new System.EventHandler(this.btnGetURLS_Click);
            // 
            // txtCoolBlueWebsiteURL
            // 
            this.txtCoolBlueWebsiteURL.Location = new System.Drawing.Point(12, 32);
            this.txtCoolBlueWebsiteURL.Name = "txtCoolBlueWebsiteURL";
            this.txtCoolBlueWebsiteURL.Size = new System.Drawing.Size(155, 20);
            this.txtCoolBlueWebsiteURL.TabIndex = 0;
            this.txtCoolBlueWebsiteURL.Text = "http://www.coolblue.be";
            // 
            // lblCoolBlueWebsiteURL
            // 
            this.lblCoolBlueWebsiteURL.AutoSize = true;
            this.lblCoolBlueWebsiteURL.Location = new System.Drawing.Point(12, 16);
            this.lblCoolBlueWebsiteURL.Name = "lblCoolBlueWebsiteURL";
            this.lblCoolBlueWebsiteURL.Size = new System.Drawing.Size(113, 13);
            this.lblCoolBlueWebsiteURL.TabIndex = 2;
            this.lblCoolBlueWebsiteURL.Text = "CoolBlue main website";
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
            this.txtResult.Size = new System.Drawing.Size(252, 177);
            this.txtResult.TabIndex = 0;
            // 
            // lblFoundResult
            // 
            this.lblFoundResult.AutoSize = true;
            this.lblFoundResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoundResult.Location = new System.Drawing.Point(12, 189);
            this.lblFoundResult.Name = "lblFoundResult";
            this.lblFoundResult.Size = new System.Drawing.Size(0, 20);
            this.lblFoundResult.TabIndex = 3;
            // 
            // btnCopyToClipboard
            // 
            this.btnCopyToClipboard.Location = new System.Drawing.Point(12, 127);
            this.btnCopyToClipboard.Name = "btnCopyToClipboard";
            this.btnCopyToClipboard.Size = new System.Drawing.Size(155, 53);
            this.btnCopyToClipboard.TabIndex = 4;
            this.btnCopyToClipboard.Text = "Copy result to clipboard";
            this.btnCopyToClipboard.UseVisualStyleBackColor = true;
            this.btnCopyToClipboard.Click += new System.EventHandler(this.btnCopyToClipboard_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 227);
            this.Controls.Add(this.btnCopyToClipboard);
            this.Controls.Add(this.lblFoundResult);
            this.Controls.Add(this.lblCoolBlueWebsiteURL);
            this.Controls.Add(this.txtCoolBlueWebsiteURL);
            this.Controls.Add(this.btnGetURLS);
            this.Controls.Add(this.grpBoxResult);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Get all CoolBlue domain names";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpBoxResult.ResumeLayout(false);
            this.grpBoxResult.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxResult;
        private System.Windows.Forms.Button btnGetURLS;
        private System.Windows.Forms.TextBox txtCoolBlueWebsiteURL;
        private System.Windows.Forms.Label lblCoolBlueWebsiteURL;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label lblFoundResult;
        private System.Windows.Forms.Button btnCopyToClipboard;
    }
}

