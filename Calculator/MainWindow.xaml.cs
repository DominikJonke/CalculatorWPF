using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public bool isClicked = false;
        public int firstNum = 0;
        public int secondNum = 0;
        public int result = 0;
        public char op = ' ';

        public MainWindow()
        {
            InitializeComponent();

            btnOne.Click += BtnCalculator_Click;
            btnTwo.Click += BtnCalculator_Click;
            btnThree.Click += BtnCalculator_Click;
            btnFour.Click += BtnCalculator_Click;
            btnFive.Click += BtnCalculator_Click;
            btnSix.Click += BtnCalculator_Click;
            btnSeven.Click += BtnCalculator_Click;
            btnEight.Click += BtnCalculator_Click;
            btnNine.Click += BtnCalculator_Click;
            btnZero.Click += BtnCalculator_Click;

            btnAddition.Click += BtnCalculator_Click;
            btnSubtraction.Click += BtnCalculator_Click;
            btnMultiplication.Click += BtnCalculator_Click;
            btnDivision.Click += BtnCalculator_Click;

            btnDelete.Click += BtnCalculator_Click;
            btnResult.Click += BtnCalculator_Click;
        }

        public void BtnCalculator_Click(object sender, RoutedEventArgs e)
        {
            Button getResult = (Button)sender;

            switch (getResult.Content.ToString())
            {
                #region Numbers

                case "1":
                    txtDisplay.Text = "1";

                    if (!isClicked)
                    {
                        firstNum = 1;
                        isClicked = true;
                    }
                    else
                    {
                        secondNum = 1;
                    }
                    break;

                case "2":
                    txtDisplay.Text = "2";

                    if (!isClicked)
                    {
                        firstNum = 2;
                        isClicked = true;
                    }
                    else
                    {
                        secondNum = 2;
                    }
                    break;

                case "3":
                    txtDisplay.Text = "3";

                    if (!isClicked)
                    {
                        firstNum = 3;
                        isClicked = true;
                    }
                    else
                    {
                        secondNum = 3;
                    }
                    break;

                case "4":
                    txtDisplay.Text = "4";
                    if (!isClicked)
                    {
                        firstNum = 4;
                        isClicked = true;
                    }
                    else
                    {
                        secondNum = 4;
                    }
                    break;

                case "5":
                    txtDisplay.Text = "5";
                    if (!isClicked)
                    {
                        firstNum = 5;
                        isClicked = true;
                    }
                    else
                    {
                        secondNum = 5;
                    }
                    break;

                case "6":
                    txtDisplay.Text = "6";
                    if (!isClicked)
                    {
                        firstNum = 6;
                        isClicked = true;
                    }
                    else
                    {
                        secondNum = 6;
                    }
                    break;

                case "7":
                    txtDisplay.Text = "7";
                    if (!isClicked)
                    {
                        firstNum = 7;
                        isClicked = true;
                    }
                    else
                    {
                        secondNum = 7;
                    }
                    break;

                case "8":
                    txtDisplay.Text = "8";
                    if (!isClicked)
                    {
                        firstNum = 8;
                        isClicked = true;
                    }
                    else
                    {
                        secondNum = 8;
                    }
                    break;

                case "9":
                    txtDisplay.Text = "9";
                    if (!isClicked)
                    {
                        firstNum = 9;
                        isClicked = true;
                    }
                    else
                    {
                        secondNum = 9;
                    }
                    break;

                case "0":
                    txtDisplay.Text = "0";
                    if (!isClicked)
                    {
                        firstNum = 0;
                        isClicked = true;
                    }
                    else
                    {
                        secondNum = 0;
                    }
                    break;
                #endregion

                #region Operators
                case "+":
                    txtDisplay.Text = "+";
                    op = '+';
                    break;
                case "-":
                    txtDisplay.Text = "-";
                    op = '-';
                    break;
                case "*":
                    txtDisplay.Text = "*";
                    op = '*';
                    break;
                case "/":
                    txtDisplay.Text = "/";
                    op = '/';
                    break;
                #endregion

                #region Delete and Result
                case "C":
                    txtDisplay.Text = "";
                    firstNum = 0;
                    secondNum = 0;
                    op = ' ';
                    isClicked = false;
                    break;
                case "=":

                    if(op == '+')
                    {
                        result = firstNum + secondNum;
                        txtDisplay.Text = result.ToString();
                    }

                    if (op == '-')
                    {
                        result = firstNum - secondNum;
                        txtDisplay.Text = result.ToString();
                    }

                    if (op == '*')
                    {
                        result = firstNum * secondNum;
                        txtDisplay.Text = result.ToString();
                    }

                    if (op == '/')
                    {
                        if(secondNum != 0)
                        {
                            result = firstNum / secondNum;
                            txtDisplay.Text = result.ToString();
                        }

                        else
                        {
                            txtDisplay.Text = "DIVIDE BY 0 ERROR";
                        }
                    }
                    break;
                    #endregion 
            }
        }
    }
}
