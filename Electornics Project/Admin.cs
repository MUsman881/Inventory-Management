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
    public partial class Admin : MetroFramework.Forms.MetroForm
    {   
        DataSet ds = new DataSet();
        repo rp = new repo();
        public Admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string query = "select * from tbl_Admin where Password = '" + txtlogin.Text + "'";
            //ds = rp.getdata(query);

            //if (ds.Tables["0"].Rows.Count == 1)
            //{
            //    this.Hide();
            //    AdminPlace ad = new AdminPlace();
            //    ad.Show();
            //    //MessageBox.Show("Welcome To Your Main Account!");
            //}
            //else
            //{
            //    MessageBox.Show("Invalid Password , Please Try Again With Valid Password!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            this.Activate();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                btnlogin.Focus();
            }
        }

        private void txtlogin_DragLeave(object sender, EventArgs e)
        {

        }

        private void txtlogin_Leave(object sender, EventArgs e)
        {
            string query = "select * from tbl_Admin where Password = '" + txtlogin.Text + "'";
            ds = rp.getdata(query);

            if (ds.Tables["0"].Rows.Count == 1)
            {
                this.Hide();
                AdminPlace ad = new AdminPlace();
                ad.Show();
                //MessageBox.Show("Welcome To Your Main Account!");
            }
            else
            {
                MessageBox.Show("Invalid Password , Please Try Again With Valid Password!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtlogin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
