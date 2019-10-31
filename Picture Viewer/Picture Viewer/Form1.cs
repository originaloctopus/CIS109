/* Jeremy Page
 * Reno Technology Academy
 * CIS109: Coding in C# for Imbedded System
 * Udemy: 17 Beginner C# Walkthrough Projects Step By Step
 * Project 1: Create a Matching Pairs Icon Image Game
 * */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Picture_Viewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
            //will close the form
        }

        private void setBackgroundButton_Click(object sender, EventArgs e)
        {
            //Show the color dialog box. If the user clicks OK, change the Picturebox control's backgroud to the color the user chose.
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                pictureBox1.BackColor = colorDialog1.Color;
        }

        private void clearPicButton_Click(object sender, EventArgs e)
        {
            //Will clear the picture.
            pictureBox1.Image = null; //null = empty
        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            /*Shows the open file dialog. If the user clicks okay the picture user selected will be loaded
              
            */
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            /* If the user selects the Streth check box,
               change the picturebox's sizemode propertry to stretch. If the user clears the checkbox, change it to normal.
               
            */
            if (checkBox1.Checked)
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            else 
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
        }
    }
}
