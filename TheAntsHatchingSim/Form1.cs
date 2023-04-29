using System;
using System.Drawing.Drawing2D;
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
            AntName.BackColor = Color.Transparent;
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
                    if (AntName.Text == "Wise Berserker" ||
                        AntName.Text == "Nimble Tree Ant" ||
                        AntName.Text == "Predator" ||
                        AntName.Text == "Jet Black" ||
                        AntName.Text == "Shield Warden" ||
                        AntName.Text == "Leaf Devourer" ||
                        AntName.Text == "Blood Giant" ||
                        AntName.Text == "Grave Digger" ||
                        AntName.Text == "Golden Crystal" ||
                        AntName.Text == "Crimson Fragger" ||
                        AntName.Text == "Ruby Slender" ||
                        AntName.Text == "Dusky Lurker")
                    {
                        AntName.BackColor = ColorTranslator.FromHtml("#fc8c21");
                        MessageBox.Show(AntName.Text);
                    }
                    break;
                }
            }
        }
    }
}