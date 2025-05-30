using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemaHospitalario.Datos
{
    public class ConexionBD
    {
        // Cadenas de conexión para diferentes configuraciones locales
        // Descomenta la que corresponda a tu configuración

        // Para SQL Server Express con instancia por defecto (SQLEXPRESS)
        private static string cadenaConexion = @"Data Source=.\SQLEXPRESS;Initial Catalog=HospitalSaludIntegral;Integrated Security=True";

        // Para SQL Server LocalDB (descomenta si usas LocalDB)
        //private static string cadenaConexion = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=HospitalSaludIntegral;Integrated Security=True";

        // Para SQL Server Express con nombre de instancia específico (reemplaza TUPC por el nombre de tu PC)
        //private static string cadenaConexion = @"Data Source=TUPC\SQLEXPRESS;Initial Catalog=HospitalSaludIntegral;Integrated Security=True";

        // Para SQL Server sin instancia nombrada
        //private static string cadenaConexion = @"Data Source=localhost;Initial Catalog=HospitalSaludIntegral;Integrated Security=True";

        // Instancia única de la conexión (Singleton)
        private static ConexionBD instancia = null;
        private SqlConnection conexion;

        // Constructor privado para implementar patrón Singleton
        private ConexionBD()
        {
            conexion = new SqlConnection(cadenaConexion);
        }

        // Método para obtener la instancia única
        public static ConexionBD ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new ConexionBD();
            }
            return instancia;
        }

        // Método para probar diferentes cadenas de conexión automáticamente
        public static string DetectarCadenaConexion()
        {
            string[] cadenasAPrueba = {
                @"Data Source=.\SQLEXPRESS;Initial Catalog=HospitalSaludIntegral;Integrated Security=True",
                @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=HospitalSaludIntegral;Integrated Security=True",
                @"Data Source=localhost;Initial Catalog=HospitalSaludIntegral;Integrated Security=True",
                @"Data Source=.;Initial Catalog=HospitalSaludIntegral;Integrated Security=True",
                $@"Data Source={Environment.MachineName}\SQLEXPRESS;Initial Catalog=HospitalSaludIntegral;Integrated Security=True"
            };

            foreach (string cadena in cadenasAPrueba)
            {
                try
                {
                    using (SqlConnection testConexion = new SqlConnection(cadena))
                    {
                        testConexion.Open();
                        return cadena; // Si funciona, devolvemos esta cadena
                    }
                }
                catch
                {
                    // Continúa con la siguiente cadena
                    continue;
                }
            }

            return null; // No se encontró ninguna cadena válida
        }

        // Método para obtener la conexión
        public SqlConnection ObtenerConexion()
        {
            try
            {
                if (conexion.State == ConnectionState.Closed)
                {
                    conexion.Open();
                }
                return conexion;
            }
            catch (Exception ex)
            {
                // Si falla, intentamos detectar automáticamente la cadena correcta
                string nuevaCadena = DetectarCadenaConexion();
                if (nuevaCadena != null)
                {
                    cadenaConexion = nuevaCadena;
                    conexion = new SqlConnection(cadenaConexion);
                    try
                    {
                        conexion.Open();
                        MessageBox.Show($"Conexión establecida automáticamente con: {nuevaCadena}",
                                       "Conexión Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return conexion;
                    }
                    catch
                    {
                        // Si aún falla, mostrar el error original
                    }
                }

                MessageBox.Show($"Error al conectar con la base de datos: {ex.Message}\n\n" +
                               "Posibles soluciones:\n" +
                               "1. Verifica que SQL Server esté ejecutándose\n" +
                               "2. Comprueba el nombre de la instancia de SQL Server\n" +
                               "3. Asegúrate de que la base de datos 'HospitalSaludIntegral' exista\n" +
                               "4. Verifica los permisos de Windows Authentication",
                               "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        // Método para cerrar la conexión
        public void CerrarConexion()
        {
            try
            {
                if (conexion != null && conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cerrar la conexión: {ex.Message}",
                               "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Método para probar la conexión
        public bool ProbarConexion()
        {
            try
            {
                string cadenaDetectada = DetectarCadenaConexion();
                if (cadenaDetectada != null)
                {
                    cadenaConexion = cadenaDetectada;
                    return true;
                }
                else
                {
                    MessageBox.Show("No se pudo encontrar una configuración válida de SQL Server.\n\n" +
                                   "Verifica que:\n" +
                                   "- SQL Server esté instalado y ejecutándose\n" +
                                   "- La base de datos 'HospitalSaludIntegral' exista\n" +
                                   "- Tengas permisos para acceder a la base de datos",
                                   "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al probar la conexión: {ex.Message}",
                               "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // Método para ejecutar consultas SELECT
        public DataTable EjecutarConsulta(string consulta)
        {
            DataTable tabla = new DataTable();
            try
            {
                using (SqlCommand comando = new SqlCommand(consulta, ObtenerConexion()))
                {
                    using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                    {
                        adaptador.Fill(tabla);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al ejecutar consulta: {ex.Message}",
                               "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tabla;
        }

        // Método para ejecutar consultas INSERT, UPDATE, DELETE
        public int EjecutarComando(string comando)
        {
            int filasAfectadas = 0;
            try
            {
                using (SqlCommand sqlCommand = new SqlCommand(comando, ObtenerConexion()))
                {
                    filasAfectadas = sqlCommand.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al ejecutar comando: {ex.Message}",
                               "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return filasAfectadas;
        }

        // Método para ejecutar consultas con parámetros
        public DataTable EjecutarConsultaConParametros(string consulta, SqlParameter[] parametros)
        {
            DataTable tabla = new DataTable();
            try
            {
                using (SqlCommand comando = new SqlCommand(consulta, ObtenerConexion()))
                {
                    comando.Parameters.AddRange(parametros);
                    using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                    {
                        adaptador.Fill(tabla);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al ejecutar consulta con parámetros: {ex.Message}",
                               "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tabla;
        }

        // Método para obtener un valor escalar (útil para COUNT, MAX, etc.)
        public object ObtenerValorEscalar(string consulta)
        {
            try
            {
                using (SqlCommand comando = new SqlCommand(consulta, ObtenerConexion()))
                {
                    return comando.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener valor escalar: {ex.Message}",
                               "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        // Liberación de recursos
        public void Dispose()
        {
            CerrarConexion();
            if (conexion != null)
            {
                conexion.Dispose();
                conexion = null;
            }
            instancia = null;
        }
    }
}