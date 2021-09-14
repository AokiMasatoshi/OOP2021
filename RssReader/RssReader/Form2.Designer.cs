
namespace RssReader
{
    partial class Form2
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
            this.wbBrowser2 = new System.Windows.Forms.WebBrowser();
            this.btMoveOn = new System.Windows.Forms.Button();
            this.btReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // wbBrowser2
            // 
            this.wbBrowser2.Location = new System.Drawing.Point(2, 62);
            this.wbBrowser2.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbBrowser2.Name = "wbBrowser2";
            this.wbBrowser2.Size = new System.Drawing.Size(795, 386);
            this.wbBrowser2.TabIndex = 0;
            this.wbBrowser2.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.wbBrowser2_DocumentCompleted);
            // 
            // btMoveOn
            // 
            this.btMoveOn.Location = new System.Drawing.Point(172, 8);
            this.btMoveOn.Name = "btMoveOn";
            this.btMoveOn.Size = new System.Drawing.Size(128, 44);
            this.btMoveOn.TabIndex = 1;
            this.btMoveOn.Text = "進む";
            this.btMoveOn.UseVisualStyleBackColor = true;
            this.btMoveOn.Click += new System.EventHandler(this.btMoveOn_Click);
            // 
            // btReturn
            // 
            this.btReturn.Location = new System.Drawing.Point(21, 8);
            this.btReturn.Name = "btReturn";
            this.btReturn.Size = new System.Drawing.Size(128, 44);
            this.btReturn.TabIndex = 1;
            this.btReturn.Text = "戻る";
            this.btReturn.UseVisualStyleBackColor = true;
            this.btReturn.Click += new System.EventHandler(this.btReturn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btReturn);
            this.Controls.Add(this.btMoveOn);
            this.Controls.Add(this.wbBrowser2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btMoveOn;
        private System.Windows.Forms.Button btReturn;
        private System.Windows.Forms.WebBrowser wbBrowser2;
    }
}