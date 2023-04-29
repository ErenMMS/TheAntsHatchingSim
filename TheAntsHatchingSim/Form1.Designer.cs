namespace TheAntsHatchingSim
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            HatchButton = new Button();
            listBox1 = new ListBox();
            label1 = new Label();
            AntName = new Label();
            CounterLbl = new Label();
            AntPictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)AntPictureBox).BeginInit();
            SuspendLayout();
            // 
            // HatchButton
            // 
            HatchButton.BackColor = Color.DarkOrange;
            HatchButton.BackgroundImageLayout = ImageLayout.None;
            HatchButton.FlatStyle = FlatStyle.Flat;
            HatchButton.Font = new Font("Cambria", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            HatchButton.ForeColor = SystemColors.ControlText;
            HatchButton.Location = new Point(455, 464);
            HatchButton.Name = "HatchButton";
            HatchButton.Size = new Size(110, 41);
            HatchButton.TabIndex = 0;
            HatchButton.Text = "Hatch";
            HatchButton.UseVisualStyleBackColor = false;
            HatchButton.Click += HatchButton_Click;
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.BlanchedAlmond;
            listBox1.BorderStyle = BorderStyle.None;
            listBox1.ForeColor = Color.Black;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "Wise Berserker\t\t0.10", "Nimble Tree Ant \t\t0.10", "Predator \t\t\t0.10", "Jet Black \t\t\t0.10", "Shield Warden \t\t0.10", "Leaf Devourer \t\t0.10", "Blood Giant \t\t0.10", "Grave Digger \t\t0.10", "Golden Crystal \t\t0.10", "Crimson Fragger \t\t0.12", "Ruby Slender \t\t0.12", "Dusky Lurker \t\t0.12", "New World General \t\t0.19", "Guard General \t\t0.19", "Acid General \t\t0.19", "Gold Armor \t\t0.28", "Bullet Ant\t\t\t0.25", "Slim Arched \t\t0.28", "Jack Jumper \t\t0.25", "Giant Tooth \t\t0.25", "Driver Ant \t\t0.27", "Golden Sugar \t\t0.27", "Golden Spiny \t\t0.27", "Green Head \t\t0.07", "Strober \t\t\t0.21", "Yellow Spider \t\t0.07", "Red Foot \t\t          \t0.07", "Thorn Ant \t          \t0.04", "Muscleman \t          \t1.86", "Red Spider \t          \t1.86", "Shield Leafcutter \t          \t1.86", "Spiny Leafcutter\t          \t1.86", "Red Head\t\t\t1.86", "Whorl Ponerine                    \t9.30", "Other Purple Special Ants  \t10.02", "Other Blue Special Ants      \t66.96" });
            listBox1.Location = new Point(755, 220);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(221, 285);
            listBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.BackColor = Color.BlanchedAlmond;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(755, 190);
            label1.Name = "label1";
            label1.Size = new Size(221, 30);
            label1.TabIndex = 2;
            label1.Text = "Season Hatch (IR)";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AntName
            // 
            AntName.BackColor = Color.BlanchedAlmond;
            AntName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            AntName.Location = new Point(755, 152);
            AntName.Name = "AntName";
            AntName.Size = new Size(221, 28);
            AntName.TabIndex = 4;
            AntName.Text = "Ant Name";
            AntName.TextAlign = ContentAlignment.MiddleCenter;
            AntName.Visible = false;
            // 
            // CounterLbl
            // 
            CounterLbl.AutoSize = true;
            CounterLbl.BackColor = Color.BlanchedAlmond;
            CounterLbl.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            CounterLbl.Location = new Point(17, 480);
            CounterLbl.Name = "CounterLbl";
            CounterLbl.Size = new Size(22, 25);
            CounterLbl.TabIndex = 5;
            CounterLbl.Text = "0";
            // 
            // AntPictureBox
            // 
            AntPictureBox.BackColor = Color.Transparent;
            AntPictureBox.BackgroundImageLayout = ImageLayout.Zoom;
            AntPictureBox.Location = new Point(362, -53);
            AntPictureBox.Name = "AntPictureBox";
            AntPictureBox.Size = new Size(296, 580);
            AntPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            AntPictureBox.TabIndex = 7;
            AntPictureBox.TabStop = false;
            AntPictureBox.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.the_ants_underground_kingdom;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(992, 521);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Controls.Add(HatchButton);
            Controls.Add(CounterLbl);
            Controls.Add(AntName);
            Controls.Add(AntPictureBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "The Ants Hatching Simulation";
            ((System.ComponentModel.ISupportInitialize)AntPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button HatchButton;
        private ListBox listBox1;
        private Label label1;
        private Label AntName;
        private Label CounterLbl;
        private PictureBox AntPictureBox;
    }
}