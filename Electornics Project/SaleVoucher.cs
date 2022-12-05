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
    public partial class SaleVoucher : MetroFramework.Forms.MetroForm
    {
        DataSet ds = new DataSet();
        repo rp = new repo();
        int selectedRow;
        double dscamt = 0;
        double dscperc = 0;
        public SaleVoucher()
        {
            InitializeComponent();
        }
        private void combofill()
        {
            ComboPrdct.Items.Clear();
            ComboCust.Items.Clear();
            string q = "Select CustName from tblCustomer";
            ds = rp.getdata(q);
            foreach (DataRow item in ds.Tables["0"].Rows)
            {
                ComboCust.Items.Add(item[0].ToString());
            }
            string qs = "Select PrdctName from tblSalePrdct";
            ds = rp.getdata(qs);
            foreach (DataRow items in ds.Tables["0"].Rows)
            {
                ComboPrdct.Items.Add(items[0].ToString());
            }
        }
        private void CalculateTTL()
        {
            //double Qtotal = 0;
            //double Gtotal = 0;
            //double qt = 0;
            //double rt = 0;
            //double total = 0;

            //Qtotal = Convert.ToDouble(Qty.Text);
            //Gtotal = Convert.ToDouble(txt_ttlamnt.Text);
            //qt = Convert.ToDouble(Qty.Text);
            //rt = Convert.ToDouble(Rate.Text);
            //total = qt * rt;

            //txt_ttlamnt.Text = total.ToString();
            //txt_ttlqty.Text = Qtotal.ToString();


            //double nettotal = 0;
            //double dscamt = 0;
            //double dscperc = 0;

            //dscperc = Convert.ToDouble(txt_disc.Text);
            //dscamt = (total * dscperc);
            //nettotal = dscamt - total;

            //txt_ttldisc.Text = nettotal.ToString();

        }

        private void SaleVoucher_Load(object sender, EventArgs e)
        {
            string qu = "select* from tbl_sale";
            ds = rp.getdata(qu);
            custCastGrid.DataSource = ds.Tables["0"].DefaultView;

            combo_term.Text = "Cash";
            ComboCust.Focus();
            combofill();
            this.Activate();
        }

        private void QtyRate_Leave(object sender, EventArgs e)
        {
            try
            {
                double total = 0;
                double qt = 0;
                double rt = 0;

                qt = Convert.ToDouble(Qty.Text);
                rt = Convert.ToDouble(Rate.Text);
                total = qt * rt;

                txt_total.Text = total.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Error: Please Enter only Numeric Value", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txt_disc_Leave(object sender, EventArgs e)
        {
            try
            {
                double total = 0;
                double qt = 0;
                double rt = 0;

                qt = Convert.ToDouble(Qty.Text);
                rt = Convert.ToDouble(Rate.Text);
                total = qt * rt;

                double nettotal = 0;
                dscperc = Convert.ToDouble(txt_disc.Text);
                dscamt = (total * dscperc) / 100;
                //txt_ttldisc.Text = dscamt.ToString();

                nettotal = total - dscamt;
                txt_total.Text = nettotal.ToString();

            }
            catch (Exception)
            {
                MessageBox.Show("Error: Please Enter only Numeric Value", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ComboCust_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_cell.Focus();
            }
        }

        private void txt_cell_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                combo_term.Focus();
            }
        }

        private void combo_term_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                combo_datetime.Focus();
            }
        }

        private void combo_datetime_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ComboPrdct.Focus();
            }
        }

        private void ComboPrdct_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_desc.Focus();
            }
        }

        private void txt_desc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Qty.Focus();
            }
        }

        private void Qty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Rate.Focus();
            }
        }

        private void Rate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_disc.Focus();
            }
        }

        private void txt_disc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_total.Focus();
            }
        }

        private void txt_total_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tb_AddToCart.Focus();
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            if (txt_cell.Text != "")
            {
                string query = "insert into tbl_cust (Customername,CustName,Custcell,Terms,Date) values ('" + txtcustname.Text + "'" + ComboCust.Text + "','" + txt_cell.Text + "','" + combo_term.Text + "','" + combo_datetime.Text + "')";
                ds = rp.getdata(query);
                MessageBox.Show("Customer Information Has Been Saved Successfully!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Error: Customer Name Should not be empty", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ComboPrdct.Focus();
        }

        private void ComboCust_SelectedIndexChanged(object sender, EventArgs e)
        {
            string qu = "select* from tblCustomer where CustName like '%" + ComboCust.Text + "%'";
            ds = rp.getdata(qu);
            txt_cell.Text = ds.Tables[0].Rows[0][2].ToString();
        }

        private void tb_AddToCart_Click(object sender, EventArgs e)
        {
            if (ComboPrdct.SelectedIndex == -1)
            {
                MessageBox.Show("Enter product name to continue..", "Product name missing!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    string query = "insert into tbl_sale (Prdctname,Description,Qty,Price,[Disc%],Total) values ('" + ComboPrdct.Text + "','" + txt_desc.Text + "','" + Qty.Text + "','" + Rate.Text + "','" + txt_disc.Text + "','" + txt_total.Text + "')";
                    ds = rp.getdata(query);
                    MessageBox.Show("Sale Information has been added successfully!!");
                }
                catch (Exception)
                {
                    MessageBox.Show("Something Could be wrong..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            try
            {
                double total = 0;
                double qt = 0;
                double rt = 0;
                double nettotal = 0;

                qt = Convert.ToDouble(Qty.Text);
                rt = Convert.ToDouble(Rate.Text);
                total = qt * rt;

                dscperc = Convert.ToDouble(txt_disc.Text);
                dscamt = (total * dscperc) / 100;
                txt_ttldisc.Text = dscamt.ToString();

                nettotal = total - dscamt;
                txt_total.Text = nettotal.ToString();

                txt_ttlqty.Text = qt.ToString();
                txt_ttlamnt.Text = total.ToString();
                txt_nettl.Text = nettotal.ToString();

            }
            catch (Exception)
            {
                MessageBox.Show("Error: Please Enter only Numeric Value", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            string qu = "select* from tbl_sale";
            ds = rp.getdata(qu);
            custCastGrid.DataSource = ds.Tables["0"].DefaultView;
        }

        private void custCastGrid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ComboPrdct_SelectedIndexChanged(object sender, EventArgs e)
        {
            string qu = "select* from tblSalePrdct where PrdctName like '%" + ComboPrdct.Text + "%'";
            ds = rp.getdata(qu);
            // custCastGrid.DataSource = ds.Tables["0"].DefaultView;
            txt_desc.Text = ds.Tables[0].Rows[0][6].ToString();
        }

        private void txt_disc_TextChanged(object sender, EventArgs e)
        {

        }

        private void custCastGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            DataGridViewRow row = custCastGrid.Rows[selectedRow];
            txtno.Text = row.Cells[0].Value.ToString();
            ComboPrdct.Text = row.Cells[1].Value.ToString();
            txt_desc.Text = row.Cells[2].Value.ToString();
            Qty.Text = row.Cells[3].Value.ToString();
            Rate.Text = row.Cells[4].Value.ToString();
            txt_disc.Text = row.Cells[5].Value.ToString();
            txt_total.Text = row.Cells[6].Value.ToString();
        }

        private void custCastGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult dialouge = MessageBox.Show("Do you Really Want to Delete?", "Delete", MessageBoxButtons.YesNo);
            if (dialouge == DialogResult.Yes)
            {
                int u;
                string quer = "delete from tbl_sale where Vouchno = '" + txtno.Text + "'";
                u = rp.savedata(quer);
                if (u > 0)
                {
                    MessageBox.Show("Selected Informaton Is Deleted From List!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Error; Not Available!!");
                }
                string qu = "select* from tbl_sale";
                ds = rp.getdata(qu);
                custCastGrid.DataSource = ds.Tables["0"].DefaultView;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string qu = "select* from tbl_sale";
            ds = rp.getdata(qu);
            custCastGrid.DataSource = ds.Tables["0"].DefaultView;

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}

