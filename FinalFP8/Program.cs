using Microsoft.VisualBasic;
using System.Numerics;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Timers;

namespace FinalFP8
{
    internal class Program
    {
        static string[,] vehiculo = new string[20, 4];
        static int contadorVehiculos = 0;
        

        static void Main(string[] args)
        {
            

            menuPrincipal();
        }

        static void menuPrincipal()
        {
            
            char opcion = ' ';

            Console.WriteLine("\n===================BIENVENIDO AL TALLER MECANICO================");

            Console.WriteLine("Seleccione una opcion del menu:");
            Console.WriteLine("1. Gestion de vehículos");
            Console.WriteLine("2. Gestion de clientes");
            Console.WriteLine("3. Gestion de servicios de mantenimiento");
            Console.WriteLine("4. Salir");

            opcion = Convert.ToChar(Console.ReadLine());

            switch (opcion)
            {
                case '1':
                    gestionarVehiculos();
                    break;
                case '2':
                    gestionarClientes();
                    break;
                case '3':
                    gestionarServiciosMantenimiento();
                    break;
                case '4':
                    Console.WriteLine("Saliendo del programa. ¡Hasta luego!");
                    break;
                default:
                    Console.WriteLine("Opción no válida. Por favor, seleccione una opción del 1 al 4.");
                    break;
            }

        }

        static void gestionarVehiculos()
        {
            
            char respuesta = ' ';
            

            Console.WriteLine("Gestion de vehículos seleccionada.");
            Console.WriteLine("1. Registrar un nuevo vehículo (marca, modelo, placa, año)");
            Console.WriteLine("2. Ver lista de vehículos registrados");
            Console.WriteLine("3. Editar información de un vehículo (buscar por número de placa)");
            Console.WriteLine("4. Asignar vehículo a un cliente");
            Console.WriteLine("5. Ver vehículos de un cliente específico");
            Console.WriteLine("6. Salir de Gestión de vehículos (volver al Menú principal)");

            respuesta = Convert.ToChar(Console.ReadLine());

            switch (respuesta)
            { 
              case '1':
                    
                    break;
            }
        }

        static void registrarVehiculo()
        {
            
            if (contadorVehiculos >= 20)
            {
                Console.WriteLine("Ingrese la placa del vehículo:");
                vehiculo[contadorVehiculos, 0] = Console.ReadLine();
                Console.WriteLine("Ingrese la marca del vehículo:");
                vehiculo[contadorVehiculos, 1] = Console.ReadLine();
                Console.WriteLine("Ingrese el modelo del vehículo:");
                vehiculo[contadorVehiculos, 2] = Console.ReadLine();
                Console.WriteLine("Ingrese el año del vehículo:");
                vehiculo[contadorVehiculos, 3] = Console.ReadLine();
                contadorVehiculos++;
            }
                   

        }
        



        static void gestionarClientes()
        {
            Console.WriteLine("Gestion de clientes seleccionada.");
        }

        static void gestionarServiciosMantenimiento()
        {
            Console.WriteLine("Gestion de servicios de mantenimiento seleccionada.");
        }
    }
}
