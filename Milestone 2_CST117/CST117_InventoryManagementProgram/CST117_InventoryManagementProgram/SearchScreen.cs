using System;
using System.Windows.Forms;

namespace CST117_InventoryManagementProgram
{
    public partial class SearchScreen : Form
    {
        public SearchScreen()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            HomeScreen homeScreen = new HomeScreen();

            this.Close();
            homeScreen.Show();
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            IndividualProductScreen individualProductScreen = new IndividualProductScreen();

            this.Hide();
            individualProductScreen.Show();
        }

        private void quantityRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
