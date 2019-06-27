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
        //declare the rectangles to display the Ladybug and Balls in
        Rectangle area, area1, area2, area3, area4, area5, area6, area7;
        Random speed = new Random();
        int speed1;
        private void TmrBall_Tick(object sender, EventArgs e)
        {
            area1.X += speed1;// move the area(ball) across the panel 
            if (area.X > PnlGame.Width)
            {
                area1.X = 20;
            }
            PnlGame.Invalidate();//makes the paint event fire to redraw panel
        }

        int x2 = 540, y2 = 250; //starting position of Ladybug
        //Load our two images from the bin/debug folder
        Image ladybug = Image.FromFile(Application.StartupPath + @"/ladybug.png");
        Image ball1 = Image.FromFile(Application.StartupPath + @"/dragon.png");

        private void PnlGame_Paint(object sender, PaintEventArgs e)
        {
            //get the method from the graphic's class to paint on the panel
            g = e.Graphics;
            //use the DrawImage method to draw the ladybug on the panel 
            g.DrawImage(ladybug, area);
            //use the DrawImage method to draw the dragon on the panel
            g.DrawImage(ball1, area1);
            g.DrawImage(ball1, area2);
            g.DrawImage(ball1, area3);
            g.DrawImage(ball1, area4);
            g.DrawImage(ball1, area5);
            g.DrawImage(ball1, area6);
            g.DrawImage(ball1, area7);
        }

        
        public FrmLadybug()
        {
            InitializeComponent();
            area = new Rectangle(x2, y2, 30, 30); //Ladybug's rectangle
            area1 = new Rectangle(x, y, 20, 20); //ball1's rectangle
            area2 = new Rectangle(x + 70, y, 40, 40);//ball2's reactangle
            area3 = new Rectangle(x + 140, y, 40, 40);//ball3's rectangle
            area4 = new Rectangle(x + 210, y, 40, 40);//ball4's rectangle
            area5 = new Rectangle(x + 280, y, 40, 40);//ball5's rectangle
            area6 = new Rectangle(x + 350, y, 40, 40);//ball6's rectangle
            area7 = new Rectangle(x + 420, y, 40, 40);//ball7's rectangle
            speed1 = speed.Next(5, 10);//ball1's speed will be between 5 and 10
           
        }
    }
}
