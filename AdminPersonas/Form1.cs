using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Process;

namespace AdminPersonas
{
    public partial class Form1 : Form
    {
        Process.Process process;
        Process.Person person;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                try
                {
                    string nombre = textBox1.Text;
                    string apellido = textBox2.Text;
                    string fecha = textBox3.Text;
                    int edad = Convert.ToInt32(textBox4.Text);
                    string sexo = textBox5.Text;
                    string estado = textBox6.Text;

                    person = new Person(nombre, apellido, fecha, edad, sexo, estado);
                    process.Save(person, dataGridView1);

                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                    textBox6.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                if (MessageBox.Show(this, "¿Seguro que desea eliminar este registro?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    process.Delete(dataGridView1);
                }
            }
        }
    }
}
