using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using SistemaHospitalario.Datos;

namespace SistemaHospitalario
{
    public partial class FrmUsuarios : Form
    {
        private ConexionBD conexionBD;

        public FrmUsuarios()
        {
            InitializeComponent();
            conexionBD = ConexionBD.ObtenerInstancia();
            InicializarFormulario();
        }

        private void InicializarFormulario()
        {
            // Cargar empleados en el ComboBox
            CargarEmpleados();

            // Configurar ComboBox de Tipo Usuario y Estado
            cmbTipoUsuario.Items.AddRange(new object[] { "Admin", "doctor", "Asistente", "digitador" });
            cmbEstado.Items.AddRange(new object[] { "Activo", "Inactivo" });

            // Configurar DataGridView
            ConfigurarDataGridView();

            // Cargar usuarios existentes
            CargarUsuarios();
        }

        private void CargarEmpleados()
        {
            try
            {
                string consulta = @"SELECT CodigoEmpleado
                                   FROM tbl_Empleados 
                                   WHERE Estado = 'Activo'
                                   ORDER BY CodigoEmpleado";

                DataTable empleados = conexionBD.EjecutarConsulta(consulta);

                if (empleados.Rows.Count > 0)
                {
                    // Configurar el ComboBox para mostrar solo los códigos
                    cmbCodigoEmpleado.DataSource = empleados;
                    cmbCodigoEmpleado.DisplayMember = "CodigoEmpleado";  // Lo que se muestra
                    cmbCodigoEmpleado.ValueMember = "CodigoEmpleado";    // El valor seleccionado

                    // Limpiar selección inicial
                    cmbCodigoEmpleado.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("No hay empleados activos en la base de datos.",
                                   "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar empleados: {ex.Message}",
                               "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigurarDataGridView()
        {
            dgvUsuarios.AutoGenerateColumns = false;
            dgvUsuarios.Columns.Clear();

            // Configurar columnas del DataGridView
            dgvUsuarios.Columns.Add("CodigoUsuario", "Código Usuario");
            dgvUsuarios.Columns.Add("CodigoEmpleado", "Código Empleado");
            dgvUsuarios.Columns.Add("NombreEmpleado", "Nombre Empleado");
            dgvUsuarios.Columns.Add("NombreUsuario", "Nombre Usuario");
            dgvUsuarios.Columns.Add("TipoUsuario", "Tipo Usuario");
            dgvUsuarios.Columns.Add("Estado", "Estado");

            // Ajustar ancho de columnas
            dgvUsuarios.Columns["CodigoUsuario"].Width = 100;
            dgvUsuarios.Columns["CodigoEmpleado"].Width = 120;
            dgvUsuarios.Columns["NombreEmpleado"].Width = 200;
            dgvUsuarios.Columns["NombreUsuario"].Width = 150;
            dgvUsuarios.Columns["TipoUsuario"].Width = 120;
            dgvUsuarios.Columns["Estado"].Width = 80;
        }

        private void CargarUsuarios()
        {
            try
            {
                string consulta = @"SELECT u.CodigoUsuario, u.CodigoEmpleado, 
                                   CONCAT(e.NombresEmpleado, ' ', e.ApellidosEmpleado) as NombreEmpleado,
                                   u.NombreUsuario, u.TipoUsuario, u.Estado
                                   FROM tbl_Usuarios u
                                   INNER JOIN tbl_Empleados e ON u.CodigoEmpleado = e.CodigoEmpleado
                                   ORDER BY u.CodigoUsuario";

                DataTable usuarios = conexionBD.EjecutarConsulta(consulta);

                dgvUsuarios.Rows.Clear();

                foreach (DataRow row in usuarios.Rows)
                {
                    dgvUsuarios.Rows.Add(
                        row["CodigoUsuario"].ToString(),
                        row["CodigoEmpleado"].ToString(),
                        row["NombreEmpleado"].ToString(),
                        row["NombreUsuario"].ToString(),
                        row["TipoUsuario"].ToString(),
                        row["Estado"].ToString()
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar usuarios: {ex.Message}",
                               "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbCodigoEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Limpiar el label primero
            lblEmpleadoSeleccionado.Visible = false;
            lblEmpleadoSeleccionado.Text = "";

            if (cmbCodigoEmpleado.SelectedIndex != -1)
            {
                try
                {
                    // Obtener el código seleccionado del ComboBox
                    int codigoSeleccionado = Convert.ToInt32(cmbCodigoEmpleado.SelectedValue);

                    // Buscar el nombre del empleado en la base de datos
                    string consulta = $@"SELECT CONCAT(NombresEmpleado, ' ', ApellidosEmpleado) as NombreCompleto
                                        FROM tbl_Empleados 
                                        WHERE CodigoEmpleado = {codigoSeleccionado} AND Estado = 'Activo'";

                    DataTable resultado = conexionBD.EjecutarConsulta(consulta);

                    if (resultado.Rows.Count > 0)
                    {
                        string nombreCompleto = resultado.Rows[0]["NombreCompleto"].ToString();
                        lblEmpleadoSeleccionado.Text = nombreCompleto;
                        lblEmpleadoSeleccionado.Visible = true;
                    }
                    else
                    {
                        lblEmpleadoSeleccionado.Text = "Empleado no encontrado";
                        lblEmpleadoSeleccionado.Visible = true;
                    }
                }
                catch (Exception ex)
                {
                    lblEmpleadoSeleccionado.Text = "Error al cargar empleado";
                    lblEmpleadoSeleccionado.Visible = true;

                    // Mostrar error solo en modo debug
#if DEBUG
                    MessageBox.Show($"Error al obtener empleado: {ex.Message}");
#endif
                }
            }
        }

        private bool ValidarDatos()
        {
            if (cmbCodigoEmpleado.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un empleado.", "Validación",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbCodigoEmpleado.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNombreUsuario.Text))
            {
                MessageBox.Show("Debe ingresar un nombre de usuario.", "Validación",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombreUsuario.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtContrasena.Text))
            {
                MessageBox.Show("Debe ingresar una contraseña.", "Validación",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContrasena.Focus();
                return false;
            }

            if (cmbTipoUsuario.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un tipo de usuario.", "Validación",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbTipoUsuario.Focus();
                return false;
            }

            if (cmbEstado.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un estado.", "Validación",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbEstado.Focus();
                return false;
            }

            return true;
        }

        private bool VerificarUsuarioExistente()
        {
            try
            {
                object resultado = conexionBD.ObtenerValorEscalar(
                    $"SELECT COUNT(*) FROM tbl_Usuarios WHERE NombreUsuario = '{txtNombreUsuario.Text.Trim()}'");

                return Convert.ToInt32(resultado) > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al verificar usuario: {ex.Message}",
                               "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true; // En caso de error, asumir que existe para evitar duplicados
            }
        }

        private bool VerificarEmpleadoTieneUsuario()
        {
            try
            {
                int codigoEmpleado = Convert.ToInt32(cmbCodigoEmpleado.SelectedValue);

                object resultado = conexionBD.ObtenerValorEscalar(
                    $"SELECT COUNT(*) FROM tbl_Usuarios WHERE CodigoEmpleado = {codigoEmpleado}");

                return Convert.ToInt32(resultado) > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al verificar empleado: {ex.Message}",
                               "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
        }


        private void btnAgregar_Click_1(object sender, EventArgs e)
        {

            if (!ValidarDatos())
                return;

            if (VerificarUsuarioExistente())
            {
                MessageBox.Show("Ya existe un usuario con ese nombre de usuario.",
                               "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombreUsuario.Focus();
                return;
            }

            if (VerificarEmpleadoTieneUsuario())
            {
                MessageBox.Show("El empleado seleccionado ya tiene un usuario asignado.",
                               "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbCodigoEmpleado.Focus();
                return;
            }

            try
            {
                int codigoEmpleado = Convert.ToInt32(cmbCodigoEmpleado.SelectedValue);
                string nombreUsuario = txtNombreUsuario.Text.Trim();
                string contrasena = txtContrasena.Text.Trim();
                string tipoUsuario = cmbTipoUsuario.Text;
                string estado = cmbEstado.Text;

                // Construir comando SQL
                string comandoSQL = $@"INSERT INTO tbl_Usuarios (CodigoEmpleado, NombreUsuario, PasswordUsuario, TipoUsuario, Estado)
                                      VALUES ({codigoEmpleado}, '{nombreUsuario}', '{contrasena}', '{tipoUsuario}', '{estado}')";

                int filasAfectadas = conexionBD.EjecutarComando(comandoSQL);

                if (filasAfectadas > 0)
                {
                    MessageBox.Show("Usuario agregado exitosamente.", "Éxito",
                                   MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LimpiarFormulario();
                    CargarUsuarios(); // Recargar la lista de usuarios
                }
                else
                {
                    MessageBox.Show("No se pudo agregar el usuario.", "Error",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar usuario: {ex.Message}",
                               "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void LimpiarFormulario()
        {
            cmbCodigoEmpleado.SelectedIndex = -1;
            txtNombreUsuario.Clear();
            txtContrasena.Clear();
            cmbTipoUsuario.SelectedIndex = -1;
            cmbEstado.SelectedIndex = -1;
            lblEmpleadoSeleccionado.Visible = false;
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            // El formulario ya se inicializa en el constructor
        }

        private void FrmUsuarios_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Cerrar conexión cuando se cierre el formulario
            conexionBD?.CerrarConexion();
        }

        private void lblEmpleadoSeleccionado_Click(object sender, EventArgs e)
        {
            // Este evento puede estar vacío
        }

        private void cmbCodigoEmpleado_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}