using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Process
{
    public class Process
    {
        private Person person;

        public void Save(Person person, DataGridView dataGridView)
        {
            DataGridViewRow rows = new DataGridViewRow();
            rows.CreateCells(dataGridView);
            rows.Cells[0].Value = person.Id;
            rows.Cells[1].Value = person.Nombre;
            rows.Cells[2].Value = person.Apellido;
            rows.Cells[3].Value = person.Fecha;
            rows.Cells[4].Value = person.Edad;
            rows.Cells[5].Value = person.Sexo;
            rows.Cells[6].Value = person.Estado;
            dataGridView.Rows.Add(rows);
        }

        public void Delete(DataGridView dataGridView)
        {
            dataGridView.Rows.Remove(dataGridView.CurrentRow);
        }
    }
}
