using System;

namespace cadenas_pract
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce cadena con al menos 40 caracteres por favor y gracias :)");
            string texto = Console.ReadLine();
            while (texto != null)
            {

                while (texto.Length < 40)
                {
                    Console.WriteLine("La cadena introducida posee únicamente" + texto.Length + "caracteres. Por favor, introduzca una nueva cadena con más de 40 caracteres: ");
                    texto = Console.ReadLine();
                }

                Console.WriteLine("*******MENU*******");
                Console.WriteLine("     Pulsa opción 1 para sustituir una palabra por otra");
                Console.WriteLine("     Pulsa opción 2 para buscar texto en la cadena");
                Console.WriteLine("     Pulsa opción 3 para buscar texto de inicio en la cadena");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Introduce palabra a sustituir y separadas por un espacio la palabra sustituta");
                        string respuesta = Console.ReadLine();
                        String[] strlist = respuesta.Split(" ");
                        texto = texto.Replace(strlist[0], strlist[1]);
                        Console.WriteLine("El texto con las cadenas reemplazadas es: ");
                        Console.WriteLine(texto);
                        break;
                    case "2":
                        Console.WriteLine("Introduce texto para ser buscado: ");
                        string busca = Console.ReadLine();
                        bool contains = texto.Contains(busca);

                        if (contains == true)
                        {
                            Console.WriteLine("El texto existe en la cadena");
                        }
                        else
                        {
                            Console.WriteLine("El texto no existe en la cadena");
                        }

                        break;
                    case "3":
                        Console.WriteLine("Introduce texto para ser buscado al principio: ");
                        string busca_inicio = Console.ReadLine();
                        bool start = texto.StartsWith(busca_inicio);

                        if (start == true)
                        {
                            Console.WriteLine("La cadena empieza por el mismo texto introducido");
                        }
                        else
                        {
                            Console.WriteLine("La cadena no empieza por el mismo texto introducido");
                        }
                        break;
                    default:
                        Console.WriteLine("Opción no válida");
                        break;
                }

                Console.WriteLine("Introduce cadena con al menos 40 caracteres por favor y gracias :)");
                texto = Console.ReadLine();
            }
        }
    }
}


