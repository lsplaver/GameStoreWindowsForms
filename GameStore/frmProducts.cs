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
    public partial class frmProducts : Form
    {
        List<Product> products = new List<Product>();

        public frmProducts()
        {
            InitializeComponent();
        }

        private void frmProducts_Load(object sender, EventArgs e)
        {
            products = ProductDB.GetAllProducts();
            FillListBox();
        }

        private void FillListBox()
        {
            lstProducts.Items.Clear();

            foreach (Product product in products)
            {
                lstProducts.Items.Add(product.GetDisplayText());
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            frmAddProduct addProduct = new frmAddProduct();
            Product product = addProduct.GetNewProduct();
            if (product.Code != null)
            {
                products.Add(product);
                ProductDB.SaveProducts(products);
            }
            FillListBox();

        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            int index = lstProducts.SelectedIndex;

            if (index != -1)
            {
                products.RemoveAt(index);
                ProductDB.SaveProducts(products);
            }
            FillListBox();

        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            int index = lstProducts.SelectedIndex;

            if (index != -1)
            {
                Product product = products.ElementAt(index);
                frmAddProduct editProduct = new frmAddProduct();
                product = editProduct.GetNewProduct(product);
                products.RemoveAt(index);
                products.Insert(index, product);
            }

            FillListBox();

        }
    }
}
