using Examen.models;
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
        Persona persona = new Persona();
        public RdE()
        {
            InitializeComponent();
        }

        private void tbNombre_TextChanged(object sender, EventArgs e)
        {
            // Se ingresa el nombre de la persona
            tbNombre.Text = tbNombre.Text.Trim();

        }

        private void tbApellido_TextChanged(object sender, EventArgs e)
        {
            // Se ingresa el apellido de la persona
            tbApellido.Text = tbApellido.Text.Trim();
        }
        private void dtpNacimiento_ValueChanged(object sender, EventArgs e)
        {
            // Se ingresa la fecha de nacimiento de la persona
            dtpNacimiento.Value = dtpNacimiento.Value;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Ciudad de la persona
            cbCiudad.Text = cbCiudad.Text;
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
                string apellido = tbApellido.Text.Trim();
                int fechaNacimiento = dtpNacimiento.Value.Year;
                string ciudad = cbCiudad.Text;
                
                persona.Nombre = nombre;
                persona.Apellido = apellido;
                persona.FechaNacimiento = dtpNacimiento.Value;
                persona.Ciudad = ciudad;
                Registro registro = new Registro();
                registro.AgregarPersona(persona);
                lbPersona.Items.Add($"{persona.Nombre} {persona.Apellido} {persona.FechaNacimiento} {persona.Ciudad}");


            }
        }
        private void btnMostrarEdad_Click(object sender, EventArgs e)
        {
            // El botón muestra la edad de la persona
            Operacion operacion = new Operacion();
            operacion.CalcularEdad(persona.FechaNacimiento);
            MessageBox.Show($"La edad de la persona es: {operacion.Edad} años, {operacion.MayorMenor}");


        }

        private void lbPersona_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
