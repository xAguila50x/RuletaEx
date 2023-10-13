using System;

namespace Ruleta.Clases
{
    internal class Apuesta
    {
        public string TipoApuesta { get; set; }
        public int CantidadApuesta { get; set; }
        public int DineroInicial { get; set; }
        public int NumeroElegido { get; set; }
        public string DescripcionApuesta { get; set; }

        public Apuesta(string tipoApuesta, int dineroInicial = 300, string descripcionApuesta = "", int numeroElegido = 0)
        {
            TipoApuesta = tipoApuesta;
            DineroInicial = dineroInicial;
            DescripcionApuesta = descripcionApuesta;
            NumeroElegido = numeroElegido;
        }

        public void RealizarApuestaNumero()
        {
            Console.Write("Elige un número (0-36): ");
            NumeroElegido = int.Parse(Console.ReadLine());
            Console.Write("Apuesta: $");
            CantidadApuesta = int.Parse(Console.ReadLine());

            if (CantidadApuesta <= DineroInicial)
            {
                if (NumeroElegido >= 0 && NumeroElegido <= 36 && CantidadApuesta % 10 == 0)
                {
                    DescripcionApuesta = "Número " + NumeroElegido;
                }
                else
                {
                    Console.WriteLine("Apuesta no válida. Inténtalo de nuevo, recuerda que tienes que apostar en múltiplos de 10 y en el rango de números.");
                }
            }
            else
            {
                Console.WriteLine("No tienes tanto dinero, te expulsamos por pobre.");
            }
        }

        public void RealizarApuestaColor()
        {
            Console.Write("Elige un color (R/N): ");
            string colorElegido = Console.ReadLine().ToUpper();
            Console.Write("Apuesta: $");
            CantidadApuesta = int.Parse(Console.ReadLine());

            if (CantidadApuesta <= DineroInicial)
            {
                if ((colorElegido == "R" || colorElegido == "N") && CantidadApuesta % 10 == 0)
                {
                    DescripcionApuesta = colorElegido == "R" ? "Color Rojo" : "Color Negro";
                }
                else
                {
                    Console.WriteLine("Apuesta no válida. Inténtalo de nuevo, recuerda que tienes que apostar en múltiplos de 10 y elegir el color R o N.");
                }
            }
            else
            {
                Console.WriteLine("No tienes tanto dinero, te expulsamos por pobre.");
            }
        }

        public void RealizarApuestaParImpar()
        {
            Console.Write("Elige par (P) o impar (I): ");
            string paridadElegida = Console.ReadLine().ToUpper();
            Console.Write("Apuesta: $");
            CantidadApuesta = int.Parse(Console.ReadLine());

            if (CantidadApuesta <= DineroInicial)
            {
                if ((paridadElegida == "P" || paridadElegida == "I") && CantidadApuesta % 10 == 0)
                {
                    DescripcionApuesta = paridadElegida == "P" ? "Par" : "Impar";
                }
                else
                {
                    Console.WriteLine("Apuesta no válida. Inténtalo de nuevo, recuerda que tienes que apostar en múltiplos de 10 y seleccionar P o I.");
                }
            }
            else
            {
                Console.WriteLine("No tienes tanto dinero, te expulsamos por pobre.");
            }
        }
    }
}
