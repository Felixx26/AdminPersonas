using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Process
{
    class Person
    {

        public Person(int id, string nombre, string Apellido, string fecha, int edad, string sexo, string estado)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Apellido = Apellido;
            this.Fecha = fecha;
            this.Edad = edad;
            this.Sexo = sexo;
            this.Estado = estado;

        }

        public int Id { get => Id; set => Id = value; }
        public string Nombre { get => Nombre; set => Nombre = value; }
        public string Apellido { get => Apellido; set => Apellido = value; }
        public string Fecha { get => Fecha; set => Fecha = value; }
        public int Edad { get => Edad; set => Edad = value; }
        public string Sexo { get => Sexo; set => Sexo = value; }
        public string Estado { get => Estado; set => Estado = value; }


    }
}
