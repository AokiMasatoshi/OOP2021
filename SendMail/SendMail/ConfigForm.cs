using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace SendMail
{
    public partial class ConfigForm : Form
    {
       private Settings settings = Settings.getInstance();
        public ConfigForm()
        {
            InitializeComponent();
        }
        

        private void btDefault_Click(object sender, EventArgs e)
        {
            tbHost.Text = settings.sHost();
            tbPass.Text = settings.sPass();
            tbPort.Text = settings.sPort();
            tbUserName.Text = settings.sMailAddr();
            tbSender.Text = settings.sMailAddr();
            cbSsl.Checked = settings.bSsl();
        }

        private void btApply_Click(object sender, EventArgs e)
        {
            //settingオブジェクトに入力データを渡して登録を行う
            settings.setSendConfig(tbHost.Text, int.Parse(tbPort.Text),
                                tbUserName.Text, tbPass.Text, cbSsl.Checked);

        }

        private void btOK_Click(object sender, EventArgs e)
        { 
            btApply_Click(sender, e);
            this.Close();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
        //private void SettingRegist()
        //{
           
        //}
        private void sendMailAdd()
        {
            var configSettings = new XmlWriterSettings
            {
                Encoding = new System.Text.UTF8Encoding(false),
                Indent = true,
                IndentChars = "  ",
            };

            using(var writer = XmlWriter.Create("mailsetting.xml", configSettings))
            {
                var serializer = new DataContractSerializer(settings.GetType()) ;
                serializer.WriteObject(writer, settings);
            }
        }
        //設定画面をロードすると一度だけ実行されるイベントハンドラ
        private void ConfigForm_Load(object sender, EventArgs e)
        {
            tbHost.Text = settings.Host;
            tbPass.Text = settings.Pass;
            tbPort.Text = settings.Port.ToString();
            tbUserName.Text = settings.MailAddr;
            tbSender.Text = settings.MailAddr;
            cbSsl.Checked = settings.Ssl;
        }
    }
}
