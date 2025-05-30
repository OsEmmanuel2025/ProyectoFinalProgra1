using System;
using System.Windows.Forms;

namespace SistemaHospitalario
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            FrmUsuarios usuarios = new FrmUsuarios();
            usuarios.Show();
        }

        private void btnCitas_Click(object sender, EventArgs e)
        {
            FrmCitas citas = new FrmCitas();
            citas.Show();
        }

        private void btnPagoCitas_Click(object sender, EventArgs e)
        {
            FrmPagoCitas pagoCitas = new FrmPagoCitas();
            pagoCitas.Show();
        }

        private void btnPagoEmpleados_Click(object sender, EventArgs e)
        {
            FrmPagoEmpleados pagoEmpleados = new FrmPagoEmpleados();
            pagoEmpleados.Show();
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }
    }
}