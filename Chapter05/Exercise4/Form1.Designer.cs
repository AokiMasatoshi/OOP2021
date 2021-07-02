
namespace Exercise4 {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.tb2 = new System.Windows.Forms.TextBox();
            this.button5_4 = new System.Windows.Forms.Button();
            this.tb3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tb2
            // 
            this.tb2.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tb2.Location = new System.Drawing.Point(171, 30);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(527, 31);
            this.tb2.TabIndex = 0;
            // 
            // button5_4
            // 
            this.button5_4.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button5_4.Location = new System.Drawing.Point(51, 121);
            this.button5_4.Name = "button5_4";
            this.button5_4.Size = new System.Drawing.Size(80, 31);
            this.button5_4.TabIndex = 1;
            this.button5_4.Text = "5_4";
            this.button5_4.UseVisualStyleBackColor = true;
            this.button5_4.Click += new System.EventHandler(this.button5_4_Click);
            // 
            // tb3
            // 
            this.tb3.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tb3.Location = new System.Drawing.Point(160, 121);
            this.tb3.Name = "tb3";
            this.tb3.Size = new System.Drawing.Size(501, 31);
            this.tb3.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb3);
            this.Controls.Add(this.button5_4);
            this.Controls.Add(this.tb2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.Button button5_4;
        private System.Windows.Forms.TextBox tb3;
    }
}

