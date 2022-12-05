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
    public partial class User : MetroFramework.Forms.MetroForm
    {
        DataSet ds = new DataSet();
        repo rp = new repo();
        public User()
        {
            InitializeComponent();
        }

        private void BtnExt_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string query = "select * from tbl_user where UserName = '" + textBox1.Text + "' and Password = '" + textBox2.Text + "'";
            ds = rp.getdata(query);

            if (ds.Tables["0"].Rows.Count == 1)
            {
                this.Hide();
                addproduct IM = new addproduct();
                IM.Show();
                MessageBox.Show("Welcome To The Inventory System!");
            }
            else
            {
                MessageBox.Show("Invalid UserName Or Password", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void User_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox2.Focus();
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnLogin.Focus();
            }
        }
    }
}
