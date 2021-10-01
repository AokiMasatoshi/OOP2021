using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            SettingRegist();
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
       
    }
}
