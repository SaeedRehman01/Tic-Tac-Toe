namespace Tic_Tac_Toe
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            button10 = new Button();
            GeniusAITimer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(163, 28);
            label1.TabIndex = 0;
            label1.Text = "Player Wins:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Firebrick;
            label2.Location = new Point(327, 9);
            label2.Name = "label2";
            label2.Size = new Size(180, 28);
            label2.TabIndex = 1;
            label2.Text = "Genius AI Wins:";
            // 
            // button1
            // 
            button1.Font = new Font("Showcard Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(59, 62);
            button1.Name = "button1";
            button1.Size = new Size(128, 118);
            button1.TabIndex = 2;
            button1.Text = "?";
            button1.UseVisualStyleBackColor = true;
            button1.Click += PlayerClickButton;
            // 
            // button2
            // 
            button2.Font = new Font("Showcard Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(193, 62);
            button2.Name = "button2";
            button2.Size = new Size(128, 118);
            button2.TabIndex = 3;
            button2.Text = "?";
            button2.UseVisualStyleBackColor = true;
            button2.Click += PlayerClickButton;
            // 
            // button3
            // 
            button3.Font = new Font("Showcard Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(327, 62);
            button3.Name = "button3";
            button3.Size = new Size(128, 118);
            button3.TabIndex = 4;
            button3.Text = "?";
            button3.UseVisualStyleBackColor = true;
            button3.Click += PlayerClickButton;
            // 
            // button6
            // 
            button6.Font = new Font("Showcard Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.Location = new Point(327, 182);
            button6.Name = "button6";
            button6.Size = new Size(128, 118);
            button6.TabIndex = 7;
            button6.Text = "?";
            button6.UseVisualStyleBackColor = true;
            button6.Click += PlayerClickButton;
            // 
            // button5
            // 
            button5.Font = new Font("Showcard Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.Location = new Point(193, 182);
            button5.Name = "button5";
            button5.Size = new Size(128, 118);
            button5.TabIndex = 6;
            button5.Text = "?";
            button5.UseVisualStyleBackColor = true;
            button5.Click += PlayerClickButton;
            // 
            // button4
            // 
            button4.Font = new Font("Showcard Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(59, 182);
            button4.Name = "button4";
            button4.Size = new Size(128, 118);
            button4.TabIndex = 5;
            button4.Text = "?";
            button4.UseVisualStyleBackColor = true;
            button4.Click += PlayerClickButton;
            // 
            // button9
            // 
            button9.Font = new Font("Showcard Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button9.Location = new Point(327, 306);
            button9.Name = "button9";
            button9.Size = new Size(128, 118);
            button9.TabIndex = 10;
            button9.Text = "?";
            button9.UseVisualStyleBackColor = true;
            button9.Click += PlayerClickButton;
            // 
            // button8
            // 
            button8.Font = new Font("Showcard Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button8.Location = new Point(193, 306);
            button8.Name = "button8";
            button8.Size = new Size(128, 118);
            button8.TabIndex = 9;
            button8.Text = "?";
            button8.UseVisualStyleBackColor = true;
            button8.Click += PlayerClickButton;
            // 
            // button7
            // 
            button7.Font = new Font("Showcard Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.Location = new Point(59, 306);
            button7.Name = "button7";
            button7.Size = new Size(128, 118);
            button7.TabIndex = 8;
            button7.Text = "?";
            button7.UseVisualStyleBackColor = true;
            button7.Click += PlayerClickButton;
            // 
            // button10
            // 
            button10.Font = new Font("Showcard Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button10.ForeColor = Color.LimeGreen;
            button10.Location = new Point(184, 445);
            button10.Name = "button10";
            button10.Size = new Size(150, 66);
            button10.TabIndex = 11;
            button10.Text = "Restart Game";
            button10.UseVisualStyleBackColor = true;
            button10.Click += RestartGameButton;
            // 
            // GeniusAITimer
            // 
            GeniusAITimer.Interval = 1000;
            GeniusAITimer.Tick += AiMove;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(534, 523);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Tic Tac Toe - Player vs Genius AI";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button10;
        private System.Windows.Forms.Timer GeniusAITimer;
    }
}
