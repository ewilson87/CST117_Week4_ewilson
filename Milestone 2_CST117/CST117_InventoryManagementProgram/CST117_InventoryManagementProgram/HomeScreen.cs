using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST117_InventoryManagementProgram
{
    public partial class HomeScreen : Form
    {
        InventoryScreen inventoryScreen = new InventoryScreen();
        SearchScreen searchScreen = new SearchScreen();
        NewItemScreen newItemScreen = new NewItemScreen();
        ReOrderScreen reOrderScreen = new ReOrderScreen();

        public HomeScreen()
        {
            InitializeComponent();           
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            this.Hide();
            inventoryScreen.Show(this);
        }

        private void companyLabel_Click(object sender, EventArgs e)
        {

        }

        private void HomeScreen_Load(object sender, EventArgs e)
        {

        }

        private void searchInventoryButton_Click(object sender, EventArgs e)
        {
            

            this.Hide();
            searchScreen.Show(this);
        }

        private void addNewItemButton_Click(object sender, EventArgs e)
        {
            

            this.Hide();
            newItemScreen.Show(this);
        }

        private void reOrderInventoryButton_Click(object sender, EventArgs e)
        {
            

            this.Hide();
            reOrderScreen.Show(this);
        }
    }
}
