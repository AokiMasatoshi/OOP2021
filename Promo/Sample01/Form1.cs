using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sample01
{
    public partial class Form1 : Form
    {
        PLTeam pt;
        private static Form3 _instance3;
        public string SelectTeam = "";
        public string Teamname ="" ;
        public string PLteamname = "リヴァプール,マンチェスターシティ,マンチェスターユナイテッド,アーセナル,チェルシー,トッテナム,ウェストハム,ウルブス,ブライトン,レスターシティ,サウサンプトン,クリスタル・パレス,ブレントフォード,アストン・ヴィラ,エヴァートン,リーズU,ワトフォード,バーンリー,ニューカッスル,ノリッジ";

        public Form1()
        {
            InitializeComponent(); 
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SelectTeam = ((Button)sender).Text.ToString();
            var form = new Form2(SelectTeam); 
            Visible = false;
            form.ShowDialog();
        }
        
        public static Form3 Instance3
        {
            get
            {
                //_instanceがnullまたは破棄されているときは、
                //新しくインスタンスを作成する
                if (_instance3 == null || _instance3.IsDisposed)
                {
                    _instance3 = new Form3();
                }
                return _instance3;
            }
        }
        //ボタンコントロール配列のフィールドを作成
        private Button[] Buttons;
        //チームの個数
        public int NumberOfTeams = 0;
        //チームの名前を格納する配列
        public string[] SplitTeamName;

        //フォームのLoadイベントハンドラ
        private void Form1_Load(object sender, System.EventArgs e)
        {
            SplitTeamName = PLteamname.Split(',');        
            //ボタンコントロール配列の作成
            this.Buttons = new Button[SplitTeamName.Length];

            //ボタンコントロールのインスタンス作成し、プロパティを設定する
            this.SuspendLayout();
            for (int i = 0; i < this.Buttons.Length; i++)
            {
                //インスタンス作成
                this.Buttons[i] = new Button();
                const int offsetX = 50, offsetY = 20;
                //プロパティ設定
                this.Buttons[i].Name = SplitTeamName[i];
                this.Buttons[i].Text = SplitTeamName[i];
                this.Buttons[i].Size = new Size(120,84);
                this.Buttons[i].Click += button1_Click;
                int sizeW = Buttons[i].Size.Width;
                int sizeH = Buttons[i].Size.Height;
                Buttons[i].BackColor = Color.White;
               // this.Buttons[i].Margin = new Padding(100,150,100,100);
                this.Buttons[i].Location = new Point(offsetX+50 + i % 5 * sizeW,
                                                        offsetY+50 + i / 5 * sizeH);
            }

            //フォームにコントロールを追加
            this.Controls.AddRange(this.Buttons);
            this.ResumeLayout(false);
        }
        private void btOthers_Click(object sender, EventArgs e)
        {
            Visible = false;
            Instance3.ShowDialog();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
