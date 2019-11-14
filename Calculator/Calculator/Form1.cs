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
        Double resultValue;
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

        private void button_Equals_Click(object sender, EventArgs e)
        {
            switch (operator_Clicked)
            {
                case "+":
                    result_Box.Text = (resultValue + Double.Parse(result_Box.Text)).ToString();
                    break;
                case "-":
                    result_Box.Text = (resultValue - Double.Parse(result_Box.Text)).ToString();
                    break;
                case "x":
                    result_Box.Text = (resultValue * Double.Parse(result_Box.Text)).ToString();
                    break;
                case "/":
                    result_Box.Text = (resultValue / Double.Parse(result_Box.Text)).ToString();
                    break;
                default:
                    break;


            }
        }
    }
}
