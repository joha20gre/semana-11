using System;
using System.Collections.Generic;

class TraductorBasico
{
    static Dictionary<string, string> diccionario = new Dictionary<string, string>()
    {
        {"tiempo", "time"},
        {"persona", "person"},
        {"año", "year"},
        {"camino", "way"},
        {"día", "day"},
        {"cosa", "thing"},
        {"hombre", "man"},
        {"mundo", "world"},
        {"vida", "life"},
        {"mano", "hand"},
        {"parte", "part"},
        {"niño", "child"},
        {"ojo", "eye"},
        {"mujer", "woman"},
        {"lugar", "place"},
        {"trabajo", "work"},
        {"semana", "week"},
        {"caso", "case"},
        {"punto", "point"},
        {"gobierno", "government"},
        {"empresa", "company"}
    };

    static void Main()
    {
        int opcion;
        do
        {
            Console.WriteLine("\n==================== MENÚ ====================");
            Console.WriteLine("1. Traducir una frase");
            Console.WriteLine("2. Agregar palabras al diccionario");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");
            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    TraducirFrase();
                    break;
                case 2:
                    AgregarPalabra();
                    break;
                case 0:
                    Console.WriteLine("¡Hasta luego!");
                    break;
                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }
        } while (opcion != 0);
    }

    static void TraducirFrase()
    {
        Console.Write("\nIngrese una frase en español: ");
        string frase = Console.ReadLine().ToLower();
        string[] palabras = frase.Split(' ', ',', '.', ';', ':', '!', '?');
        Console.WriteLine("\nTraducción parcial:");
        foreach (string palabra in palabras)
        {
            if (diccionario.ContainsKey(palabra))
                Console.Write(diccionario[palabra] + " ");
            else
                Console.Write(palabra + " ");
        }
        Console.WriteLine();
    }

    static void AgregarPalabra()
    {
        Console.Write("\nIngrese la palabra en español: ");
        string esp = Console.ReadLine().ToLower();
        Console.Write("Ingrese su traducción en inglés: ");
        string ing = Console.ReadLine().ToLower();

        if (!diccionario.ContainsKey(esp))
        {
            diccionario.Add(esp, ing);
            Console.WriteLine("Palabra agregada correctamente.");
        }
        else
        {
            Console.WriteLine("La palabra ya existe en el diccionario.");
        }
    }
}
