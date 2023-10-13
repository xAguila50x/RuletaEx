using System;
using System.Collections.Generic;
using Ruleta.Clases;

class Program
{
    static void Main()
    {
        int dineroInicial = 300;
        int dinero = dineroInicial;
        List<string> historial = new List<string>();

        Console.WriteLine("¡Bienvenido a la Ruleta!");
        Console.WriteLine("¿Listo para perder tu dinero?");
        Console.WriteLine($"Tienes ${dineroInicial}");

        while (dinero > 0)
        {
            Console.Write("Elige qué quieres hacer: 1) Apostar Número específico, 2) Apostar Color (R/N), 3) Apostar Par/Impar, 4) Retirarse: ");
            int opcion = int.Parse(Console.ReadLine());

            if (opcion == 4)
                break;

            int apuesta;
            string descripcionApuesta = "";

            Apuesta apuestaObject = new Apuesta("");

            if (opcion == 1)
            {
                apuestaObject.RealizarApuestaNumero();
            }
            else if (opcion == 2)
            {
                apuestaObject.RealizarApuestaColor();
            }
            else if (opcion == 3)
            {
                apuestaObject.RealizarApuestaParImpar();
            }
            else
            {
                Console.WriteLine("Opción no válida. Inténtalo de nuevo.");
                continue;
            }

            apuesta = apuestaObject.CantidadApuesta;
            descripcionApuesta = apuestaObject.DescripcionApuesta;

            dinero -= apuesta;

            // Realizar el giro de la ruleta
            Random random = new Random();
            int resultado = random.Next(37);

            // Determinar el color del número
            string colorResultado = resultado == 0 ? "N" : (resultado % 2 == 0 ? "N" : "R");

            Console.WriteLine($"El número es {resultado} ({colorResultado})");

            // Verificar si el jugador ganó
            bool gano = false;

            if (opcion == 1)
            {
                gano = resultado == apuestaObject.NumeroElegido;  
            }
            else if (opcion == 2)
            {
                gano = (colorResultado == "R" && descripcionApuesta == "Color Rojo") || (colorResultado == "N" && descripcionApuesta == "Color Negro");
            }
            else if (opcion == 3)
            {
                gano = (resultado != 0 && resultado % 2 == 0 && descripcionApuesta == "Par") || (resultado != 0 && resultado % 2 != 0 && descripcionApuesta == "Impar");
            }

            if (gano)
            {
                int ganancia = apuesta * (opcion == 1 ? 10 : (opcion == 2 ? 5 : 2));    // Dependiendo de la opción
                dinero += ganancia + apuesta;
                historial.Add($"¡Conseguiste! (+ {ganancia})");
            }
            else
            {
                historial.Add($"Perdiste (-{apuesta})");
            }
        }

        Console.WriteLine("¡El juego ha terminado!");
        Console.WriteLine($"Dinero final: ${dinero}");
        Console.WriteLine("Historial de giros:");

        foreach (string apuesta in historial)
        {
            Console.WriteLine(apuesta);
        }

        if (dinero > dineroInicial)
        {
            Console.WriteLine($"¡Felicidades! Lo que Ganaste ${dinero - dineroInicial}");
        }
        else if (dinero < dineroInicial)
        {
            Console.WriteLine($"Lo siento, perdiste ${dineroInicial - dinero}");
        }
        else
        {
            Console.WriteLine("Terminaste en el punto de partida, no ganaste ni perdiste dinero, solo tu tiempo ;)");
        }
    }
}
