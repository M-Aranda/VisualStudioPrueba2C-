using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Prueba2_NET_MarceloAranda_2018;

namespace Prueba2_NET_MarceloAranda_2018
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void opRegistrarAutomóvilToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            regAutos regA = new regAutos();
            regA.Show();
            
            
        }

        private void opBuscarAutomóvilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buscarAutos ba = new buscarAutos();
            ba.Show();
        }
    }
}
