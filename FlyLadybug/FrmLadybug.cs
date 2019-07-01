using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlyLadybug
{
    public partial class FrmLadybug : Form
    {
        Graphics g; //declare the graphics object
        int x = 20, y = 20; //starting position of ball
        //declare a rectangle to contain the ladybug and spaceship and an area array to contain the balls
        Rectangle arealadybug;
        Rectangle[] area = new Rectangle[7]; //area[0] to area [6]
        Random speed = new Random();
        int[] ballSpeed = new int[7];
        bool up, down;
        private void TmrBall_Tick(object sender, EventArgs e)
        {
           for(int i=0;i<=6;i++)
            {
                area[i].X += ballSpeed[i];
                if(area[i].X > PnlGame.Width)
                {
                    area[i].X = 20;
                }
            }
            PnlGame.Invalidate();//makes the paint event fire to redraw panel
        }

        int x2 = 540, y2 = 250; //starting position of Ladybug
        //Load our two images from the bin/debug folder
        Image ladybug = Image.FromFile(Application.StartupPath + @"/ladybug.png");

        private void FrmLadybug_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.W)
            {
                up = true;
            }
            if (e.KeyData == Keys.A)
            {
                down = true;
            }
        }

        private void FrmLadybug_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.W)
            {
                up = false;
            }
            if (e.KeyData == Keys.A)
            {
                down = false;
            }
        }

        private void TmrLadybug_Tick(object sender, EventArgs e)
        {
            if (up) //if W key pressed 
            {
                if (arealadybug.Y < 10)
                //check to see if ball within 10 of up side
                {
                    arealadybug.Y = 10;
                    //if it is < 10 away "bounce" it (set position at 10)
                }
                {
                    arealadybug.Y -= 5;
                    //else move 5 up
                }
            }
            if (down) //if A key pressed 
            {
                if(arealadybug.Y > PnlGame.Height - 40)//is spaceship within 40 of right side 
                {
                    arealadybug.Y = PnlGame.Height - 40;
                }
                else
                {
                    arealadybug.Y += 5;
                }
            }
        }

        Image ball1 = Image.FromFile(Application.StartupPath + @"/dragon.png");

        private void PnlGame_Paint(object sender, PaintEventArgs e)
        {
            //get the method from the graphic's class to paint on the panel
            g = e.Graphics;
            //use the DrawImage method to draw the ladybug on the panel 
            g.DrawImage(ladybug, arealadybug);
            //use the DrawImage method to draw the dragon on the panel
            for (int i=0;i<6;i++)
            {
                g.DrawImage(ball1, area[i]);
            }
        }
        public FrmLadybug()
        {
            InitializeComponent();
            arealadybug = new Rectangle(x2, y2, 30, 30);//ladybugs rectangle 
                                                        //position the balls
            for (int i = 0; i < 7; i++)
            {
                area[i] = new Rectangle(x, y + 70 * i, 20, 20);

                ballSpeed[i] = speed.Next(5, 10);
                //each ball has a random speed
            }
        }
    }
}

