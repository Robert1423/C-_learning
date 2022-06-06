using ShopList.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ShopList
{
    /// <summary>
    /// Logika interakcji dla klasy AddWindow.xaml
    /// </summary>
    public partial class AddWindow : Window, INotifyPropertyChanged
    {
        public string ProductName { get; set; }
        public int ProductGrammage { get; set; }
        public AddWindow()
        {
            InitializeComponent();
            DataContext = this;
        }
        //Zainstalowany nuget fody
        public event PropertyChangedEventHandler PropertyChanged;

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void GrammageInput_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            //Wymuszenie na textbox przyjmowania tylko cyfr
            Regex regex = new Regex("[^0-9]+"); //Użycie wyrażenia regularnego, jeżeli znak między 0 - 9 to przyjmuje
            e.Handled = regex.IsMatch(e.Text);
        }

        private void Accept_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(ProductName) && CategoryBox.SelectedIndex != 7)
            {
                var product = new ProductModel(ProductName, ProductGrammage, CategoryBox.SelectedIndex);
                GlobalData.productView.AddProduct(product);
            }
            ProductName = string.Empty;
            ProductGrammage = 0;
            CategoryBox.SelectedIndex = 7;
        }
    }
}
