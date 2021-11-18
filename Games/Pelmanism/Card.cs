using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Pelmanism
{
    //カードクラス
    class Card : Button
    {
        //カードの横幅と高さ
        private const int SizeW = 50, SizeH = 70;
        //カードの絵柄
        public string Picture { get; set; }
        //カードの状態｛true:表　false:裏｝
        public bool State { get; set; }
        //カード表面の色
        public Color OpenColor { get; set; } = Color.White;
        //カード裏面の色
        public Color CloseColor { get; set; } = Color.Aquamarine;
        public Card(string picture)
        {
            Picture = picture;
            State = false;
            Size = new Size(SizeW, SizeW);
            BackColor = CloseColor;
            Font = new Font("MS UI Goshic", 14, FontStyle.Bold);
            Enabled = false;
        }

        //カードオープン
        public void Open()
        {
            State = true;//表
            BackColor = OpenColor;
            Text = Picture;
            Enabled = false;//選択不可
        }
        //カードオープン
        public void Close()
        {
            State = false;//表
            BackColor = CloseColor;
            Text = "";
            Enabled = true;//選択可能
        }
        //カードをひっくり返す
        public void Turn()
        {
            if (State)
            {
                Close();
            }
            else
            {
                Open();
            }
        }
    }
}
