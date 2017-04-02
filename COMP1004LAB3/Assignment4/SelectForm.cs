using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Assignment4.Modules;

/*Name:-Gowtham Talluri
 StudentID :- 200335297
 App:-Dollar Computer
 Description:- Online computer sale cart
 */

namespace Assignment4
{
    public partial class SelectForm : Form
    { // connect to DB using Entity Framework
        ProductsContext db = new ProductsContext();

        // CONSTRUCTOR
        public SelectForm()
        {
            InitializeComponent();
        }

        
        // Call getProducts() - get data from DB

        private void SelectForm_Load(object sender, EventArgs e)
        {
            getProducts();
        }




        
        // Get products table from database and use that in the datagridview
       
        private void getProducts()
        {
            // use LINQ to access the table in the DB
            List<product> productList = (from product in db.products
                                         select product).ToList();

            // set the datasource of the products DataGridView
            dataGridView_products.DataSource = productList;
        }

       
        // Get productID from selected cell in datagridview, set the selectedProduct object,
      
       
        private void getSelectedProductData(short ProductID)
        {
            
            

            Program.selectedProduct = (from product in db.products
                                       where product.productID == ProductID
                                       select product).FirstOrDefault();

            string productInfo = Program.selectedProduct.manufacturer + " " + Program.selectedProduct.model
                + " Priced at: $" + Program.selectedProduct.cost;

            txt_selected.Text = productInfo;
        }

       
        // Close the application
        //--------------------------------------------------------------------------------------------------------
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
        // Open the product info form
        
        private void btn_next_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProductInfoForm productInfoForm = new ProductInfoForm();
            productInfoForm.previousForm = this;
            productInfoForm.Show();
        }
        //selected cell coloun number retrived
        private void dataGridView_products_SelectionChanged(object sender, EventArgs e)
        {
            var rowindex = dataGridView_products.CurrentRow.Index;
            short colval = (short)dataGridView_products.Rows[rowindex].Cells[0].Value;
            
            getSelectedProductData(colval);
            btn_next.Enabled = true;

        }
    }
}
