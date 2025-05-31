using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_Final.Datos;

namespace Proyecto_Final
{
    public partial class FRMTratamientos : Form
    {
        CDconexion cd_conexion = new CDconexion();
        CLTratamientos cal = new CLTratamientos();
        CDTratamientos cd_tratamiento = new CDTratamientos();

        public FRMTratamientos()
        {
            InitializeComponent();
        }

        private void FRMTratamientos_Load(object sender, EventArgs e)
        {
            
            lblFechaHoy.Text = cal.MtdFechaHoy().ToString();
            MtdConsultarTratamientos();
            MtdMostrarlistaMedicamento();
            MtdMostrarlistaCita();
            




        }
        private void MtdMostrarlistaCita()
        {
            var ListaCita = cd_tratamiento.MtdCodigoCita();
            //cboxCodigoCita.DataSource = ListaCita;
            foreach (var Cita in ListaCita)
            {
              cboxCodigoCita.Items.Add(Cita);
            }

            cboxCodigoCita.DisplayMember = "Value";
            //cboxCodigoCita.ValueMember = "Value";
        }

        private void MtdMostrarlistaMedicamento()
        {
           
            var ListaMedicamento = cd_tratamiento.MtdCodigoMedicamento();

            foreach (var Cita in ListaMedicamento)
            {
                cboxCodigoMedicamento.Items.Add(Cita);
            }


            //cboxCodigoMedicamento.DisplayMember = "Text";
            cboxCodigoMedicamento.ValueMember = "Value";

      

        }


        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var FilaSeleccionada = dgvTratamientos.SelectedRows[0];

            if (FilaSeleccionada.Index == dgvTratamientos.RowCount - 1)
            {
                MessageBox.Show("Seleccione una fila con datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            else
            {
                txtCodigoTratamiento.Text = dgvTratamientos.SelectedCells[0].Value.ToString();
                cboxCodigoCita.Text = dgvTratamientos.SelectedCells[1].Value.ToString();
                cboxCodigoMedicamento.Text = dgvTratamientos.SelectedCells[2].Value.ToString();
                lblCosto.Text = dgvTratamientos.SelectedCells[3].Value.ToString();
                DtpFechaTratamiento.Text = dgvTratamientos.SelectedCells[4].Value.ToString();

            }

            cboxEstado.Text = dgvTratamientos.SelectedCells[5].Value.ToString();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cboxCodigoCita.Text) || string.IsNullOrEmpty(cboxCodigoMedicamento.Text) || string.IsNullOrEmpty(lblCosto.Text) ||
                string.IsNullOrEmpty(DtpFechaTratamiento.Text) || string.IsNullOrEmpty(cboxEstado.Text))
            {
                MessageBox.Show("Favor ingresar todos los datos en pantalla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    string CodigoCita = cboxCodigoCita.Text;
                    string CodigoMedicamento = cboxCodigoMedicamento.Text;
                    double Costo = cal.MtdCostoTratamiento(CodigoMedicamento);
                    DateTime FechaVencimiento = DtpFechaTratamiento.Value;
                    string Estado = cboxEstado.Text;
                    DateTime FechaAuditoria = cal.MtdFechaHoy();
                    string UsuarioAuditoria = "AMartinez";

                    cd_tratamiento.MtdAgregarTratamientos(CodigoCita, CodigoMedicamento, Costo, FechaVencimiento, Estado, FechaAuditoria, UsuarioAuditoria);
                    MessageBox.Show("Medicamento agregado", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MtdConsultarTratamientos();
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

        private void txtCodigoTratamiento_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCosto_Click(object sender, EventArgs e)
        {
            
            
        }

        private void cboxCodigoMedicamento_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(cboxCodigoMedicamento.Text))
            {
                MessageBox.Show("Seleccione una descripcion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                lblCosto.Text = cal.MtdCostoTratamiento(cboxCodigoMedicamento.Text).ToString("c");
            }
        }

        private void MtdLimpiarCampos()
        {
            cboxCodigoCita.Text = "";
            cboxCodigoMedicamento.Text = "";
            lblCosto.Text = "";
            DtpFechaTratamiento.Text = "";
            cboxEstado.Text = "";



        }
        private void MtdConsultarTratamientos()
        {
            DataTable Dt = cd_tratamiento.MtdConsultarTratamiento();
            dgvTratamientos.DataSource = Dt;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cboxCodigoCita.Text) || string.IsNullOrEmpty(cboxCodigoMedicamento.Text) || string.IsNullOrEmpty(lblCosto.Text) ||
                  string.IsNullOrEmpty(DtpFechaTratamiento.Text) || string.IsNullOrEmpty(cboxEstado.Text))
            {
                MessageBox.Show("Favor ingresar todos los datos en pantalla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    string CodigoTratamiento = txtCodigoTratamiento.Text;
                    string CodigoCita = cboxCodigoCita.Text;
                    string CodigoMedicamento = cboxCodigoMedicamento.Text;
                    double Costo = cal.MtdCostoTratamiento(CodigoMedicamento);
                    DateTime FechaVencimiento = DtpFechaTratamiento.Value;
                    string Estado = cboxEstado.Text;
                    DateTime FechaAuditoria = cal.MtdFechaHoy();
                    string UsuarioAuditoria = "AMartinez";

                    cd_tratamiento.MtdActualizarTratamientos(CodigoTratamiento, CodigoCita, CodigoMedicamento, Costo, FechaVencimiento, Estado, FechaAuditoria, UsuarioAuditoria);
                    MessageBox.Show("Medicamento Actualizado", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MtdConsultarTratamientos();
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodigoTratamiento.Text))
            {
                MessageBox.Show("Favor seleccionar Tratamiento a eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                try
                {
                    int CodigoTratamiento = (int.Parse(txtCodigoTratamiento.Text));

                    cd_tratamiento.MtdEliminarTratamiento(CodigoTratamiento);
                    MessageBox.Show("Medicamento eliminado", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MtdConsultarTratamientos();
                    MtdLimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }









            }



        }

        private void cboxCodigoCita_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
