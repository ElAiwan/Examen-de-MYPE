using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.models
{
    internal class Registro
    {
        public Registro() { }
        public List<Persona> Personas { get; set; } = new List<Persona>();
        public void AgregarPersona(Persona persona)
        {
            Personas.Add(persona);
        }
        
        public string MostrarPersonas()
        {
            string listaPersonas = "";
            foreach (var persona in Personas)
            {
                listaPersonas += $"{persona.Nombre} {persona.Apellido} {persona.FechaNacimiento} {persona.Ciudad}\n";
            }
            return listaPersonas;
        }


    }
}
