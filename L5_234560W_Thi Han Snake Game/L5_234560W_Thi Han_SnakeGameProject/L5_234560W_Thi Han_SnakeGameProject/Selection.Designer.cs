
namespace L5_234560W_Thi_Han_SnakeGameProject
{
    partial class Selection
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnEasy = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.GameDescription = new System.Windows.Forms.Label();
            this.btnMedium = new System.Windows.Forms.Button();
            this.btnHard = new System.Windows.Forms.Button();
            this.DGVleaderboard = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGVleaderboard)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1656, 24);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(86, 35);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnEasy
            // 
            this.btnEasy.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEasy.Location = new System.Drawing.Point(142, 215);
            this.btnEasy.Name = "btnEasy";
            this.btnEasy.Size = new System.Drawing.Size(371, 402);
            this.btnEasy.TabIndex = 6;
            this.btnEasy.Text = "Easy";
            this.btnEasy.UseVisualStyleBackColor = true;
            this.btnEasy.Click += new System.EventHandler(this.btnEasy_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Rockwell Condensed", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.Red;
            this.lblHeader.Location = new System.Drawing.Point(343, 78);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(875, 110);
            this.lblHeader.TabIndex = 9;
            this.lblHeader.Text = "SELECT YOUR GAME MODE";
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.Color.White;
            this.btnReturn.Location = new System.Drawing.Point(1241, 96);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(179, 68);
            this.btnReturn.TabIndex = 14;
            this.btnReturn.Text = "Return to Menu";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // GameDescription
            // 
            this.GameDescription.AllowDrop = true;
            this.GameDescription.AutoEllipsis = true;
            this.GameDescription.AutoSize = true;
            this.GameDescription.BackColor = System.Drawing.Color.White;
            this.GameDescription.Font = new System.Drawing.Font("Gill Sans MT Ext Condensed Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameDescription.Location = new System.Drawing.Point(156, 679);
            this.GameDescription.Name = "GameDescription";
            this.GameDescription.Size = new System.Drawing.Size(0, 50);
            this.GameDescription.TabIndex = 15;
            // 
            // btnMedium
            // 
            this.btnMedium.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedium.Location = new System.Drawing.Point(678, 215);
            this.btnMedium.Name = "btnMedium";
            this.btnMedium.Size = new System.Drawing.Size(371, 402);
            this.btnMedium.TabIndex = 16;
            this.btnMedium.Text = "Medium";
            this.btnMedium.UseVisualStyleBackColor = true;
            this.btnMedium.Click += new System.EventHandler(this.btnMedium_Click);
            // 
            // btnHard
            // 
            this.btnHard.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHard.Location = new System.Drawing.Point(1209, 215);
            this.btnHard.Name = "btnHard";
            this.btnHard.Size = new System.Drawing.Size(371, 402);
            this.btnHard.TabIndex = 17;
            this.btnHard.Text = "Hard";
            this.btnHard.UseVisualStyleBackColor = true;
            // 
            // DGVleaderboard
            // 
            this.DGVleaderboard.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.DGVleaderboard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVleaderboard.Location = new System.Drawing.Point(1124, 696);
            this.DGVleaderboard.Name = "DGVleaderboard";
            this.DGVleaderboard.RowHeadersWidth = 82;
            this.DGVleaderboard.RowTemplate.Height = 33;
            this.DGVleaderboard.Size = new System.Drawing.Size(645, 469);
            this.DGVleaderboard.TabIndex = 18;
            // 
            // Selection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(890, 588);
            this.Controls.Add(this.DGVleaderboard);
            this.Controls.Add(this.btnHard);
            this.Controls.Add(this.btnMedium);
            this.Controls.Add(this.GameDescription);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.btnEasy);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Selection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selection";
            ((System.ComponentModel.ISupportInitialize)(this.DGVleaderboard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnEasy;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label GameDescription;
        private System.Windows.Forms.Button btnMedium;
        private System.Windows.Forms.Button btnHard;
        private System.Windows.Forms.DataGridView DGVleaderboard;
    }
}