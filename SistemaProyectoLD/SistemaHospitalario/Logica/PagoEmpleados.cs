namespace SistemaHospitalario
{
    public class PagoEmpleados
    {
        public static double MtdSalarioEmpleado(string tipoTrabajo)
        {
            return tipoTrabajo switch
            {
                "Director" => 10000,
                "Medico" => 8000,
                "Enfermero" => 5000,
                "Tecnico" => 4000,
                "Farmaceutico" => 4500,
                _ => 0
            };
        }
    }
}