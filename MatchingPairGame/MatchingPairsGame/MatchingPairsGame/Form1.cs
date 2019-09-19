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

    public FormMatchingPairsGame()
        {
            
         
            InitializeComponent();
            AssignIconsToSquare();
        }

        private void AssignIconsToSquare()
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;
                if (iconLabel != null)
                {
                    int randomNumber = random.Next(icons.Count);
                    iconLabel.Text = icons[randomNumber];

                    icons.RemoveAt(randomNumber);


                    };
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
