
namespace Promotion
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
            this.lbLeagueName = new System.Windows.Forms.Label();
            this.btTeamSerectBack = new System.Windows.Forms.Button();
            this.btLeagueSelectBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbLeagueName
            // 
            this.lbLeagueName.AutoSize = true;
            this.lbLeagueName.Location = new System.Drawing.Point(14, 14);
            this.lbLeagueName.Name = "lbLeagueName";
            this.lbLeagueName.Size = new System.Drawing.Size(35, 12);
            this.lbLeagueName.TabIndex = 0;
            this.lbLeagueName.Text = "label1";
            // 
            // btTeamSerectBack
            // 
            this.btTeamSerectBack.Location = new System.Drawing.Point(679, 411);
            this.btTeamSerectBack.Name = "btTeamSerectBack";
            this.btTeamSerectBack.Size = new System.Drawing.Size(110, 34);
            this.btTeamSerectBack.TabIndex = 1;
            this.btTeamSerectBack.Text = "チーム選択に戻る";
            this.btTeamSerectBack.UseVisualStyleBackColor = true;
            this.btTeamSerectBack.Click += new System.EventHandler(this.btSerectBack_Click);
            // 
            // btLeagueSelectBack
            // 
            this.btLeagueSelectBack.Location = new System.Drawing.Point(554, 412);
            this.btLeagueSelectBack.Name = "btLeagueSelectBack";
            this.btLeagueSelectBack.Size = new System.Drawing.Size(110, 33);
            this.btLeagueSelectBack.TabIndex = 2;
            this.btLeagueSelectBack.Text = "リーグ選択に戻る";
            this.btLeagueSelectBack.UseVisualStyleBackColor = true;
            this.btLeagueSelectBack.Click += new System.EventHandler(this.btLeagueSelectBack_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btLeagueSelectBack);
            this.Controls.Add(this.btTeamSerectBack);
            this.Controls.Add(this.lbLeagueName);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbLeagueName;
        private System.Windows.Forms.Button btTeamSerectBack;
        private System.Windows.Forms.Button btLeagueSelectBack;
    }
}