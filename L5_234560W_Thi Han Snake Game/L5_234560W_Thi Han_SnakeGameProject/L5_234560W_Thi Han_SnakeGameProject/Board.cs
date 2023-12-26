using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L5_234560W_Thi_Han_SnakeGameProject
{
    class Board
    {
        int maxRow = 10;
        int maxCol = 20; 
        int squareSize = 30;                //Each square is 30px by 30px

        PictureBox[,] squares;

        public Board(Form easyForm)
        {
            squares = new PictureBox[maxRow, maxCol];
            for (int row = 0; row < maxRow; row++)
            {
                for (int col = 0; col < maxCol; col++)
                {
                    squares[row, col] = new PictureBox();
                    squares[row, col].Location = new Point(col * squareSize, row * squareSize);
                    squares[row, col].Height = squareSize;
                    squares[row, col].Width = squareSize;
                    squares[row, col].SizeMode = PictureBoxSizeMode.StretchImage;
                    squares[row, col].BackColor = Color.DarkGray;
                    squares[row, col].BorderStyle = BorderStyle.FixedSingle;

                    easyForm.Controls["boardPanel"].Controls.Add(squares[row, col]);
                }
            }
            easyForm.Controls["controlPanel"].Location = new Point(easyForm.Controls["boardPanel"].Location.X, easyForm.Controls["boardPanel"].Location.Y + easyForm.Controls["boardPanel"].Height + 20);
        }

        public int getMaxColNo()
        {
            return maxCol - 1; 
        }

        public int getMaxRowNo()
        {
            return maxRow - 1; 
        }

        public int getMinColNo()
        {
            return 0;       
        }

        public int getMinRowNo()
        {
            return 0;  
        }

        public void draw()
        {
            for (int row = 0; row < maxRow; row++)
            {
                for (int col = 0; col < maxCol; col++)
                {
                    squares[row, col].Image = null;
                }
            }
        }

        public void draw(Position p, Image pic)
        {
            squares[p.getRowNo(), p.getColNo()].Image = pic;
        }
    }
}
