using System;
using System.Windows.Forms;
using SistemaHospitalario.Logica;

namespace SistemaHospitalario
{
    public partial class FrmPagoCitas : Form
    {
        public FrmPagoCitas()
        {
            InitializeComponent();
            cmbCodigoCita.Items.AddRange(new object[] { "Cita001", "Cita002" });
            cmbTipoPago.Items.AddRange(new object[] { "Efectivo", "Tarjeta", "Transferencia" });

            dgvPagoCitas.ColumnCount = 7;
            dgvPagoCitas.Columns[0].Name = "Código Cita";
            dgvPagoCitas.Columns[1].Name = "Monto Cita";
            dgvPagoCitas.Columns[2].Name = "Impuesto";
            dgvPagoCitas.Columns[3].Name = "Descuento";
            dgvPagoCitas.Columns[4].Name = "Total Pago";
            dgvPagoCitas.Columns[5].Name = "Fecha Pago";
            dgvPagoCitas.Columns[6].Name = "Tipo Pago";
        }

        private void btnCalcular_Click_1(object sender, EventArgs e)
        {
          /*  double monto = double.Parse(txtMontoCita.Text);
            double impuesto = PagoCita.MtdImpuestoPago(monto);
            double descuento = PagoCita.MtdDescuentoPago(monto);
            double total = PagoCita.MtdTotalPago(monto, impuesto, descuento);

           txtImpuesto.Text = impuesto.ToString("F2");
           txtDescuento.Text = descuento.ToString("F2");
           txtTotalPago.Text = total.ToString("F2");
          */
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            string[] row = new string[]
            {
                cmbCodigoCita.Text,
                txtMontoCita.Text,
                txtImpuesto.Text,
                txtDescuento.Text,
                txtTotalPago.Text,
                dtpFechaPago.Value.ToShortDateString(),
                cmbTipoPago.Text
            };

            dgvPagoCitas.Rows.Add(row);
        }

       /* private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cmbCodigoCita.SelectedIndex = -1;
            txtMontoCita.Clear();
            txtImpuesto.Clear();
            txtDescuento.Clear();
            txtTotalPago.Clear();
            dtpFechaPago.Value = DateTime.Now;
            cmbTipoPago.SelectedIndex = -1;
            dgvPagoCitas.Rows.Clear();
        }*/

        private void dgvPagoCitas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmPagoCitas_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToShortDateString();
        }


        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvPagoCitas.CurrentRow != null && dgvPagoCitas.CurrentRow.Index >= 0)
            {
                int fila = dgvPagoCitas.CurrentRow.Index;

                dgvPagoCitas.Rows[fila].Cells[0].Value = cmbCodigoCita.Text;
                dgvPagoCitas.Rows[fila].Cells[1].Value = txtMontoCita.Text;
                dgvPagoCitas.Rows[fila].Cells[2].Value = txtImpuesto.Text;
                dgvPagoCitas.Rows[fila].Cells[3].Value = txtDescuento.Text;
                dgvPagoCitas.Rows[fila].Cells[4].Value = txtTotalPago.Text;
                dgvPagoCitas.Rows[fila].Cells[5].Value = dtpFechaPago.Value.ToShortDateString();
                dgvPagoCitas.Rows[fila].Cells[6].Value = cmbTipoPago.Text;

                MessageBox.Show("Pago de cita actualizado correctamente.", "Edición", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Selecciona una fila para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvPagoCitas.CurrentRow != null && dgvPagoCitas.CurrentRow.Index >= 0)
            {
                DialogResult confirmacion = MessageBox.Show(
                    "¿Deseas eliminar este registro de pago de cita?",
                    "Confirmación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (confirmacion == DialogResult.Yes)
                {
                    dgvPagoCitas.Rows.RemoveAt(dgvPagoCitas.CurrentRow.Index);
                    MessageBox.Show("Pago de cita eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Selecciona una fila para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

   

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}