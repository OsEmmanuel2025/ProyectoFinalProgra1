namespace SistemaHospitalario.Logica
{
    public static class Citas
    {
        // Simulación de búsqueda en tabla Tratamientos
        public static double MtdCostoTratamientos(string codigoCita)

        {
            // Ejemplo simulado
            if (codigoCita == "Cita001") return 250;
            if (codigoCita == "Cita002") return 400;
            return 0;
        }

        // Simulación de búsqueda en tabla Pacientes y Habitaciones
        public static double MtdCostoHabitacion(string codigoPaciente)
        {
            // Simulación: paciente -> habitación
            string codigoHabitacion = codigoPaciente switch
            {
                "Paciente001" => "HAB01",
                "Paciente002" => "HAB02",
                _ => null
            };

            // Simulación: habitación -> costo
            return codigoHabitacion switch
            {
                "HAB01" => 1200,
                "HAB02" => 1500,
                _ => 0
            };
        }
    }

}

