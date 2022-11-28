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
using System.Windows.Shapes;
using System.Xml.Schema;

namespace Restaurante
{
    /// <summary>
    /// Lógica de interacción para VentanaAcerca.xaml
    /// </summary>
    public partial class VentanaAcerca : Window
    {
        decimal TotalPagar;
        public List<string> ProductosRecibidos;
        public VentanaAcerca(List<string> listaProductos, decimal totalPagar)
        {
            InitializeComponent();
            ProductosRecibidos = listaProductos;
            TotalPagar = totalPagar;

            LsvTicketNuevaVentana.ItemsSource = ProductosRecibidos;
            //MessageBox.Show("Su total a pagar es: $" + TotalPagar.ToString(), "COMPRA REALIZADA", MessageBoxButton.OK, MessageBoxImage.Information);
            TxtTotalPagar.Text = TotalPagar.ToString();
        }

        private void BtnPagar_Click(object sender, RoutedEventArgs e)
        {
            decimal.TryParse(TxtPago.Text, out decimal pago);
            if (pago > TotalPagar)
            {
                decimal cambio = pago - TotalPagar;
                MessageBox.Show("Gracias por su compra\n\t su cambio es: $" + cambio, "Restaurante \"La mejor\"", MessageBoxButton.OK, MessageBoxImage.Information);
                DialogResult = true;
                Close();
            }
            else
            {
                decimal cambio = TotalPagar - pago;
                MessageBox.Show("Lo siento le faltan: $" + cambio + "\n para pagar su pedido", "Restaurante \"La mejor\"", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            
        }
    }
}
