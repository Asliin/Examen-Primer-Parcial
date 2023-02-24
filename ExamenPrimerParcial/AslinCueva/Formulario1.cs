using System;
using System.Windows.Forms;

namespace AslinCueva
{
    public partial class Formulario1 : Form
    {
        public Formulario1()
        {
            InitializeComponent();
        }

        private void CalcularInteresesButtom_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("El cliente " + NombreTextBox.Text + " presenta intereses ganados mes a mes de:");
            listBox1.Items.Add("Enero:               L. " + Enero());
            listBox1.Items.Add("Febrero:                " + Febrero());
            listBox1.Items.Add("Marzo:                   " + Marzo());
            listBox1.Items.Add("Abril:                     " + Abril());
            listBox1.Items.Add("Mayo:                   " + Mayo());
            listBox1.Items.Add("Junio:                   " + Junio());
            listBox1.Items.Add("Julio:                     " + Julio());
            listBox1.Items.Add("Agosto:                 " + Agosto());
            listBox1.Items.Add("Septiembre:         " + Septiembre());
            listBox1.Items.Add("Octubre:              " + Octubre());
            listBox1.Items.Add("Noviembre:         " + Noviembre());
            listBox1.Items.Add("Diciembre:          " + Diciembre());
        }

        private string CalcularIntereses()
        {
            decimal capital = 200000;
            decimal tasaInteres = 0.015M;
            decimal tiempo = 1;
            decimal Intereses = 0;

            Intereses = capital * (tasaInteres * tiempo);

            return Intereses.ToString("0,0.00");
        }

        private string Enero()
        {
            decimal interesInicial = Convert.ToDecimal(CalcularIntereses());
            decimal interesAcumulado = interesInicial + (interesInicial * 0);
            return interesAcumulado.ToString("0,0.00");
        }

        private string Febrero()
        {
            decimal interesInicial = Convert.ToDecimal(CalcularIntereses());
            decimal interesAcumulado = interesInicial + (interesInicial * 1);
            return interesAcumulado.ToString("0,0.00");
        }

        private string Marzo()
        {
            decimal interesInicial = Convert.ToDecimal(CalcularIntereses());
            decimal interesAcumulado = interesInicial + (interesInicial * 2);
            return interesAcumulado.ToString("0,0.00");
        }

        private string Abril()
        {
            decimal interesInicial = Convert.ToDecimal(CalcularIntereses());
            decimal interesAcumulado = interesInicial + (interesInicial * 3);
            return interesAcumulado.ToString("0,0.00");
        }

        private string Mayo()
        {
            decimal interesInicial = Convert.ToDecimal(CalcularIntereses());
            decimal interesAcumulado = interesInicial + (interesInicial * 4);
            return interesAcumulado.ToString("0,0.00");
        }

        private string Junio()
        {
            decimal interesInicial = Convert.ToDecimal(CalcularIntereses());
            decimal interesAcumulado = interesInicial + (interesInicial * 5);
            return interesAcumulado.ToString("0,0.00");
        }

        private string Julio()
        {
            decimal interesInicial = Convert.ToDecimal(CalcularIntereses());
            decimal interesAcumulado = interesInicial + (interesInicial * 6);
            return interesAcumulado.ToString("0,0.00");
        }

        private string Agosto()
        {
            decimal interesInicial = Convert.ToDecimal(CalcularIntereses());
            decimal interesAcumulado = interesInicial + (interesInicial * 7);
            return interesAcumulado.ToString("0,0.00");
        }

        private string Septiembre()
        {
            decimal interesInicial = Convert.ToDecimal(CalcularIntereses());
            decimal interesAcumulado = interesInicial + (interesInicial * 8);
            return interesAcumulado.ToString("0,0.00");
        }

        private string Octubre()
        {
            decimal interesInicial = Convert.ToDecimal(CalcularIntereses());
            decimal interesAcumulado = interesInicial + (interesInicial * 9);
            return interesAcumulado.ToString("0,0.00");
        }

        private string Noviembre()
        {
            decimal interesInicial = Convert.ToDecimal(CalcularIntereses());
            decimal interesAcumulado = interesInicial + (interesInicial * 10);
            return interesAcumulado.ToString("0,0.00");
        }

        private string Diciembre()
        {
            decimal interesInicial = Convert.ToDecimal(CalcularIntereses());
            decimal interesAcumulado = interesInicial + (interesInicial * 11);
            return interesAcumulado.ToString("0,0.00");
        }

        private void CerrarFormularioButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
