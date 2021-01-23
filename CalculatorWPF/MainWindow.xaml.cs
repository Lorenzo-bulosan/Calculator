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
