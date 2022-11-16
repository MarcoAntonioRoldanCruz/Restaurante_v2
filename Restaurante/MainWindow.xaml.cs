using BootstrapIcons.Wpf;
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
using WPF.Bootstrap.Controls;

namespace Restaurante
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnAgregar_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void BtnBotonBootstrap_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hola Omar", "Saludando a Omar", MessageBoxButton.YesNoCancel, MessageBoxImage.Information);
        }
    }
}
