using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenSaverApp
{
    public partial class formScreenSaver : Form
    {
        List<Image> BGImages = new List<Image>();
        List<BritPic> BritPics = new List<BritPic>();
        Random rand = new Random();

        class BritPic
        {
            public int PicNum;
            public float X;
            public float Y;
            public float Speed;
        }

        public formScreenSaver()
        {
            InitializeComponent();
        }

        private void formScreenSaver_KeyDown(object sender, KeyEventArgs e)
        {
            Close();
        }

        private void formScreenSaver_Load(object sender, EventArgs e)
        {
            string[] images = System.IO.Directory.GetFiles("Pics");

            foreach (string image in images)
            {
                BGImages.Add(new Bitmap(image));
            }

            for (int i = 0; i < 100; ++i)
            {
                BritPic np = new BritPic();
                np.PicNum = i % BGImages.Count;
                np.X = rand.Next(0, Width);
                np.Y = rand.Next(0, Height);

                BritPics.Add(np);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Refresh();
        }

        private void formScreenSaver_Paint(object sender, PaintEventArgs e)
        {
            foreach (BritPic bp in BritPics)
            {
                e.Graphics.DrawImage(BGImages[bp.PicNum], bp.X, bp.Y);

                if (bp.X < -250)
                {
                    bp.X = Width + rand.Next(20, 100);
                }
            }
        }

    }

}