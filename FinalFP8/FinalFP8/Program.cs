﻿using Microsoft.VisualBasic;
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
                    registrarVehiculo();
                    break;
              case '2':
                    ListarVehiculos();
                    break;
               case '3':
                    ModificarVehiculo();
                    break;
            }
        }

        static void registrarVehiculo()
        {
            Console.WriteLine("Registrar un nuevo vehículo seleccionado.");

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 20; j++)
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

        }




        static void gestionarClientes()
        {
            {
                int respuesta = 1;

                Console.WriteLine("Gestion de clientes seleccionada.");
                Console.WriteLine("1. Registrar un nuevo cliente (nombre, cedula, telefono)");
                Console.WriteLine("2. Ver lista de todos los clientes");
                Console.WriteLine("3. Editar informacion del cliente)");
                Console.WriteLine("4. Salir de Gestion de clientes (volver al menu principal)");

                respuesta = Convert.ToInt32(Console.ReadLine());

                if (respuesta == 1)
                {
                    for (int i = 0; i < 15; i++)
                    {
                        for (int j = 0; j < 15; j++)
                        {
                            Console.WriteLine("Ingrese su nombre:");
                            string nombre = Console.ReadLine();
                            Console.WriteLine("Ingrese su cedula:");
                            string cedula = Console.ReadLine();
                            Console.WriteLine("Ingrese su numero de telefono:");
                            string telefono = Console.ReadLine();
                            Console.WriteLine($"Usuario registrado: {nombre} {cedula} {telefono}");
                        }
                        gestionarClientes();
                    }
                }
            }
        }

        static void gestionarServiciosMantenimiento()
        {
            Console.WriteLine("Gestion de servicios de mantenimiento seleccionada.");
        }
    }
}
