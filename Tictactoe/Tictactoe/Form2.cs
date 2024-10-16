using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tictactoe
{
    public partial class Form2 : Form
    {
        private Form1 mainForm; // Field to hold reference to Form1

        
        public Form2(Form1 form)
        {
            InitializeComponent();
            mainForm = form; // Set the passed Form1 reference to mainForm
        }

        private void buttonNewGame_Click(object sender, EventArgs e)
        {
            mainForm.ResetGame(); // Call ResetGame on Form1 to restart the game
            this.Close(); // Close Form2 after starting a new game
        }
    }
}
