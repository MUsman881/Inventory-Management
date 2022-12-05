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
    public partial class Customer : MetroFramework.Forms.MetroForm
    {
        DataSet ds = new DataSet();
        repo rp = new repo();
        int selectedRow;
        public Customer()
        {
            InitializeComponent();
        }
        //private void autonumber()
        //{
        //    string an = "select isnull (max (cast (CustID as int)),0)+1 from tblCustomer";
        //    ds = rp.getdata(an);
        //    if (ds.Tables["0"].Rows.Count > 0)
        //    {
        //        txtno.Text = ds.Tables["0"].Rows[0][0].ToString();
        //    }
        //}

        private void Customer_Load(object sender, EventArgs e)
        {
            this.Activate();
            //autonumber();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminPlace ad = new AdminPlace();
            ad.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtcustname.Undo();
            txtcustcont.Undo();
            txtcustemail.Undo();
            txtcustname.Focus();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[selectedRow];
            txtno.Text = row.Cells[0].Value.ToString();
            txtcustname.Text = row.Cells[1].Value.ToString();
            txtcustcont.Text = row.Cells[2].Value.ToString();
            txtcustemail.Text = row.Cells[3].Value.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtcustcont.Text!="")
            {
                string query = "insert into tblCustomer (CustName,Contact,Email) values ('" + txtcustname.Text + "','" + txtcustcont.Text + "','" + txtcustemail.Text + "')";
                ds = rp.getdata(query);
                MessageBox.Show("Customer Has Been Added!");
                txtcustname.Clear();
                txtcustcont.Clear();
                txtcustemail.Clear();
                txtcustname.Focus();
            }
            else
            {
                MessageBox.Show("Error: Fields Should not be empty", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);               
            }
            string qu = "Select * From tblCustomer";
            ds = rp.getdata(qu);
            dataGridView1.DataSource = ds.Tables["0"].DefaultView;

        }

        private void textbox4_TextChanged(object sender, EventArgs e)
        {
            string quer = "Select CustName From tblCustomer where CustName Like '%" + textBox4.Text + "%'";
            ds = rp.getdata(quer);
            dataGridView1.DataSource = ds.Tables["0"].DefaultView;
        }

        private void Textbox5_TextChanged(object sender, EventArgs e)
        {
            string quer = "Select Contact From tblCustomer where Contact Like '%" + textBox5.Text + "%'";
            ds = rp.getdata(quer);
            dataGridView1.DataSource = ds.Tables["0"].DefaultView;
        }

        private void Textbox6_TextChanged(object sender, EventArgs e)
        {
            string quer = "Select Email From tblCustomer where Email Like '%" + textBox6.Text + "%'";
            ds = rp.getdata(quer);
            dataGridView1.DataSource = ds.Tables["0"].DefaultView;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(txtcustcont.Text != "")
            {
                string query = "update tblCustomer set Contact = '" + txtcustcont.Text + "', Email = '" + txtcustemail.Text + "' Where CustName ='" + txtcustname.Text + "'";
                ds = rp.getdata(query);
                MessageBox.Show("Customer Has Been Updated!");
                txtcustname.Clear();
                txtcustcont.Clear();
                txtcustemail.Clear();
                txtcustname.Focus();
            }
            else
            {
                MessageBox.Show("Error: Something Wrong.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dialouge = MessageBox.Show("Do you Really Want to Delete?", "Delete", MessageBoxButtons.YesNo);
            if (dialouge == DialogResult.Yes)
            {
                int u;
                string quer = "delete from tblCustomer where Contact = '" + txtcustcont.Text + "'";
                u = rp.savedata(quer);
                if (u > 0)
                {
                    MessageBox.Show("Selected Customer Is Deleted From List!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Customer is not Available!");
                }
            }
            //else if (dialouge==DialogResult.No)
            //{
            //    this.Hide();
            //    Customer cu = new Customer();
            //    cu.Show();
            //}
            //string quer = "delete from tblCustomer where CustName = '" + textBox1.Text + "'";
            //ds = rp.getdata(quer);
            //MessageBox.Show("Selected Customer Is Deleted From List!", "Deleter", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //textBox2.Clear();
            //textBox3.Clear();
            //textBox1.Focus();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                txtcustcont.Focus();
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtcustemail.Focus();
            }
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
               btnsave.Focus();
            }
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnupdate.Focus();
            }
        }

        private void button2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btndel.Focus();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string qu = "Select * From tblCustomer";
            ds = rp.getdata(qu);
            dataGridView1.DataSource = ds.Tables["0"].DefaultView;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
