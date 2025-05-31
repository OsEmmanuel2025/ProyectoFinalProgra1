namespace SistemaHospitalario
{
    public class CLPagoEmpleados
    {

        public static double MtdSalarioEmpleado(string tipoTrabajo)
        {
            if (tipoTrabajo == "Director")
                return 10000;
            else if (tipoTrabajo == "Medico")
                return 8000;
            else if (tipoTrabajo == "Enfermero")
                return 5000;
            else if (tipoTrabajo == "Tecnico")
                return 4000;
            else if (tipoTrabajo == "Farmaceutico")
                return 4500;
            else
                return 0;
        }

    }
}