using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    public partial class Empleados : Form
    {
        CDEmpleados cd_Empleados = new CDEmpleados();
        CLEmpleados cl_Empleados = new CLEmpleados();

        public Empleados()
        {
            InitializeComponent();
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
                txtCodigoEmpleado.Text = dataGridView1[0, FilaSeleccionada].Value.ToString();
                txtNombre.Text = dataGridView1[1, FilaSeleccionada].Value.ToString();
                cboxTipoTrabajo.Text = dataGridView1[2, FilaSeleccionada].Value.ToString();
                lblSueldo.Text = dataGridView1[4, FilaSeleccionada].Value.ToString();
                txtEspecialidad.Text = dataGridView1[3, FilaSeleccionada].Value.ToString();
                dtpFechaAlta.Text = dataGridView1[5, FilaSeleccionada].Value.ToString();
                cboxEstado.Text = dataGridView1[6, FilaSeleccionada].Value.ToString();
                txtUsuarioAuditoria.Text = dataGridView1[7, FilaSeleccionada].Value.ToString();
                lblFechaAuditoria.Text = dataGridView1[8, FilaSeleccionada].Value.ToString();
            }
        }

        private void Empleados_Load(object sender, EventArgs e)
        {
            lblFechaAuditoria.Text = cl_Empleados.MtdFechaHoy().ToString("d");
            MtdConsultarEmpleados();
        }

        private void MtdConsultarEmpleados()
        {
            DataTable DtEmpleados = cd_Empleados.MtdConsultarEmpleados();
            dataGridView1.DataSource = DtEmpleados;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(cboxTipoTrabajo.Text) || string.IsNullOrEmpty(txtEspecialidad.Text) || string.IsNullOrEmpty(dtpFechaAlta.Text) || string.IsNullOrEmpty(cboxEstado.Text) || string.IsNullOrEmpty(txtUsuarioAuditoria.Text))
            {
                MessageBox.Show("Favor completar formulario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string Nombres = txtNombre.Text;
                string TipoTrabajo = cboxTipoTrabajo.Text;
                double Sueldo = cl_Empleados.MtdSalarioEmpleado(lblSueldo.Text);
                string Especialidad = txtEspecialidad.Text;
                DateTime FechaAlta = dtpFechaAlta.Value;
                string Estado = cboxEstado.Text;
                DateTime FechaAuditoria = cl_Empleados.MtdFechaHoy();
                string UsuarioAuditoria = "Emmanuel";

                try
                {
                    cd_Empleados.MtdAgregarEmpleados(Nombres, TipoTrabajo, Especialidad, Sueldo, FechaAlta, Estado, FechaAuditoria, UsuarioAuditoria);
                    MessageBox.Show("Datos agregados correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MtdConsultarEmpleados();
                    MtdLimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int FilaSeleccionada = dataGridView1.CurrentRow.Index;

            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(cboxTipoTrabajo.Text) || string.IsNullOrEmpty(txtEspecialidad.Text) || string.IsNullOrEmpty(dtpFechaAlta.Text) || string.IsNullOrEmpty(cboxEstado.Text) || string.IsNullOrEmpty(txtUsuarioAuditoria.Text))
            {
                MessageBox.Show("Favor completar formulario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int CodigoEmpleado = (int.Parse(txtCodigoEmpleado.Text));
                string Nombre = txtNombre.Text;
                string TipoTrabajo = cboxTipoTrabajo.Text;
                double Sueldo = cl_Empleados.MtdSalarioEmpleado(lblSueldo.Text);
                string Especialidad = txtEspecialidad.Text;
                DateTime FechaAlta = dtpFechaAlta.Value;
                string Estado = cboxEstado.Text;
                DateTime FechaAuditoria = cl_Empleados.MtdFechaHoy();
                string UsuarioAuditoria = "Emmanuel";

                try
                {
                    cd_Empleados.MtdActualizarEmpleados(CodigoEmpleado, Nombre, TipoTrabajo, Especialidad, Sueldo, FechaAlta, Estado, FechaAuditoria, UsuarioAuditoria);
                    MessageBox.Show("Datos actualizados correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MtdConsultarEmpleados();
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
            txtNombre.Text = "";
            cboxTipoTrabajo.Text = "";
            lblSueldo.Text = "Imprimir Sueldo:";
            txtEspecialidad.Text = "";
            dtpFechaAlta.Text = "";
            txtUsuarioAuditoria.Text = "";
            cboxEstado.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodigoEmpleado.Text))
            {
                MessageBox.Show("Favor seleccionar fila a eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int CodigoEmpleado = int.Parse(txtCodigoEmpleado.Text);

                    cd_Empleados.MtdEliminarEmpleados(CodigoEmpleado);
                    MessageBox.Show("Dato eliminado correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MtdConsultarEmpleados();
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

        private void cboxTipoTrabajo_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblSueldo.Text = cl_Empleados.MtdSalarioEmpleado(cboxTipoTrabajo.Text).ToString();
        }
    }
}
