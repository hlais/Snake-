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

        }
    }
}
