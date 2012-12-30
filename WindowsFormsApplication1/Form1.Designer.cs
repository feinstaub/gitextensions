namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.helpImageDisplayUserControl1 = new GitUI.Help.HelpImageDisplayUserControl();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.helpImageDisplayUserControl2 = new GitUI.Help.HelpImageDisplayUserControl();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // helpImageDisplayUserControl1
            // 
            this.helpImageDisplayUserControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.helpImageDisplayUserControl1.AutoSize = true;
            this.helpImageDisplayUserControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.helpImageDisplayUserControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.helpImageDisplayUserControl1.Image1 = null;
            this.helpImageDisplayUserControl1.Image2 = null;
            this.helpImageDisplayUserControl1.Location = new System.Drawing.Point(2, 5);
            this.helpImageDisplayUserControl1.MinimumSize = new System.Drawing.Size(100, 150);
            this.helpImageDisplayUserControl1.Name = "helpImageDisplayUserControl1";
            this.helpImageDisplayUserControl1.ShowImage2HoverText = "Hover to see scenario when fast forward is possible.";
            this.helpImageDisplayUserControl1.ShowImage2OnHover = false;
            this.helpImageDisplayUserControl1.Size = new System.Drawing.Size(100, 150);
            this.helpImageDisplayUserControl1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.helpImageDisplayUserControl2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(177, 5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(445, 273);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // helpImageDisplayUserControl2
            // 
            this.helpImageDisplayUserControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.helpImageDisplayUserControl2.AutoSize = true;
            this.helpImageDisplayUserControl2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.helpImageDisplayUserControl2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.helpImageDisplayUserControl2.Image1 = null;
            this.helpImageDisplayUserControl2.Image2 = null;
            this.helpImageDisplayUserControl2.Location = new System.Drawing.Point(3, 3);
            this.helpImageDisplayUserControl2.MinimumSize = new System.Drawing.Size(100, 150);
            this.helpImageDisplayUserControl2.Name = "helpImageDisplayUserControl2";
            this.helpImageDisplayUserControl2.ShowImage2HoverText = "Hover to see scenario when fast forward is possible.";
            this.helpImageDisplayUserControl2.ShowImage2OnHover = false;
            this.helpImageDisplayUserControl2.Size = new System.Drawing.Size(100, 150);
            this.helpImageDisplayUserControl2.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 294);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.helpImageDisplayUserControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GitUI.Help.HelpImageDisplayUserControl helpImageDisplayUserControl1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private GitUI.Help.HelpImageDisplayUserControl helpImageDisplayUserControl2;
    }
}

