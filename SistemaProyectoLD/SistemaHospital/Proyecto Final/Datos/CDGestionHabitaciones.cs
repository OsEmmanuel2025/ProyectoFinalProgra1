using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProyecto.Datos
{
    internal class CDGestionHabitaciones
    {
        CDconexión cd_conexion = new CDconexión();

        public DataTable MtdConsultarGestionHabitaciones()
        {
            string QueryConsultar = "Select * from tbl_GestionHabitaciones";
            SqlDataAdapter SqlAdap = new SqlDataAdapter(QueryConsultar, cd_conexion.MtdAbrirConexion());
            DataTable Dt = new DataTable();
            SqlAdap.Fill(Dt);
            cd_conexion.MtdCerrarConexion();
            return Dt;
        }

        public void MtdAgregarGestionHabitaciones(int CodigoEmpleado, int CodigoHabitacion, string TipoGestion, DateTime FechaGestion, string Estado, DateTime FechaAuditoria, string UsuarioAuditoria)
        {
            string QueryAgregar = "Insert into tbl_GestionHabitaciones (CodigoEmpleado, CodigoHabitacion, TipoGestion, FechaGestion, Estado, FechaAuditoria, UsuarioAuditoria) values (@CodigoEmpleado, @CodigoHabitacion, @TipoGestion, @FechaGestion, @Estado, @FechaAuditoria, @UsuarioAuditoria)";
            SqlCommand cmd = new SqlCommand(QueryAgregar, cd_conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoEmpleado", CodigoEmpleado);
            cmd.Parameters.AddWithValue("@CodigoHabitacion", CodigoHabitacion);
            cmd.Parameters.AddWithValue("@TipoGestion", TipoGestion);
            cmd.Parameters.AddWithValue("@FechaGestion", FechaGestion);
            cmd.Parameters.AddWithValue("@Estado", Estado);
            cmd.Parameters.AddWithValue("@FechaAuditoria", FechaAuditoria);
            cmd.Parameters.AddWithValue("@UsuarioAuditoria", UsuarioAuditoria);
            cmd.ExecuteNonQuery();
            cd_conexion.MtdCerrarConexion();
        }

        public void MtdActualizarGestionHabitaciones(int CodigoGestion, int CodigoEmpleado, int CodigoHabitacion, string TipoGestion, DateTime FechaGestion, string Estado, DateTime FechaAuditoria, string UsuarioAuditoria)
        {
            string QueryActualizar = "Insert into tbl_GestionHabitaciones (CodigoGestion, CodigoEmpleado, CodigoHabitacion, TipoGestion, FechaGestion, Estado, FechaAuditoria, UsuarioAuditoria) values (@CodigoGestion, @CodigoEmpleado, @CodigoHabitacion, @TipoGestion, @FechaGestion, @Estado, @FechaAuditoria, @UsuarioAuditoria)";
            SqlCommand cmd = new SqlCommand(QueryActualizar, cd_conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoGestion", CodigoGestion);
            cmd.Parameters.AddWithValue("@CodigoEmpleado", CodigoEmpleado);
            cmd.Parameters.AddWithValue("@CodigoHabitacion", CodigoHabitacion);
            cmd.Parameters.AddWithValue("@TipoGestion", TipoGestion);
            cmd.Parameters.AddWithValue("@FechaGestion", FechaGestion);
            cmd.Parameters.AddWithValue("@Estado", Estado);
            cmd.Parameters.AddWithValue("@FechaAuditoria", FechaAuditoria);
            cmd.Parameters.AddWithValue("@UsuarioAuditoria", UsuarioAuditoria);
            cmd.ExecuteNonQuery();
            cd_conexion.MtdCerrarConexion();
        }

        public void MtdEliminarGestionHabitaciones(int CodigoGestionHabitacion)
        {
            string QueryEliminar = "Delete from tbl_GestionHabitaciones where CodigoGestionHabitacion=@CodigoGestionHabitacion";
            SqlCommand cmd = new SqlCommand(QueryEliminar, cd_conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoGestionHabitacion", CodigoGestionHabitacion);
            cmd.ExecuteNonQuery();
            cd_conexion.MtdCerrarConexion();
        }
    }
}
