using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.models
{
    internal class Operacion
    {
        public Operacion() { }

        public Persona persona { get; set; }
        public int Edad { get; set; }
        public string MayorMenor { get; set; }

        // Calcula la edad de una persona
        public void CalcularEdad(DateTime fechaNacimiento)
        {
            // Calcula la edad en años
            int edad = DateTime.Now.Year - fechaNacimiento.Year;

            // Verifica si ya pasó el cumpleaños este año, si no, resta un año
            if (fechaNacimiento > DateTime.Now.AddYears(-edad))
            {
                edad--;
            }

            Edad = edad;

            if (Edad >= 18)
            {
                MayorMenor = "Mayor de edad";
            }
            else
            {
                MayorMenor = "Menor de edad";
            }
        }
        
    }
}

