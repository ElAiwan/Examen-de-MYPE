using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen
{
    public partial class RdE : Form
    {
        public RdE()
        {
            InitializeComponent();
        }

        private void tbNombre_TextChanged(object sender, EventArgs e)
        {
            // Se almacena el Nombre de la persona

        }

        private void tbApellido_TextChanged(object sender, EventArgs e)
        {
            // Se almacena el Apellido de la persona

        }
        private void dtpNacimiento_ValueChanged(object sender, EventArgs e)
        {
            // Fecha de nacimiento de la persona
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Ciudad de la persona
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Agregar propiedades de la persona
            btnAgregar.Enabled = true;

        }

        private void btnMostrarEdad_Click(object sender, EventArgs e)
        {
            // Mostrar edad
            btnMostrarEdad.Enabled = true;

        }

       
    }
}
