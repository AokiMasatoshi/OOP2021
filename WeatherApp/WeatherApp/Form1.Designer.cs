
namespace WeatherApp
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
            this.cbSelectArea = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btSelect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbSelectArea
            // 
            this.cbSelectArea.FormattingEnabled = true;
            this.cbSelectArea.Location = new System.Drawing.Point(166, 53);
            this.cbSelectArea.Name = "cbSelectArea";
            this.cbSelectArea.Size = new System.Drawing.Size(128, 23);
            this.cbSelectArea.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "地域を選択";
            // 
            // btSelect
            // 
            this.btSelect.Location = new System.Drawing.Point(320, 49);
            this.btSelect.Name = "btSelect";
            this.btSelect.Size = new System.Drawing.Size(78, 29);
            this.btSelect.TabIndex = 2;
            this.btSelect.Text = "選択";
            this.btSelect.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 514);
            this.Controls.Add(this.btSelect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbSelectArea);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbSelectArea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btSelect;
    }
}

