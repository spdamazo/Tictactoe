namespace Tictactoe
{
    partial class Form2
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
            buttonNewGame = new Button();
            SuspendLayout();
            // 
            // buttonNewGame
            // 
            buttonNewGame.Anchor = AnchorStyles.None;
            buttonNewGame.Location = new Point(123, 100);
            buttonNewGame.Name = "buttonNewGame";
            buttonNewGame.Size = new Size(163, 103);
            buttonNewGame.TabIndex = 0;
            buttonNewGame.Text = "Play Again?";
            buttonNewGame.UseVisualStyleBackColor = true;
            buttonNewGame.Click += buttonNewGame_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(414, 307);
            Controls.Add(buttonNewGame);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "New Game";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonNewGame;
    }
}