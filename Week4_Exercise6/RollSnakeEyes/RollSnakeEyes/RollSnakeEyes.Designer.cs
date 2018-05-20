namespace RollSnakeEyes
{
    partial class RollSnakeEyes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RollSnakeEyes));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.sidesGroupBox = new System.Windows.Forms.GroupBox();
            this.sidesLabel = new System.Windows.Forms.Label();
            this.sidesSlider = new Bunifu.Framework.UI.BunifuSlider();
            this.numberOfRollsTextBox = new System.Windows.Forms.TextBox();
            this.rollsDataGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Roll = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dice1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dice2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rollButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuGradientPanel1.SuspendLayout();
            this.sidesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rollsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.rollButton);
            this.bunifuGradientPanel1.Controls.Add(this.rollsDataGrid);
            this.bunifuGradientPanel1.Controls.Add(this.numberOfRollsTextBox);
            this.bunifuGradientPanel1.Controls.Add(this.sidesGroupBox);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Salmon;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(542, 407);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // sidesGroupBox
            // 
            this.sidesGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.sidesGroupBox.Controls.Add(this.sidesLabel);
            this.sidesGroupBox.Controls.Add(this.sidesSlider);
            this.sidesGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sidesGroupBox.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.sidesGroupBox.Location = new System.Drawing.Point(28, 30);
            this.sidesGroupBox.Name = "sidesGroupBox";
            this.sidesGroupBox.Size = new System.Drawing.Size(214, 81);
            this.sidesGroupBox.TabIndex = 1;
            this.sidesGroupBox.TabStop = false;
            this.sidesGroupBox.Text = "NUMBER OF SIDES";
            // 
            // sidesLabel
            // 
            this.sidesLabel.AutoSize = true;
            this.sidesLabel.Font = new System.Drawing.Font("Cooper Black", 16F);
            this.sidesLabel.Location = new System.Drawing.Point(95, 52);
            this.sidesLabel.Name = "sidesLabel";
            this.sidesLabel.Size = new System.Drawing.Size(25, 25);
            this.sidesLabel.TabIndex = 1;
            this.sidesLabel.Text = "6";
            // 
            // sidesSlider
            // 
            this.sidesSlider.BackColor = System.Drawing.Color.Transparent;
            this.sidesSlider.BackgroudColor = System.Drawing.Color.DarkGray;
            this.sidesSlider.BorderRadius = 0;
            this.sidesSlider.IndicatorColor = System.Drawing.Color.SeaGreen;
            this.sidesSlider.Location = new System.Drawing.Point(0, 19);
            this.sidesSlider.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.sidesSlider.MaximumValue = 16;
            this.sidesSlider.Name = "sidesSlider";
            this.sidesSlider.Size = new System.Drawing.Size(214, 30);
            this.sidesSlider.TabIndex = 0;
            this.sidesSlider.Value = 2;
            this.sidesSlider.ValueChanged += new System.EventHandler(this.bunifuSlider1_ValueChanged);
            // 
            // numberOfRollsTextBox
            // 
            this.numberOfRollsTextBox.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfRollsTextBox.Location = new System.Drawing.Point(28, 351);
            this.numberOfRollsTextBox.Name = "numberOfRollsTextBox";
            this.numberOfRollsTextBox.Size = new System.Drawing.Size(487, 26);
            this.numberOfRollsTextBox.TabIndex = 3;
            // 
            // rollsDataGrid
            // 
            this.rollsDataGrid.AllowUserToAddRows = false;
            this.rollsDataGrid.AllowUserToDeleteRows = false;
            this.rollsDataGrid.AllowUserToResizeColumns = false;
            this.rollsDataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rollsDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.rollsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.rollsDataGrid.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.rollsDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rollsDataGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.rollsDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.rollsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rollsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Roll,
            this.Dice1,
            this.Dice2});
            this.rollsDataGrid.DoubleBuffered = true;
            this.rollsDataGrid.EnableHeadersVisualStyles = false;
            this.rollsDataGrid.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.rollsDataGrid.HeaderForeColor = System.Drawing.Color.White;
            this.rollsDataGrid.Location = new System.Drawing.Point(28, 134);
            this.rollsDataGrid.MultiSelect = false;
            this.rollsDataGrid.Name = "rollsDataGrid";
            this.rollsDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.rollsDataGrid.RowHeadersVisible = false;
            this.rollsDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.rollsDataGrid.Size = new System.Drawing.Size(487, 194);
            this.rollsDataGrid.TabIndex = 4;
            this.rollsDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bunifuCustomDataGrid1_CellContentClick);
            // 
            // Roll
            // 
            this.Roll.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Roll.DefaultCellStyle = dataGridViewCellStyle3;
            this.Roll.DividerWidth = 1;
            this.Roll.HeaderText = "Roll #";
            this.Roll.MinimumWidth = 145;
            this.Roll.Name = "Roll";
            this.Roll.ReadOnly = true;
            this.Roll.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Roll.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Dice1
            // 
            this.Dice1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dice1.DefaultCellStyle = dataGridViewCellStyle4;
            this.Dice1.DividerWidth = 1;
            this.Dice1.HeaderText = "Dice 1 Rolled";
            this.Dice1.MinimumWidth = 145;
            this.Dice1.Name = "Dice1";
            this.Dice1.ReadOnly = true;
            this.Dice1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Dice1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Dice2
            // 
            this.Dice2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dice2.DefaultCellStyle = dataGridViewCellStyle5;
            this.Dice2.DividerWidth = 1;
            this.Dice2.HeaderText = "Dice 2 Rolled";
            this.Dice2.MinimumWidth = 145;
            this.Dice2.Name = "Dice2";
            this.Dice2.ReadOnly = true;
            this.Dice2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Dice2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // rollButton
            // 
            this.rollButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.rollButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.rollButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rollButton.BorderRadius = 0;
            this.rollButton.ButtonText = "ROLL";
            this.rollButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rollButton.DisabledColor = System.Drawing.Color.Gray;
            this.rollButton.Iconcolor = System.Drawing.Color.Transparent;
            this.rollButton.Iconimage = global::RollSnakeEyes.Properties.Resources.dice;
            this.rollButton.Iconimage_right = global::RollSnakeEyes.Properties.Resources.dice;
            this.rollButton.Iconimage_right_Selected = null;
            this.rollButton.Iconimage_Selected = null;
            this.rollButton.IconMarginLeft = 0;
            this.rollButton.IconMarginRight = 0;
            this.rollButton.IconRightVisible = true;
            this.rollButton.IconRightZoom = 0D;
            this.rollButton.IconVisible = true;
            this.rollButton.IconZoom = 90D;
            this.rollButton.IsTab = false;
            this.rollButton.Location = new System.Drawing.Point(296, 30);
            this.rollButton.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.rollButton.Name = "rollButton";
            this.rollButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.rollButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.rollButton.OnHoverTextColor = System.Drawing.Color.White;
            this.rollButton.selected = false;
            this.rollButton.Size = new System.Drawing.Size(219, 81);
            this.rollButton.TabIndex = 5;
            this.rollButton.Text = "ROLL";
            this.rollButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rollButton.Textcolor = System.Drawing.Color.White;
            this.rollButton.TextFont = new System.Drawing.Font("Cooper Black", 20F);
            this.rollButton.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // RollSnakeEyes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 407);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Name = "RollSnakeEyes";
            this.Text = "Roll Snake Eyes";
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.sidesGroupBox.ResumeLayout(false);
            this.sidesGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rollsDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.GroupBox sidesGroupBox;
        private Bunifu.Framework.UI.BunifuSlider sidesSlider;
        private System.Windows.Forms.Label sidesLabel;
        private System.Windows.Forms.TextBox numberOfRollsTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Roll;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dice1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dice2;
        private Bunifu.Framework.UI.BunifuCustomDataGrid rollsDataGrid;
        private Bunifu.Framework.UI.BunifuFlatButton rollButton;
    }
}

