using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba2_NET_MarceloAranda_2018.Model
{
    public class DAO_automovil: Conexion, IDAO<Automovil>
    {
        public DAO_automovil(): base ("registroDeAutomovilesUsadosMAAT")
        {

        }

        public DataTable BuscarPorPatente(string patente)
        {

            DataTable dt = new DataTable();
            dt = Ejecutar("SELECT * FROM automovil WHERE patente='"+patente+"' ");
            return dt;

        }

        public void Create(Automovil ob)
        {
            Ejecutar("INSERT INTO automovil VALUES ('"+ob.Patente+"', '"+ob.Marca+"', "+ob.Anio+", '"+ob.Detalles+"' " +
                ", '"+ob.Duenio.Run+"')");
        }

        public void DeleteAutomovil(int id)
        {
            Ejecutar("DELETE FROM automovil WHERE id="+id+"");
        }

        public void DeleteDuenio(string run)
        {
            throw new NotImplementedException();
        }

        public DataTable Read()
        {

            DataTable dt = new DataTable();
            dt=Ejecutar("SELECT * FROM automovil");
            return dt;
        }

        public void Update(Automovil ob)
        {
            Ejecutar("UPDATE automovil SET patente='" + ob.Patente + "',  marca='" + ob.Marca + "', anio=" + ob.Anio + ", detalles='" + ob.Detalles + "' " +
                ", datosUltimoDuenio='" + ob.Duenio.Run + "')");
        }
    }
}
