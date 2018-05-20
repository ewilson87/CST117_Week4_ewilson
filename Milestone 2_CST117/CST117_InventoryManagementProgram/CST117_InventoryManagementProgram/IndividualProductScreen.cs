using System;
using System.Windows.Forms;

namespace CST117_InventoryManagementProgram
{
    public partial class IndividualProductScreen : Form
    {
        public IndividualProductScreen()
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

            this.Hide();
            homeScreen.Show();
        }

        private void IndividualProductScreen_Load(object sender, EventArgs e)
        {

        }

        private void nameLabel_Click(object sender, EventArgs e)
        {

        }

        private void priceLabel_Click(object sender, EventArgs e)
        {

        }

        private void priceTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void quantityLabel_Click(object sender, EventArgs e)
        {

        }

        private void quantityTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void descriptionTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void typeLabel_Click(object sender, EventArgs e)
        {

        }

        private void typeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void descriptionLabel_Click(object sender, EventArgs e)
        {

        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void editButton_Click(object sender, EventArgs e)
        {
            nameTextBox.ReadOnly = false;
            priceTextBox.ReadOnly = false;
            quantityTextBox.ReadOnly = false;
            typeTextBox.ReadOnly = false;
            msrpTextBox.ReadOnly = false;
            modelTextBox.ReadOnly = false;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            nameTextBox.ReadOnly = true;
            priceTextBox.ReadOnly = true;
            quantityTextBox.ReadOnly = true;
            typeTextBox.ReadOnly = true;
            msrpTextBox.ReadOnly = true;
            modelTextBox.ReadOnly = true;
        }
    }
}
