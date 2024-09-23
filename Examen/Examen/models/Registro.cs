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
        // Almacenar 30 personas
        public List<Persona> Personas { get; set; } = new List<Persona>();
        public void AgregarPersona(Persona persona)
        {
            Personas.Add(persona);
        }
        public void EliminarPersona(Persona persona)
        {
            Personas.Remove(persona);
        }
        // Mostrar las personas en el lbPersona
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
