using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameStore
{
    public partial class frmCustomers : Form
    {
        List<Customer> customers = null;
        public frmCustomers()
        {
            InitializeComponent();
        }

        private void frmCustomers_Load(object sender, EventArgs e)
        {
            customers = CustomerDB.GetAllCustomers();
            FillListBox();
        }

        private void FillListBox()
        {
            lstCustomers.Items.Clear();
            
            foreach(Customer customer in customers)
            {
                lstCustomers.Items.Add(customer.GetDisplayText());
            }
        }
    }
}
