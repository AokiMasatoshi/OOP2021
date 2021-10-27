using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddressBook
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void personBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.personBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202118DataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // TODO: このコード行はデータを 'infosys202118DataSet.Person' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.personTableAdapter.Fill(this.infosys202118DataSet.Person);
        }

        private void btNameFilter_Click(object sender, EventArgs e)
        {
            this.personTableAdapter.FillByName(this.infosys202118DataSet.Person, tbNameSearch.Text);
        }

        private void tbBirthdayFilter_Click(object sender, EventArgs e)
        {
            this.personTableAdapter.FillByBirthday(this.infosys202118DataSet.Person, dtpBirthdaySearch.Text);
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            //personDataGridView.CurrentRow.Cells[1].Value = tbName.Text;
            //personDataGridView.CurrentRow.Cells[1].Value = dtpDate.Value;
            //personDataGridView.CurrentRow.Cells[1].Value = tbTelephone.Text;
            //personDataGridView.CurrentRow.Cells[1].Value = tbMemo.Text;
            this.Validate();
            this.personBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202118DataSet);
        }

        private void personDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if(personDataGridView.Rows.Count != 0){

            }
        }
    }
}
