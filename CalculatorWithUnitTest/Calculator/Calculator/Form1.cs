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
        String operationPerformed = "";
        bool isOperationPerormed = false;
        



        public Form1()
        {
            InitializeComponent();
        }
        
        public enum MathFunction
        {
            Plus, Minus, Multiply, Divide

        };

        MathFunction Operation;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_click(object sender, EventArgs e)
        {
            if ((textBox_Result.Text == "0") || (isOperationPerormed))
                textBox_Result.Clear();
            isOperationPerormed = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if(!textBox_Result.Text.Contains("."))
                    textBox_Result.Text = textBox_Result.Text + button.Text;
            }else
            textBox_Result.Text = textBox_Result.Text + button.Text;
        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Operation = MathFunction.Plus;


            if (resultValue != 0)
            {
                button23.PerformClick();
                operationPerformed = button.Text;
                labelCurrentOperation.Text = resultValue + " " + operationPerformed;
                isOperationPerormed = true;
            }
            else
            {
                operationPerformed = button.Text;
                resultValue = Double.Parse(textBox_Result.Text);
                labelCurrentOperation.Text = resultValue + " " + operationPerformed;
                isOperationPerormed = true;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
            resultValue = 0;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            

            switch (Operation)
            {
                case MathFunction.Plus:
                    textBox_Result.Text = (resultValue + Double.Parse(textBox_Result.Text)).ToString();
                    break;

                case MathFunction.Minus:
                    textBox_Result.Text = (resultValue - Double.Parse(textBox_Result.Text)).ToString();
                    break;

                case MathFunction.Multiply:
                    textBox_Result.Text = (resultValue * Double.Parse(textBox_Result.Text)).ToString();
                    break;

                case MathFunction.Divide:
                    textBox_Result.Text = (resultValue / Double.Parse(textBox_Result.Text)).ToString();
                    break;
            }
            resultValue = Double.Parse(textBox_Result.Text);
            labelCurrentOperation.Text = "";
        }

        private void textBox_Result_TextChanged(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Operation = MathFunction.Minus;


            if (resultValue != 0)
            {
                button23.PerformClick();
                operationPerformed = button.Text;
                labelCurrentOperation.Text = resultValue + " " + operationPerformed;
                isOperationPerormed = true;
            }
            else
            {
                operationPerformed = button.Text;
                resultValue = Double.Parse(textBox_Result.Text);
                labelCurrentOperation.Text = resultValue + " " + operationPerformed;
                isOperationPerormed = true;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Operation = MathFunction.Multiply;


            if (resultValue != 0)
            {
                button23.PerformClick();
                operationPerformed = button.Text;
                labelCurrentOperation.Text = resultValue + " " + operationPerformed;
                isOperationPerormed = true;
            }
            else
            {
                operationPerformed = button.Text;
                resultValue = Double.Parse(textBox_Result.Text);
                labelCurrentOperation.Text = resultValue + " " + operationPerformed;
                isOperationPerormed = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Operation = MathFunction.Divide;


            if (resultValue != 0)
            {
                button23.PerformClick();
                operationPerformed = button.Text;
                labelCurrentOperation.Text = resultValue + " " + operationPerformed;
                isOperationPerormed = true;
            }
            else
            {
                operationPerformed = button.Text;
                resultValue = Double.Parse(textBox_Result.Text);
                labelCurrentOperation.Text = resultValue + " " + operationPerformed;
                isOperationPerormed = true;
            }
        }
    }
}
