using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba2_NET_MarceloAranda_2018.Model
{
    public class Automovil
    {
        int id;
        String patente;
        String marca;
        int anio;
        String detalles;
        UltimoDuenio duenio;

        public Automovil()
        {

        }

        public int Id { get => id; set => id = value; }
        public string Patente { get => patente; set => patente = value; }
        public string Marca { get => marca; set => marca = value; }
        public int Anio { get => anio; set => anio = value; }
        public string Detalles { get => detalles; set => detalles = value; }
        public UltimoDuenio Duenio { get => duenio; set => duenio = value; }
    }
}
