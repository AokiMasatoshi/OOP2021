
namespace Sample0823
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
            this.tbValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbJyou = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btExec = new System.Windows.Forms.Button();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbValue
            // 
            this.tbValue.Font = new System.Drawing.Font("MS UI Gothic", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbValue.Location = new System.Drawing.Point(33, 29);
            this.tbValue.Name = "tbValue";
            this.tbValue.Size = new System.Drawing.Size(128, 54);
            this.tbValue.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(177, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "の";
           
            // 
            // tbJyou
            // 
            this.tbJyou.Font = new System.Drawing.Font("MS UI Gothic", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbJyou.Location = new System.Drawing.Point(249, 29);
            this.tbJyou.Name = "tbJyou";
            this.tbJyou.Size = new System.Drawing.Size(128, 54);
            this.tbJyou.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(402, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 44);
            this.label2.TabIndex = 1;
            this.label2.Text = "乗";
            
            // 
            // btExec
            // 
            this.btExec.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btExec.Location = new System.Drawing.Point(491, 28);
            this.btExec.Name = "btExec";
            this.btExec.Size = new System.Drawing.Size(147, 55);
            this.btExec.TabIndex = 2;
            this.btExec.Text = "結果";
            this.btExec.UseVisualStyleBackColor = true;
            this.btExec.Click += new System.EventHandler(this.btExec_Click);
            // 
            // tbResult
            // 
            this.tbResult.Font = new System.Drawing.Font("MS UI Gothic", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbResult.Location = new System.Drawing.Point(681, 29);
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(149, 54);
            this.tbResult.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 472);
            this.Controls.Add(this.btExec);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.tbJyou);
            this.Controls.Add(this.tbValue);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbJyou;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btExec;
        private System.Windows.Forms.TextBox tbResult;
    }
}

