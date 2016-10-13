using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_App
{
    public partial class Form1 : Form
    {
        double value = 0; 
        string operation = "0";
        bool operation_pressed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((Result.Text == "0") || (operation_pressed = true))
                Result.Clear();

            Button b = (Button)sender;
            Result.Text = Result.Text + b.Text;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Result.Text = "0";
        }

        private void operatorClick(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            value = double.Parse(Result.Text);
            operation_pressed = true;
            equation3.Text = value + " " + operation;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            equation.Text = "";
            switch(operation)
            {
                case "+":
                    Result.Text = (value + double.Parse(Result.Text)).ToString();
                    break;
                case "-":
                    Result.Text = (value - double.Parse(Result.Text)).ToString();
                    break;
                case "*":
                    Result.Text = (value * double.Parse(Result.Text)).ToString();
                    break;
                case "/":
                    Result.Text = (value / double.Parse(Result.Text)).ToString();
                    break;
                default:
                    break;
            }
            operation_pressed = false;
            
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Result.Clear();
            value = 0;
           

        }

        private void equation3_Click(object sender, EventArgs e)
        {

        }
    }
}
