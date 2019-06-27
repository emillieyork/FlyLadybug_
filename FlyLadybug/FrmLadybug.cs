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
        Image ball = Image.FromFile(Application.StartupPath + @"/dragon.png");

        private void PnlGame_Paint(object sender, PaintEventArgs e)
        {
            //get the method from the graphic's class to paint on the panel
            g = e.Graphics;
            //use the DrawImage method to draw the ladybug on the panel 
            g.DrawImage(ladybug, area);
            //use the DrawImage method to draw the dragon on the panel
            g.DrawImage(ball, area1);
           
        }

        
        public FrmLadybug()
        {
            InitializeComponent();
            area = new Rectangle(x2, y2, 30, 30); //Ladybug's rectangle
            area1 = new Rectangle(x, y, 20, 20); //ball's rectangle
            speed1 = speed.Next(5, 10);//ball's speed will be between 5 and 10
           
        }
    }
}
