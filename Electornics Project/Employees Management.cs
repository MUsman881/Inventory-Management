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
    public partial class Employees_Management : MetroFramework.Forms.MetroForm
    {
        DataSet ds = new DataSet();
        repo rp = new repo();
        int selectedRow;
        public Employees_Management()
        {
            InitializeComponent();
        }

        private void Employees_Management_Load(object sender, EventArgs e)
        {
            this.Activate();
            //string qu = "Select *From tblEmployees";
            //ds = rp.getdata(qu);
            //dataGridView1.DataSource = ds.Tables["0"].DefaultView;

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            empname.Undo();
            txtCnic.Undo();
            txtEmail.Undo();
            txtContact.Undo();
            txtaddress.Undo();
            txtDesignation.Undo();
            empname.Focus();
           
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
            textno.Text = row.Cells[0].Value.ToString();
            empname.Text = row.Cells[1].Value.ToString();
            txtCnic.Text = row.Cells[2].Value.ToString();
            txtEmail.Text = row.Cells[3].Value.ToString();
            txtContact.Text = row.Cells[4].Value.ToString();
            txtaddress.Text = row.Cells[5].Value.ToString();
            txtDesignation.Text = row.Cells[6].Value.ToString();
            dateTimePicker1.Text = row.Cells[7].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
             DialogResult dialouge = MessageBox.Show("Do you Really Want to Delete?", "Delete", MessageBoxButtons.YesNo);
             if (dialouge == DialogResult.Yes)
             {
                 int u;
                 string quer = "delete from tblEmployees where EmpName = '" + empname.Text + "'";
                 u = rp.savedata(quer);
                 if (u > 0)
                 {
                     MessageBox.Show("Selected Employee Is Deleted From List!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 }
                 else
                 {
                     MessageBox.Show("Employee is not Available!");
                 }
             }
             else if (dialouge == DialogResult.No)
             {
                 this.Hide();
                 Employees_Management em = new Employees_Management();
                 em.Show();
             }
            //string quer = "delete from tblEmployees where EmpName = '" + textBox1.Text + "'";
            //ds = rp.getdata(quer);
            //MessageBox.Show("Selected Employee Is Deleted From List!", "Deleter", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (empname.Text != "" && txtCnic.Text != "")
            {
                string query = "update tblEmployees  set CNIC = '" + txtCnic.Text + "', Email = '" + txtEmail.Text + "', Contact='" + txtContact.Text + "', Address='" + txtaddress.Text + "', Designation='" + txtDesignation.Text + "', DateOfAppointment='" + dateTimePicker1.Text + "' Where EmpName ='" + empname.Text + "'";
                ds = rp.getdata(query);
                MessageBox.Show("Employee Information Has Been Updated!");
                empname.Clear();
                txtCnic.Clear();
                txtEmail.Clear();
                txtContact.Clear();
                txtaddress.Clear();
                txtDesignation.Clear();
                empname.Focus();
            }
            else
            {
                MessageBox.Show("Error; Something Should be Wrong, Please Try Again!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textbox8_TextChanged(object sender, EventArgs e)
        {
            string quer = "Select EmpName From tblEmployees where EmpName Like '%" + textbox8.Text + "%'";
            ds = rp.getdata(quer);
            dataGridView1.DataSource = ds.Tables["0"].DefaultView;
        }

        private void textbox9_TextChanged(object sender, EventArgs e)
        {
            string quer = "Select Contact From tblEmployees where Contact Like '%" + textbox9.Text + "%'";
            ds = rp.getdata(quer);
            dataGridView1.DataSource = ds.Tables["0"].DefaultView;
        }

        private void textbox10_TextChanged(object sender, EventArgs e)
        {
            string quer = "Select Email From tblEmployees where Email Like '%" + textbox10.Text + "%'";
            ds = rp.getdata(quer);
            dataGridView1.DataSource = ds.Tables["0"].DefaultView;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtCnic.Focus();
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtEmail.Focus();
            }
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtContact.Focus();
            }
        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtaddress.Focus();
            }
        }

        private void textBox5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtDesignation.Focus();
            }
        }

        private void textBox6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dateTimePicker1.Focus();
            }
        }

        private void dateTimePicker1_KeyDown(object sender, KeyEventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (empname.Text != "" && txtCnic.Text != "")
            {
                string query = "insert into tblEmployees (EmpName,CNIC,Email,Contact,Address,Designation,DateOfAppointment) values ('" + empname.Text + "','" + txtCnic.Text + "','" + txtEmail.Text + "','" + txtContact.Text + "','" + txtaddress.Text + "','" + txtDesignation.Text + "','" + dateTimePicker1.Text + "')";
                ds = rp.getdata(query);
                MessageBox.Show("Employee is Added!", "Employees", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCnic.Clear();
                txtEmail.Clear();
                txtContact.Clear();
                txtaddress.Clear();
                txtDesignation.Clear();
                empname.Focus();
            }
            else
            {
                MessageBox.Show("Error; Something Could be Wrong,Please Try Again!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string qu = "Select *From tblEmployees";
            ds = rp.getdata(qu);
            dataGridView1.DataSource = ds.Tables["0"].DefaultView;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
