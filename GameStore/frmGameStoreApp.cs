namespace GameStore
{
    public partial class frmGameStoreApp : Form
    {
        public frmGameStoreApp()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GameStoreApp_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to the Game Store App. \nYou can choose Customer Maintenance, Product Maintenance or complete a Purchase.");
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            Form frmOrders = new frmOrders();
            frmOrders.ShowDialog();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            Form frmProducts = new frmProducts();
            frmProducts.ShowDialog();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            Form frmCustomers = new frmCustomers();
            frmCustomers.ShowDialog();
        }
    }
}