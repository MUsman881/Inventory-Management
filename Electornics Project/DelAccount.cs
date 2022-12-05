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
    public partial class DelAccount : MetroFramework.Forms.MetroForm
    {
        //int selectedRow;
        DataSet ds = new DataSet();
        repo rp = new repo();
        public DelAccount()
        {
            InitializeComponent();
        }

        private void btnBackD_Click(object sender, EventArgs e)
        {
            
        }

        private void DelAccount_Load(object sender, EventArgs e)
        {
            this.Activate();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

            string quer = "Select Username From tbl_user where Username Like '%" + textBox4.Text + "%'";
            ds = rp.getdata(quer);
            dataGridView1.DataSource = ds.Tables["0"].DefaultView;
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            int u;
            string quer = "delete from tbl_user where Username = '" + textBox1.Text + "'";
            u = rp.savedata(quer);
            if (u > 0)
            {
                MessageBox.Show("Selected Username is Deleted!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Username is not Available!");
            }
            textBox1.Clear();
            textBox1.Focus();
            //string quer = "delete from tbl_user where Username = '" + textBox1.Text + "'";
            //ds = rp.getdata(quer);
            //MessageBox.Show("Selected USERNAME Is Deleted!", "Deleter", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {

           
        }

        private void BtnDel_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
               btnBack.Focus();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminPlace ad = new AdminPlace();
            ad.Show();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnDel.Focus();
            }
        }
    }
}
