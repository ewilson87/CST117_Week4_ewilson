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
    public partial class NewItemScreen : Form
    {
        public NewItemScreen()
        {
            InitializeComponent();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            HomeScreen homeScreen = new HomeScreen();

            this.Hide();
            homeScreen.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void descriptionLabel_Click(object sender, EventArgs e)
        {

        }

        private void productPictureBox_Click(object sender, EventArgs e)
        {
            
        }

        private void priceLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
