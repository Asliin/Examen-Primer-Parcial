using System;
using System.Windows.Forms;

namespace AslinCueva
{
    public partial class Formulario3 : Form
    {
        public Formulario3()
        {
            InitializeComponent();
        }

        private void CerrarFormularioButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EjecutarButton_Click(object sender, EventArgs e)
        {
            for (int numero = 1; numero <= 100; numero++)
            {
                if (numero % 3 == 0 && numero % 5 == 0)
                {
                    NumerosListBox.Items.Add("Aslin Cueva");
                }

                else if (numero % 3 == 0)
                {
                    NumerosListBox.Items.Add("Aslin");
                }

                else if (numero % 5 == 0)
                {
                    NumerosListBox.Items.Add("Cueva");
                }

                else
                {
                    NumerosListBox.Items.Add(numero);
                }
            }
        }


    }
}
