using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProyecto.Datos
{
    internal class CDPacientes
    {
        CDconexión cd_conexion = new CDconexión();

        public DataTable MtdConsultarPacientes()
        {
            string QueryConsultar = "Select * from tbl_Pacientes";
            SqlDataAdapter SqlAdap = new SqlDataAdapter(QueryConsultar, cd_conexion.MtdAbrirConexion());
            DataTable Dt = new DataTable();
            SqlAdap.Fill(Dt);
            cd_conexion.MtdCerrarConexion();
            return Dt;
        }

        public void MtdAgregarPacientes(int CodigoHabitacion, string Nombres, string Nit, DateTime FechaNacimiento, string TipoPaciente, string Estado, DateTime FechaAuditoria, string UsuarioAuditoria)
        {
            string QueryAgregar = "Insert into tbl_Pacientes (CodigoHabitacion, Nombres, Nit, FechaNacimiento, TipoPaciente, Estado, FechaAuditoria, UsuarioAuditoria) values (@CodigoHabitacion, @Nombres, @Nit, @FechaNacimiento, @TipoPaciente, @Estado, @FechaAuditoria, @UsuarioAuditoria)";
            SqlCommand cmd = new SqlCommand(QueryAgregar, cd_conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoHabitacion", CodigoHabitacion);
            cmd.Parameters.AddWithValue("@Nombres", Nombres);
            cmd.Parameters.AddWithValue("@Nit", Nit);
            cmd.Parameters.AddWithValue("@FechaNacimiento", FechaNacimiento);
            cmd.Parameters.AddWithValue("@TipoPaciente", TipoPaciente);
            cmd.Parameters.AddWithValue("@Estado", Estado);
            cmd.Parameters.AddWithValue("@FechaAuditoria", FechaAuditoria);
            cmd.Parameters.AddWithValue("@UsuarioAuditoria", UsuarioAuditoria);
            cmd.ExecuteNonQuery();
            cd_conexion.MtdCerrarConexion();
        }

        public void MtdActualizarPacientes(int CodigoPaciente, int CodigoHabitacion, string Nombres, string Nit, DateTime FechaNacimiento, string TipoPaciente, string Estado, DateTime FechaAuditoria, string UsuarioAuditoria)
        {
            string QueryActualizar = "Insert into tbl_Pacientes (CodigoPaciente, CodigoHabitacion, Nombres, Nit, FechaNacimiento, TipoPaciente, Estado, FechaAuditoria, UsuarioAuditoria) values (@CodigoPaciente, @CodigoHabitacion, @Nombres, @Nit, @FechaNacimiento, @TipoPaciente, @Estado, @FechaAuditoria, @UsuarioAuditoria)";
            SqlCommand cmd = new SqlCommand(QueryActualizar, cd_conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoPaciente", CodigoPaciente);
            cmd.Parameters.AddWithValue("@CodigoHabitacion", CodigoHabitacion);
            cmd.Parameters.AddWithValue("@Nombres", Nombres);
            cmd.Parameters.AddWithValue("@Nit", Nit);
            cmd.Parameters.AddWithValue("@FechaNacimiento", FechaNacimiento);
            cmd.Parameters.AddWithValue("@TipoPaciente", TipoPaciente);
            cmd.Parameters.AddWithValue("@Estado", Estado);
            cmd.Parameters.AddWithValue("@FechaAuditoria", FechaAuditoria);
            cmd.Parameters.AddWithValue("@UsuarioAuditoria", UsuarioAuditoria);
            cmd.ExecuteNonQuery();
            cd_conexion.MtdCerrarConexion();
        }

        public void MtdEliminarPacientes(int CodigoPaciente)
        {
            string QueryEliminar = "Delete from tbl_Pacientes where CodigoPaciente=@CodigoPaciente";
            SqlCommand cmd = new SqlCommand(QueryEliminar, cd_conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoPaciente", CodigoPaciente);
            cmd.ExecuteNonQuery();
            cd_conexion.MtdCerrarConexion();
        }
    }
}

