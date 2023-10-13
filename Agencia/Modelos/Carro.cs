using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agencia.Modelos
{
    internal class Carro
    {
        public string Modelo { get; set; }
        public short Anio { get; set; }
        public string Marca { get; set; }
        public string Color { get; set; }
        public bool Encendido { get; set; }
        public int Velocidad { get; set; }

        public Carro(string modelo, short anio, string marca, string color, bool encendido, int velocidad)  //Inicializacion
        {
            Modelo = modelo;
            Anio = anio;
            Marca = marca;
            Color = color;
            Encendido = encendido;
            Velocidad = velocidad;
        }

        public void acelerar() {
            if (this.Encendido)
                this.Velocidad += 10;
            else
                Console.WriteLine("El auto está apagado Animal!!");
        }

        public void frenar(){
            if (this.Velocidad != 0)
                this.Velocidad -= 10;
            else
                Console.WriteLine("Ya está detenido q no ves o que???");
        }

        public void encender(){
            this.Encendido = true;
        }

        public void apagar(){
            this.Encendido = false;
        }
    }
}
