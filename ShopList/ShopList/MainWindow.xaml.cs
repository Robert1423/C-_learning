using ShopList.model;
using ShopList.ViewModel;
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

namespace ShopList
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MouseDown += Window_MouseDown;
            DataContext = GlobalData.productView;
            GlobalData.productView.Load();

        }
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                DragMove();
        }
        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            AddWindow addWindow = new AddWindow();
            addWindow.Owner = this;
            addWindow.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            addWindow.ShowDialog();
            GlobalData.productView.Save();
        }

        private void RemoveButton_Click(object sender, RoutedEventArgs e)
        {
            GlobalData.productView.RemoveProducts();
            GlobalData.productView.Save();

        }

        private void Close_button_Click(object sender, RoutedEventArgs e)
        {
            GlobalData.productView.Save();
            Close();
        }

        private void FiltrButton_Click(object sender, RoutedEventArgs e)
        {
            if (FiltrBox.SelectedIndex!=7)
            {
                GlobalData.productView.Filtr(FiltrBox.SelectedIndex);
                Display.SetBinding(DataGrid.ItemsSourceProperty, "FiltredList");
            }
            else
            {
                Display.SetBinding(DataGrid.ItemsSourceProperty, "Products");
            }
        }
    }
}
