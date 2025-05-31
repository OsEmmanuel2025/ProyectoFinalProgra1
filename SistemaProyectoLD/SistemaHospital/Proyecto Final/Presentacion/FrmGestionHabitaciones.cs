using HospitalProyecto.Datos;
using HospitalProyecto.Lógica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


namespace HospitalProyecto
{
    public partial class GestionHabitaciones : Form
    {
        CDGestionHabitaciones cd_GestionHabitaciones = new CDGestionHabitaciones();
        CLGestionHabitaciones cl_GestionHabitaciones = new CLGestionHabitaciones();

        public GestionHabitaciones()
        {
            InitializeComponent();
        }

        private void lblCosto_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            lblFechaAuditoria.Text = cl_GestionHabitaciones.MtdFechaHoy().ToString("d");
            MtdConsultarGestionHabitaciones();
        }

        private void MtdConsultarGestionHabitaciones()
        {
            DataTable DtGestionHabitaciones = cd_GestionHabitaciones.MtdConsultarGestionHabitaciones();
            dataGridView1.DataSource = DtGestionHabitaciones;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodigoEmpleado.Text) || string.IsNullOrEmpty(txtCodigoHabitacion.Text) || string.IsNullOrEmpty(cboxTipoGestion.Text) || string.IsNullOrEmpty(dtpFechaGestion.Text) || string.IsNullOrEmpty(cboxEstado.Text) || string.IsNullOrEmpty(txtUsuarioAuditoria.Text))
            {
                MessageBox.Show("Favor completar formulario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int CodigoEmpleado = (int.Parse(txtCodigoEmpleado.Text));
                int CodigoHabitacion = (int.Parse(txtCodigoHabitacion.Text));
                string TipoGestion = (cboxTipoGestion.Text);
                DateTime FechaGestion = dtpFechaGestion.Value;
                string Estado = cboxEstado.Text;
                DateTime FechaAuditoria = cl_GestionHabitaciones.MtdFechaHoy();
                string UsuarioAuditoria = "Emmanuel";

                try
                {
                    cd_GestionHabitaciones.MtdAgregarGestionHabitaciones(CodigoEmpleado, CodigoHabitacion, TipoGestion, FechaGestion, Estado, FechaAuditoria, UsuarioAuditoria);
                    MessageBox.Show("Datos agregados correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MtdConsultarGestionHabitaciones();
                    MtdLimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int FilaSeleccionada = dataGridView1.CurrentRow.Index;

            if (e.RowIndex == dataGridView1.RowCount - 1)
            {
                MessageBox.Show("Seleccione una fila con datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                txtCodigoGestion.Text = dataGridView1[0, FilaSeleccionada].Value.ToString();
                txtCodigoEmpleado.Text = dataGridView1[1, FilaSeleccionada].Value.ToString();
                txtCodigoHabitacion.Text = dataGridView1[2, FilaSeleccionada].Value.ToString();
                cboxTipoGestion.Text = dataGridView1[3, FilaSeleccionada].ToString();
                dtpFechaGestion.Text = dataGridView1[4, FilaSeleccionada].Value.ToString();
                cboxEstado.Text = dataGridView1[5, FilaSeleccionada].Value.ToString();
                txtUsuarioAuditoria.Text = dataGridView1[6, FilaSeleccionada].Value.ToString();
                lblFechaAuditoria.Text = dataGridView1[7, FilaSeleccionada].Value.ToString();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int FilaSeleccionada = dataGridView1.CurrentRow.Index;

            if (string.IsNullOrEmpty(txtCodigoEmpleado.Text) || string.IsNullOrEmpty(txtCodigoHabitacion.Text) || string.IsNullOrEmpty(cboxTipoGestion.Text) || string.IsNullOrEmpty(dtpFechaGestion.Text) || string.IsNullOrEmpty(cboxEstado.Text) || string.IsNullOrEmpty(txtUsuarioAuditoria.Text))
            {
                MessageBox.Show("Favor completar formulario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int CodigoGestion = (int.Parse(txtCodigoGestion.Text));
                int CodigoEmpleado = (int.Parse(txtCodigoEmpleado.Text));
                int CodigoHabitacion = (int.Parse(txtCodigoHabitacion.Text));
                string TipoGestion = (cboxTipoGestion.Text);
                DateTime FechaGestion = dtpFechaGestion.Value;
                string Estado = cboxEstado.Text;
                DateTime FechaAuditoria = cl_GestionHabitaciones.MtdFechaHoy();
                string UsuarioAuditoria = "Emmanuel";

                try
                {
                    cd_GestionHabitaciones.MtdActualizarGestionHabitaciones(CodigoGestion, CodigoEmpleado, CodigoHabitacion, TipoGestion, FechaGestion, Estado, FechaAuditoria, UsuarioAuditoria);
                    MessageBox.Show("Datos agregados correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MtdConsultarGestionHabitaciones();
                    MtdLimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MtdLimpiarCampos();
        }

        public void MtdLimpiarCampos()
        {
            txtCodigoEmpleado.Text = "";
            txtCodigoHabitacion.Text = "";
            cboxTipoGestion.Text = "";
            dtpFechaGestion.Text = "";
            txtUsuarioAuditoria.Text = "";
            cboxEstado.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodigoGestion.Text))
            {
                MessageBox.Show("Favor seleccionar fila a eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int CodigoGestionHabitacion = int.Parse(txtCodigoGestion.Text);

                    cd_GestionHabitaciones.MtdEliminarGestionHabitaciones(CodigoGestionHabitacion);
                    MessageBox.Show("Dato eliminado correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MtdConsultarGestionHabitaciones();
                    MtdLimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
