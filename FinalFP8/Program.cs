using Microsoft.VisualBasic;
using System.Numerics;
using System.Reflection;
using System.Text.RegularExpressions;

namespace FinalFP8
{
    internal class Program
    {
        string[,] vehiculo =new string[20, 20];


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
            int respuesta = 0;

            Console.WriteLine("Gestion de vehículos seleccionada.");
            Console.WriteLine("1. Registrar un nuevo vehículo (marca, modelo, placa, año)");
            Console.WriteLine("2. Ver lista de vehículos registrados");
            Console.WriteLine("3. Editar información de un vehículo (buscar por número de placa)");
            Console.WriteLine("4. Asignar vehículo a un cliente");
            Console.WriteLine("5. Ver vehículos de un cliente específico");
            Console.WriteLine("6. Salir de Gestión de vehículos (volver al Menú principal)");

            respuesta = Convert.ToInt32(Console.ReadLine());

            if (respuesta == 1)
            {
                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        Console.WriteLine("Ingrese la marca del vehículo:");
                        string marca = Console.ReadLine();
                        Console.WriteLine("Ingrese el modelo del vehículo:");
                        string modelo = Console.ReadLine();
                        Console.WriteLine("Ingrese la placa del vehículo:");
                        string placa = Console.ReadLine();
                        Console.WriteLine("Ingrese el año del vehículo:");
                        string año = Console.ReadLine();
                        // Aquí se debería guardar la información en una estructura de datos adecuada
                        // Por simplicidad, solo mostramos la información ingresada
                        Console.WriteLine($"Vehículo registrado: {marca} {modelo}, Placa: {placa}, Año: {año}");
                    }
                }
                gestionarVehiculos();
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
