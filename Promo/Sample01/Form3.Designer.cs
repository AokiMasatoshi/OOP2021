
namespace Sample01
{
    partial class Form3
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
            this.tbSelect = new System.Windows.Forms.TextBox();
            this.btSearch = new System.Windows.Forms.Button();
            this.wb1 = new System.Windows.Forms.WebBrowser();
            this.label1 = new System.Windows.Forms.Label();
            this.btBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbSelect
            // 
            this.tbSelect.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbSelect.Location = new System.Drawing.Point(25, 60);
            this.tbSelect.Name = "tbSelect";
            this.tbSelect.Size = new System.Drawing.Size(752, 31);
            this.tbSelect.TabIndex = 0;
            // 
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(809, 50);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(106, 41);
            this.btSearch.TabIndex = 1;
            this.btSearch.Text = "検索";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // wb1
            // 
            this.wb1.Location = new System.Drawing.Point(25, 108);
            this.wb1.MinimumSize = new System.Drawing.Size(20, 20);
            this.wb1.Name = "wb1";
            this.wb1.Size = new System.Drawing.Size(941, 553);
            this.wb1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("ＭＳ 明朝", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(65, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "選手の名前を入力してください";
            // 
            // btBack
            // 
            this.btBack.Location = new System.Drawing.Point(935, 51);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(106, 40);
            this.btBack.TabIndex = 4;
            this.btBack.Text = "戻る";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 673);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.wb1);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.tbSelect);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSelect;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.WebBrowser wb1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btBack;
    }
}