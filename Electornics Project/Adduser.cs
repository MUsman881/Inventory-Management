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
    public partial class Adduser : MetroFramework.Forms.MetroForm
    {
        int selectedRow;
        DataSet ds = new DataSet();
        repo rp = new repo();
        public Adduser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminPlace ad = new AdminPlace();
            ad.Show();
        }

        private void Adduser_Load(object sender, EventArgs e)
        {
            string qu = "Select Username From tbl_user";
            ds = rp.getdata(qu);
            dataGridView1.DataSource = ds.Tables["0"].DefaultView;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[selectedRow];
            textBox1.Text = row.Cells[0].Value.ToString();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            string quer = "Select Username From tbl_user where Username Like '%" + textBox4.Text + "%'";
            ds = rp.getdata(quer);
            dataGridView1.DataSource = ds.Tables["0"].DefaultView;
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == textBox3.Text && textBox1.Text != "")
            {
                string query = "insert into tbl_user (Username,Password,ConfirmPasword) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')";
                ds = rp.getdata(query);
                MessageBox.Show("USER IS Created!", "AddUser", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox1.Focus();
            }
            else
            {
                MessageBox.Show("Please Enter Password!", "AddUser", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //if (textBox3.Text != textBox2.Text)
            //{
            //    label2.Text = "Not Matched!";
            //    label2.ForeColor = Color.Red;
            //}
            //else
            //{
            //    label2.Text = "Matched!";
            //    label2.ForeColor = Color.PowderBlue;
            //}
        }

        private void BtnBackC_Click(object sender, EventArgs e)
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
                textBox3.Focus();
            }
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnCreate.Focus();
            }
        }

        private void BtnCreate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnUpdate.Focus();
            }
        }

        private void BtnUpdate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox4.Focus();
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.Focus();
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == textBox3.Text && textBox2.Text != "")
            {
                string query = "update tbl_user  set Password = '" + textBox2.Text + "', ConfirmPasword = '" + textBox3.Text + "' Where Username ='" + textBox1.Text + "'";
                ds = rp.getdata(query);
                MessageBox.Show("User Password Has Been Updated!");
                textBox2.Clear();
                textBox3.Clear();
                textBox1.Focus();
            }
            else
            {
                MessageBox.Show("Please Enter Password!", "AddUser", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
