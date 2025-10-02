using System;
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
        public Form1()
        {
            InitializeComponent();
        }

        double firstNumber = 0;
        double secondNumber = 0;
        string operation = "";
        bool isOperationPressed = false;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_1_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "1";
        }

        private void button1_Click(object sender, EventArgs e)  // i have no idea why i have button1_Click and button1_Click_1 when i was removing it was throwing error
                                                                // so i just left like that
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void bt_2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "2";
        }

        private void bt_3_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "3";
        }

        private void bt_4_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "4";
        }

        private void bt_5_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "5";
        }

        private void bt_6_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "6";
        }

        private void bt_7_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "7";
        }

        private void bt_8_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "8";
        }

        private void bt_9_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "9";
        }

        private void bt_0_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "0";
        }

        private void bt_3_Click_1(object sender, EventArgs e)
        {
            txtDisplay.Text += "3";
        }

        private void bt_dot_Click(object sender, EventArgs e)
        {
            if (!txtDisplay.Text.Contains("."))
            {
                txtDisplay.Text += ".";
            }
        }

        private void bt_c_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "";
            label1.Text = "";
            firstNumber = 0;
            secondNumber = 0;
            operation = "";
            isOperationPressed = false;
        }

        private void bt_CE_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 0)
            {
                txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1);
            }
        }

        private void bt_plus_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDisplay.Text != "")
                {
                    label1.Text = "+";
                    firstNumber = Convert.ToDouble(txtDisplay.Text);
                    operation = "+";
                    isOperationPressed = true;
                    txtDisplay.Text = firstNumber.ToString() + " + ";
                }
            }
            catch
            {
                MessageBox.Show("Invalid input for addition.");
            }
        }

        private void bt_minus_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDisplay.Text != "")
                {
                    label1.Text = "-";
                    firstNumber = Convert.ToDouble(txtDisplay.Text);
                    operation = "-";
                    isOperationPressed = true;
                    txtDisplay.Text = firstNumber.ToString() + " - ";
                }
            }
            catch
            {
                MessageBox.Show("Invalid input for subtraction.");
            }
        }

        private void bt_star_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDisplay.Text != "")
                {
                    label1.Text = "*";
                    firstNumber = Convert.ToDouble(txtDisplay.Text);
                    operation = "*";
                    isOperationPressed = true;
                    txtDisplay.Text = firstNumber.ToString() + " * ";
                    

                }
            }
            catch
            {
                MessageBox.Show("Invalid input for multiplication.");
            }
          
        }

        private void bt_divide_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDisplay.Text != "")
                {
                    label1.Text = "/";
                    firstNumber = Convert.ToDouble(txtDisplay.Text);
                    operation = "/";
                    isOperationPressed = true;
                    txtDisplay.Text = firstNumber.ToString() + " / ";
                }
            }
            catch
            {
                MessageBox.Show("Invalid input for division.");
            }
        }

        private string GetSecondOperandText()
        {
            int index = txtDisplay.Text.LastIndexOfAny(new char[] { '+', '-', '*', '/' });
            if (index >= 0 && index < txtDisplay.Text.Length - 1)
            {
                return txtDisplay.Text.Substring(index + 1).Trim();
            }
            return txtDisplay.Text;
        }

        private void bt_equal_Click(object sender, EventArgs e)
        {
            try
            {
                string secondOperandText = GetSecondOperandText();

                if (double.TryParse(secondOperandText, out double parsedSecondNumber))
                {
                    if (secondNumber == 0 || isOperationPressed)
                    {
                        secondNumber = parsedSecondNumber;
                    }

                    switch (operation)
                    {
                        case "+":
                            
                            firstNumber += secondNumber;
                            label1.Text = "";
                            break;
                        case "-":
                            firstNumber -= secondNumber;
                            break;
                            label1.Text = "";
                        case "*":
                            firstNumber *= secondNumber;
                            label1.Text = "";
                            break;
                        case "/":
                            if (secondNumber != 0) 
                            { 
                                label1.Text = "";
                                firstNumber /= secondNumber;
                            }

                            else
                            {
                                MessageBox.Show("Cannot divide by zero.");
                                label1.Text = "";
                                return;
                            }
                            break;
                        default:
                            return;
                    }

                    txtDisplay.Text = firstNumber.ToString();
                    isOperationPressed = false;
                }
                else
                {
                    MessageBox.Show("Invalid second operand.");
                }
            }
            catch
            {
                MessageBox.Show("An error occurred during calculation.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bt_root_Click(object sender, EventArgs e)
        {

        }
    }
}
