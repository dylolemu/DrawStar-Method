//Created by Dylon Lemus
//April 19, 2016
//Description: A program which draws a star in a location and size inputed. Also includes a method which can be used in any computer to draw the star.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Star : Form
    {
        public Star()
        {
            InitializeComponent();
        }
        float xVal;//location
        float yVal;//location
        float size;//lenght and width

        private void button1_Click(object sender, EventArgs e)
        {
            xVal = Convert.ToSingle(xBox.Text);
            yVal = Convert.ToSingle(yBox.Text);
            size = Convert.ToSingle(sizeBox.Text);
            xBox.Hide();
            yBox.Hide();
            sizeBox.Hide();
            label1.Hide();
            label2.Hide();
            Pen drawPen = new Pen(Color.Red, 2);
            DrawStar(drawPen,xVal,yVal,size);
        }

        /// <summary>
        /// This method draws a star of whatever size you want it, in whichever location you want it. 
        /// The color of the star as well as the thickness of the line is also customizable.
        /// </summary>
        /// <param name="drawPen">This is the pen that is used to draw the star.</param>
        /// <param name="x">This is the x-coordinate of the star.</param>
        /// <param name="y">This is the y-cordinate of the star.</param>
        /// <param name="size">This is the lenght and width of the star.</param>
        public void DrawStar(Pen drawPen,float x, float y, float size)
        {
            Graphics formGraphics = this.CreateGraphics();
            formGraphics.DrawLine(drawPen, x + size / 2, y, x + size * 383333 / 1000000, y + size * 329 / 1000);
            formGraphics.DrawLine(drawPen, x + size / 2, y, x + size * 60833 / 100000, y + size * 329 / 1000);
            formGraphics.DrawLine(drawPen, x, y + size * 329 / 1000, x + size * 383333 / 1000000, y + size * 329 / 1000);
            formGraphics.DrawLine(drawPen, x + size, y + size * 329 / 1000, x + size * 60833 / 100000, y + size * 329 / 1000);
            formGraphics.DrawLine(drawPen, x, y + size * 329 / 1000, x + size * 304166 / 1000000, y + size * 575 / 1000);
            formGraphics.DrawLine(drawPen, x + size, y + size * 329 / 1000, x + size * 6875 / 10000, y + size * 575 / 1000);
            formGraphics.DrawLine(drawPen, x + size * 170833 / 1000000, y + size, x + size * 304166 / 1000000, y + size * 575 / 1000);
            formGraphics.DrawLine(drawPen, x + size * 8291 / 10000, y + size, x + size * 6875 / 10000, y + size * 575 / 1000);
            formGraphics.DrawLine(drawPen, x + size * 170833 / 1000000, y + size, x + size / 2, y + size * 729 / 1000);
            formGraphics.DrawLine(drawPen, x + size * 8291 / 10000, y + size, x + size / 2, y + size * 729 / 1000);
        }

    }
}
