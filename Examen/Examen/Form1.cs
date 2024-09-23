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
            // Se ingresa el nombre de la persona

        }

        private void tbApellido_TextChanged(object sender, EventArgs e)
        {
            // Se ingresa el apellido de la persona

        }
        private void dtpNacimiento_ValueChanged(object sender, EventArgs e)
        {
            // Se ingresa la fecha de nacimiento de la persona

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Ciudad de la persona
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Se almacenan los datos de la persona
            agregar();    

        }
        private void agregar()
        {
            if (tbNombre.Text.Trim().Length > 0)
            {
                string nombre = tbNombre.Text.Trim();

            }
        }
        private void btnMostrarEdad_Click(object sender, EventArgs e)
        {
            // El botón muestra la edad de la persona



        }

       
    }
}
