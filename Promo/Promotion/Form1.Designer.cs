
namespace Promotion
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
            this.btPre = new System.Windows.Forms.Button();
            this.btLaLiga = new System.Windows.Forms.Button();
            this.btBundes = new System.Windows.Forms.Button();
            this.btUEFAChanpions = new System.Windows.Forms.Button();
            this.btSerieA = new System.Windows.Forms.Button();
            this.btLigue1 = new System.Windows.Forms.Button();
            this.btDecision = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btPre
            // 
            this.btPre.Location = new System.Drawing.Point(69, 57);
            this.btPre.Name = "btPre";
            this.btPre.Size = new System.Drawing.Size(177, 113);
            this.btPre.TabIndex = 0;
            this.btPre.Text = "プレミアリーグ";
            this.btPre.UseVisualStyleBackColor = true;
            this.btPre.Click += new System.EventHandler(this.btPre_Click);
            // 
            // btLaLiga
            // 
            this.btLaLiga.Location = new System.Drawing.Point(314, 57);
            this.btLaLiga.Name = "btLaLiga";
            this.btLaLiga.Size = new System.Drawing.Size(177, 113);
            this.btLaLiga.TabIndex = 0;
            this.btLaLiga.Text = "ラ・リーガ";
            this.btLaLiga.UseVisualStyleBackColor = true;
            this.btLaLiga.Click += new System.EventHandler(this.btLaLiga_Click);
            // 
            // btBundes
            // 
            this.btBundes.Location = new System.Drawing.Point(545, 57);
            this.btBundes.Name = "btBundes";
            this.btBundes.Size = new System.Drawing.Size(177, 113);
            this.btBundes.TabIndex = 0;
            this.btBundes.Text = "ブンデスリーガ";
            this.btBundes.UseVisualStyleBackColor = true;
            this.btBundes.Click += new System.EventHandler(this.btBundes_Click);
            // 
            // btUEFAChanpions
            // 
            this.btUEFAChanpions.Location = new System.Drawing.Point(545, 229);
            this.btUEFAChanpions.Name = "btUEFAChanpions";
            this.btUEFAChanpions.Size = new System.Drawing.Size(177, 113);
            this.btUEFAChanpions.TabIndex = 0;
            this.btUEFAChanpions.Text = "チャンピオンズリーグ";
            this.btUEFAChanpions.UseVisualStyleBackColor = true;
            this.btUEFAChanpions.Click += new System.EventHandler(this.btUEFAChanpions_Click);
            // 
            // btSerieA
            // 
            this.btSerieA.Location = new System.Drawing.Point(314, 229);
            this.btSerieA.Name = "btSerieA";
            this.btSerieA.Size = new System.Drawing.Size(177, 113);
            this.btSerieA.TabIndex = 0;
            this.btSerieA.Text = "セリエA";
            this.btSerieA.UseVisualStyleBackColor = true;
            this.btSerieA.Click += new System.EventHandler(this.btSerieA_Click);
            // 
            // btLigue1
            // 
            this.btLigue1.Location = new System.Drawing.Point(69, 229);
            this.btLigue1.Name = "btLigue1";
            this.btLigue1.Size = new System.Drawing.Size(177, 113);
            this.btLigue1.TabIndex = 0;
            this.btLigue1.Text = "リーグ・アン";
            this.btLigue1.UseVisualStyleBackColor = true;
            this.btLigue1.Click += new System.EventHandler(this.btLigue1_Click);
            // 
            // btDecision
            // 
            this.btDecision.Location = new System.Drawing.Point(565, 395);
            this.btDecision.Name = "btDecision";
            this.btDecision.Size = new System.Drawing.Size(156, 32);
            this.btDecision.TabIndex = 1;
            this.btDecision.Text = "決定";
            this.btDecision.UseVisualStyleBackColor = true;
            this.btDecision.Click += new System.EventHandler(this.btDecision_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btDecision);
            this.Controls.Add(this.btUEFAChanpions);
            this.Controls.Add(this.btSerieA);
            this.Controls.Add(this.btBundes);
            this.Controls.Add(this.btLaLiga);
            this.Controls.Add(this.btLigue1);
            this.Controls.Add(this.btPre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btPre;
        private System.Windows.Forms.Button btLaLiga;
        private System.Windows.Forms.Button btBundes;
        private System.Windows.Forms.Button btUEFAChanpions;
        private System.Windows.Forms.Button btSerieA;
        private System.Windows.Forms.Button btLigue1;
        private System.Windows.Forms.Button btDecision;
    }
}

