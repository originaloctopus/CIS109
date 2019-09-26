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
//Rename the icons and the all the elements we've added to the game
namespace MatchingPairsGame
{
    public partial class FormMatchingPairsGame : Form
    {
        Random random = new Random();
        List<string> icons = new List<string>()
           {
                "!", "!", "q", "q", "?", "?", "zoodle", "zoodle",
                "N", "N","p", "p","x", "x", "9", "9"
            };

        Label firstClicked, secondClicked;

    public FormMatchingPairsGame()
        {
            
            InitializeComponent();
            AssignIconsToSquare();
        }

        private void label_Click(object sender, EventArgs e)
        {
            if (firstClicked != null && secondClicked != null)
                return;

            Label clickedLabel = sender as Label;

            if (clickedLabel == null)
                return;

            if (clickedLabel.ForeColor == Color.Black)
                return;

            if (firstClicked == null)
            {
                firstClicked = clickedLabel;
                firstClicked.ForeColor = Color.Black;
                return;

            }

            secondClicked = clickedLabel;
            secondClicked.ForeColor = Color.Black;

            CheckForWinner();


            if (firstClicked.Text == secondClicked.Text)
            {
                firstClicked = null;
                secondClicked = null;
            }
            else
                timer1.Start();

        }

        private void CheckForWinner()
        {
            Label label;
            for (int i = 0; i < tableLayoutPanel1.Controls.Count; i++)
            {
                label = tableLayoutPanel1.Controls[i] as Label;
                if (label != null && label.ForeColor == label.BackColor)
                    return;
            }

            MessageBox.Show("You matched everything, aren't you special?");
            
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();

            firstClicked.ForeColor = firstClicked.BackColor;
            secondClicked.ForeColor = secondClicked.BackColor;

            firstClicked = null;
            secondClicked = null;


        }

        private void AssignIconsToSquare()
        {
            Label label;
            int randomNumber;

          
                for (int i = 0; i < tableLayoutPanel1.Controls.Count; i++)
                {
                    if (tableLayoutPanel1.Controls[i] is Label)
                    {
                        randomNumber = random.Next(0, icons.Count);
                        randomNumber = random.Next(icons.Count);
                        label = (Label)tableLayoutPanel1.Controls[i];
                        label.Text = icons[randomNumber];
                        icons.RemoveAt(randomNumber);
                    }
                        
                    else
                        continue;

                    
                                   
                }
            
        }
    }
}
/*
{


};



private void Form1_Load(object sender, EventArgs e)
{

}

*/
