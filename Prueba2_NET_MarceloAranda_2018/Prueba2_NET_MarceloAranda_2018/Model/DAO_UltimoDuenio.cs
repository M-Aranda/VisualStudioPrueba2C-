using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba2_NET_MarceloAranda_2018.Model
{
    public class DAO_UltimoDuenio : Conexion, IDAO<UltimoDuenio>
    {
        public DAO_UltimoDuenio() : base("registroDeAutomovilesUsadosMAAT")
        {

        }

        public DataTable BuscarPorPatente(string patente)
        {
            throw new NotImplementedException();
        }

        public void Create(UltimoDuenio ob)
        {
            Ejecutar("INSERT INTO ultimoDuenio VALUES ('"+ob.Run+"', '"+ob.NombreCompleto+"', '"+ob.Telefono+"')");
        }

        public void DeleteAutomovil(int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteDuenio(String run)
        {
            Ejecutar("DELETE FROM ultimoDuenio WHERE id=" + run + "");
        }

        public DataTable Read()
        {
            DataTable dt = new DataTable();
            dt=Ejecutar("SELECT * FROM ultimoDuenio");
            return dt;

        }

        public void Update(UltimoDuenio ob)
        {
            Ejecutar("UPDATE ultimoDuenio SET nombre='"+ob.NombreCompleto+"', telefono='"+ob.Telefono+"'  WHERE run='"+ob.Run+"' ");
        }

    }
}
