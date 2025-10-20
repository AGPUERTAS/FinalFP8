namespace FinalFP8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n===================BIENVENIDO AL TALLER MECANICO EL RORO================");
        }

        static char menuPrincipal()
        {
            Console.WriteLine("\nSeleccione una opcion del menu:");
            Console.WriteLine("1. Gestion de vehículos");
            Console.WriteLine("2. Gestion de clientes");
            Console.WriteLine("3. Gestion de servicios de mantenimiento");
            Console.WriteLine("4. Salir");
            
            char opcion = Char.ToUpper(Console.ReadKey(true).KeyChar);
            return opcion;
        }
    }
}
