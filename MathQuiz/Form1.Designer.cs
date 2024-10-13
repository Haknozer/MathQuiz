namespace MathQuiz
{
    partial class Levels
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Levels));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            level1Star = new Label();
            level2Star = new Label();
            level3Star = new Label();
            level4Star = new Label();
            level5Star = new Label();
            button5 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.DodgerBlue;
            resources.ApplyResources(button1, "button1");
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DodgerBlue;
            resources.ApplyResources(button2, "button2");
            button2.Name = "button2";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.DodgerBlue;
            resources.ApplyResources(button3, "button3");
            button3.Name = "button3";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.DodgerBlue;
            resources.ApplyResources(button4, "button4");
            button4.Name = "button4";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // level1Star
            // 
            resources.ApplyResources(level1Star, "level1Star");
            level1Star.ForeColor = Color.Yellow;
            level1Star.Name = "level1Star";
            level1Star.Click += label1_Click;
            // 
            // level2Star
            // 
            resources.ApplyResources(level2Star, "level2Star");
            level2Star.ForeColor = Color.Yellow;
            level2Star.Name = "level2Star";
            // 
            // level3Star
            // 
            resources.ApplyResources(level3Star, "level3Star");
            level3Star.ForeColor = Color.Yellow;
            level3Star.Name = "level3Star";
            // 
            // level4Star
            // 
            resources.ApplyResources(level4Star, "level4Star");
            level4Star.ForeColor = Color.Yellow;
            level4Star.Name = "level4Star";
            // 
            // level5Star
            // 
            resources.ApplyResources(level5Star, "level5Star");
            level5Star.ForeColor = Color.Yellow;
            level5Star.Name = "level5Star";
            // 
            // button5
            // 
            button5.BackColor = Color.DodgerBlue;
            resources.ApplyResources(button5, "button5");
            button5.Name = "button5";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // Levels
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(level5Star);
            Controls.Add(button5);
            Controls.Add(level4Star);
            Controls.Add(level3Star);
            Controls.Add(level2Star);
            Controls.Add(level1Star);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Levels";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label level1Star;
        private Label level2Star;
        private Label level3Star;
        private Label level4Star;
        private Label level5Star;
        private Button button5;
    }
}
