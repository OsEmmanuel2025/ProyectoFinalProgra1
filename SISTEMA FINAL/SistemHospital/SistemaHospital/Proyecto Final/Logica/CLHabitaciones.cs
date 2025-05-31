using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProyecto.Lógica
{
    public class CLHabitaciones
    {
        public DateTime MtdFechaHoy()
        {
            return DateTime.Now;
        }
        public double MtdCostoHabitacion(string Costo)
        {
            if (Costo == "General") return 300;
            else if (Costo == "Maternidad") return 1000;
            else if (Costo == "Pedriática") return 500;
            else if (Costo == "Aislamiento") return 3000;
            else if (Costo == "Observación") return 100;
            else return 0;
        }
    }
}
