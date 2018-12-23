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

namespace LibraryInventoryManager
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


        private void Users_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Users form will be loaded");
        }
        private void Inventory_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Inventory form will be loaded");
        }
        private void BorrowedBooks_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Borrowed books form will be loaded");
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

    }
}
