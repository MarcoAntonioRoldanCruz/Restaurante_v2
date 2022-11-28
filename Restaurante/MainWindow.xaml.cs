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
        private decimal TotalPagar;
        public List<string> ListaProductos;

        public MainWindow()
        {
            InitializeComponent();
            ListaProductos = new List<string>();
        }


        /// <summary>
        /// Boton que abre una nueva ventana donde se va a imprimir el ticket.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnBotonBootstrap_Click(object sender, RoutedEventArgs e)
        {
            // Para pasar datos desde la ventana MainWindow a una nueva ventana (VentanaAcerca en este caso).
            // Este es mi botón ubicado en MainWindow.
            VentanaAcerca ventanaAcerca = new VentanaAcerca(ListaProductos, TotalPagar);
            ventanaAcerca.ShowDialog();

            var dialogResult = ventanaAcerca.DialogResult;
            if (dialogResult == true)
            {
                LsvCompraMenu.Items.Clear();
                TotalPagar = 0;
                TxtTotalPagar.Text = "";
                ListaProductos.Clear();
            }
            
        }

        private void BtnMenuHamburguesa_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hamburguesa agregada", "Menú principal", MessageBoxButton.OK, MessageBoxImage.Information);
            LsvCompraMenu.Items.Add("Hamburguesa");
            TotalPagar += 60;
            TxtTotalPagar.Text = TotalPagar.ToString();
            ListaProductos.Add("Hamburguesa");
        }

        private void LsvCompraMenu_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            object compra = LsvCompraMenu.SelectedItem;
            var result = MessageBox.Show("¿Realmente deseas eliminar el producto: " + compra.ToString() + "?", "Eliminar compra", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                switch (compra)
                {
                    case "Hamburguesa":
                        TotalPagar -= 60;
                        break;
                    case "Papas a la francesa":
                        TotalPagar -= 30;
                        break;
                    case "Hot dogs":
                        TotalPagar -= 40;
                        break;
                    case "Salchichas fritas":
                        TotalPagar -= 30;
                        break;
                    case "Refresco":
                        TotalPagar -= 20;
                        break;
                    case "Limonada":
                        TotalPagar -= 15;
                        break;
                    case "Naranjada":
                        TotalPagar -= 15;
                        break;
                    case "Jugo natural":
                        TotalPagar -= 20;
                        break;
                    case "Jugo artificial":
                        TotalPagar -= 25;
                        break;
                    default:
                        break;
                }
                LsvCompraMenu.Items.Remove(compra);
                TxtTotalPagar.Text = TotalPagar.ToString();
            }

        }

        private void LsvMenu2_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            object item = LsvMenu2.SelectedIndex;
            switch (item)
            {
                case 0:
                    MessageBox.Show("Comidas");
                    break;
                case 1: // Hamburguesa - $60
                    LsvCompraMenu.Items.Add("Hamburguesa");
                    TotalPagar += 60;
                    TxtTotalPagar.Text = TotalPagar.ToString();
                    ListaProductos.Add("Hamburguesa");
                    break;
                case 2: // Papas a la francesa - $30.00
                    LsvCompraMenu.Items.Add("Papas a la francesa");
                    TotalPagar += 30;
                    TxtTotalPagar.Text = TotalPagar.ToString();
                    ListaProductos.Add("Papas a la francesa");
                    break;
                case 3: // Hotdogs - $40.00
                    LsvCompraMenu.Items.Add("Hot dogs");
                    TotalPagar += 40;
                    TxtTotalPagar.Text = TotalPagar.ToString();
                    ListaProductos.Add("Hot dogs");
                    break;
                case 4:
                    LsvCompraMenu.Items.Add("Salchichas fritas");
                    TotalPagar += 30;
                    TxtTotalPagar.Text = TotalPagar.ToString();
                    ListaProductos.Add("Salchichas fritas");
                    break;
                case 5:
                    MessageBox.Show("Bebidas");
                    break;
                case 6:
                    LsvCompraMenu.Items.Add("Refresco");
                    TotalPagar += 20;
                    TxtTotalPagar.Text = TotalPagar.ToString();
                    ListaProductos.Add("Refresco");
                    break;
                case 7:
                    LsvCompraMenu.Items.Add("Limonada");
                    TotalPagar += 15;
                    TxtTotalPagar.Text = TotalPagar.ToString();
                    ListaProductos.Add("Limonada");
                    break;
                case 8:
                    LsvCompraMenu.Items.Add("Naranjada");
                    TotalPagar += 15;
                    TxtTotalPagar.Text = TotalPagar.ToString();
                    ListaProductos.Add("Naranjada");
                    break;
                case 9:
                    LsvCompraMenu.Items.Add("Jugo natural");
                    TotalPagar += 20;
                    TxtTotalPagar.Text = TotalPagar.ToString();
                    ListaProductos.Add("Jugo natural");
                    break;
                case 10:
                    LsvCompraMenu.Items.Add("Jugo artificial");
                    TotalPagar += 25;
                    TxtTotalPagar.Text = TotalPagar.ToString();
                    ListaProductos.Add("Jugo artificial");
                    break;
                default:
                    break;
            }
        }

        private void BtnAgregarMenu2_Click(object sender, RoutedEventArgs e)
        {
            object item = LsvMenu2.SelectedIndex;
            switch (item)
            {
                case 0:
                    MessageBox.Show("Comidas");
                    break;
                case 1: // Hamburguesa - $60
                    LsvCompraMenu.Items.Add("Hamburguesa");
                    TotalPagar += 60;
                    TxtTotalPagar.Text = TotalPagar.ToString();
                    ListaProductos.Add("Hamburguesa");
                    break;
                case 2: // Papas a la francesa - $30.00
                    LsvCompraMenu.Items.Add("Papas a la francesa");
                    TotalPagar += 30;
                    TxtTotalPagar.Text = TotalPagar.ToString();
                    ListaProductos.Add("Papas a la francesa");
                    break;
                case 3: // Hotdogs - $40.00
                    LsvCompraMenu.Items.Add("Hot dogs");
                    TotalPagar += 40;
                    TxtTotalPagar.Text = TotalPagar.ToString();
                    ListaProductos.Add("Hot dogs");
                    break;
                case 4:
                    LsvCompraMenu.Items.Add("Salchichas fritas");
                    TotalPagar += 30;
                    TxtTotalPagar.Text = TotalPagar.ToString();
                    ListaProductos.Add("Salchichas fritas");
                    break;
                case 5:
                    MessageBox.Show("Bebidas");
                    break;
                case 6:
                    LsvCompraMenu.Items.Add("Refresco");
                    TotalPagar += 20;
                    TxtTotalPagar.Text = TotalPagar.ToString();
                    ListaProductos.Add("Refresco");
                    break;
                case 7:
                    LsvCompraMenu.Items.Add("Limonada");
                    TotalPagar += 15;
                    TxtTotalPagar.Text = TotalPagar.ToString();
                    ListaProductos.Add("Limonada");
                    break;
                case 8:
                    LsvCompraMenu.Items.Add("Naranjada");
                    TotalPagar += 15;
                    TxtTotalPagar.Text = TotalPagar.ToString();
                    ListaProductos.Add("Naranjada");
                    break;
                case 9:
                    LsvCompraMenu.Items.Add("Jugo natural");
                    TotalPagar += 20;
                    TxtTotalPagar.Text = TotalPagar.ToString();
                    ListaProductos.Add("Jugo natural");
                    break;
                case 10:
                    LsvCompraMenu.Items.Add("Jugo artificial");
                    TotalPagar += 25;
                    TxtTotalPagar.Text = TotalPagar.ToString();
                    ListaProductos.Add("Jugo artificial");
                    break;
                default:
                    break;
            }
        }

        private void BtnMenuPapas_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Papas a la francesa agregadas", "Menú principal", MessageBoxButton.OK, MessageBoxImage.Information);
            LsvCompraMenu.Items.Add("Papas a la francesa");
            TotalPagar += 30;
            TxtTotalPagar.Text = TotalPagar.ToString();
        }

        private void BtnMenuHotDogs_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Hot dogs agregados", "Menú principal", MessageBoxButton.OK, MessageBoxImage.Information);
            LsvCompraMenu.Items.Add("Hot dogs");
            TotalPagar += 40;
            TxtTotalPagar.Text = TotalPagar.ToString();
        }

        private void BtnSalchichas_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Salchicas fritas agregadas", "Menú principal", MessageBoxButton.OK, MessageBoxImage.Information);
            LsvCompraMenu.Items.Add("Salchichas fritas");
            TotalPagar += 30;
            TxtTotalPagar.Text = TotalPagar.ToString();
        }

        private void BtnRefresco_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Refresco agregado", "Menú principal", MessageBoxButton.OK, MessageBoxImage.Information);
            LsvCompraMenu.Items.Add("Refresco");
            TotalPagar += 20;
            TxtTotalPagar.Text = TotalPagar.ToString();
        }

        private void BtnLimonada_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Limonada agregada", "Menú principal", MessageBoxButton.OK, MessageBoxImage.Information);
            LsvCompraMenu.Items.Add("Limonada");
            TotalPagar += 15;
            TxtTotalPagar.Text = TotalPagar.ToString();
        }

        private void BtnNaranjada_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Naranjada agregada", "Menú principal", MessageBoxButton.OK, MessageBoxImage.Information);
            LsvCompraMenu.Items.Add("Naranjada");
            TotalPagar += 15;
            TxtTotalPagar.Text = TotalPagar.ToString();
        }

        private void BtnJugoNatural_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Jugo natural agregado", "Menú principal", MessageBoxButton.OK, MessageBoxImage.Information);
            LsvCompraMenu.Items.Add("Jugo natural");
            TotalPagar += 20;
            TxtTotalPagar.Text = TotalPagar.ToString();
        }

        private void BtnJugoArtificial_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Jugo artificial agregado", "Menú principal", MessageBoxButton.OK, MessageBoxImage.Information);
            LsvCompraMenu.Items.Add("Jugo artificial");
            TotalPagar += 25;
            TxtTotalPagar.Text = TotalPagar.ToString();
        }

        private void BtnEliminarMenu2_Click(object sender, RoutedEventArgs e)
        {
            object compra = LsvCompraMenu.SelectedItem;
            var result = MessageBox.Show("¿Realmente deseas eliminar el producto: " + compra.ToString() + "?", "Eliminar compra", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                switch (compra)
                {
                    case "Hamburguesa":
                        TotalPagar -= 60;
                        break;
                    case "Papas a la francesa":
                        TotalPagar -= 30;
                        break;
                    case "Hot dogs":
                        TotalPagar -= 40;
                        break;
                    case "Salchichas fritas":
                        TotalPagar -= 30;
                        break;
                    case "Refresco":
                        TotalPagar -= 20;
                        break;
                    case "Limonada":
                        TotalPagar -= 15;
                        break;
                    case "Naranjada":
                        TotalPagar -= 15;
                        break;
                    case "Jugo natural":
                        TotalPagar -= 20;
                        break;
                    case "Jugo artificial":
                        TotalPagar -= 25;
                        break;
                    default:
                        break;
                }
                LsvCompraMenu.Items.Remove(compra);
                TxtTotalPagar.Text = TotalPagar.ToString();
            }
        }

        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Gracias por su visita\nFundamentos de programación\nISC 1ro Grupo 2", "Restaurante \"La mejor\"", MessageBoxButton.OK, MessageBoxImage.Information);
            Application.Current.Shutdown();
        }
    }
}
