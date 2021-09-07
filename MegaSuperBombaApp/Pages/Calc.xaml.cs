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

namespace MegaSuperBombaApp.Pages
{
    /// <summary>
    /// Логика взаимодействия для Calc.xaml
    /// </summary>
    public partial class Calc : Page
    {
        public Calc()
        {
            InitializeComponent();
        }

        // need to maximize and getting winodw back to normal 
        bool maximized = false;

        string value;

        // Used to clear gritting from textbox
        bool beenPressedAnyButton = false;


        double result;
        double currentNumber;

        bool beenAssigned = false;

        bool beenDoneOperations = false;

        char lastOperation;

        bool beenUsedDote = false;

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            if (beenPressedAnyButton == false)
            {
                value = "";

                value = value + "1";
                TextNumbers.Text = value;
                beenPressedAnyButton = true;
                beenAssigned = true;
            }

            else
            {
                value = value + "1";
                TextNumbers.Text = value;
                beenAssigned = true;

            }
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            if (beenPressedAnyButton == false)
            {
                value = "";

                value = value + "2";
                TextNumbers.Text = value;
                beenPressedAnyButton = true;
                beenAssigned = true;

            }

            else
            {
                value = value + "2";
                TextNumbers.Text = value;
                beenAssigned = true;

            }
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            if (beenPressedAnyButton == false)
            {
                value = "";

                value = value + "3";
                TextNumbers.Text = value;
                beenPressedAnyButton = true;
                beenAssigned = true;

            }

            else
            {
                value = value + "3";
                TextNumbers.Text = value;
                beenAssigned = true;

            }
        }

        private void btnDevision_Click(object sender, RoutedEventArgs e)
        {
            if (beenAssigned == false)
            {
                value = "First input value you are adding to";
                TextNumbers.Text = value;

            }
            else
            {
                if (beenDoneOperations == false)
                {
                    result = Double.Parse(value);
                    beenDoneOperations = true;
                    value = "";
                    lastOperation = '/';
                    beenUsedDote = false;
                }
                else
                {

                    lastOperation = '/';
                    value = "";
                    beenUsedDote = false;
                }
            }
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            if (beenPressedAnyButton == false)
            {
                value = "";

                value = value + "4";
                TextNumbers.Text = value;
                beenPressedAnyButton = true;
                beenAssigned = true;

            }

            else
            {
                value = value + "4";
                TextNumbers.Text = value;
                beenAssigned = true;
            }
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            if (beenPressedAnyButton == false)
            {
                value = "";

                value = value + "5";
                TextNumbers.Text = value;
                beenPressedAnyButton = true;
                beenAssigned = true;

            }

            else
            {
                value = value + "5";
                TextNumbers.Text = value;
                beenAssigned = true;
            }
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            if (beenPressedAnyButton == false)
            {
                value = "";

                value = value + "6";
                TextNumbers.Text = value;
                beenAssigned = true;
                beenPressedAnyButton = true;
            }

            else
            {
                value = value + "6";
                TextNumbers.Text = value;
                beenAssigned = true;
            }
        }

        private void btnMultiply_Click(object sender, RoutedEventArgs e)
        {
            if (beenAssigned == false)
            {
                value = "First input value you are adding to";
                TextNumbers.Text = value;

            }
            else
            {
                if (beenDoneOperations == false)
                {
                    result = float.Parse(value);
                    beenDoneOperations = true;
                    value = "";
                    lastOperation = '*';
                    beenUsedDote = false;
                }
                else
                {

                    lastOperation = '*';
                    value = "";
                    beenUsedDote = false;
                }
            }
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            if (beenPressedAnyButton == false)
            {
                value = "";

                value = value + "7";
                TextNumbers.Text = value;
                beenPressedAnyButton = true;
                beenAssigned = true;
            }

            else
            {
                value = value + "7";
                TextNumbers.Text = value;
                beenAssigned = true;
            }
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            if (beenPressedAnyButton == false)
            {
                value = "";

                value = value + "8";
                TextNumbers.Text = value;
                beenPressedAnyButton = true;
                beenAssigned = true;
            }

            else
            {
                value = value + "8";
                TextNumbers.Text = value;
                beenAssigned = true;
            }
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            if (beenPressedAnyButton == false)
            {
                value = "";

                value = value + "9";
                TextNumbers.Text = value;
                beenPressedAnyButton = true;
                beenAssigned = true;
            }

            else
            {
                value = value + "9";
                TextNumbers.Text = value;
                beenAssigned = true;
            }
        }

        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            if (beenAssigned == false)
            {
                value = "First input value you are adding to";
                TextNumbers.Text = value;

            }
            else
            {
                if (beenDoneOperations == false)
                {
                    result = Double.Parse(value);
                    beenDoneOperations = true;
                    value = "";
                    lastOperation = '+';
                    beenUsedDote = false;

                }
                else
                {

                    lastOperation = '+';
                    value = "";
                    beenUsedDote = false;

                }
            }
        }

        private void btnDote_Click(object sender, RoutedEventArgs e)
        {
            if (beenPressedAnyButton != false)
            {

                if (beenUsedDote == false)
                {
                    value = value + ",";
                    TextNumbers.Text = value;
                    beenUsedDote = true;
                }
                else
                {

                }


            }
            else
            {

                TextNumbers.Text = "Can't start frome dote";
            }


        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            if (beenPressedAnyButton == false)
            {
                value = "";

                value = value + "0";
                TextNumbers.Text = value;
                beenPressedAnyButton = true;
            }

            else
            {
                value = value + "0";
                TextNumbers.Text = value;

            }
        }

        private void btnEqual_Click(object sender, RoutedEventArgs e)
        {
            switch (lastOperation)
            {
                case '+':
                    currentNumber = Double.Parse(value);
                    result = result + currentNumber;
                    TextNumbers.Text = result.ToString();
                    beenUsedDote = false;

                    break;

                case '-':
                    currentNumber = Double.Parse(value);
                    result = result - currentNumber;
                    TextNumbers.Text = result.ToString();
                    beenUsedDote = false;

                    break;

                case '*':
                    currentNumber = Double.Parse(value);
                    result = result * currentNumber;
                    TextNumbers.Text = result.ToString();
                    beenUsedDote = false;

                    break;

                case '/':
                    currentNumber = Double.Parse(value);
                    if (currentNumber != 0)
                    {
                        result = result / currentNumber;
                        TextNumbers.Text = result.ToString();
                        beenUsedDote = false;

                        break;
                    }
                    else
                    {
                        MessageBox.Show("Can't devide by 0");
                        value = "";
                        TextNumbers.Text = "Input another value!";
                        beenPressedAnyButton = false;
                        beenUsedDote = false;

                    }
                    break;

                    beenUsedDote = false;


            }
        }

        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {
            if (beenAssigned == false)
            {
                value = "First input value you are adding to";
                TextNumbers.Text = value;

            }
            else
            {
                if (beenDoneOperations == false)
                {
                    result = Double.Parse(value);
                    beenDoneOperations = true;
                    value = "";
                    lastOperation = '-';
                }
                else
                {

                    lastOperation = '-';
                    value = "";
                }
            }
        }

        private void TextNumbers_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
