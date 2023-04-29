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
            SuspendLayout();
            // 
            // HatchButton
            // 
            HatchButton.BackColor = SystemColors.ActiveCaptionText;
            HatchButton.BackgroundImage = Properties.Resources.png_transparent_button_gold_buttons_miscellaneous_rectangle_gold1;
            HatchButton.BackgroundImageLayout = ImageLayout.Stretch;
            HatchButton.FlatStyle = FlatStyle.Flat;
            HatchButton.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            HatchButton.Location = new Point(293, 270);
            HatchButton.Name = "HatchButton";
            HatchButton.Size = new Size(115, 47);
            HatchButton.TabIndex = 0;
            HatchButton.Text = "Hatch";
            HatchButton.UseVisualStyleBackColor = false;
            HatchButton.Click += HatchButton_Click;
            // 
            // listBox1
            // 
            listBox1.BackColor = SystemColors.Info;
            listBox1.ForeColor = Color.Black;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "Wise Berserker\t\t0.10", "Nimble Tree Ant \t\t0.10", "Predator \t\t\t0.10", "Jet Black \t\t\t0.10", "Shield Warden \t\t0.10", "Leaf Devourer \t\t0.10", "Blood Giant \t\t0.10", "Grave Digger \t\t0.10", "Golden Crystal \t\t0.10", "Crimson Fragger \t\t0.12", "Ruby Slender \t\t0.12", "Dusky Lurker \t\t0.12", "New World General \t\t0.19", "Guard General \t\t0.19", "Acid General \t\t0.19", "Gold Armor \t\t0.28", "Bullet Ant\t\t\t0.25", "Slim Arched \t\t0.28", "Jack Jumper \t\t0.25", "Giant Tooth \t\t0.25", "Driver Ant \t\t0.27", "Golden Sugar \t\t0.27", "Golden Spiny \t\t0.27", "Green Head \t\t0.07", "Strober \t\t\t0.21", "Yellow Spider \t\t0.07", "Red Foot \t\t          \t0.07", "Thorn Ant \t          \t0.04", "Muscleman \t          \t1.86", "Red Spider \t          \t1.86", "Shield Leafcutter \t          \t1.86", "Spiny Leafcutter\t          \t1.86", "Red Head\t\t\t1.86", "Whorl Ponerine                    \t9.30", "Other Purple Special Ants  \t10.02", "Other Blue Special Ants      \t66.96" });
            listBox1.Location = new Point(12, 68);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(221, 289);
            listBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 44);
            label1.Name = "label1";
            label1.Size = new Size(138, 21);
            label1.TabIndex = 2;
            label1.Text = "Season Hatch (IR)";
            // 
            // AntName
            // 
            AntName.AutoSize = true;
            AntName.BackColor = Color.Transparent;
            AntName.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            AntName.Location = new Point(293, 134);
            AntName.Name = "AntName";
            AntName.Size = new Size(148, 40);
            AntName.TabIndex = 4;
            AntName.Text = "AntName";
            AntName.Visible = false;
            // 
            // CounterLbl
            // 
            CounterLbl.AutoSize = true;
            CounterLbl.BackColor = Color.Gold;
            CounterLbl.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            CounterLbl.Location = new Point(626, 347);
            CounterLbl.Name = "CounterLbl";
            CounterLbl.Size = new Size(22, 25);
            CounterLbl.TabIndex = 5;
            CounterLbl.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.thea;
            ClientSize = new Size(680, 381);
            Controls.Add(CounterLbl);
            Controls.Add(AntName);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Controls.Add(HatchButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button HatchButton;
        private ListBox listBox1;
        private Label label1;
        private Label AntName;
        private Label CounterLbl;
    }
}