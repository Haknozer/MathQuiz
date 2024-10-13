namespace MathQuiz
{
    partial class Quests
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
            components = new System.ComponentModel.Container();
            button1 = new Button();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            label2 = new Label();
            panel10 = new Panel();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(495, 389);
            button1.Name = "button1";
            button1.Size = new Size(252, 103);
            button1.TabIndex = 0;
            button1.Text = "Next";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F);
            label1.Location = new Point(659, 84);
            label1.Name = "label1";
            label1.Size = new Size(71, 57);
            label1.TabIndex = 2;
            label1.Text = "90";
            label1.Click += label1_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 25.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(500, 84);
            label2.Name = "label2";
            label2.Size = new Size(170, 57);
            label2.TabIndex = 3;
            label2.Text = "TIME = ";
            // 
            // panel10
            // 
            panel10.Location = new Point(12, 16);
            panel10.Name = "panel10";
            panel10.Size = new Size(460, 661);
            panel10.TabIndex = 5;
            // 
            // Quests
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(812, 689);
            Controls.Add(panel10);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Quests";
            Text = "Questions";
            Load += Quests_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
        private Label label2;
        private Panel panel10;
    }
}