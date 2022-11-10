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

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            frmAddCustomer addCustomer = new frmAddCustomer();
            Customer customer = addCustomer.GetNewCustomer();
            if (customer.FirstName != null)
            {
                customers.Add(customer);
                CustomerDB.SaveCustomers(customers);
            }
            FillListBox();
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            int index = lstCustomers.SelectedIndex;

            if (index != -1)
            {
                customers.RemoveAt(index);
                CustomerDB.SaveCustomers(customers);
            }
            FillListBox();
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            int index = lstCustomers.SelectedIndex;

            if (index != -1)
            {
                Customer customer = customers.ElementAt(index);
                frmAddCustomer editCustomer = new frmAddCustomer();
                customer = editCustomer.GetNewCustomer();
                customers.RemoveAt(index);
                customers.Insert(index, customer);
            }

            FillListBox();
        }
    }
}
