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
    public partial class Control : Form
    {
        private string selectedOption = "arrow";
        public Control()
        {
            InitializeComponent();
            cbArrow.Checked = true;

            if (!string.IsNullOrEmpty(Properties.Settings.Default.SelectedOption))
            {
                selectedOption = Properties.Settings.Default.SelectedOption;
                UpdateCheckboxSelection();
            }
            else
            {
                // Set default selection
                cbArrow.Checked = true;
            }
        }

        private void UpdateCheckboxSelection()
        {
            // Update the checkbox selection based on the selectedOption variable
            if (selectedOption == "arrow")
            {
                cbArrow.Checked = true;
                cbKeyboard.Checked = false;
            }
            else if (selectedOption == "keyboard")
            {
                cbArrow.Checked = false;
                cbKeyboard.Checked = true;
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Menu form = new Menu();
            form.Show();
            this.Hide();
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            if (cbArrow.Checked)
            {
                selectedOption = "arrow";
            }
            else if (cbKeyboard.Checked)
            {
                selectedOption = "keyboard";
            }

            Properties.Settings.Default.SelectedOption = selectedOption;
            Properties.Settings.Default.Save();

            if (ChangesNeedSaving())
            {
                DialogResult result = MessageBox.Show("Are you sure you want to save the changes?", "Save Changes", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Code to save changes goes here
                    SaveChanges();
                }
                else
                {
                    // User selected No, do not save changes
                }
            }
            else
            {
                // No changes to save
                MessageBox.Show("No changes to save.", "No Changes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private bool ChangesNeedSaving()
        {
            return true; 
        }
        private void SaveChanges()
        {
            MessageBox.Show("Changes saved successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cbArrow_CheckedChanged(object sender, EventArgs e)
        {

            if (cbArrow.Checked)
            {
                cbKeyboard.Checked = false;
                selectedOption = "arrow";
            }
        }

        private void cbKeyboard_CheckedChanged(object sender, EventArgs e)
        {
            if (cbKeyboard.Checked)
            {
                cbArrow.Checked = false;
                selectedOption = "keyboard";
            }
        }
    }
}
