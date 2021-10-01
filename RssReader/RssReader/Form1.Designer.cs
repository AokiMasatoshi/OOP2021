
namespace RssReader
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.lbTitles = new System.Windows.Forms.ListBox();
            this.btRead = new System.Windows.Forms.Button();
            this.lbldesc = new System.Windows.Forms.Label();
            this.btWeb = new System.Windows.Forms.Button();
            this.lbPubDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("ＭＳ ゴシック", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(9, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "RssReader";
            // 
            // tbUrl
            // 
            this.tbUrl.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbUrl.Location = new System.Drawing.Point(124, 10);
            this.tbUrl.Margin = new System.Windows.Forms.Padding(2);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(492, 26);
            this.tbUrl.TabIndex = 1;
            this.tbUrl.TextChanged += new System.EventHandler(this.tbUrl_TextChanged);
            // 
            // lbTitles
            // 
            this.lbTitles.FormattingEnabled = true;
            this.lbTitles.ItemHeight = 12;
            this.lbTitles.Location = new System.Drawing.Point(13, 57);
            this.lbTitles.Margin = new System.Windows.Forms.Padding(2);
            this.lbTitles.Name = "lbTitles";
            this.lbTitles.Size = new System.Drawing.Size(206, 328);
            this.lbTitles.TabIndex = 2;
            this.lbTitles.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbTitles_MouseClick);
            this.lbTitles.SelectedIndexChanged += new System.EventHandler(this.lbTitles_SelectedIndexChanged);
            // 
            // btRead
            // 
            this.btRead.Location = new System.Drawing.Point(637, 7);
            this.btRead.Margin = new System.Windows.Forms.Padding(2);
            this.btRead.Name = "btRead";
            this.btRead.Size = new System.Drawing.Size(76, 31);
            this.btRead.TabIndex = 4;
            this.btRead.Text = "読込み";
            this.btRead.UseVisualStyleBackColor = true;
            this.btRead.Click += new System.EventHandler(this.btRead_Click);
            // 
            // lbldesc
            // 
            this.lbldesc.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbldesc.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbldesc.Location = new System.Drawing.Point(238, 92);
            this.lbldesc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbldesc.Name = "lbldesc";
            this.lbldesc.Size = new System.Drawing.Size(378, 142);
            this.lbldesc.TabIndex = 5;
            // 
            // btWeb
            // 
            this.btWeb.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btWeb.Location = new System.Drawing.Point(240, 259);
            this.btWeb.Margin = new System.Windows.Forms.Padding(2);
            this.btWeb.Name = "btWeb";
            this.btWeb.Size = new System.Drawing.Size(98, 32);
            this.btWeb.TabIndex = 6;
            this.btWeb.Text = "Web表示";
            this.btWeb.UseVisualStyleBackColor = true;
            this.btWeb.Click += new System.EventHandler(this.btWeb_Click);
            // 
            // lbPubDate
            // 
            this.lbPubDate.AutoSize = true;
            this.lbPubDate.BackColor = System.Drawing.SystemColors.Control;
            this.lbPubDate.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbPubDate.Location = new System.Drawing.Point(238, 57);
            this.lbPubDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPubDate.Name = "lbPubDate";
            this.lbPubDate.Size = new System.Drawing.Size(0, 24);
            this.lbPubDate.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 402);
            this.Controls.Add(this.lbPubDate);
            this.Controls.Add(this.btWeb);
            this.Controls.Add(this.lbldesc);
            this.Controls.Add(this.btRead);
            this.Controls.Add(this.lbTitles);
            this.Controls.Add(this.tbUrl);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "32145";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbUrl;
        private System.Windows.Forms.ListBox lbTitles;
        private System.Windows.Forms.Button btRead;
        private System.Windows.Forms.Label lbldesc;
        private System.Windows.Forms.Button btWeb;
        private System.Windows.Forms.Label lbPubDate;
    }
}

