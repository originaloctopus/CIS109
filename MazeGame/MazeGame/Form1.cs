using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MazeGame
{
    public partial class Form1 : Form
    {
        System.Media.SoundPlayer startSoundPLayer = new System.Media.SoundPlayer(@"C:\Windows\Media\chord.wav");
        System.Media.SoundPlayer finishSoundPLayer = new System.Media.SoundPlayer(@"C:\Windows\Media\tada.wav");


        public Form1()
        {
            InitializeComponent();
            MoveToStart();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            int x = 0;
        }

        private void finishedLabel_MouseEnter(object sender, EventArgs e)
        {
            finishSoundPLayer.Play();
            MessageBox.Show("Congratulations!");
            Close();
        }
        private void MoveToStart()
        {
            startSoundPLayer.Play();
            Point startingPoint = panel1.Location;
            startingPoint.Offset(10, 10);
            Cursor.Position = PointToScreen(startingPoint);
        }

        private void wall_MouseEnter(object sender, EventArgs e)
        {
            MoveToStart();

        }

    }
}
