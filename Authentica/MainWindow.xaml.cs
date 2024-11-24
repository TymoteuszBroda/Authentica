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
            listBOX.ItemsSource = new string[] { "1024", "2048", "3072", "4096" };
            RSA = (RadioButton)FindName("RSA");
            DSA = (RadioButton)FindName("DSA");
            SSH1 = (RadioButton)FindName("SSH1");
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }


        private bool IsRadioButtonChecked()
        {
            return (RSA?.IsChecked ?? false) || (DSA?.IsChecked ?? false) || (SSH1?.IsChecked ?? false);
        }

        private void GenerateCertificate_Click(object sender, RoutedEventArgs e)
        {
            string selectedAlgorithm = GetSelectedAlgorithm();
            string selectedBits = listBOX.SelectedItem?.ToString() ?? string.Empty;

            if (listBOX.SelectedItem == null | !IsRadioButtonChecked())
            {
                
                MessageBox.Show($"Wybrano algorytm: {selectedAlgorithm}, Liczba bitów: {selectedBits}");
                MessageBox.Show("Proszę wybrać rodzaj certyfikatu i liczbę bitów.");
                return;
            }

            

            MessageBox.Show($"Wybrano algorytm: {selectedAlgorithm}, Liczba bitów: {selectedBits}");

            // Logika generowania certyfikatu
        }

        private string GetSelectedAlgorithm()
        {
            if (RSA != null && RSA.IsChecked == true) return "RSA";
            if (DSA != null && DSA.IsChecked == true) return "DSA";
            if (SSH1 != null && SSH1.IsChecked == true) return "SSH-1 (RSA)";
            return string.Empty;
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
