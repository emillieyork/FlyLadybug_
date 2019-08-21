using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace FlyLadybug
{
    public partial class FrmLadybug : Form
    {
        Graphics g; //declare the graphics object
        int x = 14, y = 14; //start position of ball
        //declare a rectangle to contain the ladybug and an area array to contain the balls
        Rectangle arealadybug;
        Rectangle[] area = new Rectangle[10]; //area[0] to area [9]
        Random speed = new Random();
        int[] ballSpeed = new int[10];
        bool Up, Down, left, right;
        int score = 0;
        int lives;
        int x2 = 540, y2 = 250; //starting position of Ladybug
        //Load our two images from the bin/debug folder
        Image ladybug = Image.FromFile(Application.StartupPath + @"/ladybug.png");
        Image ball1 = Image.FromFile(Application.StartupPath + @"/dragon.png");

        private void TmrBall_Tick(object sender, EventArgs e)
        {
           for(int i=0;i<=9;i++)
           {
                area[i].X += ballSpeed[i];
                //if ladybug collides with any ball add 3 points and move ball to the top of the panel
                if (area[i].IntersectsWith(arealadybug))
                {
                    area[i].X = 20;
                    score += 5;// add 5 to score
                    LblScore.Text = score.ToString();//display score on the form
                }
                if(area[i].X > PnlGame.Width)
                {
                    score -= 1;// subtract 1 from score
                    LblScore.Text = score.ToString();//display score on the form
                    area[i].X = 20;
                }
           }
           if (score > 10)
           {
                TmrBall.Interval = 60;
           }

           if (score > 20)
           {
                TmrBall.Interval = 50;
           }

           if (score > 30)
           {
                TmrBall.Interval = 47;
           }

           if (score > 40)
           {
                TmrBall.Interval = 44;
           }

           if (score > 50)
           {
                TmrBall.Interval = 42;
           }

           if (score > 60)
           {
                TmrBall.Interval = 40;
           }

           if (score > 70)
           {
                TmrBall.Interval = 37;
           }

           if (score > 80)
           {
                TmrBall.Interval = 36;
           }

           if (score > 90)
           {
                TmrBall.Interval = 35;
           }

           if (score > 100)
           {
                TmrBall.Interval = 34;
           }

           if (score > 110)
           {
                TmrBall.Interval = 33;
           }

           if (score > 120)
           {
                TmrBall.Interval = 32;
           }

           if (score > 130)
           {
                TmrBall.Interval = 31;
           }

           if (score > 140)
           {
                TmrBall.Interval = 30;
           }

           if (score > 150)
           {
                TmrBall.Interval = 29;
           }

           if (score > 160)
           {
                TmrBall.Interval = 28;
           }

           if (score > 170)
           {
                TmrBall.Interval = 27;
           }

           if (score > 180)
           {
                TmrBall.Interval = 26;
           }

           if (score > 190)
           {
                TmrBall.Interval = 25;
           }

           if (score > 200)
           {
                TmrBall.Interval = 24;
           }

           if (score > 210)
           {
                TmrBall.Interval = 23;
           }

           if (score > 220)
           {
                TmrBall.Interval = 22;
           }

           if (score > 230)
           {
                TmrBall.Interval = 21;
           }

           if (score > 240)
           {
                TmrBall.Interval = 20;
           }

           if (score > 250)
           {
                TmrBall.Interval = 19;
           }

           if (score > 260)
           {
                TmrBall.Interval = 18;
           }

           if (score > 270)
           {
                TmrBall.Interval = 17;
           }

           if (score > 280)
           {
                TmrBall.Interval = 16;
           }

           if (score > 290)
           {
                TmrBall.Interval = 15;
           }

           if (score > 300)
           {
                TmrBall.Interval = 14;
           }

           if (score > 310)
           {
                TmrBall.Interval = 13;
           }

           if (score > 320)
           {
                TmrBall.Interval = 12;
           }

           if (score > 330)
           {
                TmrBall.Interval = 11;
           }

           if (score > 340)
           {
                TmrBall.Interval = 10;
           }

           if (score > 350)
           {
                TmrBall.Interval = 9;
           }

           if (score > 360)
           {
                TmrBall.Interval = 8;
           }

           if (score > 370)
           {
                TmrBall.Interval = 7;
           }

           if (score > 380)
           {
                TmrBall.Interval = 6;
           }

           if (score > 390)
           {
                TmrBall.Interval = 5;
           }

           if (score > 400)
           {
                TmrBall.Interval = 4;
           }

           if (score > 410)
           {
                TmrBall.Interval = 3;
           }

           if (score > 420)
           {
                TmrBall.Interval = 2;
           }

           if (score > 430)
           {
                TmrBall.Interval = 1;
           }

            PnlGame.Invalidate();//makes the paint event fire to redraw panel
        }

        private void FrmLadybug_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Up)
            {
                Up = true;
            }
            if (e.KeyData == Keys.Down)
            {
                Down = true;
            }
            if (e.KeyData == Keys.Left)
            {
                left = true;
            }
            if (e.KeyData == Keys.Right)
            {
                right = true;
            }
        }

        private void FrmLadybug_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Up)
            {
                Up = false;
            }
            if (e.KeyData == Keys.Down)
            {
                Down = false;
            }
            if (e.KeyData == Keys.Left)
            {
                left = false;
            }
            if (e.KeyData == Keys.Right)
            {
                right = false;
            }
        }

        private void TmrLadybug_Tick(object sender, EventArgs e)
        {
            if (Up) //if up key pressed 
            {
                if (arealadybug.Y < 10)//check to see is ladybug within 10 of top
                {
                    arealadybug.Y = 10;
                }
                else
                {
                    arealadybug.Y -= 5;
                }
            }
            if (Down) //if down key pressed 
            {
                if(arealadybug.Y > PnlGame.Height - 40)//is ladybug within 40 of down side 
                {
                    arealadybug.Y = PnlGame.Height - 40;
                }
                else
                {
                    arealadybug.Y += 5;
                }
            }
            if (left) //if left key pressed
            {
                if(arealadybug. X < 10)//check to see is ladybug within 10 of left side
                {
                    arealadybug.X = 10;
                    //if it is < 10 away "bounce" it (set position ar 10)
                }
                else
                {
                    arealadybug.X -= 5;
                    //else move 5 to the left
                }
            }
            if (right) //if right key pressed
            {
                if (arealadybug.X > PnlGame.Width - 40) //is lady bug within 10 of right side
                {
                    arealadybug.X = PnlGame.Width - 40;
                }
                else
                {
                    arealadybug.X += 5;
                }
            }
        }

        private void MnuStart_Click(object sender, EventArgs e)
        {
            lives = int.Parse(Txtlives.Text);
            score = 0;//when game starts set the score to 0
            LblScore.Text = score.ToString();//display the score on the form 
            TmrBall.Enabled = true;//start the timer to move the balls
            TmrLadybug.Enabled = true;//start the timer to move the ladybug
            score = 0;
        }

        private void MnuStop_Click(object sender, EventArgs e)
        {
            TmrBall.Enabled = false;
            TmrLadybug.Enabled = false;
        }

        private void FrmLadybug_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Use the arrow keys to move the Ladybug up, down, left and right to avoid the balls! \nEvery ball you dodge scores a point. \nIf a ball hits the Ladybug a life lost! \nTo start the game enter your name (must be letters) and amount of lives (reccomened between 5 and 10).Then push start\nBe aware the game will speed up as it goes on. ", "Game Instructions");
        }

        private void TxtName_TextChanged(object sender, EventArgs e)
        {
            string context = TxtName.Text;
            bool isletter = true;
            //for loop checks for letters as charactes are entered
            for (int i = 0; i < context.Length; i++)
            {
                if (!char.IsLetter(context[i]))//if current character not a letter 
                {
                    isletter = false;//make isletter false 
                    break; //exit the for loop
                }
            }

            //if not a letter clear the textbox and focus on it 
            //to enter name again
            if (isletter == false)
            {
                TxtName.Clear();
                TxtName.Focus();
            }
            else
            {
                MnuStart.Enabled = true;
            }
        }

        private void Txtlives_TextChanged(object sender, EventArgs e)
        {
            string context = Txtlives.Text;
            bool isnumber = true;
            //for loop checks for numbers as characters are entered
            for (int i = 0; i < context.Length; i++)
            {
                if (!char.IsNumber(context[i]))//if current character not a number
                {
                    isnumber = false;//make isnumber false
                    break; //exit the for loop
                }
            }
            //if not a number clear the textbox and focus on it
            //to enter lives again
            if (isnumber == false)
            {
                Txtlives.Clear();
                Txtlives.Focus();
            }
        }

        private void PnlGame_Paint(object sender, PaintEventArgs e)
        {
            //get the method from the graphic's class to paint on the panel
            g = e.Graphics;
            //use the DrawImage method to draw the ladybug on the panel 
            g.DrawImage(ladybug, arealadybug);
            //use the DrawImage method to draw the ball on the panel
            for (int i=0;i<10;i++)
            {
                g.DrawImage(ball1, area[i]);
            }
        }
        public FrmLadybug()
        {
            InitializeComponent();
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic, null, PnlGame, new object[] { true });
            arealadybug = new Rectangle(x2, y2, 30, 30);//ladybugs rectangle 
                                                        //position the balls
            for (int i = 0; i < 10; i++)
            {
                area[i] = new Rectangle(x, y + 39 * i, 17, 17);

                ballSpeed[i] = speed.Next(4, 10);
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
