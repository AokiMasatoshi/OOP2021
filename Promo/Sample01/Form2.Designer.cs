
namespace Sample01
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
            this.lbPL = new System.Windows.Forms.ListBox();
            this.wb = new System.Windows.Forms.WebBrowser();
            this.btback = new System.Windows.Forms.Button();
            this.lbTeamName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbPL
            // 
            this.lbPL.FormattingEnabled = true;
            this.lbPL.ItemHeight = 12;
            this.lbPL.Location = new System.Drawing.Point(27, 147);
            this.lbPL.Name = "lbPL";
            this.lbPL.Size = new System.Drawing.Size(225, 316);
            this.lbPL.TabIndex = 0;
            this.lbPL.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbPL_MouseClick);
            this.lbPL.SelectedIndexChanged += new System.EventHandler(this.lbPL_SelectedIndexChanged);
            // 
            // wb
            // 
            this.wb.Location = new System.Drawing.Point(344, 18);
            this.wb.MinimumSize = new System.Drawing.Size(20, 20);
            this.wb.Name = "wb";
            this.wb.Size = new System.Drawing.Size(691, 641);
            this.wb.TabIndex = 1;
            // 
            // btback
            // 
            this.btback.Location = new System.Drawing.Point(27, 576);
            this.btback.Name = "btback";
            this.btback.Size = new System.Drawing.Size(157, 46);
            this.btback.TabIndex = 3;
            this.btback.Text = "戻る";
            this.btback.UseVisualStyleBackColor = true;
            this.btback.Click += new System.EventHandler(this.btback_Click);
            // 
            // lbTeamName
            // 
            this.lbTeamName.AutoSize = true;
            this.lbTeamName.Font = new System.Drawing.Font("ＭＳ 明朝", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbTeamName.Location = new System.Drawing.Point(23, 46);
            this.lbTeamName.Name = "lbTeamName";
            this.lbTeamName.Size = new System.Drawing.Size(106, 24);
            this.lbTeamName.TabIndex = 4;
            this.lbTeamName.Text = "チーム名";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 690);
            this.Controls.Add(this.lbTeamName);
            this.Controls.Add(this.btback);
            this.Controls.Add(this.wb);
            this.Controls.Add(this.lbPL);
            this.Name = "Form2";
            this.RightToLeftLayout = true;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbPL;
        private System.Windows.Forms.Button btback;
        public System.Windows.Forms.WebBrowser wb;
        public System.Windows.Forms.Label lbTeamName;
    }
}