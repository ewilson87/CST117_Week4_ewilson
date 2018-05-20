/**
 * Program: Dice Roller for Snake Eyes
 * File: RollSnakeEyes.cs
 * Summary: User selects how many sided dice, then randomly rolls until snake eyes (double 1) is rolled
 * Author: Evan Wilson
 * Date: May 20th, 2018
 **/

using System;
using System.Windows.Forms;

namespace RollSnakeEyes
{
    public partial class RollSnakeEyes : Form
    {
        private int sides = 6;
        private int rollsCount;
        Random random = new Random();

        public RollSnakeEyes()
        {
            InitializeComponent();
        }

        private void bunifuSlider1_ValueChanged(object sender, EventArgs e)
        {
            sidesLabel.Text = (sidesSlider.Value + 4).ToString();
            sides = sidesSlider.Value + 4;
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            //clears data grid
            rollsDataGrid.Rows.Clear();


            //instantiates 2 Dice objects
            Dice dice1 = new Dice();
            Dice dice2 = new Dice();

            int dice1Value = 0;
            int dice2Value = 0;

            //loop until both dice randomly roll snake eyes
            while (true)
            {
                //increases rolls count
                rollsCount++;

                dice1Value = dice1.RollDice(sides, random.Next());
                dice2Value = dice2.RollDice(sides, random.Next());

                rollsDataGrid.Rows.Insert(rollsCount - 1);
                rollsDataGrid[0, rollsCount - 1].Value = rollsCount;
                rollsDataGrid[1, rollsCount - 1].Value = dice1Value;
                rollsDataGrid[2, rollsCount - 1].Value = dice2Value;

                if (dice1Value == 1 && dice2Value == 1)
                {
                    //rollsDataGrid.Rows[0].Selected = true;
                    rollsDataGrid.CurrentCell = rollsDataGrid.Rows[rollsCount - 1].Cells[0];
                    break;
                }


            }

            numberOfRollsTextBox.TextAlign = HorizontalAlignment.Center;
            numberOfRollsTextBox.Text = "It took " + rollsCount + " rolls to get snake eyes using " + sides + " sided dice!";

            //resets rolls count
            rollsCount = 0;

        }
    }
}
