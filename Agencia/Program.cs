/*using Agencia.Modelos;  //Necesario poner es el directorio de las clases
Carro carro = new Carro("Fit", 2015, "Honda", "Blanco Chocao", false, 0);
carro.encender();
carro.acelerar();
Console.WriteLine(carro.Velocidad);
carro.acelerar();
Console.WriteLine(carro.Velocidad);
carro.apagar();
carro.acelerar();
*/
using Agencia.Modelos;
int opcion;
List<Carro> listaCarros = new List<Carro>();
do
{
    do
    {
        Console.WriteLine("Opciones");
        Console.WriteLine("1.- Agregar carro");
        Console.WriteLine("2.- Mostrar Carros");

    } while (!int.TryParse(Console.ReadLine(), out opcion));  //Se lee pantalla Console.ReadLine() y se pasa a TryParse para convertirlo en entero si puede convertirlo se almaacena en opcion si no puede se devuelve falso y se repite el do

    switch (opcion)
    {
        case 1:
            agregarCarro();
            break;
        case 2:
            listarCarros();
            break;
    } 
} while (true);
void agregarCarro(){
    Carro carro = new Carro("Fit", 2015, "Honda", "Blanco Chocao", false, 0);
    listaCarros.Add(carro);
}

void listarCarros() {
    foreach ( Carro carro in listaCarros)
    {
        Console.WriteLine($"{carro.Marca}, {carro.Anio}, {carro.Modelo}, {carro.Color}");
    }
    Console.ReadLine();

}