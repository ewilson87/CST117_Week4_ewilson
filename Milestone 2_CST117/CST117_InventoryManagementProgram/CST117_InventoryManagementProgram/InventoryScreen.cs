using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CST117_InventoryManagementProgram
{
    public partial class InventoryScreen : Form
    {
        public InventoryScreen()
        {
            InitializeComponent();

            //HomeScreen homeScreen = (HomeScreen)this.Owner;

            //Inventory inventory = new Inventory();

            List<InventoryItem> inventoryList = Program.inventoryList;
            //List<InventoryItem> inventoryList = inventory.ReadInventoryFile();     

            int row = 0;

            foreach (InventoryItem inventoryItem in inventoryList)
            {
                inventoryDataGrid.Rows.Insert(row);
                inventoryDataGrid[0, row].Value = inventoryItem.Name;
                inventoryDataGrid[1, row].Value = inventoryItem.Model;
                inventoryDataGrid[2, row].Value = inventoryItem.Type;
                inventoryDataGrid[3, row].Value = inventoryItem.Quantity;
                inventoryDataGrid[4, row].Value = inventoryItem.Msrp;
                inventoryDataGrid[5, row].Value = inventoryItem.SalePrice;

                row++;
            }

            //maybe needed in future?
            //row = 0;
        }

        private void inventoryTable_Paint(object sender, PaintEventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            HomeScreen homeScreen = new HomeScreen();

            this.Hide();
            homeScreen.Show();

        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            IndividualProductScreen individualProductScreen = new IndividualProductScreen();

            this.Hide();
            individualProductScreen.Show();
        }

        private void inventoryDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
