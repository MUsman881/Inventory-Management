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
    public partial class Suppliers_Managment :MetroFramework.Forms.MetroForm
    {

        DataSet ds = new DataSet();
        repo rp = new repo();
        int selectedRow;
        public Suppliers_Managment()
        {
            InitializeComponent();
        }

        private void Suppliers_Managment_Load(object sender, EventArgs e)
        {
            this.Activate();
            //string qu = "Select *From tblSuppliers";
            //ds = rp.getdata(qu);
            //dataGridView1.DataSource = ds.Tables["0"].DefaultView;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtname.Undo();
            txtcontact.Undo();
            txtmail.Undo();
            txtname.Focus();
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminPlace ad = new AdminPlace();
            ad.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[selectedRow];
            txtno.Text = row.Cells[0].Value.ToString();
            txtname.Text = row.Cells[1].Value.ToString();
            txtcontact.Text = row.Cells[2].Value.ToString();
            txtmail.Text = row.Cells[3].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtcontact.Text != "")
            {
                string query = "update tblSuppliers  set Contact = '" + txtcontact.Text + "', Email = '" + txtmail.Text + "' Where Name ='" + txtname.Text + "'";
                ds = rp.getdata(query);
                MessageBox.Show("Suppliers Information Has Been Updated!");
                txtname.Clear();
                txtcontact.Clear();
                txtmail.Clear();
                txtname.Focus();
            }
            else
            {
                MessageBox.Show("Error: Something should be Empty...!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
          DialogResult dialouge = MessageBox.Show("Do you Really Want to Delete?", "Delete", MessageBoxButtons.YesNo);
          if (dialouge == DialogResult.Yes)
          {
              int u;
              string quer = "delete from tblSuppliers where Name = '" + txtname.Text + "'";
              u = rp.savedata(quer);
              if (u > 0)
              {
                  MessageBox.Show("Selected Supplier Is Deleted From List!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
              }
              else
              {
                  MessageBox.Show("Supplier is not Available!");
              }
          }
          //else if(dialouge == DialogResult.No)
          //{
          //    this.Hide();
          //    Suppliers_Managment su = new Suppliers_Managment();
          //    su.Show();
          //}
            //string quer = "delete from tblSuppliers where Name = '" + textBox1.Text + "'";
            //ds = rp.getdata(quer);
            //MessageBox.Show("Selected Supplier Is Removed From List!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void textbox4_TextChanged(object sender, EventArgs e)
        {
            string quer = "Select Name From tblSuppliers where Name Like '%" + textbox4.Text + "%'";
            ds = rp.getdata(quer);
            dataGridView1.DataSource = ds.Tables["0"].DefaultView;
        }

        private void Textbox5_TextChanged(object sender, EventArgs e)
        {
            string quer = "Select Contact From tblSuppliers where Contact Like '%" + Textbox5.Text + "%'";
            ds = rp.getdata(quer);
            dataGridView1.DataSource = ds.Tables["0"].DefaultView;
        }

        private void Textbox6_TextChanged(object sender, EventArgs e)
        {
            string quer = "Select Email From tblSuppliers where Email Like '%" + Textbox6.Text + "%'";
            ds = rp.getdata(quer);
            dataGridView1.DataSource = ds.Tables["0"].DefaultView;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtcontact.Focus();
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtmail.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            if (txtname.Text != "")
            {
                string query = "insert into tblSuppliers (Name,Contact,Email) values ('" + txtname.Text + "','" + txtcontact.Text + "','" + txtmail.Text + "')";
                ds = rp.getdata(query);
                MessageBox.Show("Supplier Information Has been Added!", "Suppliers", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtname.Clear();
                txtcontact.Clear();
                txtmail.Clear();
                txtname.Focus();
            }
            else
            {
                MessageBox.Show("Error; Something Should be Wrong, Please Try Again!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string quer = "Select *From tblSuppliers";
            ds = rp.getdata(quer);
            dataGridView1.DataSource = ds.Tables["0"].DefaultView;
        }

        private void txtmail_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                btnsave.Focus();
            }
        }
    }
}
