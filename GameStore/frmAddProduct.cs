using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace GameStore
{
    public partial class frmAddProduct : Form
    {
        private Product product = new Product();

        public frmAddProduct()
        {
            InitializeComponent();
        }

        private void btnCancelProduct_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public Product GetNewProduct()
        {
            this.ShowDialog();
            return product;
        }

        public Product GetNewProduct(Product p)
        {
            this.txtCode.Text = p.Code;
            this.txtName.Text = p.Name;
            this.txtPrice.Text = p.Price;
            this.ShowDialog();
            return product;
        }

        private void btnSaveProduct_Click(object sender, EventArgs e)
        {
            if (IsValidData(this.txtCode.Text, this.txtName.Text, this.txtPrice.Text))
            {
                product.Code = this.txtCode.Text;
                product.Name = this.txtName.Text;
                product.Price = this.txtPrice.Text;
                this.Close();
            }

        }

        private bool IsValidData(string code, string name, string price)
        {
            bool success = true;
            string msg = "";
            if (Validator.IsPresent(code) != "")
            {
                msg += Validator.IsPresent(code);
            }
            if (Validator.IsPresent(name) != "")
            {
                msg += Validator.IsPresent(name);
            }
            if (Validator.IsPresent(price) != "")
            {
                msg += Validator.IsPresent(price);
            }

            if (Validator.IsDecimal(price) != "")
            {
                msg += Validator.IsDecimal(price);
            }
            else
            {
                double d = 0;
                d = Convert.ToDouble(price);
                if (Validator.IsWithinRange(d, 0.01, 99.99) != "")
                {
                    msg += Validator.IsWithinRange(d, 0.01, 99.99);
                }
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
