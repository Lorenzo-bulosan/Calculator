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

// calculator library
using CalculatorLib;

namespace CalculatorWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // = and .

        private void btnHandlerEquals(object sender, RoutedEventArgs e)
        {
            // get math expresion
            string mathematicalExpression = MathematicalExpressionScreen.Content.ToString();

            // try to evaluate
            try
            {
                double result = StaticCalculator.evaluateMathString(mathematicalExpression);
                ResultsScreen.Content = result;
            }
            catch (Exception ex)
            {
                ResultsScreen.Content = "Error";
                MessageBox.Show(ex.Message);
            }
            
            // reset screen
            MathematicalExpressionScreen.Content = "";
        }
        private void btnHandlerDecimal(object sender, RoutedEventArgs e)
        {
            string currentExpression = MathematicalExpressionScreen.Content.ToString();
            MathematicalExpressionScreen.Content = currentExpression + '.';
        }

        // Operators + - * /
        private void btnHandlerDivision(object sender, RoutedEventArgs e)
        {
            string currentExpression = MathematicalExpressionScreen.Content.ToString();
            MathematicalExpressionScreen.Content = currentExpression + '/';
        }

        private void btnHandlerMultiply(object sender, RoutedEventArgs e)
        {
            string currentExpression = MathematicalExpressionScreen.Content.ToString();
            MathematicalExpressionScreen.Content = currentExpression + '*';
        }

        private void btnHandlerAdd(object sender, RoutedEventArgs e)
        {
            string currentExpression = MathematicalExpressionScreen.Content.ToString();
            MathematicalExpressionScreen.Content = currentExpression + '+';
        }

        private void btnHandlerSubtract(object sender, RoutedEventArgs e)
        {
            string currentExpression = MathematicalExpressionScreen.Content.ToString();
            MathematicalExpressionScreen.Content = currentExpression + '-';
        }

        // Numbers 0-9

        private void btnHandlerNumber0(object sender, RoutedEventArgs e)
        {
            string currentExpression = MathematicalExpressionScreen.Content.ToString();
            MathematicalExpressionScreen.Content = currentExpression + '0';
        }

        private void btnHandlerNumber1(object sender, RoutedEventArgs e)
        {
            string currentExpression = MathematicalExpressionScreen.Content.ToString();
            MathematicalExpressionScreen.Content = currentExpression + '1';
        }

        private void btnHandlerNumber2(object sender, RoutedEventArgs e)
        {
            string currentExpression = MathematicalExpressionScreen.Content.ToString();
            MathematicalExpressionScreen.Content = currentExpression + '2';
        }

        private void btnHandlerNumber3(object sender, RoutedEventArgs e)
        {
            string currentExpression = MathematicalExpressionScreen.Content.ToString();
            MathematicalExpressionScreen.Content = currentExpression + '3';
        }

        private void btnHandlerNumber4(object sender, RoutedEventArgs e)
        {
            string currentExpression = MathematicalExpressionScreen.Content.ToString();
            MathematicalExpressionScreen.Content = currentExpression + '4';
        }

        private void btnHandlerNumber5(object sender, RoutedEventArgs e)
        {
            string currentExpression = MathematicalExpressionScreen.Content.ToString();
            MathematicalExpressionScreen.Content = currentExpression + '5';
        }

        private void btnHandlerNumber6(object sender, RoutedEventArgs e)
        {
            string currentExpression = MathematicalExpressionScreen.Content.ToString();
            MathematicalExpressionScreen.Content = currentExpression + '6';
        }

        private void btnHandlerNumber7(object sender, RoutedEventArgs e)
        {
            string currentExpression = MathematicalExpressionScreen.Content.ToString();
            MathematicalExpressionScreen.Content = currentExpression + '7';
        }

        private void btnHandlerNumber8(object sender, RoutedEventArgs e)
        {
            string currentExpression = MathematicalExpressionScreen.Content.ToString();
            MathematicalExpressionScreen.Content = currentExpression + '8';
        }

        private void btnHandlerNumber9(object sender, RoutedEventArgs e)
        {
            string currentExpression = MathematicalExpressionScreen.Content.ToString();
            MathematicalExpressionScreen.Content = currentExpression + '8';
        }



        //private void btnEnterHandler(object sender, RoutedEventArgs e)
        //{
        //    string mathematicalExpression = ResultsScreenTwo.Content.ToString();
        //    double result = StaticCalculator.evaluateMathString(mathematicalExpression); 
        //    MessageBox.Show($"{mathematicalExpression} = {result}");
        //}
        //private void ResultsScreen_TextHandler(object sender, TextChangedEventArgs e)
        //{
        //    ResultsScreenTwo.Content = $"{ResultsScreen.Text}";
        //}


    }
}
