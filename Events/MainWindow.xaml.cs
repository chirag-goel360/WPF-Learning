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

namespace Events
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Button was Clicked - Direct Event");
        }

        private void Button_MouseUp(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Mouse Button went Up - Bubbling Event");
        }

        private void Button_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Mouse Button went Up - Tunneling Event");
        }

        private void Button_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Left Mouse Button went Down - Tunneling Event");
        }

        private void Button_PreviewMouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Right Mouse Button went Up - Tunneling Event");
        }
    }
}
