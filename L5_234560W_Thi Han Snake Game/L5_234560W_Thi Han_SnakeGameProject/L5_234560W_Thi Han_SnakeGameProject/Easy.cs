using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L5_234560W_Thi_Han_SnakeGameProject
{
    public partial class Easy : Form
    {
        Snake mySnake;
        Board mainBoard;
        Reward apples;

        string mode;
        Timer clock;
        int duration; //How long the game has been running
        int speed = 500; //500ms
        int score;
        int level;

        Panel formBoardPanel; // Rename the variable to avoid ambiguity
        Panel controlPanel;
        public Easy()
        {
            InitializeComponent();



            //Set up the main board
            //mainBoard = new Board(this);

            formBoardPanel = new Panel();
            formBoardPanel.Name = "boardPanel";
            this.Controls.Add(formBoardPanel);

            controlPanel = new Panel();
            controlPanel.Name = "controlPanel";
            this.Controls.Add(controlPanel);

            mainBoard = new Board(this);

            //Set up the game timer at the given speed
            clock = new Timer();
            clock.Interval = speed; //Set the clock to tick every 500ms
            clock.Tick += new EventHandler(refresh); //Call the refresh method at every tick to redraw the board and snake.

            duration = 0;
            score = 0;
            level = 1;
            modeLBL.Text = mode;
            difficulityLBL.Text = "Easy";

            gotoNextLevel(level);

            
        }

        private void gotoNextLevel(int nextLevel)
        {
            mode = "Rest";
            mySnake = new Snake(mainBoard); //Brand new snake with length 1
            apples = new Reward(nextLevel, mainBoard); 
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

        private void btnUp_Click(object sender, EventArgs e)
        {
            mode = "Up";
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            mode = "Right";
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            mode = "Left";
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            mode = "Down";
        }

        private void refresh(Object myObject, EventArgs myEventArgs)
        {
            mySnake.move(mode); //Move the snake based on mode
            modeLBL.Text = mode;

            mainBoard.draw();
            apples.draw();  //<----- draw apples
            mySnake.draw();

            //increment the duration by amount of time that has passed
            //this method is called every speed millisecond
            duration += speed;
            timerLBL.Text = Convert.ToString(duration / 1000); //Show time passed


            //Check if snke is biting itself. If so, call GameOver.
            if (mySnake.checkEatItself() == true)
            {
                GameOver();
            }
            else if (apples.checkIFSnakeHeadEatApple(mySnake.getHeadPosition()) == true)
            {
                score += apples.eatAppleAtPostion(mySnake.getHeadPosition());

                scoreLBL.Text = Convert.ToString(score);


                if (apples.noMoreApples() == true)
                {
                    clock.Stop();
                    level++;
                    levelLBL.Text = Convert.ToString(level);
                    gotoNextLevel(level);
                    MessageBox.Show("Press the start button to go to Level " + level, "Congrats");
                }
                else
                {
                    //Length the snake and continue with the Game
                    mySnake.extendBody();
                }
            }


        }

        private void GameOver()
        {
            clock.Stop();
            MessageBox.Show("Your time taken is " + duration / 1000 + " seconds.", "Game Over");
            this.Close();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            clock.Start();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            clock.Stop();
        }
    }
}
