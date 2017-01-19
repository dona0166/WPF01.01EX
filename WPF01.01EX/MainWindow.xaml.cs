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

namespace WPF01._01EX
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            //string s1 = textBox.Text;
            //string s2 = textBox1.Text;
            //string s3 = textBox2.Text;
            string idiot = textBox3.Text;

            textBox3.Text = textBox.Text;
            textBox.Text = textBox1.Text;
            textBox1.Text = textBox2.Text;
            textBox2.Text = idiot;
        }


        private void button1_Click(object sender, RoutedEventArgs e)
        {
            //string s1 = textBox.Text;
            string idiot = textBox1.Text;
            //string s3 = textBox2.Text;
            //string s4 = textBox3.Text;

            textBox1.Text = textBox.Text;
            textBox.Text = textBox3.Text;
            textBox3.Text = textBox2.Text;
            textBox2.Text = idiot;
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = textBox1.Text = textBox2.Text = textBox3.Text = "";
        }
    }
}
