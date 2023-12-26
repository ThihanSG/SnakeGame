
namespace L5_234560W_Thi_Han_SnakeGameProject
{
    partial class Medium
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
            this.lblGamemode = new System.Windows.Forms.Label();
            this.timerLBL = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEnd = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.difficulityLBL = new System.Windows.Forms.Label();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.scoreLBL = new System.Windows.Forms.Label();
            this.levelLBL = new System.Windows.Forms.Label();
            this.boardPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblGamemode
            // 
            this.lblGamemode.AutoSize = true;
            this.lblGamemode.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGamemode.Location = new System.Drawing.Point(36, 273);
            this.lblGamemode.Name = "lblGamemode";
            this.lblGamemode.Size = new System.Drawing.Size(124, 25);
            this.lblGamemode.TabIndex = 9;
            this.lblGamemode.Text = "Difficulity :";
            // 
            // timerLBL
            // 
            this.timerLBL.AutoSize = true;
            this.timerLBL.Location = new System.Drawing.Point(185, 198);
            this.timerLBL.Name = "timerLBL";
            this.timerLBL.Size = new System.Drawing.Size(0, 50);
            this.timerLBL.TabIndex = 5;
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(36, 198);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(85, 25);
            this.lblTimer.TabIndex = 2;
            this.lblTimer.Text = "Timer :";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(36, 122);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(87, 25);
            this.lblScore.TabIndex = 1;
            this.lblScore.Text = "Score :";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevel.Location = new System.Drawing.Point(36, 50);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(76, 25);
            this.lblLevel.TabIndex = 0;
            this.lblLevel.Text = "Level:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnEnd);
            this.panel1.Controls.Add(this.btnPause);
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Controls.Add(this.difficulityLBL);
            this.panel1.Controls.Add(this.lblGamemode);
            this.panel1.Controls.Add(this.btnRight);
            this.panel1.Controls.Add(this.btnDown);
            this.panel1.Controls.Add(this.btnLeft);
            this.panel1.Controls.Add(this.btnUp);
            this.panel1.Controls.Add(this.timerLBL);
            this.panel1.Controls.Add(this.scoreLBL);
            this.panel1.Controls.Add(this.levelLBL);
            this.panel1.Controls.Add(this.lblTimer);
            this.panel1.Controls.Add(this.lblScore);
            this.panel1.Controls.Add(this.lblLevel);
            this.panel1.Location = new System.Drawing.Point(12, 379);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1189, 340);
            this.panel1.TabIndex = 15;
            // 
            // btnEnd
            // 
            this.btnEnd.BackColor = System.Drawing.Color.Red;
            this.btnEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnd.ForeColor = System.Drawing.Color.White;
            this.btnEnd.Location = new System.Drawing.Point(1007, 254);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(107, 44);
            this.btnEnd.TabIndex = 13;
            this.btnEnd.Text = "End";
            this.btnEnd.UseVisualStyleBackColor = false;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.Color.Yellow;
            this.btnPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPause.Location = new System.Drawing.Point(1007, 179);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(107, 44);
            this.btnPause.TabIndex = 12;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = false;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.YellowGreen;
            this.btnStart.Location = new System.Drawing.Point(1007, 103);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(107, 44);
            this.btnStart.TabIndex = 11;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            // 
            // difficulityLBL
            // 
            this.difficulityLBL.AutoSize = true;
            this.difficulityLBL.Location = new System.Drawing.Point(185, 273);
            this.difficulityLBL.Name = "difficulityLBL";
            this.difficulityLBL.Size = new System.Drawing.Size(0, 25);
            this.difficulityLBL.TabIndex = 10;
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(680, 163);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(88, 37);
            this.btnRight.TabIndex = 8;
            this.btnRight.Text = "▶";
            this.btnRight.UseVisualStyleBackColor = true;
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(580, 225);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(88, 37);
            this.btnDown.TabIndex = 7;
            this.btnDown.Text = "▼";
            this.btnDown.UseVisualStyleBackColor = true;
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(479, 163);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(88, 37);
            this.btnLeft.TabIndex = 6;
            this.btnLeft.Text = "◀ ";
            this.btnLeft.UseVisualStyleBackColor = true;
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(580, 96);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(88, 37);
            this.btnUp.TabIndex = 2;
            this.btnUp.Text = "▲";
            this.btnUp.UseVisualStyleBackColor = true;
            // 
            // scoreLBL
            // 
            this.scoreLBL.AutoSize = true;
            this.scoreLBL.Location = new System.Drawing.Point(185, 122);
            this.scoreLBL.Name = "scoreLBL";
            this.scoreLBL.Size = new System.Drawing.Size(0, 50);
            this.scoreLBL.TabIndex = 4;
            // 
            // levelLBL
            // 
            this.levelLBL.AutoSize = true;
            this.levelLBL.Location = new System.Drawing.Point(185, 50);
            this.levelLBL.Name = "levelLBL";
            this.levelLBL.Size = new System.Drawing.Size(0, 50);
            this.levelLBL.TabIndex = 3;
            // 
            // boardPanel
            // 
            this.boardPanel.Location = new System.Drawing.Point(12, 18);
            this.boardPanel.Name = "boardPanel";
            this.boardPanel.Size = new System.Drawing.Size(1189, 355);
            this.boardPanel.TabIndex = 16;
            // 
            // Medium
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 739);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.boardPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Medium";
            this.Text = "Medium";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblGamemode;
        private System.Windows.Forms.Label timerLBL;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label difficulityLBL;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Label scoreLBL;
        private System.Windows.Forms.Label levelLBL;
        private System.Windows.Forms.Panel boardPanel;
    }
}