using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante_Console
{
    internal class Program
    {
        #region Variables globales.
        private static int pedido;
        private static int hamburguesa;
        private static int precio;
        private static int papas;
        private static int hotdog;
        private static int salchichas;
        private static int refresco;
        private static int limonada;
        private static int naranjada;
        private static int jugoNatural;
        private static int jugoArtificial;
        private static int opcion;
        #endregion

        /// <summary>
        /// Método principal de función de consola.
        /// </summary>
        /// <param name="args">valores generales para que la consola funcione correctamente</param>
        static void Main(string[] args)
        {
            Console.WriteLine("RESTAURANTE Marco Antonio Roldán Cruz - DOC210382"); // Va mi matrícula y el nombre del proyecto.
            Console.WriteLine("Objetivo del programa: Comprar en restaurant");
            Console.WriteLine("Objetivo principal: analizar estructura y sintaxis de un programa en C#");
            do
            {
                Console.WriteLine("\nMENÚ DE OPCIONES");// Muestra el menú de opciones
                Console.WriteLine("0. Salir");
                Console.WriteLine("1. Mostrar precios");
                Console.WriteLine("2. Hacer pedidos");
                Console.WriteLine("3. Realizar pago");
                Console.WriteLine("Elige una opcion"); // Espera una selección del cliente del menú principal.

                // Esta es una variable global está definido en la linea 26
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1: // Mostrar precios.
                        Console.Clear();
                        Console.WriteLine("Comidas");
                        Console.WriteLine("Hamburguesas: $60");
                        Console.WriteLine("Papas: $30");
                        Console.WriteLine("Hot dogs: $40");
                        Console.WriteLine("Salchichas fritas: $30");
                        Console.WriteLine("Bebidas");
                        Console.WriteLine("Refresco $20");
                        Console.WriteLine("Limonada $15");
                        Console.WriteLine("Naranjada $15");
                        Console.WriteLine("Jugo natural $20");
                        Console.WriteLine("Jugo artificial $25");
                        break;
                    case 2: // Hacer pedidos.
                        do
                        {
                            Console.Clear(); // Limpia la consola.
                            Console.WriteLine("0. Terminar pedido.\n1. Hamburguesa.\n2. Papas.\n3. Hot dog." +
                                "\n4. Salchichas fritas.\n5. Refresco.\n6. Limonada.\n7. Naranjada." +
                                "\n8. Jugo natural.\n9. Jugo artificial."); // Vuelve a mostrar el menú, pero sin precios.
                            Console.WriteLine("¿Qué va a pedir?");// Pregunta al cliente que va a comprar.
                            pedido = int.Parse(Console.ReadLine()); // Escucha las peticiones del cliente.
                            switch (pedido)
                            {
                                case 1: // El cliente pidió una hamburguesa.
                                    hamburguesa++; // Hamburguesa suma 1 pedido.
                                    precio += 60; // El precio total suma $60.00 MXN
                                    break;
                                case 2: // El cliente pidió unas papás fritas.
                                    papas++; // Las papás suman 1 pedido.
                                    precio += 30; // El precio total suma $30.00 MXN
                                    break;
                                case 3: // El cliente pidió un perro caliente.
                                    hotdog++; // Hotdog suma 1 pedido.
                                    precio += 40; // El precio total suma $40.00 MXN
                                    break;
                                case 4:
                                    salchichas++; // Salchichas fritas suma 1 pedido.
                                    precio += 30; // El precio total suma $40.00 MXN.
                                    break;
                                case 5:
                                    refresco++;
                                    precio += 20;
                                    break;
                                case 6:
                                    limonada++;
                                    precio += 15;
                                    break;
                                case 7:
                                    naranjada++;
                                    precio += 15;
                                    break;
                                case 8:
                                    jugoNatural++;
                                    precio += 20;
                                    break;
                                case 9:
                                    jugoArtificial++;
                                    precio += 25;
                                    break;
                                default:
                                    break;
                            }
                        } while (pedido != 0); // Termina el pedido.
                        Console.WriteLine("En un momento le traemos su pedido.");
                        break;
                    case 3: // Realizar el pago.
                        #region Imprimir la comanda;
                        /* Imprimir la comanda consulta la cantidad de productos comprados y genera una tabla con ellos haciendo la multiplicación de la cantidad comprada por el precio de la comida / bebida.
                         * Sí la cantidad comprada es mayor a cero lo imprimirá en la comanda.
                         * Y el subtotal es la variable local, calculada en cada operación se inicia en cero.
                         * subtotal = [producto] * [precio_unitario]
                         * Ejemplo: 
                         * subtotal = 5 * 60; (Hamburguesas).
                         * */
                        Console.Clear();
                        Console.WriteLine("Restaurante Marco Antonio Roldán Cruz");
                        Console.WriteLine("------------------------------------------------------------------");
                        Console.WriteLine("| Producto \t\t|\tCantidad\t|\tSubtotal |");
                        // Variable local subtotal calcula el precio de los productos.
                        int subtotal = 0;
                        if (hamburguesa > 0)
                        {
                            subtotal = hamburguesa * 60;
                            Console.WriteLine("| Hamburguesa $60\t|\t" + hamburguesa + "\t\t|\t$" + subtotal + "\t |");
                        }
                        if (papas > 0)
                        {
                            subtotal = papas * 30;
                            Console.WriteLine("| Papas $30\t\t|\t" + papas + "\t\t|\t$" + subtotal + "\t |");
                        }
                        if (hotdog > 0)
                        {
                            subtotal = hotdog * 40;
                            Console.WriteLine("| Hot Dog(s) $40\t|\t" + hotdog + "\t\t|\t$" + subtotal + "\t |");
                        }
                        if (salchichas > 0)
                        {
                            subtotal = salchichas * 30;
                            Console.WriteLine("| Salchichas fritas $30\t|\t" + salchichas + "\t\t|\t$" + subtotal + "\t |");
                        }
                        if (refresco > 0)
                        {
                            subtotal = refresco * 20;
                            Console.WriteLine("| Refresco(s) $20\t|\t" + refresco + "\t\t|\t$" + subtotal + "\t |");
                        }
                        if (limonada > 0)
                        {
                            subtotal = limonada * 15;
                            Console.WriteLine("| Limonada $15\t\t|\t" + limonada + "\t\t|\t$" + subtotal + "\t |");
                        }
                        if (naranjada > 0)
                        {
                            subtotal = naranjada * 15;
                            Console.WriteLine("| Naranjada $15\t\t|\t" + naranjada + "\t\t|\t$" + subtotal + "\t |");
                        }
                        if (jugoNatural > 0)
                        {
                            subtotal = jugoNatural * 20;
                            Console.WriteLine("| Jugo natural $20\t|\t" + jugoNatural + "\t\t|\t$" + subtotal + "\t |");
                        }
                        if (jugoArtificial > 0)
                        {
                            subtotal = jugoArtificial * 25;
                            Console.WriteLine("| Jugo artificial $25\t|\t" + jugoArtificial + "\t\t|\t$" + subtotal + "\t |");
                        }
                        Console.WriteLine("------------------------------------------------------------------");
                        #endregion
                        Console.WriteLine("\tSon $" + precio + " pesos"); // Muestra el costo total.
                        Console.Write("Su pago es: $"); // Solicita el pago.
                        // Variable local
                        int pago = int.Parse(Console.ReadLine());
                        while (pago < precio) // Sí el pago es menor que el costo total no le alcanza a pagar.
                        {
                            Console.WriteLine("Disculpe no le alcanza para pagar su pedido");
                            Console.WriteLine("\tSon $" + precio + " pesos");
                            Console.Write("Su pago es: $");
                            pago = int.Parse(Console.ReadLine());
                        }
                        int cambio = pago - precio; // Calcula el cambio.
                        Console.WriteLine("Su cambio es $" + cambio + " pesos");
                        Console.WriteLine("Gracias por su compra");
                        break;
                    default:
                        break;
                }

            } while (opcion != 0);
            Console.WriteLine("¡Muchas gracias por su visita, vuelva pronto!");
            Console.ReadLine();
        }
    }
}
