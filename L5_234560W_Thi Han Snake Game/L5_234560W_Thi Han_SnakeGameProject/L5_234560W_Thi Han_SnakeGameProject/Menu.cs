using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Media;

namespace L5_234560W_Thi_Han_SnakeGameProject
{
    public partial class Menu : Form
    {
        private SoundPlayer soundPlayer;


        public Menu()
        {
            InitializeComponent();

            errorProvider1 = new ErrorProvider();
            btnStart.Enabled = false;
            btnConfirm.Click += btnConfirm_Click;

            soundPlayer = new SoundPlayer(@"C:\Users\thiha\OneDrive\Desktop\nature-soundstropicaljunglebirds-108380.wav.crdownload");
            soundPlayer.PlayLooping();

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            // Check if the TextBox is empty when Confirm button is clicked
            if (string.IsNullOrWhiteSpace(txtbUsername.Text))
            {
                errorProvider1.SetError(txtbUsername, "Please enter a username.");
                MessageBox.Show("Please enter a username.", "Username Not Entered", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // Do not enable the Start button as the username is not entered
                btnStart.Enabled = false;
            }
            else
            {
                // Username entered, enable the Start button
                btnStart.Enabled = true;
                
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit the game?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                // Do nothing, let the form remain open
            }
            else
            {
                this.Close(); 
            }
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (btnStart.Enabled)
            {
                string username = txtbUsername.Text.Trim();

                // Instantiate Selection form and pass the username to its constructor
                Selection selectionForm = new Selection(username);
                this.Hide();

                // Show the Selection form
                selectionForm.ShowDialog();

                // After the Selection form is closed, retrieve the selected difficulty and save the user data if needed
                if (selectionForm.DialogResult == DialogResult.OK)
                {
                    string selectedDifficulty = selectionForm.SelectedDifficulty;

                    // Combine username and difficulty into a single string
                    string userData = $"{username}, {selectedDifficulty}";

                    SaveNameToFile(username, selectedDifficulty);
                }
            }
        }

        private void btnControl_Click(object sender, EventArgs e)
        {
            Control form = new Control();
            form.Show();
            this.Hide();
        }

        private void txtbUsername_Click(object sender, EventArgs e)
        {
            
        }

        private void SaveNameToFile(string username, string selectedDifficulty)
        {
            StreamWriter sw = new StreamWriter(@"C:\tmp\Game.txt", append: true);
            string userData = $"{username}, {selectedDifficulty}";
            sw.WriteLine(userData);
            sw.Close();
        }
    }
}
