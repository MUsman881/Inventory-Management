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
    public partial class AdminPlace : MetroFramework.Forms.MetroForm
    {
        public AdminPlace()
        {
            InitializeComponent();
        }

        private void AdminPlace1_Load(object sender, EventArgs e)
        {
            this.Activate();
        }

        private void btnNewStock_Click(object sender, EventArgs e)
        {
            this.Hide();
            addproduct ad = new addproduct();
            ad.Show();
        }

        private void btnCreateCS_Click(object sender, EventArgs e)
        {
            this.Hide();
            Adduser ad = new Adduser();
            ad.Show();
        }

        private void insertNewStockToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            addproduct ad = new addproduct();
            ad.Show();
        }

        private void deleteCompleteStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdateStock up = new UpdateStock();
            up.Show();
        }

        private void toolStripMenuItem20_Click(object sender, EventArgs e)
        {
            this.Hide();
            Adduser ad = new Adduser();
            ad.Show();
        }

        private void toolStripMenuItem22_Click(object sender, EventArgs e)
        {
            this.Hide();
            DelAccount de = new DelAccount();
            de.Show();
        }

        private void aboutSoftwareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //About ab = new About();
            //ab.Show();
        }

        private void toolStripMenuItem16_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customer cs = new Customer();
            cs.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("Do you Want to LogOut", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Hide();
                Form1 f1 = new Form1();
                f1.Show();
            }
            else
            {
                this.Hide();
                AdminPlace A1 = new AdminPlace();
                A1.Show();
            }
            
        }

        private void employeesManagmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Employees_Management em = new Employees_Management();
            em.Show();
        }

        private void supppliersManagmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Suppliers_Managment sm = new Suppliers_Managment();
            sm.Show();
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {

        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewStock vs = new ViewStock();
            vs.Show();
        }

        private void Btnsale_Click(object sender, EventArgs e)
        {
            this.Hide();
            SaleVoucher Sa = new SaleVoucher();
            Sa.Show();
        }

        private void BtnCustomer_Click(object sender, EventArgs e)
        {

        }

        private void purchaseProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            PurchaseVoucher pv = new PurchaseVoucher();
            pv.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            PurchaseVoucher pv = new PurchaseVoucher();
            pv.Show();
        }

        private void cashToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void saleProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            SaleVoucher sl = new SaleVoucher();
            sl.Show();  
        }

        private void toolStripMenuItem19_Click(object sender, EventArgs e)
        {

        }
    }
}
