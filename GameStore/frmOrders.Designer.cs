namespace GameStore
{
    partial class frmOrders
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lstOrders = new System.Windows.Forms.ListBox();
            this.btnChooseCustomer = new System.Windows.Forms.Button();
            this.btnChooseProducts = new System.Windows.Forms.Button();
            this.btnRemoveProduct = new System.Windows.Forms.Button();
            this.btnDisplayOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Orders";
            // 
            // lstOrders
            // 
            this.lstOrders.FormattingEnabled = true;
            this.lstOrders.ItemHeight = 15;
            this.lstOrders.Location = new System.Drawing.Point(12, 27);
            this.lstOrders.Name = "lstOrders";
            this.lstOrders.Size = new System.Drawing.Size(120, 109);
            this.lstOrders.TabIndex = 1;
            // 
            // btnChooseCustomer
            // 
            this.btnChooseCustomer.Location = new System.Drawing.Point(138, 27);
            this.btnChooseCustomer.Name = "btnChooseCustomer";
            this.btnChooseCustomer.Size = new System.Drawing.Size(109, 23);
            this.btnChooseCustomer.TabIndex = 2;
            this.btnChooseCustomer.Text = "Add Customer";
            this.btnChooseCustomer.UseVisualStyleBackColor = true;
            // 
            // btnChooseProducts
            // 
            this.btnChooseProducts.Location = new System.Drawing.Point(138, 56);
            this.btnChooseProducts.Name = "btnChooseProducts";
            this.btnChooseProducts.Size = new System.Drawing.Size(109, 23);
            this.btnChooseProducts.TabIndex = 3;
            this.btnChooseProducts.Text = "Add Products";
            this.btnChooseProducts.UseVisualStyleBackColor = true;
            // 
            // btnRemoveProduct
            // 
            this.btnRemoveProduct.Location = new System.Drawing.Point(138, 85);
            this.btnRemoveProduct.Name = "btnRemoveProduct";
            this.btnRemoveProduct.Size = new System.Drawing.Size(109, 23);
            this.btnRemoveProduct.TabIndex = 4;
            this.btnRemoveProduct.Text = "Remove Product";
            this.btnRemoveProduct.UseVisualStyleBackColor = true;
            // 
            // btnDisplayOrder
            // 
            this.btnDisplayOrder.Location = new System.Drawing.Point(138, 114);
            this.btnDisplayOrder.Name = "btnDisplayOrder";
            this.btnDisplayOrder.Size = new System.Drawing.Size(109, 23);
            this.btnDisplayOrder.TabIndex = 5;
            this.btnDisplayOrder.Text = "Display Order";
            this.btnDisplayOrder.UseVisualStyleBackColor = true;
            // 
            // frmOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 147);
            this.Controls.Add(this.btnDisplayOrder);
            this.Controls.Add(this.btnRemoveProduct);
            this.Controls.Add(this.btnChooseProducts);
            this.Controls.Add(this.btnChooseCustomer);
            this.Controls.Add(this.lstOrders);
            this.Controls.Add(this.label1);
            this.Name = "frmOrders";
            this.Text = "Orders";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ListBox lstOrders;
        private Button btnChooseCustomer;
        private Button btnChooseProducts;
        private Button btnRemoveProduct;
        private Button btnDisplayOrder;
    }
}