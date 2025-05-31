using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using Proyecto_Final.Datos;

namespace Proyecto_Final
{
    internal class CDTratamientos
    {
        CDconexion cd_conexion = new CDconexion();

        public List<dynamic> MtdCodigoCita()
        {
            List<dynamic> ListaCitas = new List<dynamic>();
            string QueryListaCitas = "Select CodigoCita from tbl_Citas";
            SqlCommand cmd = new SqlCommand(QueryListaCitas, cd_conexion.MtdAbrirConexion());
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
               
                ListaCitas.Add(new
                {
                   Value = reader["CodigoCita"],
                   //Tex = $"{reader["CodigoCita"]} - {reader["Cita"]}"
                });
            }

            cd_conexion.MtdCerrarConexion();
            return ListaCitas;
        }

        public List<dynamic> MtdCodigoMedicamento()
        {
            List<dynamic> ListaMedicamento = new List<dynamic>();
            string QueryListaMedicamento = "Select CodigoMedicamento, Nombre from tbl_Medicamentos";
            SqlCommand cmd = new SqlCommand(QueryListaMedicamento, cd_conexion.MtdAbrirConexion());
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                ListaMedicamento.Add(new 
                {
                    Value = reader["CodigoMedicamento"],
                    Text = $"{reader["CodigoMedicamento"]} - {reader["Nombre"]}"
                });
            }

            cd_conexion.MtdCerrarConexion();
            return ListaMedicamento;
        }
        public void MtdAgregarTratamientos(string CodigoCita, string CodigoMedicamento, double Costo, DateTime FechaTratamiento, string Estado, DateTime FechaAuditoria, string UsuarioAuditoria)
        {
            string QueryAgregarTratamientos = "Insert into tbl_Tratamiento(CodigoCita, CodigoMedicamento,Costo, FechaTratamiento, Estado, FechaAuditoria, UsuarioAuditoria) values (@CodigoCita, @CodigoMedicamento, @Costo, @FechaTratamiento, @Estado, @FechaAuditoria, @UsuarioAuditoria)";
            SqlCommand cmd = new SqlCommand(QueryAgregarTratamientos, cd_conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoCita", CodigoCita);
            cmd.Parameters.AddWithValue("@CodigoMedicamento", CodigoMedicamento);
            cmd.Parameters.AddWithValue("@Costo", Costo);
            cmd.Parameters.AddWithValue("@FechaTratamiento", FechaTratamiento);
            cmd.Parameters.AddWithValue("@Estado", Estado);
            cmd.Parameters.AddWithValue("@FechaAuditoria", FechaAuditoria);
            cmd.Parameters.AddWithValue("@UsuarioAuditoria", UsuarioAuditoria);
            cmd.ExecuteNonQuery();
            cd_conexion.MtdCerrarConexion();
        }

        public void MtdActualizarTratamientos(string CodigoTratamiento, string CodigoCita, string CodigoMedicamento, double Costo, DateTime FechaTratamiento, string Estado, DateTime FechaAuditoria, string UsuarioAuditoria)
        {
            string QueryActualizarTratamientos = "Update tbl_Tratamiento set CodigoCita=@CodigoCita, CodigoMedicamento=@CodigoMedicamento, Costo=@Costo, FechaTratamiento=@FechaTratamiento, Estado=@Estado, FechaAuditoria=@FechaAuditoria, UsuarioAuditoria=@UsuarioAuditoria where CodigoTratamiento=@CodigoTratamiento";
            SqlCommand cmd = new SqlCommand(QueryActualizarTratamientos, cd_conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoTratamiento", CodigoTratamiento);
            cmd.Parameters.AddWithValue("@CodigoCita", CodigoCita);
            cmd.Parameters.AddWithValue("@CodigoMedicamento", CodigoMedicamento);
            cmd.Parameters.AddWithValue("@Costo", Costo);
            cmd.Parameters.AddWithValue("@FechaTratamiento", FechaTratamiento);
            cmd.Parameters.AddWithValue("@Estado", Estado);
            cmd.Parameters.AddWithValue("@FechaAuditoria", FechaAuditoria);
            cmd.Parameters.AddWithValue("@UsuarioAuditoria", UsuarioAuditoria);
            cmd.ExecuteNonQuery();
            cd_conexion.MtdCerrarConexion();

        }
        public DataTable MtdConsultarTratamiento()
        {
            string QueryConsultarTratamientos = "Select * from tbl_Tratamiento";
            SqlDataAdapter Adapter = new SqlDataAdapter(QueryConsultarTratamientos, cd_conexion.MtdAbrirConexion());
            DataTable Dt = new DataTable();
            Adapter.Fill(Dt);
            cd_conexion.MtdCerrarConexion();
            return Dt;
        }
        public void MtdEliminarTratamiento(int CodigoTratamientos)
        {
            string QueryEliminarTratamientos = "Delete tbl_Tratamiento where CodigoTratamiento=@CodigoTratamiento";
            SqlCommand cmd = new SqlCommand(QueryEliminarTratamientos, cd_conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoTratamiento", CodigoTratamientos);
            cmd.ExecuteNonQuery();
            cd_conexion.MtdCerrarConexion();
        }




    }   
}
