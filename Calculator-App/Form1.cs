using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private double currentValue = 0;
        private string currentOperation = "";
        private bool operationInProgress = false;
        private bool newEquation = true;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void NumBtn_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (textBox1.Text == "0" || operationInProgress || newEquation)
            {
                textBox1.Text = button.Text;
                operationInProgress = false;
                newEquation = false;
            } else
            {
                textBox1.Text += button.Text;
            }
        }

        private void OpBtn_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (!operationInProgress && currentOperation != "")
            {
                Calculate();
            }


            currentValue = double.Parse(textBox1.Text);
            currentOperation = button.Text;
            operationInProgress = true;

        }

        private void EqualBtn_Click(object sender, EventArgs e)
        {
            Calculate();
            currentOperation = "";
            newEquation = true;
            operationInProgress = false;
        }

        private void Calculate()
        {
            double value = double.Parse(textBox1.Text);

            switch(currentOperation)
            {
                case "+":
                    currentValue += value;
                    break;
                case "-":
                    currentValue -= value;
                    break;
                case "*":
                    currentValue *= value;
                    break;
                case "/":
                    if (value != 0)
                        currentValue /= value;
                    else
                        throw new DivideByZeroException();
                    break;
            }

            textBox1.Text = currentValue.ToString();
        }

        private void ClearBtn_Click(object sender, EventArgs args)
        {
            textBox1.Text = "0";
            currentValue = 0;
            currentOperation = "";
            newEquation = true;
            operationInProgress = false;
        }

        private void DecimalBtn_Click(object obj, EventArgs args)
        {
            if (!textBox1.Text.Contains("."))
            {
                textBox1.Text += ".";
            }
        }

    }
}
