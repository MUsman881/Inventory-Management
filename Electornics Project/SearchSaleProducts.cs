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
    public partial class SearchSaleProducts : MetroFramework.Forms.MetroForm
    {
        DataSet ds = new DataSet();
        repo rp = new repo();
        public SearchSaleProducts()
        {
            InitializeComponent();
        }

        private void CustomersInfo_Load(object sender, EventArgs e)
        {
           
        }

        private void Textbox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void Textbox5_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Textbox6_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
