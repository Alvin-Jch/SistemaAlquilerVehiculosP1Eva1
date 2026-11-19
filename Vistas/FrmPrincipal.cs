using System;
using System.Windows.Forms;

namespace SistemaAlquilerVehiculos.Vistas
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void Abrir(Form frm)
        {
            using (frm)
            {
                frm.ShowDialog(this);
            }
        }

        private void btn_vehiculos_Click(object sender, EventArgs e)
        {
            Abrir(new FrmVehiculos());
        } 
        private void btn_clientes_Click(object sender, EventArgs e)
        {
             Abrir(new FrmClientes());
        }
        private void btn_alquileres_Click(object sender, EventArgs e)
        {
            Abrir(new FrmAlquileres());
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
