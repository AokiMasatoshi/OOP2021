using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace SendMail
{
    public partial class Form1 : Form
    {
        private ConfigForm configForm = new ConfigForm();
        private Settings settings = Settings.getInstance();

        public Form1()
        {
            InitializeComponent();
                        
        }

        private void btSend_Click(object sender, EventArgs e)
        {

            if (!Settings.Set)
            {
                MessageBox.Show("送信情報を設定してください");
                return;
            }
            try
            {
                //メール送信のためのインスタンスを生成
                MailMessage mailMessage = new MailMessage();
                //差出人アドレス
                mailMessage.From = new MailAddress(settings.MailAddr) ;
                //宛先（To）
                if (tbTo.Text =="")
                {
                    MessageBox.Show("アドレスが未入力です");
                    return;
                }
                mailMessage.To.Add(tbTo.Text);
                if (tbCC.Text!="")
                {
                    mailMessage.CC.Add(tbCC.Text);
                }
                if (tbBCC.Text!="")
                {
                    mailMessage.Bcc.Add(tbBCC.Text);
                }
                
                //
                //件名（タイトル）
                mailMessage.Subject = tbTitle.Text;
                //本文
                mailMessage.Body = tbMessage.Text;
                if (tbMessage.Text == null || tbMessage.Text == string.Empty)
                {
                    MessageBox.Show("本文が未入力です");
                    return;
                }
                //SMTPを使ってメールを送信する
                SmtpClient smtpClient = new SmtpClient();
                //メール送信のための認証情報を設定（ユーザー名、パスワード）
                smtpClient.Credentials= new NetworkCredential(settings.MailAddr, settings.Pass);
                smtpClient.Host = settings.Host;
                smtpClient.Port = settings.Port;
                smtpClient.EnableSsl = settings.Ssl;
                // smtpClient.Send(mailMessage);
                //送信完了時に呼ばれるイベントハンドラの登録
                smtpClient.SendCompleted += SmtpClient_SendCompleted;
                //smtpClient.SendCompleted += new SendCompletedEventHandler(SmtpClient_SendCompleted);  古い考え
                string userState = "Send";

                clear();
                smtpClient.SendAsync(mailMessage,userState);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //送信が完了すると呼ばれるコールバックメソッド
        private void SmtpClient_SendCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Error!=null)
            {
                MessageBox.Show(e.Error.Message);
            }
            else
            {
                MessageBox.Show("送信完了");
            }
            
        }

        private void btConfig_Click(object sender, EventArgs e)
        {
            configForm.ShowDialog(); 
        }

        //XMLファイルを読み込む
        private void Form1_Load(object sender, EventArgs e)
        {
            //起動時に送信情報が未設定の場合設定画面を表示する
            if (!Settings.Set)
            {
                configForm.ShowDialog();
            }
        }

        private void 終了XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 新規作成NToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clear();
        }


        public void clear()
        {
            tbTo.Text = "";
            tbBCC.Text = "";
            tbCC.Text = "";
            tbTitle.Text = "";
            tbMessage.Text = "";
        }
        
        
    }
}
