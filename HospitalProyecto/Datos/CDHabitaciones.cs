using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace HospitalProyecto.Datos
{
    internal class CDHabitaciones
    {
        CDconexión cd_conexion = new CDconexión();

        public DataTable MtdConsultarHabitaciones()
        {
            string QueryConsultar = "Select * from tbl_Habitaciones";
            SqlDataAdapter SqlAdap = new SqlDataAdapter(QueryConsultar, cd_conexion.MtdAbrirConexion());
            DataTable Dt = new DataTable();
            SqlAdap.Fill(Dt);
            cd_conexion.MtdCerrarConexion();
            return Dt;
        }

        public void MtdAgregarHabitaciones(string Numero, string Ubicacion, string TipoHabitacion, double Costo, string Estado, DateTime FechaAuditoria, string UsuarioAuditoria)
        {
            string QueryAgregar = "Insert into tbl_Habitaciones (Numero, Ubicacion, TipoHabitacion, Costo, Estado, FechaAuditoria, UsuarioAuditoria) values (@Numero, @Ubicacion, @TipoHabitacion, @Costo, @Estado, @FechaAuditoria, @UsuarioAuditoria)";
            SqlCommand cmd = new SqlCommand(QueryAgregar, cd_conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@Numero", Numero);
            cmd.Parameters.AddWithValue("@Ubicacion", Ubicacion);
            cmd.Parameters.AddWithValue("@TipoHabitacion", TipoHabitacion);
            cmd.Parameters.AddWithValue("@Costo", Costo);
            cmd.Parameters.AddWithValue("@Estado", Estado);
            cmd.Parameters.AddWithValue("@FechaAuditoria", FechaAuditoria);
            cmd.Parameters.AddWithValue("@UsuarioAuditoria", UsuarioAuditoria);
            cmd.ExecuteNonQuery();
            cd_conexion.MtdCerrarConexion();
        }

        public void MtdActualizarHabitaciones(string Numero, string Ubicacion, string TipoHabitacion, double Costo, string Estado, DateTime FechaAuditoria, string UsuarioAuditoria)
        {
            string QueryActualizar = "Insert into tbl_Habitaciones (Numero, Ubicacion, TipoHabitacion, Costo, Estado, FechaAuditoria, UsuarioAuditoria) values (@Numero, @Ubicacion, @TipoHabitacion, @Costo, @Estado, @FechaAuditoria, @UsuarioAuditoria)";
            SqlCommand cmd = new SqlCommand(QueryActualizar, cd_conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@Numero", Numero);
            cmd.Parameters.AddWithValue("@Ubicacion", Ubicacion);
            cmd.Parameters.AddWithValue("@TipoHabitacion", TipoHabitacion);
            cmd.Parameters.AddWithValue("@Costo", Costo);
            cmd.Parameters.AddWithValue("@Estado", Estado);
            cmd.Parameters.AddWithValue("@FechaAuditoria", FechaAuditoria);
            cmd.Parameters.AddWithValue("@UsuarioAuditoria", UsuarioAuditoria);
            cmd.ExecuteNonQuery();
            cd_conexion.MtdCerrarConexion();
        }

        public void MtdEliminarHabitaciones(int CodigoHabitacion)
        {
            string QueryEliminar = "Delete from tbl_Habitaciones where CodigoHabitacion=@CodigoHabitacion";
            SqlCommand cmd = new SqlCommand(QueryEliminar, cd_conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoProveedor", CodigoHabitacion);
            cmd.ExecuteNonQuery();
            cd_conexion.MtdCerrarConexion();
        }
    }
}
