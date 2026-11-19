using System.ComponentModel;

namespace SistemaAlquilerVehiculos.Modelos
{
    public class Vehiculo
    {
        public int IdVehiculo { get; set; }
        public string Placa { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Anio { get; set; }
        public string Color { get; set; }
        public decimal PrecioDia { get; set; }
    }
}
