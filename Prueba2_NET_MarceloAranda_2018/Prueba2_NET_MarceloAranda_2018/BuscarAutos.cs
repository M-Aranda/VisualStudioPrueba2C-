using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Prueba2_NET_MarceloAranda_2018.Model;

namespace Prueba2_NET_MarceloAranda_2018
{
    public partial class buscarAutos : Form
    {
        public buscarAutos()
        {
            InitializeComponent();
            DAO_automovil da = new DAO_automovil();
            DAO_UltimoDuenio du = new DAO_UltimoDuenio();

            DataTable listaAutos = da.Read();

            cboAutos.DataSource = listaAutos;
            cboAutos.DropDownStyle = ComboBoxStyle.DropDownList;

            cboAutos.DisplayMember = "patente";
            cboAutos.ValueMember = "id";


        }

        private void cboAutos_SelectedIndexChanged(object sender, EventArgs e)
        {

            
        }
    }
}
