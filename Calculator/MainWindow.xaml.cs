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
        double result;
        double numberOne;
        double numberSecond;
        string clutchNumber;
        string operations;
        int countOperation;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void OneButton_Click(object sender, RoutedEventArgs e)
        {
            ClutchNumbers("1");
        }

        private void TwoButton_Click(object sender, RoutedEventArgs e)
        {
            ClutchNumbers("2");
        }

        private void ThreeButton_Click(object sender, RoutedEventArgs e)
        {
            ClutchNumbers("3");
        }

        private void FourButton_Click(object sender, RoutedEventArgs e)
        {
            ClutchNumbers("4");
        }

        private void FiveButton_Click(object sender, RoutedEventArgs e)
        {
            ClutchNumbers("5");
        }

        private void SixButton_Click(object sender, RoutedEventArgs e)
        {
            ClutchNumbers("6");
        }

        private void SevenButton_Click(object sender, RoutedEventArgs e)
        {
            ClutchNumbers("7");
        }

        private void EigthButton_Click(object sender, RoutedEventArgs e)
        {
            ClutchNumbers("8");
        }

        private void NineButton_Click(object sender, RoutedEventArgs e)
        {
            ClutchNumbers("9");
        }

        private void ZeroButton_Click(object sender, RoutedEventArgs e)
        {
            ClutchNumbers("0");
        }

        private void ClutchNumbers(string input)
        {
            clutchNumber += input;
            InputTextBlock.Text = clutchNumber;
        }

        private void PlusButton_Click(object sender, RoutedEventArgs e)
        {
            
            if (countOperation == 0)
            {
                countOperation++;
                result = GetNumber();
                operations = "+";
            }
            else 
            {
                countOperation++;
                result += GetNumber();
                operations = "+";
            }
            InputTextBlock.Text = result.ToString();
        }
        private void MinusButton_Click(object sender, RoutedEventArgs e)
        {
            if(result == 0 || countOperation == 0)
            {
                countOperation++;
                result = GetNumber();
            }
            else
            {
                countOperation++;
                result -= GetNumber();
            }
            operations = "-";
            InputTextBlock.Text = result.ToString();
        }
        private void MultiplicateButton_Click(object sender, RoutedEventArgs e)
        {
            if (result == 0 || countOperation == 0)
            {
                countOperation++;
                result = GetNumber();
            }
            else
            {
                countOperation++;
                result *= GetNumber();
            }
            operations = "*";
            InputTextBlock.Text = result.ToString();
        }
        private void DevisionButton_Click(object sender, RoutedEventArgs e)
        {
            numberOne = GetNumber();
            if (numberOne != 0)
            {
                if (result == 0 || countOperation == 0)
                {
                    countOperation++;
                    result = numberOne;
                }
                else
                {
                    countOperation++;
                    result /= numberOne;
                }
                operations = "/";
                InputTextBlock.Text = result.ToString();
            }
            else
            {
                MessageBox.Show($"На {numberSecond} ділити не можливо!");
            }
        }

        private Double GetNumber()
        {
            numberOne = double.Parse(InputTextBlock.Text);
            clutchNumber = "";
            InputTextBlock.Text = "";
            return numberOne;
        }

        private void EquelseButton_Click(object sender, RoutedEventArgs e)
        {
            numberSecond = int.Parse(InputTextBlock.Text);
            switch (operations)
            {
                case "+":
                    operations = "";
                    result += numberSecond;
                    ClearNumber();
                    InputTextBlock.Text = result.ToString();
                    break;
                case "-":
                    operations = "";
                    result -= numberSecond;
                    ClearNumber();
                    InputTextBlock.Text = result.ToString();
                    break;
                case "*":
                    operations = "";
                    result *= numberSecond;
                    ClearNumber();
                    InputTextBlock.Text = result.ToString();
                    break;
                case "/":
                    operations = "";
                    if (numberSecond != 0)
                    {
                        result /= numberSecond;
                        ClearNumber();
                        InputTextBlock.Text = result.ToString();
                        break;
                    }
                    else
                    {
                        MessageBox.Show($"На {numberSecond} ділити не можливо!");
                        break;
                    }
            }
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            numberOne = 0;
            numberSecond = 0;
            result = 0;
            countOperation = 0;
            clutchNumber = "";
            InputTextBlock.Text = "";
        }

        private void ClearNumber()
        {
            numberOne = 0;
            numberSecond = 0;
            countOperation = 0;
        }
    }
}
