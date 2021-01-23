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

        // AC and .

        private void bntHandlerAC(object sender, RoutedEventArgs e)
        {

        }
        private void btnHandlerDecimal(object sender, RoutedEventArgs e)
        {

        }

        // Operators + - * /
        private void btnHandlerDivision(object sender, RoutedEventArgs e)
        {

        }

        private void btnHandlerMultiply(object sender, RoutedEventArgs e)
        {

        }

        private void btnHandlerAdd(object sender, RoutedEventArgs e)
        {

        }

        private void btnHandlerSubtract(object sender, RoutedEventArgs e)
        {

        }

        // Numbers 1-9

        private void btnHandlerNumber1(object sender, RoutedEventArgs e)
        {

        }

        private void btnHandlerNumber2(object sender, RoutedEventArgs e)
        {

        }

        private void btnHandlerNumber3(object sender, RoutedEventArgs e)
        {

        }

        private void btnHandlerNumber4(object sender, RoutedEventArgs e)
        {

        }

        private void btnHandlerNumber5(object sender, RoutedEventArgs e)
        {

        }

        private void btnHandlerNumber6(object sender, RoutedEventArgs e)
        {

        }

        private void btnHandlerNumber7(object sender, RoutedEventArgs e)
        {

        }

        private void btnHandlerNumber8(object sender, RoutedEventArgs e)
        {

        }

        private void btnHandlerNumber9(object sender, RoutedEventArgs e)
        {

        }

        private void btnHandlerNumber0(object sender, RoutedEventArgs e)
        {

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
