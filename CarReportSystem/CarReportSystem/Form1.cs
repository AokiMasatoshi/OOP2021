using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarReportSystem {
    public partial class fmMain : Form
    {
        BindingList<CarReport> listCarReport = new BindingList<CarReport>();
        public fmMain()
        {
            InitializeComponent();
            //dgvRegistData.DataSource = listCarReport;
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();//アプリケーション終了
        }

        private void btPictureOpen_Click(object sender, EventArgs e)
        {
            if (ofdPictureOpen.ShowDialog() == DialogResult.OK)
            {
                pbPicture.Image = Image.FromFile(ofdPictureOpen.FileName);
            }
        }

        private void btPicturreDelete_Click(object sender, EventArgs e)
        {
            pbPicture.Image = null;
        }

        private void btDataAdd_Click(object sender, EventArgs e)
        {
            if (cbAuthor.Text == "" || cbCarName.Text == "")
            {
                MessageBox.Show("入力されていません");
                return;
            }
            else
            {
                CarReport carReport = new CarReport
                {
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
        private CarReport.MakerGroup SelectedGroup()
        {
            foreach (var rb in gbMaker.Controls)
            {
                if (((RadioButton)rb).Checked)
                {
                   return (CarReport.MakerGroup)int.Parse((string)((RadioButton)rb).Tag);
                }
            }
            return CarReport.MakerGroup.その他;
        }

        //コンボボックスに記録者をセットする
        private void setCbAuther(string author)
        {
            if (!cbAuthor.Items.Contains(author))
            {
                cbAuthor.Items.Add(author);
            }

        }
        //コンボボックスに車名をセットする
        private void setCbCarName(string carname)
        {
            if (!cbCarName.Items.Contains(carname))
            {
                cbCarName.Items.Add(carname);
            }

        }



        private void dgvRegistData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
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
        private void setMakerRadioButton(CarReport.MakerGroup mg)
        {
            switch (mg)
            {
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
                    rbImport.Checked = true;
                    break;
                case CarReport.MakerGroup.その他:
                    rbOther.Checked = true;
                    break;
                default:
                    break;
            }
        }

        //更新ボタンイベント処理
        private void btUpDate_Click(object sender, EventArgs e)
        {
            if (carReportDataGridView.CurrentRow == null) return;

            carReportDataGridView.CurrentRow.Cells[1].Value = dtpDate.Value;//日付
            carReportDataGridView.CurrentRow.Cells[2].Value = cbAuthor.Text;
            carReportDataGridView.CurrentRow.Cells[3].Value = SelectedGroup();
            carReportDataGridView.CurrentRow.Cells[4].Value = cbCarName.Text;
            carReportDataGridView.CurrentRow.Cells[5].Value = tbReport.Text;
            carReportDataGridView.CurrentRow.Cells[6].Value = ImageToByteArray( pbPicture.Image);

            this.Validate();
            this.carReportBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202118DataSet);

#if false
            try {
                if (sfdFileSave.ShowDialog() == DialogResult.OK) {
                    //バイナリー形式でシリアル化
                    var bf = new BinaryFormatter();

                    using (FileStream fs = File.Open(sfdFileSave.FileName, FileMode.Create)) {
                        bf.Serialize(fs, listCarReport);

                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show("保存できませんでした");

            }
#endif

        }

        private void btConnect_Click(object sender, EventArgs e)
        {
            // TODO: このコード行はデータを 'infosys202118DataSet.CarReport' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.carReportTableAdapter.Fill(this.infosys202118DataSet.CarReport);
#if false
            try {
                if (ofdFileOpen.ShowDialog() == DialogResult.OK) {
                    //バイナリー形式で逆シリアル化
                    var bf = new BinaryFormatter();
                    using (FileStream fs = File.Open(ofdFileOpen.FileName, FileMode.Open, FileAccess.Read)) {
                        listCarReport = (BindingList<CarReport>)bf.Deserialize(fs);
                        dgvRegistData.DataSource = null;
                        dgvRegistData.DataSource = listCarReport;
                    }

                }

            }catch (Exception ex) {
                MessageBox.Show(ex.Message);

            }
                foreach (var item in listCarReport) {
                        setCbAuther(item.Auther);
                        setCbCarName(item.CarName);
                }
                    //for (int i=0;i < dgvRegistData.RowCount; i++) {
                    //    setCbAuther(dgvRegistData.Rows[i].Cells[1].ToString());
                    //    setCbCarName(dgvRegistData.Rows[i].Cells[3].ToString());
                    //}
                
#endif
        }
        private void fmMain_Load(object sender, EventArgs e)
        {
            carReportDataGridView.Columns[0].Visible = false;
            carReportDataGridView.Columns[1].HeaderText = "日付";
            carReportDataGridView.Columns[2].HeaderText = "記録者";
            carReportDataGridView.Columns[3].HeaderText = "メーカー";
            carReportDataGridView.Columns[4].HeaderText = "車種";
            carReportDataGridView.Columns[5].HeaderText = "レポート";
            carReportDataGridView.Columns[6].HeaderText = "画像";
            //carReportDataGridView.Columns[6].Visible = false;
            ssErrerLavel.Text = "";



            // dgvRegistData.Columns[5].Visible = false;
        }

        private void carReportDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (carReportDataGridView.CurrentRow == null) return;
            try
            {
                pbPicture.Image = null;
                dtpDate.Value = (DateTime)carReportDataGridView.CurrentRow.Cells[1].Value;//日付
                cbAuthor.Text = carReportDataGridView.CurrentRow.Cells[2].Value.ToString();
                //setMakerRadioButton((CarReport.MakerGroup)
                //    Enum.Parse(typeof(CarReport.MakerGroup),carReportDataGridView.CurrentRow.Cells[3].Value.ToString())
                //    );   // メーカー（文字列→　列挙型）
                var mk = (CarReport.MakerGroup)
                    Enum.Parse(typeof(CarReport.MakerGroup), carReportDataGridView.CurrentRow.Cells[3].Value.ToString());
                setMakerRadioButton(mk);
                cbCarName.Text = carReportDataGridView.CurrentRow.Cells[4].Value.ToString();
                tbReport.Text = carReportDataGridView.CurrentRow.Cells[5].Value.ToString();
                pbPicture.Image = ByteArrayToImage((byte[])carReportDataGridView.CurrentRow.Cells[6].Value);
                ssErrerLavel.Text = "";
            }
            catch(InvalidCastException)
            {
                pbPicture.Image = null;

            }
            catch (Exception ex)
            {
                ssErrerLavel.Text = ex.Message;
               // MessageBox.Show(ex.Message);
            }
        
        
        
        }
        // バイト配列をImageオブジェクトに変換
        public static Image ByteArrayToImage(byte[] b)
        {
            ImageConverter imgconv = new ImageConverter();
            Image img = (Image)imgconv.ConvertFrom(b);
            return img;
        }
        // Imageオブジェクトをバイト配列に変換
        public static byte[] ImageToByteArray(Image img)
        {
            ImageConverter imgconv = new ImageConverter();
            byte[] b = (byte[])imgconv.ConvertTo(img, typeof(byte[]));
            return b;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            dtpDate.Value = DateTime.Now;
            cbAuthor.Text = "";
            cbCarName.Text = "";
            setMakerRadioButton(CarReport.MakerGroup.その他);
            pbPicture.Image = null;
            tbReport.Text = "";
        }

        private void carReportDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        
    }
}

