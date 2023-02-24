using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AslinCueva
{
    public partial class Formulario2 : Form
    {
        public Formulario2()
        {
            InitializeComponent();
        }
        private void Formulario2_Load(object sender, System.EventArgs e)
        {
            ProductoTextBox.Focus();
        }

        private void CerrarFormularioButton_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private async void GenerarFacturaButton_Click(object sender, System.EventArgs e)
        {
            decimal subTotalDataGridView = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                decimal descuentoTotal = 0;
                subTotalDataGridView += Convert.ToDecimal(row.Cells["PrecioColumn"].Value);
                descuentoTotal = subTotalDataGridView * 0.15M;
                DescuentoTextBox.Text = descuentoTotal.ToString("0,0.00");
            }
            SubtotalTextBox.Text = subTotalDataGridView.ToString("0,0.00");

            decimal subtotal = Convert.ToDecimal(SubtotalTextBox.Text);
            decimal descuento = Convert.ToDecimal(DescuentoTextBox.Text);

            decimal totalDescuento = await TotalAPagarAsync(subtotal, descuento);
            TotalAPagarTextBox.Text = ("L. " + totalDescuento.ToString("0,00.00"));

        }

        private async Task<decimal> TotalAPagarAsync(decimal subTotal, decimal descuentoSobreVenta)
        {

            decimal total = await Task.Run(() =>
            {
                subTotal = Convert.ToDecimal(SubtotalTextBox.Text);
                descuentoSobreVenta = Convert.ToDecimal(DescuentoTextBox.Text);

                return subTotal - descuentoSobreVenta;
            });
            return total;

        }

        private void AgregarProductoButton_Click(object sender, System.EventArgs e)
        {
            if (ProductoTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(ProductoTextBox, "Ingrese el nombre del producto.");
                return;
            }
            errorProvider1.Clear();

            if (PrecioTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(PrecioTextBox, "Ingrese el precio del producto.");
                return;
            }
            errorProvider1.Clear();


            dataGridView1.Rows.Add(ProductoTextBox.Text, PrecioTextBox.Text);
            ProductoTextBox.Clear();
            PrecioTextBox.Clear();
            ProductoTextBox.Focus();

        }

        private void BorrarFacturaButton_Click(object sender, EventArgs e)
        {
            ProductoTextBox.Clear();
            PrecioTextBox.Clear();
            dataGridView1.Rows.Clear();
            SubtotalTextBox.Clear();
            DescuentoTextBox.Clear();
            TotalAPagarTextBox.Clear();
            errorProvider1.Clear();
        }
    }
}
