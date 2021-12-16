using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Promotion
{
    public partial class Form2 : Form
    {
        private static Form3 _instance;
        private static Form1 _instance1;
        //ボタンコントロール配列のフィールドを作成
        private CheckBox[] testButtons;
        //チームの個数
        public int NumberOfTeams = 0;
        //チームの名前を格納する配列
        public String[] TeamName;
        public Form2()
        {
            InitializeComponent();
            //ボタンコントロール配列の作成（ここでは5つ作成）
            this.testButtons = new CheckBox[20];

            //ボタンコントロールのインスタンス作成し、プロパティを設定する
            this.SuspendLayout();
            for (int i = 0; i < testButtons.Length; i++)
            {



                //インスタンス作成
                this.testButtons[i] = new CheckBox();
                const int offsetX = 50, offsetY = 20;
                //プロパティ設定
                this.testButtons[i].Name = "Button" + i.ToString();
                this.testButtons[i].Text = i.ToString();
                this.testButtons[i].Size = new Size(100, 50);
                int sizeW = testButtons[i].Size.Width;
                int sizeH = testButtons[i].Size.Height;
                //this.testButtons[i].Location = new Point(i * 50, j * 20);
                this.testButtons[i].Location = new Point(offsetX + i % 5 * sizeW,
                                                        offsetY + i / 5 * sizeH);
            }

            //フォームにコントロールを追加
            this.Controls.AddRange(this.testButtons);
            this.ResumeLayout(false);
        }

        private void btDecision_Click(object sender, EventArgs e)
        {
            Instance.Show();
            this.Visible = false;

        }
       

        private void btStertBack_Click(object sender, EventArgs e)
        {
            Instance1.Show();
            this.Visible = false;
        }
        public static Form3 Instance
        {
            get
            {
                //_instanceがnullまたは破棄されているときは、
                //新しくインスタンスを作成する
                if (_instance == null || _instance.IsDisposed)
                {
                    _instance = new Form3();
                }
                return _instance;
            }
        }

        public static Form1 Instance1
        {
            get
            {
                //_instanceがnullまたは破棄されているときは、
                //新しくインスタンスを作成する
                if (_instance1 == null || _instance1.IsDisposed)
                {
                    _instance1 = new Form1();
                }
                return _instance1;
            }
        }
    }
}
//
