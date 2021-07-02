
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
            this.label1 = new System.Windows.Forms.Label();
            this.inputStrText = new System.Windows.Forms.TextBox();
            this.button5_3_1 = new System.Windows.Forms.Button();
            this.textBoxSpaceCount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button5_3_2 = new System.Windows.Forms.Button();
            this.tbWordChange = new System.Windows.Forms.TextBox();
            this.WordCountBotton = new System.Windows.Forms.Button();
            this.tbWordCount = new System.Windows.Forms.TextBox();
            this.button5_3_4 = new System.Windows.Forms.Button();
            this.tb5_3_4 = new System.Windows.Forms.TextBox();
            this.button5_3_5 = new System.Windows.Forms.Button();
            this.tb5_3_5 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.outputStrDate = new System.Windows.Forms.TextBox();
            this.inputStrDate = new System.Windows.Forms.TextBox();
            this.button5_4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(32, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "問題5.3";
            // 
            // inputStrText
            // 
            this.inputStrText.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.inputStrText.Location = new System.Drawing.Point(37, 72);
            this.inputStrText.Name = "inputStrText";
            this.inputStrText.Size = new System.Drawing.Size(553, 31);
            this.inputStrText.TabIndex = 1;
            // 
            // button5_3_1
            // 
            this.button5_3_1.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button5_3_1.Location = new System.Drawing.Point(22, 139);
            this.button5_3_1.Name = "button5_3_1";
            this.button5_3_1.Size = new System.Drawing.Size(128, 39);
            this.button5_3_1.TabIndex = 2;
            this.button5_3_1.Text = "空白をカウント";
            this.button5_3_1.UseVisualStyleBackColor = true;
            this.button5_3_1.Click += new System.EventHandler(this.button5_3_1_Click);
            // 
            // textBoxSpaceCount
            // 
            this.textBoxSpaceCount.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxSpaceCount.Location = new System.Drawing.Point(250, 148);
            this.textBoxSpaceCount.Name = "textBoxSpaceCount";
            this.textBoxSpaceCount.Size = new System.Drawing.Size(151, 28);
            this.textBoxSpaceCount.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(156, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "空白文字数";
            // 
            // button5_3_2
            // 
            this.button5_3_2.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button5_3_2.Location = new System.Drawing.Point(22, 199);
            this.button5_3_2.Name = "button5_3_2";
            this.button5_3_2.Size = new System.Drawing.Size(128, 39);
            this.button5_3_2.TabIndex = 2;
            this.button5_3_2.Text = "big→small";
            this.button5_3_2.UseVisualStyleBackColor = true;
            this.button5_3_2.Click += new System.EventHandler(this.button5_3_2_Click);
            // 
            // tbWordChange
            // 
            this.tbWordChange.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbWordChange.Location = new System.Drawing.Point(250, 204);
            this.tbWordChange.Name = "tbWordChange";
            this.tbWordChange.Size = new System.Drawing.Size(416, 28);
            this.tbWordChange.TabIndex = 3;
            // 
            // WordCountBotton
            // 
            this.WordCountBotton.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.WordCountBotton.Location = new System.Drawing.Point(22, 259);
            this.WordCountBotton.Name = "WordCountBotton";
            this.WordCountBotton.Size = new System.Drawing.Size(137, 30);
            this.WordCountBotton.TabIndex = 5;
            this.WordCountBotton.Text = "WordCount";
            this.WordCountBotton.UseVisualStyleBackColor = true;
            this.WordCountBotton.Click += new System.EventHandler(this.WordCountBotton_Click);
            // 
            // tbWordCount
            // 
            this.tbWordCount.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbWordCount.Location = new System.Drawing.Point(250, 261);
            this.tbWordCount.Name = "tbWordCount";
            this.tbWordCount.Size = new System.Drawing.Size(206, 28);
            this.tbWordCount.TabIndex = 6;
            // 
            // button5_3_4
            // 
            this.button5_3_4.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button5_3_4.Location = new System.Drawing.Point(25, 316);
            this.button5_3_4.Name = "button5_3_4";
            this.button5_3_4.Size = new System.Drawing.Size(125, 34);
            this.button5_3_4.TabIndex = 7;
            this.button5_3_4.Text = "5_3_4";
            this.button5_3_4.UseVisualStyleBackColor = true;
            this.button5_3_4.Click += new System.EventHandler(this.button5_3_4_Click);
            // 
            // tb5_3_4
            // 
            this.tb5_3_4.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tb5_3_4.Location = new System.Drawing.Point(250, 322);
            this.tb5_3_4.Name = "tb5_3_4";
            this.tb5_3_4.Size = new System.Drawing.Size(206, 28);
            this.tb5_3_4.TabIndex = 8;
            // 
            // button5_3_5
            // 
            this.button5_3_5.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button5_3_5.Location = new System.Drawing.Point(25, 378);
            this.button5_3_5.Name = "button5_3_5";
            this.button5_3_5.Size = new System.Drawing.Size(125, 34);
            this.button5_3_5.TabIndex = 9;
            this.button5_3_5.Text = "StringBuilder";
            this.button5_3_5.UseVisualStyleBackColor = true;
            this.button5_3_5.Click += new System.EventHandler(this.button5_3_5_Click);
            // 
            // tb5_3_5
            // 
            this.tb5_3_5.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tb5_3_5.Location = new System.Drawing.Point(250, 382);
            this.tb5_3_5.Name = "tb5_3_5";
            this.tb5_3_5.Size = new System.Drawing.Size(411, 28);
            this.tb5_3_5.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(33, 454);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 21);
            this.label3.TabIndex = 11;
            this.label3.Text = "問題5.4";
            // 
            // outputStrDate
            // 
            this.outputStrDate.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.outputStrDate.Location = new System.Drawing.Point(159, 508);
            this.outputStrDate.Multiline = true;
            this.outputStrDate.Name = "outputStrDate";
            this.outputStrDate.Size = new System.Drawing.Size(519, 129);
            this.outputStrDate.TabIndex = 12;
            // 
            // inputStrDate
            // 
            this.inputStrDate.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.inputStrDate.Location = new System.Drawing.Point(159, 454);
            this.inputStrDate.Name = "inputStrDate";
            this.inputStrDate.Size = new System.Drawing.Size(519, 31);
            this.inputStrDate.TabIndex = 13;
            // 
            // button5_4
            // 
            this.button5_4.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button5_4.Location = new System.Drawing.Point(25, 529);
            this.button5_4.Name = "button5_4";
            this.button5_4.Size = new System.Drawing.Size(125, 39);
            this.button5_4.TabIndex = 14;
            this.button5_4.Text = "問題5.4";
            this.button5_4.UseVisualStyleBackColor = true;
            this.button5_4.Click += new System.EventHandler(this.button5_4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 649);
            this.Controls.Add(this.button5_4);
            this.Controls.Add(this.inputStrDate);
            this.Controls.Add(this.outputStrDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb5_3_5);
            this.Controls.Add(this.button5_3_5);
            this.Controls.Add(this.tb5_3_4);
            this.Controls.Add(this.button5_3_4);
            this.Controls.Add(this.tbWordCount);
            this.Controls.Add(this.WordCountBotton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbWordChange);
            this.Controls.Add(this.textBoxSpaceCount);
            this.Controls.Add(this.button5_3_2);
            this.Controls.Add(this.button5_3_1);
            this.Controls.Add(this.inputStrText);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputStrText;
        private System.Windows.Forms.Button button5_3_1;
        private System.Windows.Forms.TextBox textBoxSpaceCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button5_3_2;
        private System.Windows.Forms.TextBox tbWordChange;
        private System.Windows.Forms.Button WordCountBotton;
        private System.Windows.Forms.TextBox tbWordCount;
        private System.Windows.Forms.Button button5_3_4;
        private System.Windows.Forms.TextBox tb5_3_4;
        private System.Windows.Forms.Button button5_3_5;
        private System.Windows.Forms.TextBox tb5_3_5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox outputStrDate;
        private System.Windows.Forms.TextBox inputStrDate;
        private System.Windows.Forms.Button button5_4;
    }
}

