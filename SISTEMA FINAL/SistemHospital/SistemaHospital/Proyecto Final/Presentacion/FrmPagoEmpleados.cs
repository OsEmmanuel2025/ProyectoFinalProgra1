using System;
using System.Windows.Forms;

namespace SistemaHospitalario
{
    public partial class FrmPagoEmpleados : Form
    {
        public FrmPagoEmpleados()
        {
            InitializeComponent();
            cmbTipoTrabajo.Items.AddRange(new object[] { "Director", "Medico", "Enfermero", "Tecnico", "Farmaceutico" });
            cmbEstado.Items.AddRange(new object[] { "Activo", "Inactivo", "Suspendido", "Despedido" });

            dgvPagoEmpleados.ColumnCount = 4;
            dgvPagoEmpleados.Columns[0].Name = "Tipo Trabajo";
            dgvPagoEmpleados.Columns[1].Name = "Sueldo";
            dgvPagoEmpleados.Columns[2].Name = "Fecha Alta";
            dgvPagoEmpleados.Columns[3].Name = "Estado";
        }

        private void btnCalcular_Click_1(object sender, EventArgs e)
        {
            double sueldo = CLPagoEmpleados.MtdSalarioEmpleado(cmbTipoTrabajo.Text);
            txtSueldo.Text = sueldo.ToString("F2");

        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            string[] row = new string[]
            {
                cmbTipoTrabajo.Text,
                txtSueldo.Text,
                dtpFechaAlta.Value.ToShortDateString(),
                cmbEstado.Text
            };

            dgvPagoEmpleados.Rows.Add(row);

        }

        private void FrmPagoEmpleados_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToShortDateString();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvPagoEmpleados.CurrentRow != null && dgvPagoEmpleados.CurrentRow.Index >= 0)
            {
                int fila = dgvPagoEmpleados.CurrentRow.Index;

                dgvPagoEmpleados.Rows[fila].Cells[0].Value = cmbTipoTrabajo.Text;
                dgvPagoEmpleados.Rows[fila].Cells[1].Value = txtSueldo.Text;
                dgvPagoEmpleados.Rows[fila].Cells[2].Value = dtpFechaAlta.Value.ToShortDateString();
                dgvPagoEmpleados.Rows[fila].Cells[3].Value = cmbEstado.Text;

                MessageBox.Show("Pago del empleado actualizado correctamente.", "Edición", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Selecciona una fila para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvPagoEmpleados.CurrentRow != null && dgvPagoEmpleados.CurrentRow.Index >= 0)
            {
                DialogResult confirmacion = MessageBox.Show(
                    "¿Estás seguro de que deseas eliminar esta fila?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (confirmacion == DialogResult.Yes)
                {
                    dgvPagoEmpleados.Rows.RemoveAt(dgvPagoEmpleados.CurrentRow.Index);
                    MessageBox.Show("Fila eliminada correctamente.", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Selecciona una fila para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}