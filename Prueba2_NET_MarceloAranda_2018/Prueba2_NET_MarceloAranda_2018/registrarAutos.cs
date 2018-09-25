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
using Prueba2_NET_MarceloAranda_2018.Utilidades;

namespace Prueba2_NET_MarceloAranda_2018
{
    public partial class regAutos : Form
    {
        public regAutos()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            DAO_automovil da = new DAO_automovil();
            DAO_UltimoDuenio du = new DAO_UltimoDuenio();
            Util utilidad = new Util();
            Automovil auto = new Automovil();


            String patente = txtPatente.Text;
            String marca = txtMarca.Text;
            int anio = int.Parse(txtAnio.Text);
            String detalles = txtDetalle.Text;

            UltimoDuenio u = new UltimoDuenio();
            u.Run = txtRun.Text;
            u.NombreCompleto = txtNombre.Text;
            u.Telefono = txtTelefono.Text;

            auto.Patente = patente;
            auto.Marca = marca;
            auto.Anio = anio;
            auto.Detalles = detalles;
            auto.Duenio = u;

            String digito = utilidad.GetDigito(u.Run);
            Boolean estaBien = utilidad.IsRutOk(u.Run, digito);



            if (estaBien == false)
            {
                MessageBox.Show("Error");
            }else if (estaBien == true)
            {
                du.Create(u);
                da.Create(auto);

            }





        }
    }
}
