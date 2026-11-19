using System.ComponentModel;

namespace SistemaAlquilerVehiculos.Modelos
{
    public class Alquiler
    {
        public int IdAlquiler { get; set; }
        public string Cliente { get; set; }
        public string Vehiculo { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public decimal Total { get; set; }
        [Browsable(false)]
        public int IdCliente { get; set; }
        [Browsable(false)]
        public int IdVehiculo { get; set; }
    }
}
