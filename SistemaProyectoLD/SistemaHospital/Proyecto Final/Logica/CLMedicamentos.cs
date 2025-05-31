using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final
{
    internal class Cal_Medicamentos
    {
        public DateTime MtdFechaHoy()
        {
            return DateTime.Now;
        }

        public double MtdCostoMedicamentos(string Medicamento)
        {

            if (Medicamento == "Jarabe") return 150.00;
            else if (Medicamento == "Suero") return 25;
            else if (Medicamento == "Crema") return 75.00;
            else if (Medicamento == "Tableta") return 25.00;
            else if (Medicamento == "Aereosol") return 100.00;
            else if (Medicamento == "Inyeccion") return 125.00;
            else return 0;

        }



    }
}
