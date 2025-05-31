using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_Final.Datos;

namespace Proyecto_Final
{
    public partial class FRMMedicamentos : Form
    {
        CDconexion cd_conexion = new CDconexion();
        Cal_Medicamentos Cal = new Cal_Medicamentos();
        CDmedicamentos Medicamentos = new CDmedicamentos();
        public FRMMedicamentos()
        {
            InitializeComponent();
        }

        private void MEDICAMENTOS_Load(object sender, EventArgs e)
        {
            lblFechaHoy.Text = Cal.MtdFechaHoy().ToString();
            MtdConsultarMedicamentos();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cboxMedicamentos_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(cboxMedicamentos.Text))
            {
                MessageBox.Show("Seleccione una descripcion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                lblCosto.Text = Cal.MtdCostoMedicamentos(cboxMedicamentos.Text).ToString("c"); 
            }




            
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombreMedicamento.Text)  || string.IsNullOrEmpty(cboxMedicamentos.Text) || string.IsNullOrEmpty(lblCosto.Text) || string.IsNullOrEmpty(txtStock.Text) ||
                string.IsNullOrEmpty(DtpFechaVencimiento.Text) || string.IsNullOrEmpty(cboxEstado.Text))
            {
                MessageBox.Show("Favor ingresar todos los datos en pantalla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    string Nombre = txtNombreMedicamento.Text;
                    string TipoMedicamento = cboxMedicamentos.Text;
                    double Costo = Cal.MtdCostoMedicamentos(TipoMedicamento);
                    double Stock = double.Parse(txtStock.Text);
                    DateTime FechaVencimiento = DtpFechaVencimiento.Value;
                    string Estado = cboxEstado.Text;
                    DateTime FechaAuditoria = Cal.MtdFechaHoy();
                    string UsuarioAuditoria = "AMartinez";

                    Medicamentos.MtdAgregarMedicamentos(Nombre,TipoMedicamento, Costo, Stock, FechaVencimiento, Estado, FechaAuditoria, UsuarioAuditoria);
                    MessageBox.Show("Medicamento agregado", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MtdConsultarMedicamentos();
                    MtdLimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

               
            }


            
        }
        private void MtdLimpiarCampos()
        {
            txtCodigoMedicamento.Text = "";
            txtNombreMedicamento.Text = "";
            cboxMedicamentos.Text = "";
            lblCosto.Text = "";
            txtStock.Text = "";
            DtpFechaVencimiento.Text = "";
            cboxEstado.Text = "";
        }
        private void MtdConsultarMedicamentos()
        {
            DataTable Dt = Medicamentos.MtdConsultarMedicamentos();
            dgvMedicamentos.DataSource = Dt;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cboxMedicamentos.Text) || string.IsNullOrEmpty(lblCosto.Text) || string.IsNullOrEmpty(txtStock.Text) ||
                string.IsNullOrEmpty(DtpFechaVencimiento.Text) || string.IsNullOrEmpty(cboxEstado.Text))
            {
                MessageBox.Show("Favor ingresar todos los datos en pantalla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    string CodigoMedicamento = txtCodigoMedicamento.Text;
                    string Nombre = txtNombreMedicamento.Text;
                    string TipoMedicamento = cboxMedicamentos.Text;
                    double Costo = Cal.MtdCostoMedicamentos(TipoMedicamento);
                    double Stock = double.Parse(txtStock.Text);
                    DateTime FechaVencimiento = DtpFechaVencimiento.Value;
                    string Estado = cboxEstado.Text;
                    DateTime FechaAuditoria = Cal.MtdFechaHoy();
                    string UsuarioAuditoria = "AMartinez";

                    Medicamentos.MtdActualizarMedicamentos(CodigoMedicamento, Nombre, TipoMedicamento, Costo, Stock, FechaVencimiento, Estado, FechaAuditoria, UsuarioAuditoria);
                    MessageBox.Show("Medicamento actualizado", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MtdConsultarMedicamentos();
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodigoMedicamento.Text))
            {
                MessageBox.Show("Favor seleccionar medicamento a eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                try
                {
                    int CodigoMedicamento = (int.Parse(txtCodigoMedicamento.Text));

                    Medicamentos.MtdEliminarMedicamentos(CodigoMedicamento);
                    MessageBox.Show("Medicamento eliminado", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MtdConsultarMedicamentos();
                    MtdLimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



            }
        }

        private void dgvMedicamentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvMedicamentos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var FilaSeleccionada = dgvMedicamentos.SelectedRows[0];

            if (FilaSeleccionada.Index == dgvMedicamentos.RowCount - 1)
            {
                MessageBox.Show("Seleccione una fila con datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            else
            {
                txtCodigoMedicamento.Text = dgvMedicamentos.SelectedCells[0].Value.ToString();
                txtNombreMedicamento.Text = dgvMedicamentos.SelectedCells[1].Value.ToString();
                cboxMedicamentos.Text = dgvMedicamentos.SelectedCells[2].Value.ToString();
                lblCosto.Text = dgvMedicamentos.SelectedCells[3].Value.ToString();
                txtStock.Text = dgvMedicamentos.SelectedCells[4].Value.ToString();
                DtpFechaVencimiento.Text = dgvMedicamentos.SelectedCells[5].Value.ToString();
                //cboxEstado.Text = dgvMedicamentos.SelectedCells[6].Value.ToString();
            }

            cboxEstado.Text = dgvMedicamentos.SelectedCells[6].Value.ToString();


        }

        private void lblCosto_Click(object sender, EventArgs e)
        {

        }
    }

}
