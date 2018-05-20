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
    public partial class LoginScreen : Form
    {
        

        public LoginScreen()
        {
            InitializeComponent();

        }

        private void logonButton_Click(object sender, EventArgs e)
        {
            HomeScreen homeScreenForm = new HomeScreen();

            this.Hide();
            homeScreenForm.Show();
        }

        private void LoginScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
