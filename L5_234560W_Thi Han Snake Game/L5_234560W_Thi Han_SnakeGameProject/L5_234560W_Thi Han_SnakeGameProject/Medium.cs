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
    public partial class Medium : Form
    {
        public Medium()
        {
            InitializeComponent();
            levelLBL.Text = "Medium";
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to quit the game?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                // Do nothing, let the game remain open
            }
            else
            {
                Menu form = new Menu();
                form.Show();
                this.Hide();
            }
        }
    }
}
