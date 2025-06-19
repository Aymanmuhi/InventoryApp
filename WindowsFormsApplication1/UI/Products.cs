using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using InventoryApp.Models;
using InventoryApp.Services;

namespace InventoryApp.UI
{
    public partial class Products : UserControl
    {
        private ProductsService services = new ProductsService();


        public Products()
        {
            InitializeComponent();

        }
        private void viewAllProducts()
        {
            products_table.Columns[0].Width = products_table.Width / 2;
            products_table.Columns[1].Width = products_table.Width / 2;

            foreach (var product in services.GetAll())
            {
                var item = new ListViewItem(product.Id.ToString());
                item.SubItems.Add(product.Name);
                products_table.Items.Add(item);
            }
        }

        private void Products_Load(object sender, EventArgs e)
        {
            viewAllProducts();
        }

        private void product_add_btn_Click(object sender, EventArgs e)
        {
            string productName = product_name_field.Text.Trim();
            if (productName=="" || productName== null) MessageBox.Show("product name field can not be empty");
            else
            {
                Product product = new Product();
                product.Name = productName;
                services.Add(product);
                MessageBox.Show("the new product '" + productName + "' has been added");
                products_table.Items.Clear();
                product_name_field.Text = null;
               viewAllProducts();
            }

        }
    }
}
