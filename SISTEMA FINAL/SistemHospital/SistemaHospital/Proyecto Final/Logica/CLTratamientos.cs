using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_Final.Datos;
using System.Windows.Forms;
using System.Windows.Media.Animation;

namespace Proyecto_Final
{
    internal class CLTratamientos
    {
        CDconexion cd_conexion = new CDconexion();
        public DateTime MtdFechaHoy()
        {
            return DateTime.Now;
        }

        
        public double MtdCostoTratamiento(string CodigoMedicamento)
        {

            double CostoTratamiento = 0;

            string QueryConsultarCostoMedicamento = "Select Costo from tbl_Medicamentos where CodigoMedicamento=@CodigoMedicamento";
            SqlCommand CommandCostoMedicamento = new SqlCommand(QueryConsultarCostoMedicamento, cd_conexion.MtdAbrirConexion());
            CommandCostoMedicamento.Parameters.AddWithValue("@CodigoMedicamento", CodigoMedicamento);
            SqlDataReader reader = CommandCostoMedicamento.ExecuteReader();

            if (reader.Read())
            {
                CostoTratamiento = double.Parse(reader["Costo"].ToString());
            }
            else
            {
                CostoTratamiento = 0;
            }

            cd_conexion.MtdCerrarConexion();
            return CostoTratamiento;
        }


        

    }








    
}
