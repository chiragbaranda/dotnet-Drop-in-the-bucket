/*
 * I, CHIRAG BARANDA, student number 000759867, 
 * certify that all code submitted is my own work; 
 * that I have not copied it from any other source.  
 * I also certify that I have not allowed my work to be copied by others.
 * 
 * Author: Chirag Baranda
 * Student Number: 000759867
 * 
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5A
{
    public partial class Lab5A_form : Form
    {
        //defalut valeus for variales
        private Color c = Color.Blue;
        Graphics draw;
        Pen pen = new Pen(Color.White);
        private SolidBrush b;

        //properties for bucket filling water, x and y -axies , heiht and width 
        int x = 101, y = 396, w = 200, h = 4;

        //properties for water falinf from tap, x and y -axies , heiht and width 
        int x1 = 115, y1 = 200, w1 = 15 , h1 = 200;

        /// <summary>
        /// initalize form for some defult values
        /// </summary>
        public Lab5A_form()
        {
            InitializeComponent();
            this.Paint += new PaintEventHandler(paintForm);
        }


        /// <summary>
        /// color choosing on button click
        /// open color dilouge box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ColorButton_Click(object sender, EventArgs e)
        {
            cdlColorChooser.Color = c;                //Display with the previous colour already chosen
            cdlColorChooser.ShowDialog();             //Display the actual dialog box
            c = cdlColorChooser.Color;
        }


        /// <summary>
        /// exiting environment
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// drawing bucket
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void paintForm(object sender, PaintEventArgs e)
        {
            draw = e.Graphics;
            draw = this.CreateGraphics();
            b = new SolidBrush(c); //Color.YellowGreen
            draw.DrawLine(pen, 100, 290, 100, 400);
            draw.DrawLine(pen, 100, 400, 300, 400);
            draw.DrawLine(pen, 300, 400, 300, 290);
            //draw.Dispose();
        }

        /// <summary>
        /// control water falling from tap as per trackbar speed and eable and disavle the water falling/timer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void speedTrackBar_Scroll(object sender, EventArgs e)
        {
            draw = this.CreateGraphics();
            timer1.Enabled = true;
            timer1.Interval = 120 - speedTrackBar.Value * 10;
            if(h>80 && timer1.Enabled == false)
            {
                draw.FillRectangle(new SolidBrush(Color.Black), x, y, w, h);
            }
            
        }


        /// <summary>
        /// timer takes value from speed track bar and control water falling speed
        /// if the bucket is filled up, it stop pouring water in bucket from tap\and reset the bucket water to empty
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {
                //filled up bucket water
                draw.FillRectangle(b, x, y, w, h);
                
                //bucket filling watter
                draw.FillRectangle(b, x, y, w, h);

                y -= 1;
                h += 1;

                //drawing water falling from tap
                draw.FillRectangle(b, x1, y1, w1, h1);

                h1 -= 10;

                //when bucket is filled up, stop puring water from tap
                if (h > 80)
                {
                    draw.FillRectangle(new SolidBrush(Color.Black), x1, y1, w1, 120); //setting background to black so it seems container is empty
                    timer1.Enabled = false; //stop timer
                    speedTrackBar.Value = speedTrackBar.Minimum; //reset the speed to minimum

                }
            }
        }
                   
            
    }
}
