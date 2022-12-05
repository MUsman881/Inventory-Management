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
    public partial class UpdateProduct : MetroFramework.Forms.MetroForm
    {
        DataSet ds = new DataSet();
        repo rp = new repo();
        public UpdateProduct()
        {
            InitializeComponent();
        }
        private void ComboFill()
        {
            comboprdct.Items.Clear();
            string qs = "Select CtgryName from tblAddPrdct";
            ds = rp.getdata(qs);
            foreach (DataRow items in ds.Tables["0"].Rows)
            {
                comboprdct.Items.Add(items[0].ToString());
            }
        }

        private void UpdateProduct_Load(object sender, EventArgs e)
        {
            ComboFill();
        }
       

        private void button4_Click(object sender, EventArgs e)
        {
            string qu = "Select * From tblAddPrdct";
            ds = rp.getdata(qu);
            dataGridView1.DataSource = ds.Tables["0"].DefaultView;
            txtdesc.Clear();
            txtprchs.Clear();
            txtprdct.Clear();
            txtprdctqty.Clear();
            txtsale.Clear();
            comboprdct.Focus();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (comboprdct.Text!="" && txtprdct.Text != "")
            {
                string quer = "update tblAddPrdct set PrdctName='" + txtprchs.Text + "',PrdctQty='" + txtprdct.Text + "',SalePrice='" + txtsale.Text + "',PrchsPrice='" + txtprchs.Text + "',[Desc]='" + txtdesc.Text + "' where CtgryName='" + comboprdct.Text + "'";
                ds = rp.getdata(quer);
                MessageBox.Show("Your Product Information Has Been Updated..", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
            }
            
            else
            {
                MessageBox.Show("Cumpolsory Fields Cannot Be Empty..(Error)", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string qu = "Select * From tblAddPrdct";
            ds = rp.getdata(qu);
            dataGridView1.DataSource = ds.Tables["0"].DefaultView;

        }

        private void comboprdct_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                txtprchs.Focus();
            }
        }

        private void txtprchs_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtprdct.Focus();
            }
        }

        private void txtprdct_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtsale.Focus();
            }
        }

        private void txtsale_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
               txtdesc.Focus();
            }
        }

        private void txtdesc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnupdate.Focus();
            }
        }
    }
}
