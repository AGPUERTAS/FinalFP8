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
        static string[,] cliente = new string[15, 4];
        static int contadorcliente = 0;


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
                    registrarVehiculo();
                    break;
              case '2':
                    ListarVehiculos();
                    break;
               case '3':
                    ModificarVehiculo();
                    break;
                case '4':
                    AsignarVehiculoACliente();
                    break;
                case '5':
                    vehiculosDeCliente();
                    break;
                case '6':
                    menuPrincipal();
                    break;
            }
        }

        static void registrarVehiculo()
        {
            Console.WriteLine("Registrar un nuevo vehículo seleccionado.");

            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 4; j++)
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

                    Console.WriteLine("Vehículo registrado exitosamente.");
                    Console.WriteLine("¿Desea registrar otro vehículo? (s/n)");

                    char respuesta = Convert.ToChar(Console.ReadLine());

                    switch(respuesta)
                    {
                        case 's':
                            registrarVehiculo();
                            break;
                        case 'n':
                            gestionarVehiculos();
                            break;
                        default:
                            Console.WriteLine("Opción no válida. Volviendo al menú de gestión de vehículos.");
                            gestionarVehiculos();
                            break;
                    }
                }
                
            }

            

        }

         static void ListarVehiculos()
         {
            Console.WriteLine("Lista de vehículos registrados:");
            for (int i = 0; i < contadorVehiculos; i++)
            {
                Console.WriteLine($"Placa: {vehiculo[i, 0]}, Marca: {vehiculo[i, 1]}, Modelo: {vehiculo[i, 2]}, Año: {vehiculo[i, 3]}");
            }

            gestionarVehiculos();
         }


        static void ModificarVehiculo()
        {
            Console.WriteLine("Modificar información de un vehículo seleccionado.");
            Console.WriteLine("Ingrese la placa del vehículo que desea modificar:");
            string placa = Console.ReadLine();

            for (int i = 0; i < contadorVehiculos; i++)
            {
                if (vehiculo[i, 0] == placa)
                {
                    Console.WriteLine("Ingrese la nueva marca del vehículo:");
                    vehiculo[i, 1] = Console.ReadLine();
                    Console.WriteLine("Ingrese el nuevo modelo del vehículo:");
                    vehiculo[i, 2] = Console.ReadLine();
                    Console.WriteLine("Ingrese el nuevo año del vehículo:");
                    vehiculo[i, 3] = Console.ReadLine();
                    Console.WriteLine("Información del vehículo actualizada exitosamente.");
                    gestionarVehiculos();
                    return;
                }
            }
        }

        static void AsignarVehiculoACliente()
        {
            Console.WriteLine("Asignar vehículo a un cliente seleccionado.");
            Console.WriteLine("Ingrese la placa del vehículo que desea asignar:");
            string placa = Console.ReadLine();

            Console.WriteLine("Ingrese la cédula del cliente al que desea asignar el vehículo:");
            string cedula = Console.ReadLine();

            for (int i = 0; i < contadorVehiculos; i++)
            {
                if (vehiculo[i, 0] == placa)
                {
                    for (int j = 0; j < contadorcliente; j++)
                    {
                        if (cliente[j, 1] == cedula)
                        {
                            Console.WriteLine($"Vehículo con placa {placa} asignado al cliente con cédula {cedula} exitosamente.");
                            gestionarVehiculos();
                            return;
                        }
                    }
                }
            }
        }

        static void vehiculosDeCliente()
        {
            Console.WriteLine("Ver vehículos de un cliente específico seleccionado.");
            Console.WriteLine("Ingrese la cédula del cliente:");
            string cedula = Console.ReadLine();
            Console.WriteLine($"Vehículos del cliente con cédula {cedula}:");
            for (int i = 0; i < contadorVehiculos; i++)
            {
                cliente[i, 1] = cedula;
                Console.WriteLine($"Placa: {vehiculo[i, 0]}, Marca: {vehiculo[i, 1]}, Modelo: {vehiculo[i, 2]}, Año: {vehiculo[i, 3]}");
            }
            gestionarVehiculos();
        }



        static void gestionarClientes()
        {
            {
                char respuesta = ' ';

                Console.WriteLine("Gestion de clientes seleccionada.");
                Console.WriteLine("1. Registrar un nuevo cliente (nombre, cedula, telefono)");
                Console.WriteLine("2. Ver lista de todos los clientes");
                Console.WriteLine("3. Editar informacion del cliente");
                Console.WriteLine("4. Salir de Gestion de clientes (volver al menu principal)");

                respuesta = Convert.ToChar(Console.ReadLine());

                switch (respuesta)
                {
                    case '1':
                        registrarCliente();
                        break;

                    case '2':
                        ListarClientes();
                        break;

                    case '3':
                        ModificarClientes();
                        break;
                        

                        gestionarClientes();
                    case '4':
                        menuPrincipal();
                        break;

                }
            }
        }

        static void registrarCliente()
        {
            Console.WriteLine("Registrar un nuevo usuario seleccionado.");

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                    Console.WriteLine("Ingrese el nombre:");
                   cliente[contadorcliente, 0] = Console.ReadLine(); 
                    Console.WriteLine("Ingrese la cedula:");
                   cliente[contadorcliente, 1] = Console.ReadLine();
                    Console.WriteLine("Ingrese el telefono:");
                   cliente[contadorcliente, 2] = Console.ReadLine();

                    contadorcliente++;

                    Console.WriteLine("usuario registrado exitosamente.");
                    Console.WriteLine("¿Desea registrar otro usuario? (s/n)");

                    char respuesta = Convert.ToChar(Console.ReadLine());

                    switch (respuesta)
                    {
                        case 's':
                            registrarCliente();
                            break;
                        case 'n':
                            gestionarClientes();
                            break;
                        default:
                            Console.WriteLine("Opción no válida. Volviendo al menú de gestión de clientes.");
                            gestionarClientes();
                            break;
                    }
                }

            }



        }
        static void ListarClientes()
        {
            Console.WriteLine("Lista de clientes registrados:");
            for (int i = 0; i < contadorcliente; i++)
            {
                Console.WriteLine($"Nombre: {cliente[i, 0]}, Cedula: {cliente[i, 1]}, Telefono: {cliente[i, 2]}");
            }
          gestionarClientes();

        }

        static void ModificarClientes()
        {
            Console.WriteLine("Modificar información del cliente seleccionado.");
            Console.WriteLine("Ingrese la Nombre que desea modificar:");
            string nombre = Console.ReadLine();

            for (int i = 0; i < contadorcliente; i++)
            {
                if (cliente[i, 0] == nombre)
                {
                    Console.WriteLine("Ingrese la cedula:");
                    cliente[i, 1] = Console.ReadLine();
                    Console.WriteLine("Ingrese el telefono:");
                    cliente[i, 2] = Console.ReadLine();
                    Console.WriteLine("Información del cliente actualizada exitosamente.");
                    gestionarClientes();
                    return;
                }
            }

        }

        static void gestionarServiciosMantenimiento()
        {
            Console.WriteLine("Gestion de servicios de mantenimiento seleccionada.");
        }
    }
}
