using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBDDistribuidas
{
    public partial class SUPERMERCADO : Form
    {
        ConexionBD con = new ConexionBD();
        public SUPERMERCADO()
        {
            InitializeComponent();
            con.Abrir();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
