using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace MathQuiz
{
    public partial class Quests : Form
    {
        Panel panel;
        int counter = 60;
        public int levelCounter = 0;
        int questCounter = 0;
        int top = 0;
        int checkButtonCounter = 1;
        int point = 0;

        string[] studentAnswer = new string[20]; 
        List<int> nonQuestAnswer = new List<int>();
        List<string> questions = new List<string>();
        List<List<string>> answers = new List<List<string>>();
        List<string> trueAnswers = new List<string>();

        int row = 5;
        int nonCounter = 0;

        public Quests()
        {
            InitializeComponent();
        }

        private void Quests_Load(object sender, EventArgs e)
        {

            string filePathQuests = "levels.txt";
            string readFiles = File.ReadAllText(filePathQuests).ToString();
            var readParts = readFiles.Split(":");
            foreach (var item in readParts[levelCounter].Split(';'))
            {
                var parts = item.Split('?');
                questions.Add(parts[0]);

                var answer = parts[1].Split(".");
                answers.Add(new List<string>(answer[0].Split(",")));
                trueAnswers.Add(answer[1]);

            }

            getQuest();
            calculateTime();
           System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
           timer.Interval = 1000;
           timer.Tick += timer1_Tick;
           timer.Start();
        }

        private void calculateTime()
        {
            counter = counter * (levelCounter + 1);
            label1.Text = counter.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkButtonCounter < 4)
            {
                getQuest();
                checkButtonCounter++;
            }
            else
            {
                if (nonQuestAnswer.Count() == 0)
                {
                    calculatePoint();
                }
                else
                {
                    getPassQuest();
                }
            }
        }

        private void calculatePoint()
        {
            panel10.Controls.Clear();
            for (int i = 0; i < 20; i++)
            { 
                if (studentAnswer[i] != null)
                {
                    if (studentAnswer[i].Trim() == trueAnswers[i].Trim())
                    {
                        point++;
                    }
                }
            }

            if (point >= 11)
            {
                calculateStar();
            }

            Application.Exit();
            Process.Start(Application.ExecutablePath);
            Environment.Exit(0);
        }

        private void calculateStar()
        {
            string filePath = "scores.txt";
            int score;
            Boolean controller = false;
            if (point >= 11 && point <= 15)
            {
                score = 1;
            }else if (point >= 16 && point <= 18)
            {
                score = 2;
            }
            else
            {
                score = 3;
            }

            string readFiles = File.ReadAllText(filePath).ToString();
            string newFile = ""; 
            foreach (var item in readFiles.Split(';'))
            {
                if (item != "\r\n" && item != "")
                {
                    var parts = item.Split(',');
                    if (Convert.ToInt32(parts[0]) == levelCounter && Convert.ToInt16(parts[1]) < score)
                    {
                        newFile += levelCounter + "," + score + ";";
                        controller = true;
                    }
                    else
                    {
                        newFile += item + ";";
                    }
                }
                else if (controller == false)
                {
                    newFile += levelCounter + "," + score + ";";
                }
            }
            File.WriteAllText(filePath, newFile);
        }

        private void getPassQuest()
        {
            panel10.Controls.Clear();
            top = 0;
            nonCounter = 0;
            if (nonQuestAnswer.Count < 5)
            {
                row = nonQuestAnswer.Count();
            }
            for (int i = 0; i < row; i++)
            {
                panel = new Panel();
                panel.Name = "panel" + i;
                panel.Location = new System.Drawing.Point(100, top);
                panel.Width = 400;

                Label label = new Label();
                label.Name = questCounter.ToString();
                label.Text = questions[nonQuestAnswer[i]].ToString();
                label.Font = new Font("Fransızca Yazısı MT", 25);
                label.ForeColor = Color.Black;
                label.Location = new System.Drawing.Point(25, 0);
                label.AutoSize = true;

                panel10.Controls.Add(panel);
                panel.Controls.Add(label);
                getPassAnswer(panel);
                questCounter++;
                top += 125;
            }

            for (int z = 0; z < row; z++)
            {
                nonQuestAnswer.Remove(nonQuestAnswer[0]);
            }
        }

        private void getQuest()
        {
            panel10.Controls.Clear();
            top = 0;
            for (int i = 0; i < row; i++)
            {
                panel = new Panel();
                panel.Name = "panel" + i;
                panel.Location = new System.Drawing.Point(100, top);
                panel.Width = 400;

                Label label = new Label();
                label.Name = questCounter.ToString();
                label.Text = questions[questCounter].ToString().Trim();
                label.Font = new Font("Fransızca Yazısı MT", 25);
                label.ForeColor = Color.Black;
                label.Location = new System.Drawing.Point(25, 0);
                label.AutoSize = true;

                panel10.Controls.Add(panel);
                panel.Controls.Add(label);
                nonQuestAnswer.Add(questCounter);
                Shuffle(answers[questCounter]);
                getAnswer(panel);
                questCounter++;
                top += 125;
            }
        }

        void Shuffle(List<String> list)
        {
            int n = list.Count;
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                int r = i + random.Next(n - i);
                string t = list[r];
                list[r] = list[i];
                list[i] = t;
            }
        }
        private void getPassAnswer(Panel panel)
        {
            int left = 0;
            for (int i = 0; i < 4; i++)
            {
                RadioButton radioButton = new RadioButton();
                radioButton.Name = "button" + i + "q" + nonQuestAnswer[nonCounter];
                radioButton.Text = answers[nonQuestAnswer[nonCounter]][i];
                radioButton.Location = new System.Drawing.Point(left, 50);
                radioButton.Height = 50;
                radioButton.Width = 75;
                radioButton.Click += checkAnswer;
                panel.Controls.Add(radioButton);
                left += 100;
            }
            nonCounter++;
        }
        private void getAnswer(Panel panel)
        {
            int left = 0;
            for (int i = 0; i < 4; i++)
            {
                RadioButton radioButton = new RadioButton();
                radioButton.Name = "button" + i + "q" +questCounter;
                radioButton.Text = answers[questCounter][i];
                radioButton.Location = new System.Drawing.Point(left, 50);
                radioButton.Height = 50;
                radioButton.Width = 75;
                radioButton.Click += checkAnswer;


                panel.Controls.Add(radioButton);
                left += 100;
            }
        }

        private void checkAnswer(object? sender, EventArgs e)
        {

            RadioButton radioButton = (RadioButton)sender;
            string[] strings = radioButton.Name.Split("q");
            int questC = Convert.ToInt32(strings[1]);
            studentAnswer[questC] = radioButton.Text;
            nonQuestAnswer.Remove(questC);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = counter.ToString();
            counter--;
            if (counter == 0)
            {
                Application.Exit();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
