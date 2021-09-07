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

namespace MegaSuperBombaApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool maximized = false;
        public MainWindow()
        {
            InitializeComponent();

            MainFrame.Navigate(new Pages.Login());
            
        }

       
        private void btnfullScreen_Click(object sender, RoutedEventArgs e)
        {
         
            if (maximized != true)
            {
                this.WindowState = WindowState.Maximized;
                
                
                maximized = !maximized;
            }
            else
            {
                this.WindowState = WindowState.Normal;
                maximized = !maximized;


            }




        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {

                if (e.ChangedButton == MouseButton.Left)
                    this.DragMove();
            
        }
    }
}
