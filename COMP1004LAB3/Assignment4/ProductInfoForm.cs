using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
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
    public partial class ProductInfoForm : Form
    { 
        // connect to DB using Entity Framework
        ProductsContext db = new ProductsContext();

        public Form previousForm;

        // CONSTRUCTOR
        public ProductInfoForm()
        {
            InitializeComponent();
        }

        
        // Populate the text fields if there is a product object
       
        private void ProductInfoForm_Load(object sender, EventArgs e)
        {
            // If there is data to display
            if (Program.selectedProduct != null)
            {
                txt_productID.Text = Program.selectedProduct.productID.ToString();
                txt_condition.Text = Program.selectedProduct.condition;
                txt_cost.Text = Program.selectedProduct.cost.ToString();
                txt_platform.Text = Program.selectedProduct.platform;
                txt_OS.Text = Program.selectedProduct.OS;
                txt_manufacturer.Text = Program.selectedProduct.manufacturer;
                txt_model.Text = Program.selectedProduct.model;
                txt_memory.Text = Program.selectedProduct.HDD_size;
                txt_lcdSize.Text = Program.selectedProduct.screensize;
                txt_HDD.Text = Program.selectedProduct.HDD_speed;
                txt_cpuBrand.Text = Program.selectedProduct.CPU_brand;
                txt_cpuNumber.Text = Program.selectedProduct.CPU_number;
                txt_gpuType.Text = Program.selectedProduct.GPU_Type;
                txt_cpuType.Text = Program.selectedProduct.CPU_type;
                txt_cpuSpeed.Text = Program.selectedProduct.CPU_speed;
                txt_webcam.Text = Program.selectedProduct.webcam;

                // enable next button
                btn_next.Enabled = true;
            }
            
            else
            {
                timer1.Start();
            }
        }

       
        // Load a txt file
    
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // set filter for and show the open file dialog 
            openFD_productInfo.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            if (openFD_productInfo.ShowDialog() == DialogResult.OK)
            {
                // enable next button
                btn_next.Enabled = true;

                // read the txt file and store product info into an array of strings
                string[] productInfo = File.ReadAllLines(openFD_productInfo.FileName);

                // display loaded product info in text boxes
                txt_productID.Text = productInfo[0];
                txt_condition.Text = productInfo[1];
                txt_cost.Text = productInfo[2];
                txt_platform.Text = productInfo[3];
                txt_OS.Text = productInfo[4];
                txt_manufacturer.Text = productInfo[5];
                txt_model.Text = productInfo[6];
                txt_memory.Text = productInfo[7];
                txt_lcdSize.Text = productInfo[8];
                txt_HDD.Text = productInfo[9];
                txt_cpuBrand.Text = productInfo[10];
                txt_cpuNumber.Text = productInfo[11];
                txt_gpuType.Text = productInfo[12];
                txt_cpuType.Text = productInfo[13];
                txt_cpuSpeed.Text = productInfo[14];
                txt_webcam.Text = productInfo[15];

                short ProductID = (short)Convert.ToInt32(productInfo[0]);

                Program.selectedProduct = (from product in db.products
                                           where product.productID == ProductID
                                           select product).FirstOrDefault();
            }
        }

        // write text file to save

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // create string of content to be saved
            string lines = Program.selectedProduct.productID + "\r\n"
                + Program.selectedProduct.condition + "\r\n"
                + Program.selectedProduct.cost + "\r\n"
                + Program.selectedProduct.platform + "\r\n"
                + Program.selectedProduct.OS + "\r\n"
                + Program.selectedProduct.manufacturer + "\r\n"
                + Program.selectedProduct.model + "\r\n"
                + Program.selectedProduct.HDD_size + "\r\n"
                + Program.selectedProduct.screensize + "\r\n"
                + Program.selectedProduct.HDD_speed + "\r\n"
                + Program.selectedProduct.CPU_brand + "\r\n"
                + Program.selectedProduct.CPU_number + "\r\n"
                + Program.selectedProduct.GPU_Type + "\r\n"
                + Program.selectedProduct.CPU_type + "\r\n"
                + Program.selectedProduct.CPU_speed + "\r\n"
                + Program.selectedProduct.webcam + "\r\n";

            // set the defualt file name
            saveFD_productInfo.FileName = "Product.txt";

            // write the string to a file if the user clicks OK in the save dialogue
            if (saveFD_productInfo.ShowDialog() == DialogResult.OK)
            {
                StreamWriter file = new StreamWriter(File.Create(saveFD_productInfo.FileName));
                file.Write(lines);

                file.Close();
            }
        }

        // application close
      
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        // Go back to the select form
       
        private void btn_selectAnotherProduct_Click(object sender, EventArgs e)
        {
            previousForm.Show();
            this.Close();
        }

        // Open order form
      
        private void btn_next_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrderForm orderForm = new OrderForm();
            orderForm.previousForm = this;
            orderForm.Show();
        }

  
        // Execute the 'Open' menu strip click event when the timer is up
      
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();

            // when timer is up, open the dialog and show the form
            openToolStripMenuItem_Click(null, null);
            this.BringToFront();
        }
    }
}
