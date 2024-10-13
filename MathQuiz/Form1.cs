using System;
using System.Windows.Forms;

namespace MathQuiz
{
    public partial class Levels : Form
    {
        Quests form = new Quests();

        public Levels()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            Button[] buttons = { button2, button3, button4, button5 };
            Label[] labels = { level1Star, level2Star, level3Star, level4Star, level5Star };
            string[] args = Environment.GetCommandLineArgs();
            if (args.Length > 1)
            {
                if (args[1] == "open")
                {
                    string levelHack = args[2].Trim();
                    unclockLevel(buttons, levelHack);

                }
            }
            
            string filePathQuests = "scores.txt";
            string readFiles = File.ReadAllText(filePathQuests).ToString();

            foreach (var item in readFiles.Split(';'))
            {
                if (item != "\r\n" && item != "")
                {
                    var parts = item.Split(',');
                    labels[Convert.ToInt32(parts[0])].Text = new string('*',Convert.ToInt32(parts[1]));
                    if (Convert.ToInt32(parts[0]) != 4)
                    {
                        buttons[Convert.ToInt32(parts[0])].Enabled = true;
                    }
                }
            }

        }

        private void unclockLevel(Button[] Buttons,string levelHack)
        {
            switch (levelHack)
            {
                case "all":
                    foreach (var item in Buttons)
                    {
                        item.Enabled = true;
                    }
                    break;
                case "2":
                case "3":
                case "4":
                case "5":
                    Buttons[(Convert.ToInt32(levelHack) - 2)].Enabled = true;
                    break;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            form.levelCounter = 0;
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form.levelCounter = 1;
            form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            form.levelCounter = 2;
            form.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            form.levelCounter = 3;
            form.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            form.levelCounter = 4;
            form.ShowDialog();
        }
    }
}
