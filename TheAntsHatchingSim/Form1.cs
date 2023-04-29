using System;
using System.Drawing.Drawing2D;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace TheAntsHatchingSim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int counter = 0;
        private void HatchButton_Click(object sender, EventArgs e)
        {
            counter++;
            CounterLbl.Text = counter.ToString();
            AntPictureBox.Visible = false;
            AntName.BackColor = Color.BlanchedAlmond;
            string[] antNames = new string[]
            {
                "Wise Berserker",
                "Nimble Tree Ant",
                "Predator",
                "Jet Black",
                "Shield Warden",
                "Leaf Devourer",
                "Blood Giant",
                "Grave Digger",
                "Golden Crystal",
                "Crimson Fragger",
                "Ruby Slender",
                "Dusky Lurker",
                "New World General",
                "Guard General",
                "Acid General",
                "Gold Armor",
                "Bullet Ant",
                "Slim Arched",
                "Jack Jumper",
                "Giant Tooth",
                "Driver Ant",
                "Golden Sugar",
                "Golden Spiny",
                "Green Head",
                "Strober",
                "Yellow Spider",
                "Red Foot",
                "Thorn Ant",
                "Muscleman",
                "Red Spider",
                "Shield Leafcutter",
                "Spiny Leafcutter",
                "Red Head",
                "Whorl Ponerine",
                "Other Purple Special Ants",
                "Other Blue Special Ants"
            };
            double[] probabilities = new double[]
            {
                0.10, 0.10, 0.10, 0.10, 0.10, 0.10, 0.10, 0.10, 0.10,
                0.12, 0.12, 0.12,
                0.19, 0.19, 0.19,
                0.28, 0.25, 0.28, 0.25, 0.25, 0.27, 0.27, 0.27,
                0.07, 0.21, 0.07, 0.07, 0.04,
                1.86, 1.86, 1.86, 1.86, 1.86,
                9.30, 10.02,
                66.96
            };

            double totalProbability = probabilities.Sum();
            Random random = new Random();
            double randomNum = random.NextDouble() * totalProbability;

            double cumulativeProbability = 0.0;
            for (int i = 0; i < probabilities.Length; i++)
            {
                cumulativeProbability += probabilities[i];
                if (randomNum <= cumulativeProbability)
                {
                    AntName.Visible = true;
                    AntName.Text = antNames[i];
                    string textToFind = AntName.Text;
                    int index = listBox1.FindString(textToFind);
                    listBox1.SetSelected(index, true);
                    switch (AntName.Text)
                    {
                        case "Wise Berserker":
                            AntPictureBox.Visible = true;
                            AntPictureBox.Image = Properties.Resources.WB;
                            AntName.BackColor = ColorTranslator.FromHtml("#fc8c21");
                            MessageBox.Show(AntName.Text);
                            break;
                        case "Nimble Tree Ant":
                            AntPictureBox.Visible = true;
                            AntPictureBox.Image = Properties.Resources.NTA;
                            AntName.BackColor = ColorTranslator.FromHtml("#fc8c21");
                            MessageBox.Show(AntName.Text);
                            break;
                        case "Predator":
                            AntPictureBox.Visible = true;
                            AntPictureBox.Image = Properties.Resources.P;
                            AntName.BackColor = ColorTranslator.FromHtml("#fc8c21");
                            MessageBox.Show(AntName.Text);
                            break;
                        case "Jet Black":
                            AntPictureBox.Visible = true;
                            AntPictureBox.Image = Properties.Resources.JB;
                            AntName.BackColor = ColorTranslator.FromHtml("#fc8c21");
                            MessageBox.Show(AntName.Text);
                            break;
                        case "Shield Warden":
                            AntPictureBox.Visible = true;
                            AntPictureBox.Image = Properties.Resources.SW;
                            AntName.BackColor = ColorTranslator.FromHtml("#fc8c21");
                            MessageBox.Show(AntName.Text);
                            break;
                        case "Leaf Devourer":
                            AntPictureBox.Visible = true;
                            AntPictureBox.Image = Properties.Resources.LD;
                            AntName.BackColor = ColorTranslator.FromHtml("#fc8c21");
                            MessageBox.Show(AntName.Text);
                            break;
                        case "Blood Giant":
                            AntPictureBox.Visible = true;
                            AntPictureBox.Image = Properties.Resources.BG;
                            AntName.BackColor = ColorTranslator.FromHtml("#fc8c21");
                            MessageBox.Show(AntName.Text);
                            break;
                        case "Grave Digger":
                            AntPictureBox.Visible = true;
                            AntPictureBox.Image = Properties.Resources.GD;
                            AntName.BackColor = ColorTranslator.FromHtml("#fc8c21");
                            MessageBox.Show(AntName.Text);
                            break;
                        case "Golden Crystal":
                            AntPictureBox.Visible = true;
                            AntPictureBox.Image = Properties.Resources.GC;
                            AntName.BackColor = ColorTranslator.FromHtml("#fc8c21");
                            MessageBox.Show(AntName.Text);
                            break;
                        case "Crimson Fragger":
                            AntPictureBox.Visible = true;
                            AntPictureBox.Image = Properties.Resources.CF;
                            AntName.BackColor = ColorTranslator.FromHtml("#fc8c21");
                            MessageBox.Show(AntName.Text);
                            break;
                        case "Ruby Slender":
                            AntPictureBox.Visible = true;
                            AntPictureBox.Image = Properties.Resources.RS;
                            AntName.BackColor = ColorTranslator.FromHtml("#fc8c21");
                            MessageBox.Show(AntName.Text);
                            break;
                        case "Dusky Lurker":
                            AntPictureBox.Visible = true;
                            AntPictureBox.Image = Properties.Resources.DL;
                            AntName.BackColor = ColorTranslator.FromHtml("#fc8c21");
                            MessageBox.Show(AntName.Text);
                            break;
                    }
                    break;
                }
            }
        }
    }
}