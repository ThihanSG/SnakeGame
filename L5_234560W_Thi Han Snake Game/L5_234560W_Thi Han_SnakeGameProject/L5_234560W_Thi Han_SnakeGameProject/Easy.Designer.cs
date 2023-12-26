
namespace L5_234560W_Thi_Han_SnakeGameProject
{
    partial class Easy
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
            this.lblLevel = new System.Windows.Forms.Label();
            this.controlPanel1 = new System.Windows.Forms.Panel();
            this.modeLBL = new System.Windows.Forms.Label();
            this.btnEnd = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.difficulityLBL = new System.Windows.Forms.Label();
            this.lblGamemode = new System.Windows.Forms.Label();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.timerLBL = new System.Windows.Forms.Label();
            this.scoreLBL = new System.Windows.Forms.Label();
            this.levelLBL = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.boardPanel = new System.Windows.Forms.Panel();
            this.controlPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevel.Location = new System.Drawing.Point(154, 128);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(76, 25);
            this.lblLevel.TabIndex = 0;
            this.lblLevel.Text = "Level:";
            // 
            // controlPanel1
            // 
            this.controlPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.controlPanel1.Controls.Add(this.modeLBL);
            this.controlPanel1.Controls.Add(this.btnEnd);
            this.controlPanel1.Controls.Add(this.btnPause);
            this.controlPanel1.Controls.Add(this.btnStart);
            this.controlPanel1.Controls.Add(this.difficulityLBL);
            this.controlPanel1.Controls.Add(this.lblGamemode);
            this.controlPanel1.Controls.Add(this.btnRight);
            this.controlPanel1.Controls.Add(this.btnDown);
            this.controlPanel1.Controls.Add(this.btnLeft);
            this.controlPanel1.Controls.Add(this.btnUp);
            this.controlPanel1.Controls.Add(this.timerLBL);
            this.controlPanel1.Controls.Add(this.scoreLBL);
            this.controlPanel1.Controls.Add(this.levelLBL);
            this.controlPanel1.Controls.Add(this.lblTimer);
            this.controlPanel1.Controls.Add(this.lblScore);
            this.controlPanel1.Controls.Add(this.lblLevel);
            this.controlPanel1.Location = new System.Drawing.Point(12, 532);
            this.controlPanel1.Name = "controlPanel1";
            this.controlPanel1.Size = new System.Drawing.Size(1371, 411);
            this.controlPanel1.TabIndex = 1;
            // 
            // modeLBL
            // 
            this.modeLBL.AutoSize = true;
            this.modeLBL.Location = new System.Drawing.Point(706, 247);
            this.modeLBL.Name = "modeLBL";
            this.modeLBL.Size = new System.Drawing.Size(0, 25);
            this.modeLBL.TabIndex = 14;
            // 
            // btnEnd
            // 
            this.btnEnd.BackColor = System.Drawing.Color.Red;
            this.btnEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnd.ForeColor = System.Drawing.Color.White;
            this.btnEnd.Location = new System.Drawing.Point(1125, 332);
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
            this.btnPause.Location = new System.Drawing.Point(1125, 257);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(107, 44);
            this.btnPause.TabIndex = 12;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.YellowGreen;
            this.btnStart.Location = new System.Drawing.Point(1125, 181);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(107, 44);
            this.btnStart.TabIndex = 11;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // difficulityLBL
            // 
            this.difficulityLBL.AutoSize = true;
            this.difficulityLBL.Location = new System.Drawing.Point(303, 351);
            this.difficulityLBL.Name = "difficulityLBL";
            this.difficulityLBL.Size = new System.Drawing.Size(0, 25);
            this.difficulityLBL.TabIndex = 10;
            // 
            // lblGamemode
            // 
            this.lblGamemode.AutoSize = true;
            this.lblGamemode.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGamemode.Location = new System.Drawing.Point(154, 351);
            this.lblGamemode.Name = "lblGamemode";
            this.lblGamemode.Size = new System.Drawing.Size(124, 25);
            this.lblGamemode.TabIndex = 9;
            this.lblGamemode.Text = "Difficulity :";
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(798, 241);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(88, 37);
            this.btnRight.TabIndex = 8;
            this.btnRight.Text = "▶";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(698, 303);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(88, 37);
            this.btnDown.TabIndex = 7;
            this.btnDown.Text = "▼";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(597, 241);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(88, 37);
            this.btnLeft.TabIndex = 6;
            this.btnLeft.Text = "◀ ";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(698, 174);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(88, 37);
            this.btnUp.TabIndex = 2;
            this.btnUp.Text = "▲";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // timerLBL
            // 
            this.timerLBL.AutoSize = true;
            this.timerLBL.Location = new System.Drawing.Point(303, 276);
            this.timerLBL.Name = "timerLBL";
            this.timerLBL.Size = new System.Drawing.Size(0, 25);
            this.timerLBL.TabIndex = 5;
            // 
            // scoreLBL
            // 
            this.scoreLBL.AutoSize = true;
            this.scoreLBL.Location = new System.Drawing.Point(303, 200);
            this.scoreLBL.Name = "scoreLBL";
            this.scoreLBL.Size = new System.Drawing.Size(0, 25);
            this.scoreLBL.TabIndex = 4;
            // 
            // levelLBL
            // 
            this.levelLBL.AutoSize = true;
            this.levelLBL.Location = new System.Drawing.Point(303, 128);
            this.levelLBL.Name = "levelLBL";
            this.levelLBL.Size = new System.Drawing.Size(0, 25);
            this.levelLBL.TabIndex = 3;
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(154, 276);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(85, 25);
            this.lblTimer.TabIndex = 2;
            this.lblTimer.Text = "Timer :";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(154, 200);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(87, 25);
            this.lblScore.TabIndex = 1;
            this.lblScore.Text = "Score :";
            // 
            // boardPanel
            // 
            this.boardPanel.Location = new System.Drawing.Point(12, 30);
            this.boardPanel.Name = "boardPanel";
            this.boardPanel.Size = new System.Drawing.Size(936, 488);
            this.boardPanel.TabIndex = 14;
            // 
            // Easy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1395, 955);
            this.Controls.Add(this.boardPanel);
            this.Controls.Add(this.controlPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Easy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Easy";
            this.controlPanel1.ResumeLayout(false);
            this.controlPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Panel controlPanel1;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label difficulityLBL;
        private System.Windows.Forms.Label lblGamemode;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Label timerLBL;
        private System.Windows.Forms.Label scoreLBL;
        private System.Windows.Forms.Label levelLBL;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Panel boardPanel;
        private System.Windows.Forms.Label modeLBL;
    }
}