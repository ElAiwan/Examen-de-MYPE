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
        // Calcular la edad de una persona y decir si es mayor o menor de edad
        public Operacion(string name) { }
        public string Name { get; set; }
        public int Edad { get; set; }
        public string MayorMenor { get; set; }
        public void CalcularEdad(int fechaNacimiento)
        {
            Edad = 2021 - fechaNacimiento;
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
