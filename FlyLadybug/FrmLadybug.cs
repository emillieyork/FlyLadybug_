﻿using System;
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
           for (int i=0; i < 7; i++)
            {
                area[i] = new Rectangle(x, y + 70 * i, 40, 40);
            }
            ballSpeed[i] = speed.Next(5, 10);
            //each ball has a random speed
        }
    }
}
