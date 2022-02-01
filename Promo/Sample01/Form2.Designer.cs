
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
            this.btback = new System.Windows.Forms.Button();
            this.lbTeamName = new System.Windows.Forms.Label();
            this.tbSelectTitle = new System.Windows.Forms.TextBox();
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
            // btback
            // 
            this.btback.Location = new System.Drawing.Point(36, 577);
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
            this.lbTeamName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbTeamName.Font = new System.Drawing.Font("ＭＳ 明朝", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbTeamName.Location = new System.Drawing.Point(23, 46);
            this.lbTeamName.Name = "lbTeamName";
            this.lbTeamName.Size = new System.Drawing.Size(106, 24);
            this.lbTeamName.TabIndex = 4;
            this.lbTeamName.Text = "チーム名";
            // 
            // tbSelectTitle
            // 
            this.tbSelectTitle.Location = new System.Drawing.Point(421, 46);
            this.tbSelectTitle.Multiline = true;
            this.tbSelectTitle.Name = "tbSelectTitle";
            this.tbSelectTitle.Size = new System.Drawing.Size(675, 611);
            this.tbSelectTitle.TabIndex = 5;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sample01.Properties.Resources.Stadium2;
            this.ClientSize = new System.Drawing.Size(1108, 690);
            this.Controls.Add(this.tbSelectTitle);
            this.Controls.Add(this.lbTeamName);
            this.Controls.Add(this.btback);
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
        public System.Windows.Forms.Label lbTeamName;
        private System.Windows.Forms.TextBox tbSelectTitle;
    }
}