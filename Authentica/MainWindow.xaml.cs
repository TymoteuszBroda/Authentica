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

namespace Authentica
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

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            bool isRadioChecked = false;
            bool isListItemChecked = false;

            foreach (var radioButton in RadioButtonGroup.Children.OfType<RadioButton>())
            {
                if (radioButton.IsChecked == true)
                {
                    MessageBox.Show($"Wybrano: {radioButton.Content}");
                    isRadioChecked = true;
                }

            }

            if (!isRadioChecked)
            {
                MessageBox.Show("Nie wybrano certyfikatu", "Informacja", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }
}
