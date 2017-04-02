using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*Name:-Gowtham Talluri
 StudentID :- 200335297
 App:-Dollar Computer
 Description:- Online computer sale cart
 */

namespace Assignment4
{
    public partial class StartForm : Form
    { // CONSTRUCTOR
        public StartForm()
        {
            InitializeComponent();
        }

     
        // Go to the select form
     
        private void btn_newOrder_Click(object sender, EventArgs e)
        {
            this.Hide();
            SelectForm selectForm = new SelectForm();
            selectForm.Show();
        }

       
        // Go to the product info form
  
        private void btn_loadOrder_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProductInfoForm productInfoForm = new ProductInfoForm();
            productInfoForm.previousForm = this;
            productInfoForm.Show();
        }
        
        // Close application
      
        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
