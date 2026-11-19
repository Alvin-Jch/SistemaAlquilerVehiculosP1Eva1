using System.ComponentModel;

namespace SistemaAlquilerVehiculos.Modelos
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
    }
}
