using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataEdit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void testTblBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.testTblBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.myDataDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myDataDataSet.TestTbl". При необходимости она может быть перемещена или удалена.
            this.testTblTableAdapter.Fill(this.myDataDataSet.TestTbl);

        }

        private void CallEditForm(bool isnew)
        {
            int selected = this.testTblDataGridView.SelectedRows.Count;
            bool lIsNew = isnew;

            if (!lIsNew && selected == 0)
                return;

            my_edit oFrm = new my_edit(lIsNew, myDataDataSet, testTblBindingSource.Position);
         
            oFrm.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            CallEditForm(false);
        }

  

        private void testTblDataGridView_DoubleClick(object sender, EventArgs e)
        {
            CallEditForm(false);
        }
    }
}
