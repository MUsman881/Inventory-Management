using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Electornics_Project
{
    public partial class UpdateStock : MetroFramework.Forms.MetroForm
    {
        DataSet ds = new DataSet();
        repo rp = new repo();
        //int selectedRow;
        public UpdateStock()
        {
            InitializeComponent();
        }
        private void ComboFill()
        {
            comboctgry.Items.Clear();
            string qs = "Select CtgryName from tblSalePrdct";
            ds = rp.getdata(qs);
            foreach (DataRow items in ds.Tables["0"].Rows)
            {
                comboctgry.Items.Add(items[0].ToString());
            }
        }

        private void UpdateStock_Load(object sender, EventArgs e)
        {
            ComboFill();
        }

        private void btnUProductName_Click(object sender, EventArgs e)
        {
            if (txtName_New.Text.Trim()!="")
            {
                MessageBox.Show("Enter New ProductName in New Field", "New Value Missing", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
            else
            {
                try
                {
                    string qu = "update tblAddPrdct set PrdctName = '" + txtName_New.Text + "'where CtgryName='" + comboctgry.Text + "'";
                    ds = rp.getdata(qu);
                    txtName_New.Clear();
                    MessageBox.Show("Name Changed Successfully", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Database Connection Error, Process Failed", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            string quer = "Select * From tblAddPrdct";
            ds = rp.getdata(quer);
            dataGridView1.DataSource = ds.Tables["0"].DefaultView;
        }

        private void btnUQty_Click(object sender, EventArgs e)
        {
            if (txtqty_new.Text.Trim() == "")
            {
                MessageBox.Show("Enter New Value in New Field", "New Value Missing", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
            else
            {
                try
                {
                    string qu = "update tblAddPrdct set PrdctQty = '" + txtqty_new.Text + "'where CtgryName='" + comboctgry.Text + "'";
                    ds = rp.getdata(qu);
                    txtqty_new.Clear();
                    MessageBox.Show("Value Changed Successfully", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Database Connection Error, Process Failed", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            string quer = "Select * From tblAddPrdct";
            ds = rp.getdata(quer);
            dataGridView1.DataSource = ds.Tables["0"].DefaultView;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //selectedRow = e.RowIndex;
            //DataGridViewRow row = dataGridView1.Rows[selectedRow];
            // = row.Cells[0].Value.ToString();
        }

        private void btnPurchasePrice_Click(object sender, EventArgs e)
        {
            if (txtNPurchasePrice.Text.Trim() == "")
            {
                MessageBox.Show("Enter new purchase price in new field", "New Value Missing", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
            else
            {
                try
                {
                    string qu = "update tblSalePrdct set PrchsPrice = '" + txtNPurchasePrice.Text + "'where CtgryName='" + comboctgry.Text + "'";
                    ds = rp.getdata(qu);
                    txtName_New.Clear();
                    MessageBox.Show("Value Changed Successfully", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Database Connection Error, Process Failed", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            string quer = "Select * From tblAddPrdct";
            ds = rp.getdata(quer);
            dataGridView1.DataSource = ds.Tables["0"].DefaultView;
        }

        private void btnUDel_Click(object sender, EventArgs e)
        {
            DialogResult dialouge = MessageBox.Show("You are about to Delete 1(Rows). Click Yes to permanently delete this. ", "Delete", MessageBoxButtons.YesNo);
            if (dialouge == DialogResult.Yes)
            {
                int u;
                string quer = "delete From tblAddPrdct where PrdctName Like '%" +txtDelete_PName.Text + "%'";
                u = rp.savedata(quer);
                if (u > 0)
                {
                    MessageBox.Show("Selected product is deleted from stock!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("The Product you want to delete is not available!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            //string quer = "Select * From tblAddPrdct";
            //ds = rp.getdata(quer);
            //dataGridView1.DataSource = ds.Tables["0"].DefaultView;
        }
    }
}
