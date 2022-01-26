
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // btOthers
            // 
            this.btOthers.Location = new System.Drawing.Point(677, 462);
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
            this.lbTitle.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbTitle.Location = new System.Drawing.Point(185, 20);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(421, 35);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "プレミアリーグ21-22選手名鑑";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sample01.Properties.Resources.wallpaperbetter__1_;
            this.ClientSize = new System.Drawing.Size(834, 525);
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
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

