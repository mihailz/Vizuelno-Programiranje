using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CountriesList
{
    public partial class Form1 : Form
    {
        double value = 0;
        string operation = "";
        bool operation_pressed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((tbResult.Text == "0")||(operation_pressed))
                tbResult.Clear();

            operation_pressed = false;
            Button b = (Button)sender;
            tbResult.Text = tbResult.Text + b.Text;
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            tbResult.Text = "0";
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            value = Double.Parse(tbResult.Text);
            operation_pressed = true;
            lblResult.Text = value + " " + operation;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";
            switch (operation)
            {
                case "+":
                    tbResult.Text = (value + Double.Parse(tbResult.Text)).ToString();
                    break;
                case "-":
                    tbResult.Text = (value - Double.Parse(tbResult.Text)).ToString();
                    break;
                case "*":
                    tbResult.Text = (value * Double.Parse(tbResult.Text)).ToString();
                    break;
                case "/":
                    tbResult.Text = (value / Double.Parse(tbResult.Text)).ToString();
                    break;
                case "%":
                    tbResult.Text = (value % Double.Parse(tbResult.Text)).ToString();
                    break;
                default:
                    break;
            }// end switch
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            tbResult.Text = "0";
            value = 0;
        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }
    }
}
