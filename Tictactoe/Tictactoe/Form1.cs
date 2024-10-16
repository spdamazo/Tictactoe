
namespace Tictactoe
{
    public partial class Form1 : Form
    {
        private bool isPlayerXTurn = true; // To keep track of whose turn it is
        private int moveCount = 0; // To count the moves

        public Form1()
        {
            InitializeComponent();
            ResetGame();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            // Display the instructions in a message box
            MessageBox.Show("Players alternate turns placing either an X or an O. If a player gets 3 in a row, they win. If all 9 spaces on the board are filled with no winner, the game is a draw.", "How to Play");
        }
        private void btnResetGame_Click(object sender, EventArgs e)
        {
            // Call the ResetGame method to start a new game
            ResetGame();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button_Click(sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button_Click(sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button_Click(sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button_Click(sender);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button_Click(sender);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Button_Click(sender);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Button_Click(sender);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Button_Click(sender);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Button_Click(sender);
        }

        private void Button_Click(object sender)
        {
            Button button = (Button)sender;

            // Set X or O depending on whose turn it is
            if (isPlayerXTurn)
            {
                button.Text = "X";
            }
            else
            {
                button.Text = "O";
            }

            button.Enabled = false; // Disable the button once clicked
            moveCount++;

            if (CheckForWinner())
            {
                string winner = isPlayerXTurn ? "Player X" : "Player O";
                MessageBox.Show($"{winner} wins!", "Game Over");
                DisableAllButtons();

                // Show Form2
                Form2 form2 = new Form2(this);
                form2.ShowDialog();
            }
            else if (moveCount == 9) // Check for a draw
            {
                MessageBox.Show("It's a draw!", "Game Over");

                // Show Form2
                Form2 form2 = new Form2(this);
                form2.ShowDialog();
            }
            else
            {
                // Switch turns
                isPlayerXTurn = !isPlayerXTurn;

                // Update the label to show whose turn it is
                lblTurn.Text = isPlayerXTurn ? "Player X's Turn" : "Player O's Turn";
            }
        }

        private bool CheckForWinner()
        {
            // Check rows, columns, and diagonals for winning combinations
            if ((button1.Text == button2.Text && button2.Text == button3.Text && !button1.Enabled) ||
                (button4.Text == button5.Text && button5.Text == button6.Text && !button4.Enabled) ||
                (button7.Text == button8.Text && button8.Text == button9.Text && !button7.Enabled) ||
                (button1.Text == button4.Text && button4.Text == button7.Text && !button1.Enabled) ||
                (button2.Text == button5.Text && button5.Text == button8.Text && !button2.Enabled) ||
                (button3.Text == button6.Text && button6.Text == button9.Text && !button3.Enabled) ||
                (button1.Text == button5.Text && button5.Text == button9.Text && !button1.Enabled) ||
                (button3.Text == button5.Text && button5.Text == button7.Text && !button3.Enabled))
            {
                return true;
            }
            return false;
        }

        private void DisableAllButtons()
        {
            // Disable all buttons after the game ends
            foreach (Control c in Controls)
            {
                Button b = c as Button;
                if (b != null && b.Name != "btnHelp" && b.Name != "btnResetGame") // Disable all buttons except for the help and reset buttons
                {
                    b.Enabled = false;
                }
            }
        }

        private void buttonNewGame_Click(object sender, EventArgs e)
        {
            ResetGame();
        }

        public void ResetGame()
        {
            // Reset all buttons and re-enable them
            isPlayerXTurn = true;
            moveCount = 0;

            // Update the label to show the starting player's turn
            lblTurn.Text = "Player X's Turn";

            foreach (Control c in Controls)
            {
                Button b = c as Button;
                if (b != null && b.Name.StartsWith("button") && b.Name != "btnHelp" && b.Name != "btnResetGame") // Reset all buttons except for the help and reset buttons
                {
                    b.Enabled = true;
                    b.Text = "";
                }
            }
        }


    }
}
