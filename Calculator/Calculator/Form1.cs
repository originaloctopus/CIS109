using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        Double resultValue = 0;
        string operator_Clicked = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void click_button(object sender, EventArgs e)
        {
            if (result_Box.Text == "0")
                result_Box.Clear();


            Button button = (Button)sender;
            result_Box.Text = result_Box.Text + button.Text;
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operator_Clicked = button.Text;
            resultValue = Double.Parse(resultValue.Text);
        }
    }
}
