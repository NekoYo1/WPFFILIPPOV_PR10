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

namespace WPFFILIPPOV_PR10
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

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
        }

        private void DeleteButtton_Click(object sender, RoutedEventArgs e)
        {
            listBox1.Items.Remove(textBox1.Text);
        }

        private void Sort_Click(object sender, RoutedEventArgs e)
        {
            listBox1.Items.SortDescriptions.Add(new System.ComponentModel.SortDescription("Content", System.ComponentModel.ListSortDirection.Ascending));
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            listBox1.Items.Remove(textBox1.Text);
        }
    }
}
