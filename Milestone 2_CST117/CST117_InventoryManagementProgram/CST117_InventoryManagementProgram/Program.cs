using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST117_InventoryManagementProgram
{
    static class Program
    {
        public static List<InventoryItem> inventoryList = new List<InventoryItem>();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {

            Inventory inventory = new Inventory();
            inventoryList = inventory.ReadInventoryFile();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginScreen());         
        }
    }
}
