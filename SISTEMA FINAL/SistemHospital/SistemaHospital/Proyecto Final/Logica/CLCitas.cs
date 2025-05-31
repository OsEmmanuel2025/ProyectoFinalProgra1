namespace SistemaHospitalario.Logica
{
    public static class CLCitas
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
            string codigoHabitacion = null;

            // Simulación: paciente -> habitación
            if (codigoPaciente == "Paciente001")
                codigoHabitacion = "HAB01";
            else if (codigoPaciente == "Paciente002")
                codigoHabitacion = "HAB02";
            else
                codigoHabitacion = null;

            // Simulación: habitación -> costo
            if (codigoHabitacion == "HAB01")
                return 1200;
            else if (codigoHabitacion == "HAB02")
                return 1500;
            else
                return 0;
        }

    
}

}

