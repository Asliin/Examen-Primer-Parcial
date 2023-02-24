using System;
using System.Windows.Forms;

namespace AslinCueva
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void AbrirFormulario1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formulario1 miformulario1 = new Formulario1();
            miformulario1.Show();
        }

        private void AbrirFormulario2ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Formulario2 miformulario2 = new Formulario2();
            miformulario2.Show();
        }

        private void AbrirFormulario3ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Formulario3 miformulario3 = new Formulario3();
            miformulario3.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
