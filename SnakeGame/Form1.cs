using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame
{
    public partial class frmSnake : Form
    {
        Random randonGen;
        enum GameBoardFields { Free, Snake, Bonus };
        enum Directions { Up, Down, Left, Right };

        //to identify position of snake
        struct SnakeCoordinates
        {
            public int x;
            public int y;
        }

        //gameboard 2D dimenstional array
        GameBoardFields[,] gameBoardField;

        //coardinates of snake. Not 2D array, since its STUCT hold 2d coordinates 
        SnakeCoordinates[] snakeXY;
        int snakeLength;
        Directions direction;

        //to paint on the surface
        Graphics graphics;

      

        public frmSnake()
        {
            InitializeComponent();
            //initalise variable. . 11 area will be wall
            gameBoardField = new GameBoardFields[11, 11];
            //game is 10x10
            snakeXY = new SnakeCoordinates[100];
            randonGen = new Random();
        }

        private void frmSnake_Load(object sender, EventArgs e)
        {
            //perpare picturebox to hold images, creat a new bitmap
            picGameBoard.Image = new Bitmap(420, 420);
            graphics = Graphics.FromImage(picGameBoard.Image);
            graphics.Clear(Color.White);

            //drawing wall
            for (int i = 1; i < 11; i++)
            {
                //top and bottom walls. i*35. 35 is the pxl sprite
                graphics.DrawImage(imgList.Images[6], i * 35, 0);
                graphics.DrawImage(imgList.Images[6], i * 35, 385);
            }
            for (int i = 0; i < 12; i++)
            {
                //top and bottom walls. i*35. 35 is the pxl sprite
                graphics.DrawImage(imgList.Images[6], 0, i*35);
                graphics.DrawImage(imgList.Images[6], 385, i *35);
            }
            // end wall

            //initial snake head
            snakeXY[0].x = 5;
            snakeXY[0].y = 5;
            //initial snake body part 1
            snakeXY[1].x = 5;
            snakeXY[1].y = 6;
            //initial snake body part 2
            snakeXY[2].x = 5;
            snakeXY[2].y = 7;

            //now to draww image.
            graphics.DrawImage(imgList.Images[5], 5 * 35, 5 * 35);
            graphics.DrawImage(imgList.Images[4], 5 * 35, 6 * 35);
            graphics.DrawImage(imgList.Images[4], 5 * 35, 7 * 35);
            //end draw snake

            gameBoardField[5, 5] = GameBoardFields.Snake;
            gameBoardField[5, 6] = GameBoardFields.Snake;
            gameBoardField[5, 7] = GameBoardFields.Snake;

            direction = Directions.Up;
            snakeLength = 3;

            for (int i = 0; i < 3; i++)
            {
                Bonus();
            }

        }
        private void Bonus()
        {
            int x, y;
            int imgIndex = randonGen.Next(0, 4);
            //to display only on free fields
            do
            {
                x = randonGen.Next(1, 10);
                y = randonGen.Next(1, 10);
            }
            while (gameBoardField[x, y] != GameBoardFields.Free);

            gameBoardField[x, y] = GameBoardFields.Bonus;
            graphics.DrawImage(imgList.Images[imgIndex], x * 35, y * 35);

     
           
        }

        private void frmSnake_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    direction = Directions.Up;
                    break;
                case Keys.Down:
                    direction = Directions.Down;
                    break;
                case Keys.Left:
                    direction = Directions.Left;
                    break;
                case Keys.Right:
                    direction = Directions.Right;
                    break;
            }
        }
        private void GameOver()
        {
            //puase game
            timer.Enabled = false;
            MessageBox.Show("Game Over");

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            //remove last piece of snake, we paint it white
            graphics.FillRectangle(Brushes.White, snakeXY[snakeLength - 1].x * 35,
                                                  snakeXY[snakeLength - 1].y *35 ,35,35);

            gameBoardField[snakeXY[snakeLength - 1].x, snakeXY[snakeLength - 1].y] = GameBoardFields.Free;
            //picGameBoard.Refresh();

            //move snake field on the position of the previous on
        
        }
    }
}
