using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Prueba2_NET_MarceloAranda_2018.Model
{
    interface IDAO <T>
    {

        void Create(T ob);
        DataTable Read();
        void Update(T ob);
        void DeleteAutomovil(int id);
        void DeleteDuenio(String run);

        DataTable BuscarPorPatente(String patente);


    }
}
