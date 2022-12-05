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
    public partial class addproduct : MetroFramework.Forms.MetroForm
    {
        DataSet ds = new DataSet();
        repo rp = new repo();
        int selectedRow;

        public addproduct()
        {
            InitializeComponent();
        }

        private void AddUpdate_Load(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToShortDateString();
            label2.Text = DateTime.Now.ToShortTimeString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtctgry.Text != "" && txtprdct.Text != "")
            {
                string query = "insert into tblSalePrdct (CtgryName,PrdctName,PrdctQty,SalePrice,PrchsPrice,[Desc]) values ('"+ txtctgry.Text + "','" + txtprdct.Text + "','" + txtprdctqty.Text + "','" + txtsale.Text + "','" + txtprchs.Text + "','" + txtdesc.Text + "')";
                ds = rp.getdata(query);
                MessageBox.Show("Product Has Been Added!");
                txtctgry.Clear();
                txtprdct.Clear();
                txtprdctqty.Clear();
                txtsale.Clear();
                txtprdct.Clear();
                txtdesc.Clear();
                txtctgry.Focus();
            }
            else
            {
                MessageBox.Show("Error; Compolsory Fields Cannot Be Empty..", "POS Software", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            string qu = "Select * From tblSalePrdct";
            ds = rp.getdata(qu);
            dataGridView1.DataSource = ds.Tables["0"].DefaultView;

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dialouge = MessageBox.Show("You are about to Delete 1(Rows). Click Yes to permanently delete this. ", "Delete", MessageBoxButtons.YesNo);
            if (dialouge == DialogResult.Yes)
            {
                int u;
                string quer = "delete from tblSalePrdct where PrdctName = '" + txtprdct.Text + "'";
                u = rp.savedata(quer);
                if (u > 0)
                {
                    MessageBox.Show("Selected product is deleted from stock!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("The Product you want to delete is not available!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            //else if (dialouge == DialogResult.No)
            //{
            //    this.Hide();
            //    AddUpdate ad = new AddUpdate();
            //    this.Show();
            //}
            string qu = "Select * From tblSalePrdct";
            ds = rp.getdata(qu);
            dataGridView1.DataSource = ds.Tables["0"].DefaultView;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string qu = "Select * From tblSalePrdct";
            ds = rp.getdata(qu);
            dataGridView1.DataSource = ds.Tables["0"].DefaultView;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[selectedRow];
            txtid.Text = row.Cells[0].Value.ToString();
            txtctgry.Text = row.Cells[1].Value.ToString();
            txtprdct.Text = row.Cells[2].Value.ToString();
            txtprdctqty.Text = row.Cells[3].Value.ToString();
            txtsale.Text = row.Cells[4].Value.ToString();
            txtprchs.Text = row.Cells[5].Value.ToString();
            txtdesc.Text = row.Cells[6].Value.ToString();
        }

        private void txtbox6_TextChanged(object sender, EventArgs e)
        {
            string quer = "Select CtgryName From tblSalePrdct where CtgryName Like '%" + txtid.Text + "%'";
            ds = rp.getdata(quer);
            dataGridView1.DataSource = ds.Tables["0"].DefaultView;
        }

        private void txtbox7_TextChanged(object sender, EventArgs e)
        {
            string quer = "Select PrdctName From tblSalePrdct where PrdctName Like '%" + txtprdctqty.Text + "%'";
            ds = rp.getdata(quer);
            dataGridView1.DataSource = ds.Tables["0"].DefaultView;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            UpdateStock up = new UpdateStock();
            up.Show();
        }

        private void textbox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
