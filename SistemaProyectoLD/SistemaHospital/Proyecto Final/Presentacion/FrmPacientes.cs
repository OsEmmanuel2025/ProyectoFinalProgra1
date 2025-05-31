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
    public partial class Pacientes : Form
    {
        CDPacientes cd_Pacientes = new CDPacientes();
        CLPacientes cl_Pacientes = new CLPacientes();

        public Pacientes()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCodigoPaciente_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodigoHabitacion.Text) || string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtNit.Text) || string.IsNullOrEmpty(dtpFechaNacimiento.Text) || string.IsNullOrEmpty(cboxTipoPaciente.Text) || string.IsNullOrEmpty(cboxEstado.Text) || string.IsNullOrEmpty(txtUsuarioAuditoria.Text))
            {
                MessageBox.Show("Favor completar formulario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int CodigoHabitacion = (int.Parse(txtCodigoHabitacion.Text));
                string Nombre = txtNombre.Text;
                string Nit = txtNit.Text;
                DateTime FechaNacimiento = dtpFechaNacimiento.Value;
                string TipoPaciente = (cboxTipoPaciente.Text);
                string Estado = cboxEstado.Text;
                DateTime FechaAuditoria = cl_Pacientes.MtdFechaHoy();
                string UsuarioAuditoria = "Emmanuel";

                try
                {
                    cd_Pacientes.MtdAgregarPacientes(CodigoHabitacion, Nombre, Nit, FechaNacimiento, TipoPaciente, Estado, FechaAuditoria, UsuarioAuditoria);
                    MessageBox.Show("Datos agregados correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MtdConsultarPacientes();
                    MtdLimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Pacientes_Load(object sender, EventArgs e)
        {
            lblFechaAuditoria.Text = cl_Pacientes.MtdFechaHoy().ToString("d");
            MtdConsultarPacientes();
        }

        private void MtdConsultarPacientes()
        {
            DataTable DtPacientes = cd_Pacientes.MtdConsultarPacientes();
            dataGridView1.DataSource = DtPacientes;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int FilaSeleccionada = dataGridView1.CurrentRow.Index;

            if (string.IsNullOrEmpty(txtCodigoHabitacion.Text) || string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtNit.Text) || string.IsNullOrEmpty(dtpFechaNacimiento.Text) || string.IsNullOrEmpty(cboxTipoPaciente.Text) || string.IsNullOrEmpty(cboxEstado.Text) || string.IsNullOrEmpty(txtUsuarioAuditoria.Text))
            {
                MessageBox.Show("Favor completar formulario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int CodigoPaciente = (int.Parse(txtCodigoPaciente.Text));
                int CodigoHabitacion = (int.Parse(txtCodigoHabitacion.Text));
                string Nombre = txtNombre.Text;
                string Nit = txtNit.Text;
                DateTime FechaNacimiento = dtpFechaNacimiento.Value;
                string TipoPaciente = (cboxTipoPaciente.Text);
                string Estado = cboxEstado.Text;
                DateTime FechaAuditoria = cl_Pacientes.MtdFechaHoy();
                string UsuarioAuditoria = "Emmanuel";

                try
                {
                    cd_Pacientes.MtdActualizarPacientes(CodigoPaciente, CodigoHabitacion, Nombre, Nit, FechaNacimiento, TipoPaciente, Estado, FechaAuditoria, UsuarioAuditoria);
                    MessageBox.Show("Datos editados correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MtdConsultarPacientes();
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
            txtCodigoPaciente.Text = "";
            txtCodigoHabitacion.Text = "";
            txtNombre.Text = "";
            txtNit.Text = "";
            dtpFechaNacimiento.Text = "";
            cboxTipoPaciente.Text = "";
            txtUsuarioAuditoria.Text = "";
            cboxEstado.Text = "";
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
                txtCodigoPaciente.Text = dataGridView1[0, FilaSeleccionada].Value.ToString();
                txtCodigoHabitacion.Text = dataGridView1[1, FilaSeleccionada].Value.ToString();
                txtNombre.Text = dataGridView1[2, FilaSeleccionada].Value.ToString();
                txtNit.Text = dataGridView1[3, FilaSeleccionada].Value.ToString();
                dtpFechaNacimiento.Text = dataGridView1[4, FilaSeleccionada].Value.ToString();
                cboxTipoPaciente.Text = dataGridView1[5, FilaSeleccionada].Value.ToString();
                cboxEstado.Text = dataGridView1[6, FilaSeleccionada].Value.ToString();
                txtUsuarioAuditoria.Text = dataGridView1[7, FilaSeleccionada].Value.ToString();
                lblFechaAuditoria.Text = dataGridView1[8, FilaSeleccionada].Value.ToString();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodigoPaciente.Text))
            {
                MessageBox.Show("Favor seleccionar fila a eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int CodigoPaciente = int.Parse(txtCodigoPaciente.Text);

                    cd_Pacientes.MtdEliminarPacientes(CodigoPaciente);
                    MessageBox.Show("Dato eliminado correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MtdConsultarPacientes();
                    MtdLimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
