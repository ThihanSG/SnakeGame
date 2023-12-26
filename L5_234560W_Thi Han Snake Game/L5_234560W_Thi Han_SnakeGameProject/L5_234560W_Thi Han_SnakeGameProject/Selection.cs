using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L5_234560W_Thi_Han_SnakeGameProject
{
    public partial class Selection : Form
    {
        private string username;
        public string SelectedDifficulty { get; private set; }
        public Selection(string username)
        {
            InitializeComponent();

            btnEasy.MouseHover += btnEasy_MouseHover;
            btnEasy.MouseLeave += btnEasy_MouseLeave;

            btnMedium.MouseHover += btnMedium_MouseHover;
            btnMedium.MouseLeave += btnMedium_MouseLeave;

            btnHard.MouseHover += btnHard_MouseHover;
            btnHard.MouseLeave += btnHard_MouseLeave;

            this.username = username;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit the game?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                // Do nothing, let the form remain open
            }
            else
            {
                this.Close(); // Close the form if the user selects Yes or closes the MessageBox
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnEasy_Click(object sender, EventArgs e)
        {
            SelectedDifficulty = "Easy";
            DialogResult = DialogResult.OK;
            Easy form = new Easy();
            form.Show();
            this.Hide();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Menu form = new Menu();
            form.Show();
            this.Hide();
        }

        private void btnEasy_MouseHover(object sender, EventArgs e)
        {
            // Change the text when the mouse hovers over the button
            GameDescription.Text = "Embark on a serpentine journey through the sun-kissed desert as you take on the role of a vibrant rattlesnake in search of succulent apples.";
        }

        private void btnEasy_MouseLeave(object sender, EventArgs e)
        {
            // Change the text back when the mouse leaves the button
            GameDescription.Text = "";
        }

        private void btnMedium_Click(object sender, EventArgs e)
        {
            SelectedDifficulty = "Medium";
            DialogResult = DialogResult.OK;
            Medium form = new Medium();
            form.Show();
            this.Hide();
        }

        private void btnMedium_MouseHover(object sender, EventArgs e)
        {
            // Change the text when the mouse hovers over the button
            GameDescription.Text = "Embark on a serpentine journey through the sun-kissed desert as you take on the role of a vibrant rattlesnake in search of succulent apples.";
        }

        private void btnMedium_MouseLeave(object sender, EventArgs e)
        {
            // Change the text back when the mouse leaves the button
            GameDescription.Text = "";
        }

        private void btnHard_MouseHover(object sender, EventArgs e)
        {
            // Change the text when the mouse hovers over the button
            GameDescription.Text = "Embark on a serpentine journey through the sun-kissed desert as you take on the role of a vibrant rattlesnake in search of succulent apples.";
        }

        private void btnHard_MouseLeave(object sender, EventArgs e)
        {
            // Change the text back when the mouse leaves the button
            GameDescription.Text = "";
        }
    }
}
