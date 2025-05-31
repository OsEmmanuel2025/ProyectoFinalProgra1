namespace SistemaHospitalario.Logica
{
    public class CLPagoCita
    {
        public static double MtdImpuestoPago(double monto) => monto * 0.12;

        public static double MtdDescuentoPago(double monto)
        {
            if (monto <= 500) return monto * 0.03;
            if (monto <= 5000) return monto * 0.05;
            return monto * 0.07;
        }

        public static double MtdTotalPago(double monto, double impuesto, double descuento)
        {
            return monto + impuesto - descuento;
        }
    }
}