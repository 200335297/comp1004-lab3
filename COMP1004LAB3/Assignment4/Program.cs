using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Assignment4.Modules;

/*Name:-Gowtham Talluri
 StudentID :- 200335297
 App:-Dollar Computer
 Description:- Online computer sale cart*/

namespace Assignment4

{
    static class Program
    {
        //product object declared to capture selected product info
        public static product selectedProduct;
       
        [STAThread]
        static void Main()
        {
           
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SplashForm());
        }
    }
}
