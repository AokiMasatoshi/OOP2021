
namespace Sample01
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
            this.btOthers = new System.Windows.Forms.Button();
            this.lbTitle = new System.Windows.Forms.Label();
            this.btClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btOthers
            // 
            this.btOthers.Location = new System.Drawing.Point(551, 461);
            this.btOthers.Name = "btOthers";
            this.btOthers.Size = new System.Drawing.Size(121, 42);
            this.btOthers.TabIndex = 0;
            this.btOthers.Text = "その他";
            this.btOthers.UseVisualStyleBackColor = true;
            this.btOthers.Click += new System.EventHandler(this.btOthers_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbTitle.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbTitle.Location = new System.Drawing.Point(185, 20);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(421, 35);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "プレミアリーグ21-22選手名鑑";
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(688, 461);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(123, 42);
            this.btClose.TabIndex = 2;
            this.btClose.Text = "終了";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sample01.Properties.Resources.Stadium;
            this.ClientSize = new System.Drawing.Size(834, 525);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.btOthers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btOthers;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Button btClose;
    }
}

