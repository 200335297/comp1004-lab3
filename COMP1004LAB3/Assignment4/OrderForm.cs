using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4
{
    public partial class OrderForm : Form
    {
        public ProductInfoForm previousForm;

        // CONSTRUCTOR
        public OrderForm()
        {
            InitializeComponent();
        }

        //--------------------------------------------------------------------------------------------------------
        // Show a message box displaying some info
        //--------------------------------------------------------------------------------------------------------
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gowtham Talluri \nDollarComputers \nwww.computerinfo.com \nSupport: (705)500-1868", "Dollar Computers", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //--------------------------------------------------------------------------------------------------------
        // Show a message box notifying user that their order is being printed
        //--------------------------------------------------------------------------------------------------------
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your order is being printed", "Dollar Computers", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //--------------------------------------------------------------------------------------------------------
        // Close the app
        //--------------------------------------------------------------------------------------------------------
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //--------------------------------------------------------------------------------------------------------
        // Show message box to confirm order and close the app when the user clicks OK
        //--------------------------------------------------------------------------------------------------------
        private void btn_finish_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Thank you for your business! \n\nYour order will be processed within 7-10 business days.", "Dollar Computers", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        //--------------------------------------------------------------------------------------------------------
        // Populate text boxes, and do cost calculations
        //--------------------------------------------------------------------------------------------------------
        private void OrderForm_Load(object sender, EventArgs e)
        {
            txt_condition.Text = Program.selectedProduct.condition;
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

            // calculate costs
            txt_cost.Text = String.Format("{0:C}", Program.selectedProduct.cost);
            decimal tax = Convert.ToDecimal(0.13);
            txt_tax.Text = String.Format("{0:C}", (Program.selectedProduct.cost * tax));
            txt_total.Text = String.Format("{0:C}", (Program.selectedProduct.cost + Program.selectedProduct.cost * tax));
        }

        //--------------------------------------------------------------------------------------------------------
        // Go back to the product info form
        //--------------------------------------------------------------------------------------------------------
        private void btn_back_Click(object sender, EventArgs e)
        {
            previousForm.Show();
            this.Close();
        }
    }
}
