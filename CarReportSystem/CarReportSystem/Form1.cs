using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarReportSystem {
    public partial class fmMain : Form {
        BindingList<CarReport> listCarReport = new BindingList<CarReport>();
        public fmMain() {
            InitializeComponent();
            dgvRegistData.DataSource = listCarReport;
        }

        private void btExit_Click(object sender, EventArgs e) {
            Application.Exit();//アプリケーション終了
        }

        private void btPictureOpen_Click(object sender, EventArgs e) {
            if(ofdPictureOpen.ShowDialog()== DialogResult.OK) {
                pbPicture.Image = Image.FromFile(ofdPictureOpen.FileName);
            }
        }

        private void btPicturreDelete_Click(object sender, EventArgs e) {
            pbPicture.Image = null;
        }

        private void btDataAdd_Click(object sender, EventArgs e) {
            if (cbAuthor.Text==""||cbCarName.Text=="") { 
                MessageBox.Show("入力されていません");
                return ;
            } else {
                CarReport carReport = new CarReport {
                    Date = dtpDate.Value,
                    Auther = cbAuthor.Text,
                    Maker = SelectedGroup(),
                    CarName = cbCarName.Text,
                    Picture = pbPicture.Image,
                    Report = tbReport.Text,


                };
                listCarReport.Add(carReport);

                setCbAuther(cbAuthor.Text);
                setCbCarName(cbCarName.Text);
            }
            
        }
        private CarReport.MakerGroup SelectedGroup() {
            foreach (var rb in gbMaker.Controls) {
                if (((RadioButton)rb).Checked) {
                    return (CarReport.MakerGroup)int.Parse(((string)((RadioButton)rb).Tag));
                }
            }
            return CarReport.MakerGroup.その他;
        }

        //コンボボックスに記録者をセットする
        private void setCbAuther(string author) {
            if (!cbAuthor.Items.Contains(author)) {
                cbAuthor.Items.Add(author);
            }
            
        }
        //コンボボックスに車名をセットする
        private void setCbCarName(string carname) {
            if (!cbCarName.Items.Contains(carname)) {
                cbCarName.Items.Add(carname);
            }

        }

        

        private void dgvRegistData_CellClick(object sender, DataGridViewCellEventArgs e) {
            //選択された行のデータ取得
            if (e.RowIndex == -1) return;
           

                
            CarReport selectedCar = listCarReport[e.RowIndex];
            


            

            //取得したデータを
            dtpDate.Value = selectedCar.Date;
            cbAuthor.Text = selectedCar.Auther;
            setMakerRadioButton(selectedCar.Maker);
            //foreach (var rb in gbMaker.Controls) {
            //    if (((RadioButton)rb).Text == selectedCar.Maker.ToString()) {
            //        ((RadioButton)rb).Checked = true;
            //    }
            //}
            cbCarName.Text = selectedCar.CarName;
            pbPicture.Image = selectedCar.Picture;
            tbReport.Text = selectedCar.Report;


        }
        private void setMakerRadioButton(CarReport.MakerGroup mg) {
            switch (mg) {
                case CarReport.MakerGroup.トヨタ:
                    rbToyota.Checked = true;
                    break;
                case CarReport.MakerGroup.ホンダ:
                    rbHonda.Checked = true;
                    break;
                case CarReport.MakerGroup.スバル:
                    rbSubaru.Checked = true;
                    break;
                case CarReport.MakerGroup.日産:
                    rbNissan.Checked = true;
                    break;
                case CarReport.MakerGroup.外国車:
                    rbToyota.Checked = true;
                    break;
                case CarReport.MakerGroup.その他:
                    rbToyota.Checked = true;
                    break;
                default:
                    break;
            }
        }

        private void btDateDelete_Click(object sender, EventArgs e) {
            listCarReport.RemoveAt(dgvRegistData.CurrentRow.Index);

            
        }

        private void btDataCorrect_Click(object sender, EventArgs e) {
            listCarReport[dgvRegistData.CurrentRow.Index].UpDate(dtpDate.Value,cbAuthor.Text, SelectedGroup(),cbCarName.Text,tbReport.Text,pbPicture.Image);

        }
    }
}

