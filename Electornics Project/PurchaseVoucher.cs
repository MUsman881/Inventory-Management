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
    public partial class PurchaseVoucher : MetroFramework.Forms.MetroForm

    {
        DataSet ds = new DataSet();
        repo rp = new repo();
        int selectedRow;
        public PurchaseVoucher()
        {
            InitializeComponent();
        }

        private void PurchaseVoucher_Load(object sender, EventArgs e)
        {
            string qu = "select* from tbl_supplier";
            ds = rp.getdata(qu);
            custCartGrid.DataSource = ds.Tables["0"].DefaultView;

            combo_term.Text = "Cash";
            Combofill();
            this.Activate();
        }
        private void Combofill()
        {
            comboprdct.Items.Clear();
            Combosupp.Items.Clear();
            string q = "Select Name from tblSuppliers";
            ds = rp.getdata(q);
            foreach (DataRow item in ds.Tables["0"].Rows)
            {
                Combosupp.Items.Add(item[0].ToString());
            }
            //string qs = "Select PrdctName from tblAddPrdct";
            //ds = rp.getdata(qs);
            //foreach (DataRow items in ds.Tables["0"].Rows)
            //{
            //    comboprdct.Items.Add(items[0].ToString());
            //}
        }
        private void gbox_CustomerInfo_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (txt_cell.Text != "")
            {
                string query = "insert into tbl_supplier (SupplierName,Suppliercell,Term,Date) values ('" + Combosupp.Text + "'" + txt_cell.Text + "','" + combo_term.Text + "','" + combo_datetime.Text + "')";
                ds = rp.getdata(query);
                MessageBox.Show("Supplier Information Has Been Saved Successfully!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Error: Suppplier Name Should not be empty", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            comboprdct.Focus();
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

                txttotal.Text = total.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Error: Please Enter only Numeric Value", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtdisc_Leave(object sender, EventArgs e)
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
                double dscperc = 0;
                double dscamt = 0;
                dscperc = Convert.ToDouble(txtdisc.Text);
                dscamt = (total * dscperc) / 100;
                //txt_ttldisc.Text = dscamt.ToString();

                nettotal = total - dscamt;
                txttotal.Text = nettotal.ToString();

            }
            catch (Exception)
            {
                MessageBox.Show("Error: Please Enter only Numeric Value", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void QtyRate_leave(object sender, EventArgs e)
        {

            try
            {
                double total = 0;
                double qt = 0;
                double rt = 0;

                qt = Convert.ToDouble(Qty.Text);
                rt = Convert.ToDouble(Rate.Text);
                total = qt * rt;

                txttotal.Text = total.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Error: Please Enter only Numeric Value", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void tb_AddToCart_Click(object sender, EventArgs e)
        {
            if (comboprdct.SelectedIndex == -1)
            {
                MessageBox.Show("Enter product name to continue..", "Product name missing!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    string query = "insert into tbl_purchase (Prdctname,Description,Qty,Price,Disc,Total) values ('" + comboprdct.Text + "','" + txt_desc.Text + "','" + Qty.Text + "','" + Rate.Text + "','" + txtdisc.Text + "','" + txttotal.Text + "')";
                    ds = rp.getdata(query);
                    MessageBox.Show("Purchase Information has been added successfully!!");
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
                double dscperc = 0;
                double dscamt = 0;

                qt = Convert.ToDouble(Qty.Text);
                rt = Convert.ToDouble(Rate.Text);
                total = qt * rt;

                dscperc = Convert.ToDouble(txtdisc.Text);
                dscamt = (total * dscperc) / 100;
                txt_ttldisc.Text = dscamt.ToString();

                nettotal = total - dscamt;
                txttotal.Text = nettotal.ToString();

                txt_ttlqty.Text = qt.ToString();
                txt_ttlamnt.Text = total.ToString();
                txt_netttl.Text = nettotal.ToString();

            }
            catch (Exception)
            {
                MessageBox.Show("Error: Please Enter only Numeric Value", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void custCartGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            DataGridViewRow row = custCartGrid.Rows[selectedRow];
            txtno.Text = row.Cells[0].Value.ToString();
            comboprdct.Text = row.Cells[1].Value.ToString();
            txt_desc.Text = row.Cells[2].Value.ToString();
            Qty.Text = row.Cells[3].Value.ToString();
            Rate.Text = row.Cells[4].Value.ToString();
            txtdisc.Text = row.Cells[5].Value.ToString();
            txttotal.Text = row.Cells[6].Value.ToString();
        }

        private void custCartGrid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult dialouge = MessageBox.Show("Do you Really Want to Delete?", "Delete", MessageBoxButtons.YesNo);
            if (dialouge == DialogResult.Yes)
            {
                int u;
                string quer = "delete from tbl_supplier where Vouchno = '" + txtno.Text + "'";
                u = rp.savedata(quer);
                if (u > 0)
                {
                    MessageBox.Show("Selected Informaton Is Deleted From List!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Error; Not Available!!");
                }
                string qu = "select* from tbl_supplier";
                ds = rp.getdata(qu);
                custCartGrid.DataSource = ds.Tables["0"].DefaultView;
            }
        }
    }
}
