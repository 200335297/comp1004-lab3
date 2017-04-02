using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Assignment4.Modules;

namespace Assignment4

{
    static class Program
    {
        // create product object to store data
        public static product orderedProduct;
        // variable to check if user want to open saved file
        public static bool openFromFile = false;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // create product object on application start
            orderedProduct = new product();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SplashForm());
        }
    }
}
