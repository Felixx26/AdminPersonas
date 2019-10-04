using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Process
{
    public class Person
    {

        public Person(string nombre, string apellido, string fecha, int edad, string sexo, string estado)
        {
            Nombre = nombre;
            Apellido = apellido;
            Fecha = fecha;
            Edad = edad;
            Sexo = sexo;
            Estado = estado;

        }

        public string Nombre { get => Nombre; set => Nombre = value; }
        public string Apellido { get => Apellido; set => Apellido = value; }
        public string Fecha { get => Fecha; set => Fecha = value; }
        public int Edad { get => Edad; set => Edad = value; }
        public string Sexo { get => Sexo; set => Sexo = value; }
        public string Estado { get => Estado; set => Estado = value; }


    }
}
