
namespace Exercise3 {
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
            this.btPlus = new System.Windows.Forms.Button();
            this.ofdOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.btSelect = new System.Windows.Forms.Button();
            this.bt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btPlus
            // 
            this.btPlus.Location = new System.Drawing.Point(23, 237);
            this.btPlus.Name = "btPlus";
            this.btPlus.Size = new System.Drawing.Size(134, 58);
            this.btPlus.TabIndex = 0;
            this.btPlus.Text = "追加";
            this.btPlus.UseVisualStyleBackColor = true;
            this.btPlus.Click += new System.EventHandler(this.btPlus_Click);
            // 
            // ofdOpenFile
            // 
            this.ofdOpenFile.FileName = "openFileDialog1";
            // 
            // btSelect
            // 
            this.btSelect.Location = new System.Drawing.Point(23, 34);
            this.btSelect.Name = "btSelect";
            this.btSelect.Size = new System.Drawing.Size(134, 68);
            this.btSelect.TabIndex = 1;
            this.btSelect.Text = "選択";
            this.btSelect.UseVisualStyleBackColor = true;
            this.btSelect.Click += new System.EventHandler(this.btSelect_Click);
            // 
            // bt
            // 
            this.bt.Location = new System.Drawing.Point(23, 133);
            this.bt.Name = "bt";
            this.bt.Size = new System.Drawing.Size(134, 75);
            this.bt.TabIndex = 2;
            this.bt.Text = "追加先";
            this.bt.UseVisualStyleBackColor = true;
            this.bt.Click += new System.EventHandler(this.bt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt);
            this.Controls.Add(this.btSelect);
            this.Controls.Add(this.btPlus);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btPlus;
        private System.Windows.Forms.OpenFileDialog ofdOpenFile;
        private System.Windows.Forms.Button btSelect;
        private System.Windows.Forms.Button bt;
    }
}

