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
    public partial class my_edit : Form
    {
        private bool IsNew;

        public my_edit()
        {
            InitializeComponent();
        }

        public my_edit (bool isNew, myDataDataSet ds, int pos)
        {
            IsNew = isNew;
            InitializeComponent();
            this.myDataDataSet  = ds;
            testTblBindingSource.DataSource = ds;


            if (!IsNew)
                testTblBindingSource.Position = pos;
            else
            {
               
            }
        }
      

        private void my_edit_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myDataDataSet.TestTbl". При необходимости она может быть перемещена или удалена.
            this.testTblTableAdapter.Fill(this.myDataDataSet.TestTbl);

        }

        private void CanselBtn_Click(object sender, EventArgs e)
        {
            this.testTblBindingSource.CancelEdit();
            Close();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.testTblBindingSource.EndEdit();
            int lnCount = this.tableAdapterManager.UpdateAll(this.myDataDataSet);


            MessageBox.Show(lnCount.ToString());

            Close();
        }
    }
}
