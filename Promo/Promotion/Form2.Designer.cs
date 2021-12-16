
namespace Promotion
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
            this.btDecision = new System.Windows.Forms.Button();
            this.btStertBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btDecision
            // 
            this.btDecision.Location = new System.Drawing.Point(586, 400);
            this.btDecision.Name = "btDecision";
            this.btDecision.Size = new System.Drawing.Size(99, 38);
            this.btDecision.TabIndex = 1;
            this.btDecision.Text = "決定";
            this.btDecision.UseVisualStyleBackColor = true;
            this.btDecision.Click += new System.EventHandler(this.btDecision_Click);
            // 
            // btStertBack
            // 
            this.btStertBack.Location = new System.Drawing.Point(691, 400);
            this.btStertBack.Name = "btStertBack";
            this.btStertBack.Size = new System.Drawing.Size(99, 38);
            this.btStertBack.TabIndex = 2;
            this.btStertBack.Text = "戻る";
            this.btStertBack.UseVisualStyleBackColor = true;
            this.btStertBack.Click += new System.EventHandler(this.btStertBack_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btStertBack);
            this.Controls.Add(this.btDecision);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btDecision;
        private System.Windows.Forms.Button btStertBack;
    }
}