using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameStore
{
    public partial class frmAddCustomer : Form
    {
        private Customer customer = new Customer();

        public frmAddCustomer()
        {
            InitializeComponent();
        }

        private void btnCancelCustomer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public Customer GetNewCustomer()
        {
            this.ShowDialog();
            return customer;
        }
        private void btnSaveCustomer_Click(Object sender, EventArgs e)
        {
            if (IsValidData(this.txtFirstName.Text, this.txtLastName.Text, this.txtEmail.Text))
            {
                customer.FirstName = this.txtFirstName.Text;
                customer.LastName = this.txtLastName.Text;
                customer.Email = this.txtEmail.Text;
                this.Close();
            }
        }

        private bool IsValidData(string firstName, string lastName, string email)
        {
            bool success = true;
            string msg = "";
            if (Validator.IsPresent(firstName) != "")
            {
                msg += Validator.IsPresent(firstName);
            }
            if (Validator.IsPresent(lastName) != "")
            {
                msg += Validator.IsPresent(lastName);
            }
            if (Validator.IsPresent(email) != "")
            {
                msg += Validator.IsPresent(email);
            }
            
            if (Validator.IsEmail(email) != "")
            {
                msg += Validator.IsEmail(email);
            }

            if (msg != "")
            {
                MessageBox.Show(msg);
                success = false;
            }
            return success;
        }
    }
}
