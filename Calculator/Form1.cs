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

        //Declaring global variables

        string assignInput, firstInput, secondInput = "";
        double answer;
        char symbol;


        public Form1()
        {
            InitializeComponent();
        }

        private void oneBtn_Click(object sender, EventArgs e)
        {
            //First when a button is pressed clears an input
            calculatorDisplay.Text = "";
            assignInput += "1";
            calculatorDisplay.Text += assignInput;
        }

        private void twoBtn_Click(object sender, EventArgs e)
        {
            //First when a button is pressed clears an input
            calculatorDisplay.Text = "";
            assignInput += "2";
            calculatorDisplay.Text += assignInput;
        }

        private void threeBtn_Click(object sender, EventArgs e)
        {
            //First when a button is pressed clears an input
            calculatorDisplay.Text = "";
            assignInput += "3";
            calculatorDisplay.Text += assignInput;
        }

        private void fourBtn_Click(object sender, EventArgs e)
        {
            //First when a button is pressed clears an input
            calculatorDisplay.Text = "";
            assignInput += "4";
            calculatorDisplay.Text += assignInput;
        }

        private void fiveBtn_Click(object sender, EventArgs e)
        {
            //First when a button is pressed clears an input
            calculatorDisplay.Text = "";
            assignInput += "5";
            calculatorDisplay.Text += assignInput;
        }

        private void sixBtn_Click(object sender, EventArgs e)
        {
            //First when a button is pressed clears an input
            calculatorDisplay.Text = "";
            assignInput += "6";
            calculatorDisplay.Text += assignInput;
        }

        private void sevenBtn_Click(object sender, EventArgs e)
        {
            //First when a button is pressed clears an input
            calculatorDisplay.Text = "";
            assignInput += "7";
            calculatorDisplay.Text += assignInput;
        }

        private void eightBtn_Click(object sender, EventArgs e)
        {
            //First when a button is pressed clears an input
            calculatorDisplay.Text = "";
            assignInput += "8";
            calculatorDisplay.Text += assignInput;
        }

        private void nineBtn_Click(object sender, EventArgs e)
        {
            //First when a button is pressed clears an input
            calculatorDisplay.Text = "";
            assignInput += "9";
            calculatorDisplay.Text += assignInput;
        }

        private void zeroBtn_Click(object sender, EventArgs e)
        {
            //First when a button is pressed clears an input
            calculatorDisplay.Text = "";
            assignInput += "0";
            calculatorDisplay.Text += assignInput;
        }

        private void decimalBtn_Click(object sender, EventArgs e)
        {
            //First when a button is pressed clears an input
            calculatorDisplay.Text += ".";
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            symbol = '+';

            //stores the assignInput in firstInput
            firstInput = assignInput;
            assignInput = "";
        }

        private void subtractBtn_Click(object sender, EventArgs e)
        {
            symbol = '-';

            //stores the assignInput in firstInput
            firstInput = assignInput;
            assignInput = "";
        }

        private void divideBtn_Click(object sender, EventArgs e)
        {
            symbol = '/';

            //stores the assignInput in firstInput
            firstInput = assignInput;
            assignInput = "";
        }

        private void multiplyBtn_Click(object sender, EventArgs e)
        {
            symbol = '*';

            //stores the assignInput in firstInput
            firstInput = assignInput;
            assignInput = "";
        }

      

        private void equals_Click(object sender, EventArgs e)
        {
            secondInput = assignInput;

            double firstNo, secondNo;

            //Parsing the first and second input
            firstNo = Convert.ToDouble(firstInput);
            secondNo=Convert.ToDouble(secondInput);
             
            if (symbol == '+')
            {
                answer = firstNo + secondNo;
                //Parsing to string
                calculatorDisplay.Text = answer.ToString();
            }
            else if (symbol == '-')
            {
                answer = firstNo - secondNo;
                //Parsing to string
                calculatorDisplay.Text = answer.ToString();
            }
            else if (symbol == '*')
            {
                answer = firstNo * secondNo;
                //Parsing to string
                calculatorDisplay.Text = answer.ToString();
            }
            else if (symbol == '/')
            {
                if(secondNo == '0')
                {
                    calculatorDisplay.Text = "Error";
                }
                else
                {
                    answer = firstNo / secondNo;

                    //Parsing to string
                    calculatorDisplay.Text = answer.ToString();

                }
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "0";
            assignInput = "";
            firstInput = "";
            secondInput = "";
        }
    }
}
