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
        int score = 0;
        int lives = 5;
        private void TmrBall_Tick(object sender, EventArgs e)
        {
           for(int i=0;i<=6;i++)
            {
                area[i].X += ballSpeed[i];
                //if spaceship collides with any planet lose a life and move planet to the top of the panel
                if (area[i].IntersectsWith(arealadybug))
                {
                    area[i].X = 20;
                    lives -= 1; //reduce lives by 1
                    //display the number of lives on the form
                    Txtlives.Text = lives.ToString();
                    CheckLives();
                }
                if(area[i].X > PnlGame.Width)
                {
                    score += 1;// add 1 to score
                    LblScore.Text = score.ToString();//display score on the form
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

        private void MnuStart_Click(object sender, EventArgs e)
        {
            score = 0;//when game starts set the score to 0
            LblScore.Text = score.ToString();//display the score on the form 
            TmrBall.Enabled = true;//start the timer to move the balls
            TmrLadybug.Enabled = true;//start the timer to move the ladybug
        }

        private void MnuStop_Click(object sender, EventArgs e)
        {
            TmrBall.Enabled = false;
            TmrLadybug.Enabled = false;
        }

        private void FrmLadybug_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Use the up and down arrow keys to move the Ladybug.\n Don't get hit by the balls");
        }

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

        //the CheckLives method will stop the balls and ladybug from moving if there are no lives left
        //and a game over message will be displayed
        private void CheckLives()
        {
            if (lives == 0)
            {
                TmrBall.Enabled = false;
                TmrLadybug.Enabled = false;
                MessageBox.Show("Game Over");
            }
        }
    }
}

