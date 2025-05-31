using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProyecto.Lógica
{
    public class CLEmpleados
    {
        public DateTime MtdFechaHoy()
        {
            return DateTime.Now;
        }
        public double MtdSalarioEmpleado(string Sueldo)
        {
            if (Sueldo == "Director") return 30000;
            else if (Sueldo == "Médico") return 20000;
            else if (Sueldo == "Enfermero") return 10000;
            else if (Sueldo == "Técnico") return 7000;
            else if (Sueldo == "Farmacéutico") return 6000;
            else return 0;
        }
    }
}
