using DocumentFormat.OpenXml.Vml;
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

namespace FeatureTextBoxAndDisplayWPF
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

        
       



        private void DisplayMessageBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            //string AddedText = "10101";
            //string newText = CreateMessageBox.Text + AddedText;
            //newText= DisplayMessageBox.Text;
            //var box = sender as ChangeText;

            //DisplayMessageBox.GetBindingExpression(TextBox.ChangeText).UpdateSource();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //string AddedText = "10101";
            string newText = CreateMessageBox.Text;
            DisplayMessageBox.Text = newText;

            string newText2 = CreateMessageBox.Text;
            DisplayMessageBox2.Text = newText;

            string newText3 = CreateMessageBox.Text;
            DisplayMessageBox3.Text = newText;

            string newText4 = CreateMessageBox.Text;
            DisplayMessageBox4.Text = newText;
        }

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    DisplayMessageBox.Text = CreateMessageBox.Text;


        //}
    }
}
