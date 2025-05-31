using System;
using System.Data;
using System.Data.SqlClient;

namespace Proyecto_Final.Datos
{
    public class ConexionBD
    {
        private SqlConnection db_conexion = new SqlConnection("Server=LFLOREST3\\SQLEXPRESS;Database=db_Hospital;Integrated Security=True");

        public SqlConnection MtdAbrirConexion()
        {
            if (db_conexion.State == ConnectionState.Closed)
            {
                db_conexion.Open();
            }
            return db_conexion;
        }

        public SqlConnection MtdCerrarConexion()
        {
            if (db_conexion.State == ConnectionState.Open)
            {
                db_conexion.Close();
            }
            return db_conexion;
        }

        public static ConexionBD ObtenerInstancia()
        {
            return new ConexionBD();
        }

        public DataTable EjecutarConsulta(string consulta)
        {
            using (SqlCommand comando = new SqlCommand(consulta, MtdAbrirConexion()))
            {
                using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                {
                    DataTable resultado = new DataTable();
                    adaptador.Fill(resultado);
                    MtdCerrarConexion();
                    return resultado;
                }
            }
        }

        public object ObtenerValorEscalar(string consulta)
        {
            using (SqlCommand comando = new SqlCommand(consulta, MtdAbrirConexion()))
            {
                object resultado = comando.ExecuteScalar();
                MtdCerrarConexion();
                return resultado;
            }
        }

        public int EjecutarComando(string comandoSQL)
        {
            using (SqlCommand comando = new SqlCommand(comandoSQL, MtdAbrirConexion()))
            {
                int filasAfectadas = comando.ExecuteNonQuery();
                MtdCerrarConexion();
                return filasAfectadas;
            }
        }

        internal void CerrarConexion()
        {
            throw new NotImplementedException();
        }
    }
}
