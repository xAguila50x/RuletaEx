namespace Fundamentos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string mensaje = "Este es un mensaje";
            int @if = 0;    //si hay una varible con nombre de if, swintch, entre otras poner un @ antes para que se pueda usar
            var variable = true;    //se adapta al tipo de variable pero consume mucha memoria
            dynamic dinamico = "asfasfasfg";    //sirve para cuando no sabemos que tipo de dato nos va regresar ya que en el var exige el tipo de dato al declararlo

            Console.WriteLine(mensaje);
            Console.WriteLine(@if);
            Console.WriteLine(mensaje + @if);
            bool b1 = true;
            bool b2 = false;
            if (@if > 0)
                Console.WriteLine("Si es mayor");
            else
                Console.WriteLine("No es mayor");
            
            if (b1 && b2)
                Console.WriteLine("Si");
            else
                Console.WriteLine("No");

            for (int i = 0; i < 10; i++) {
                Console.WriteLine(i);
            }
            
            int x = 0;
            while (x < 10)
            {
                Console.WriteLine(x);
                x++;
            }

        }
    }
}