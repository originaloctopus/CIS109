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
        bool is_Operator_Clicked = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void click_button(object sender, EventArgs e)
        {
            if (result_Box.Text == "0" || (is_Operator_Clicked))
                result_Box.Clear();

            is_Operator_Clicked = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!result_Box.Text.Contains("."))
                    result_Box.Text = result_Box.Text + button.Text;
            }
            else
            {
                result_Box.Text = result_Box.Text + button.Text;
            }
            
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (resultValue != 0)
            {
                button_Equals.PerformClick();
                operator_Clicked = button.Text;
                is_Operator_Clicked = true;
            }
            else
            {
                operator_Clicked = button.Text;
                resultValue = Double.Parse(result_Box.Text);
                is_Operator_Clicked = true;
            }

        }


        private void button_Clear_Click(object sender, EventArgs e)
        {
            result_Box.Text = "0";
            resultValue = 0;
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
                case "×":
                    result_Box.Text = (resultValue * Double.Parse(result_Box.Text)).ToString();
                    break;
                case "÷":
                    result_Box.Text = (resultValue / Double.Parse(result_Box.Text)).ToString();
                    break;
                default:
                    break;


            }
        }

    }
}
