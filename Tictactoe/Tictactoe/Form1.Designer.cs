namespace Tictactoe
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            label1 = new Label();
            btnHelp = new Button();
            btnResetGame = new Button();
            lblTurn = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Location = new Point(91, 158);
            button1.Name = "button1";
            button1.Size = new Size(97, 89);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.Location = new Point(194, 158);
            button2.Name = "button2";
            button2.Size = new Size(97, 89);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.Location = new Point(297, 158);
            button3.Name = "button3";
            button3.Size = new Size(97, 89);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.None;
            button4.Location = new Point(91, 253);
            button4.Name = "button4";
            button4.Size = new Size(97, 89);
            button4.TabIndex = 3;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.None;
            button5.Location = new Point(194, 253);
            button5.Name = "button5";
            button5.Size = new Size(97, 89);
            button5.TabIndex = 4;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.None;
            button6.Location = new Point(297, 253);
            button6.Name = "button6";
            button6.Size = new Size(97, 89);
            button6.TabIndex = 5;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Anchor = AnchorStyles.None;
            button7.Location = new Point(91, 348);
            button7.Name = "button7";
            button7.Size = new Size(97, 89);
            button7.TabIndex = 6;
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Anchor = AnchorStyles.None;
            button8.Location = new Point(194, 348);
            button8.Name = "button8";
            button8.Size = new Size(97, 89);
            button8.TabIndex = 7;
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Anchor = AnchorStyles.None;
            button9.Location = new Point(297, 348);
            button9.Name = "button9";
            button9.Size = new Size(97, 89);
            button9.TabIndex = 8;
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(111, 72);
            label1.Name = "label1";
            label1.Size = new Size(264, 65);
            label1.TabIndex = 9;
            label1.Text = "Tic-Tac-Toe";
            // 
            // btnHelp
            // 
            btnHelp.Anchor = AnchorStyles.None;
            btnHelp.Location = new Point(12, 12);
            btnHelp.Name = "btnHelp";
            btnHelp.Size = new Size(78, 34);
            btnHelp.TabIndex = 10;
            btnHelp.Text = "Help";
            btnHelp.UseVisualStyleBackColor = true;
            btnHelp.Click += btnHelp_Click;
            // 
            // btnResetGame
            // 
            btnResetGame.Location = new Point(96, 12);
            btnResetGame.Name = "btnResetGame";
            btnResetGame.Size = new Size(92, 34);
            btnResetGame.TabIndex = 11;
            btnResetGame.Text = "Reset";
            btnResetGame.UseVisualStyleBackColor = true;
            btnResetGame.Click += btnResetGame_Click;
            // 
            // lblTurn
            // 
            lblTurn.AutoSize = true;
            lblTurn.Location = new Point(178, 458);
            lblTurn.Name = "lblTurn";
            lblTurn.Size = new Size(127, 25);
            lblTurn.TabIndex = 12;
            lblTurn.Text = "Player X's Turn";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(485, 516);
            Controls.Add(lblTurn);
            Controls.Add(btnResetGame);
            Controls.Add(btnHelp);
            Controls.Add(label1);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tic-Tac-Toe";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Label label1;
        private Button btnHelp;
        private Button btnResetGame;
        private Label lblTurn;
    }
}
