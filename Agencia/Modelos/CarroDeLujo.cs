using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agencia.Modelos
{
    internal class CarroDeLujo : Carro  //Recibe herencia de Carro
    {
        public bool Camaras { get; set; }
        public bool Estereo { get; set; }
        public bool FarosNiebla { get; set; }
        public bool AsientosLujo { get; set; }
        public string Modo { get; set; }

        public CarroDeLujo(string modelo, short anio, string marca, string color, bool encendido, int velocidad, bool camaras, bool estereo, bool farosNiebla, bool asientosLujo, string modo)
                    :base(modelo,anio,marca,color,encendido,velocidad)
        {

            Camaras = camaras;
            Estereo = estereo;
            FarosNiebla = farosNiebla;
            AsientosLujo = asientosLujo;
            Modo = modo;
        }

        public void CambiaModo(string Modo) {
            this.Modo = Modo;
        }
    }
}
