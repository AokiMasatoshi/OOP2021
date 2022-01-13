using PowerArgs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Test_RadioBotton
{
    public partial class Form1 : Form
    {
            
        
        public Form1()
        {
            InitializeComponent();
        }


        //ボタンコントロール配列のフィールドを作成
        private CheckBox[] testButtons;
        //チームの個数
        public int NumberOfTeams = 0;
        //チームの名前を格納する配列
        public String[] TeamName;

        //フォームのLoadイベントハンドラ
        private void Form1_Load(object sender, System.EventArgs e)
        {
            string url = "http://example.com/app/search?type=json&q=";
            string q = HttpUtility.UrlEncode(string.Join(" ", Args));
            Debug.WriteLine("encoded q: " + q);


            //ボタンコントロール配列の作成（ここでは5つ作成）
            this.testButtons = new CheckBox[20];

            //ボタンコントロールのインスタンス作成し、プロパティを設定する
            this.SuspendLayout();
            for (int i = 0; i < this.testButtons.Length; i++)
            {
                //インスタンス作成
                this.testButtons[i] = new CheckBox();
                //プロパティ設定
                this.testButtons[i].Name = "Button" + i.ToString();
                this.testButtons[i].Text = i.ToString();
                this.testButtons[i].Size = new Size(50, 20);
                this.testButtons[i].Location = new Point(i * 50, 10);
            }

            //フォームにコントロールを追加
            this.Controls.AddRange(this.testButtons);
            this.ResumeLayout(false);
        }
    }
}
