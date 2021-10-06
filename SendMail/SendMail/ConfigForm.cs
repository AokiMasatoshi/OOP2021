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
            SettingRegist();
            sendMailAdd();
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            SettingRegist();
            sendMailAdd();
            this.Close();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
        private void SettingRegist()
        {
            settings.Host = tbHost.Text;
            settings.Port = int.Parse(tbPort.Text);
            settings.MailAddr = tbUserName.Text;
            settings.Pass = tbPass.Text;
            settings.Ssl = cbSsl.Checked;
        }
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
       
    }
}
