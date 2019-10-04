using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdminPersonas.person;

namespace AdminPersonas
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

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
