using System;
using System.Windows.Forms;
using SistemaHospitalario.Logica;

namespace SistemaHospitalario
{
    public partial class FrmCitas : Form
    {
        public FrmCitas()
        {
            InitializeComponent();
            cmbCodigoPaciente.Items.AddRange(new object[] { "Paciente001", "Paciente002" });
            cmbCodigoEmpleado.Items.AddRange(new object[] { "EmpleadoA", "EmpleadoB" });

            dgvCitas.ColumnCount = 6;
            dgvCitas.Columns[0].Name = "Código Paciente";
            dgvCitas.Columns[1].Name = "Código Empleado";
            dgvCitas.Columns[2].Name = "Fecha Ingreso";
            dgvCitas.Columns[3].Name = "Fecha Egreso";
            dgvCitas.Columns[4].Name = "Costo Tratamiento";
            dgvCitas.Columns[5].Name = "Costo Habitación";
        }

        private void btnCalcular_Click_1(object sender, EventArgs e)
        {
            double costoTratamiento = CLCitas.MtdCostoTratamientos(cmbCodigoPaciente.Text);
            double costoHabitacion = CLCitas.MtdCostoHabitacion(cmbCodigoPaciente.Text);


            txtCostoTratamiento.Text = costoTratamiento.ToString("F2");
            txtCostoHabitacion.Text = costoHabitacion.ToString("F2");

        }
 


        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            string[] row = new string[]
           {
                cmbCodigoPaciente.Text,
                cmbCodigoEmpleado.Text,
                dtpFechaIngreso.Value.ToShortDateString(),
                dtpFechaEgreso.Value.ToShortDateString(),
                txtCostoTratamiento.Text,
                txtCostoHabitacion.Text
           };

            dgvCitas.Rows.Add(row);
        }


        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            if (dgvCitas.CurrentRow != null && dgvCitas.CurrentRow.Index >= 0)
            {
                int fila = dgvCitas.CurrentRow.Index;

                dgvCitas.Rows[fila].Cells[0].Value = cmbCodigoPaciente.Text;
                dgvCitas.Rows[fila].Cells[1].Value = cmbCodigoEmpleado.Text;
                dgvCitas.Rows[fila].Cells[2].Value = dtpFechaIngreso.Value.ToShortDateString();
                dgvCitas.Rows[fila].Cells[3].Value = dtpFechaEgreso.Value.ToShortDateString();
                dgvCitas.Rows[fila].Cells[4].Value = txtCostoTratamiento.Text;
                dgvCitas.Rows[fila].Cells[5].Value = txtCostoHabitacion.Text;

                MessageBox.Show("Cita actualizada correctamente.", "Edición", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Selecciona una fila para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
 


        private void FrmCitas_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToShortDateString();
        }

        private void lblFecha_Click(object sender, EventArgs e)
        {
           

        }


        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (dgvCitas.CurrentRow != null && dgvCitas.CurrentRow.Index >= 0)
            {
                int fila = dgvCitas.CurrentRow.Index;

                DialogResult confirmacion = MessageBox.Show(
                    "¿Estás seguro de que deseas eliminar esta cita?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (confirmacion == DialogResult.Yes)
                {
                    dgvCitas.Rows.RemoveAt(fila);
                    MessageBox.Show("Cita eliminada correctamente.", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Selecciona una fila para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}