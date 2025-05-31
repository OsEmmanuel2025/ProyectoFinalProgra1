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
    public partial class Habitaciones : Form
    {
        CDHabitaciones cd_Habitaciones = new CDHabitaciones();
        CLHabitaciones cl_Habitaciones = new CLHabitaciones();

        public Habitaciones()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Habitaciones_Load(object sender, EventArgs e)
        {
            lblFechaAuditoria.Text = cl_Habitaciones.MtdFechaHoy().ToString("d");
            MtdConsultarHabitaciones();
        }

        private void MtdConsultarHabitaciones()
        {
            DataTable DtHabitaciones = cd_Habitaciones.MtdConsultarHabitaciones();
            dataGridView1.DataSource = DtHabitaciones;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNumero.Text) || string.IsNullOrEmpty(txtUbicacion.Text) || string.IsNullOrEmpty(cboxTipoHabitacion.Text) || string.IsNullOrEmpty(cboxEstado.Text) || string.IsNullOrEmpty(txtUsuarioAuditoria.Text))
            {
                MessageBox.Show("Favor completar formulario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string Numero = txtNumero.Text;
                string Ubicacion = txtUbicacion.Text;
                string TipoHabitacion = (cboxTipoHabitacion.Text);
                double Costo = cl_Habitaciones.MtdCostoHabitacion(lblCosto.Text);
                string Estado = cboxEstado.Text;
                string UsuarioAuditoria = "Emmanuel";
                DateTime FechaAuditoria = cl_Habitaciones.MtdFechaHoy();

                try
                {
                    cd_Habitaciones.MtdAgregarHabitaciones(Numero, Ubicacion, TipoHabitacion, Costo, Estado, UsuarioAuditoria, FechaAuditoria);
                    MessageBox.Show("Datos agregados correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MtdConsultarHabitaciones();
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
                txtCodigoHabitacion.Text = dataGridView1[0, FilaSeleccionada].Value.ToString();
                txtNumero.Text = dataGridView1[1, FilaSeleccionada].Value.ToString();
                txtUbicacion.Text = dataGridView1[2, FilaSeleccionada].Value.ToString();
                cboxTipoHabitacion.Text = dataGridView1[3, FilaSeleccionada].Value.ToString();
                lblCosto.Text = dataGridView1[4, FilaSeleccionada].Value.ToString();
                cboxEstado.Text = dataGridView1[5, FilaSeleccionada].Value.ToString();
                txtUsuarioAuditoria.Text = dataGridView1[6, FilaSeleccionada].Value.ToString();
                lblFechaAuditoria.Text = dataGridView1[7, FilaSeleccionada].Value.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int FilaSeleccionada = dataGridView1.CurrentRow.Index;

            if (string.IsNullOrEmpty(txtNumero.Text) || string.IsNullOrEmpty(txtUbicacion.Text) || string.IsNullOrEmpty(cboxTipoHabitacion.Text) || string.IsNullOrEmpty(cboxEstado.Text) || string.IsNullOrEmpty(txtUsuarioAuditoria.Text))
            {
                MessageBox.Show("Favor completar formulario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int CodigoHabitacion = (int.Parse(txtCodigoHabitacion.Text));
                string Numero = txtNumero.Text;
                string Ubicacion = txtUbicacion.Text;
                string TipoHabitacion = (cboxTipoHabitacion.Text);
                double Costo = cl_Habitaciones.MtdCostoHabitacion(cboxTipoHabitacion.Text);
                string Estado = cboxEstado.Text;
                string UsuarioAuditoria = "Emmanuel";
                DateTime FechaAuditoria = cl_Habitaciones.MtdFechaHoy();


                try
                {
                    cd_Habitaciones.MtdActualizarHabitaciones(CodigoHabitacion, Numero, Ubicacion, TipoHabitacion, Costo, Estado, UsuarioAuditoria, FechaAuditoria);
                    MessageBox.Show("Datos actualizados correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MtdConsultarHabitaciones();
                    MtdLimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MtdLimpiarCampos();
        }

        public void MtdLimpiarCampos()
        {
            txtCodigoHabitacion.Text = "";
            txtNumero.Text = "";
            txtUbicacion.Text = "";
            cboxTipoHabitacion.Text = "";
            lblCosto.Text = "Imprimir Costo:";
            txtUsuarioAuditoria.Text = "";
            cboxEstado.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodigoHabitacion.Text))
            {
                MessageBox.Show("Favor seleccionar fila a eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            { 
                try
                {
                    int CodigoHabitacion = int.Parse(txtCodigoHabitacion.Text);

                    cd_Habitaciones.MtdEliminarHabitaciones(CodigoHabitacion);
                    MessageBox.Show("Dato eliminado correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MtdConsultarHabitaciones();
                    MtdLimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboxEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboxTipoHabitacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblCosto.Text = cl_Habitaciones.MtdCostoHabitacion(cboxTipoHabitacion.Text).ToString();
        }

        private void lblCosto_Click(object sender, EventArgs e)
        {

        }
    }
}
