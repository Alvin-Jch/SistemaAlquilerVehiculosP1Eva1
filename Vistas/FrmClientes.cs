using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SistemaAlquilerVehiculos.Controladores;
using SistemaAlquilerVehiculos.Modelos;

namespace SistemaAlquilerVehiculos.Vistas
{
    public partial class FrmClientes : Form
    {
        private readonly ClientesController _ctrl = new ClientesController();
        private Cliente _seleccionado;
        private bool _cargando;

        public FrmClientes()
        {
            InitializeComponent();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            _cargando = true;
            try
            {
                dgv_clientes.DataSource = _ctrl.Seleccionar();
            }
            catch (Exception ex)
            {
                Error(ex);
            }
            _cargando = false;
            Nuevo();
        }

        private void Nuevo()
        {
            _cargando = true;
            _seleccionado = null;
            txt_id.Clear();
            txt_cedula.Clear();
            txt_nombre.Clear();
            txt_apellido.Clear();
            txt_telefono.Clear();
            txt_correo.Clear();
            dgv_clientes.ClearSelection();
            dgv_clientes.CurrentCell = null;
            SetModoEdicion(false);
            _cargando = false;
            txt_cedula.Focus();
        }

        private void SetModoEdicion(bool edicion)
        {
            txt_cedula.ReadOnly = edicion;
            txt_nombre.ReadOnly = edicion;
            txt_apellido.ReadOnly = edicion;
            txt_telefono.ReadOnly = edicion;
            txt_correo.ReadOnly = edicion;
            btn_guardar.Enabled = !edicion;
            btn_eliminar.Enabled = edicion;
        }

        private void Mostrar(Cliente c)
        {
            _cargando = true;
            txt_id.Text = c.IdCliente.ToString();
            txt_cedula.Text = c.Cedula ?? "";
            txt_nombre.Text = c.Nombre ?? "";
            txt_apellido.Text = c.Apellido ?? "";
            txt_telefono.Text = c.Telefono ?? "";
            txt_correo.Text = c.Correo ?? "";
            SetModoEdicion(true);
            _cargando = false;
        }

        private Cliente LeerFormulario()
        {
            var c = new Cliente();
            c.Cedula = txt_cedula.Text.Trim();
            if (c.Cedula.Length == 0)
            {
                Aviso("Ingrese un valor en 'Cédula'.", txt_cedula);
                return null;
            }
            c.Nombre = txt_nombre.Text.Trim();
            if (c.Nombre.Length == 0)
            {
                Aviso("Ingrese un valor en 'Nombre'.", txt_nombre);
                return null;
            }
            c.Apellido = txt_apellido.Text.Trim();
            if (c.Apellido.Length == 0)
            {
                Aviso("Ingrese un valor en 'Apellido'.", txt_apellido);
                return null;
            }
            c.Telefono = txt_telefono.Text.Trim();
            if (c.Telefono.Length == 0)
            {
                Aviso("Ingrese un valor en 'Teléfono'.", txt_telefono);
                return null;
            }
            c.Correo = txt_correo.Text.Trim();
            if (c.Correo.Length == 0 || !c.Correo.Contains('@'))
            {
                Aviso("Ingrese un 'Correo' válido.", txt_correo);
                return null;
            }
            return c;
        }

        private void dgv_clientes_SelectionChanged(object sender, EventArgs e)
        {
            if (_cargando) return;
            if (dgv_clientes.CurrentRow?.DataBoundItem is Cliente c)
            {
                _seleccionado = c;
                Mostrar(c);
            }
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            var c = LeerFormulario();
            if (c == null) return;
            try
            {
                _ctrl.Insertar(c);
                MessageBox.Show("Registro guardado correctamente.", "Información",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarDatos();
            }
            catch (Exception ex)
            {
                Error(ex);
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (_seleccionado == null)
            {
                Aviso("Seleccione un registro de la tabla para eliminarlo.", dgv_clientes);
                return;
            }
            var r = MessageBox.Show("¿Está seguro de eliminar el registro?", "Confirmar eliminación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r != DialogResult.Yes) return;
            try
            {
                if (_ctrl.Eliminar(_seleccionado))
                    MessageBox.Show("Registro eliminado correctamente.", "Información",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarDatos();
            }
            catch (Exception ex)
            {
                Error(ex);
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Aviso(string mensaje, Control control)
        {
            MessageBox.Show(mensaje, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            control.Focus();
        }

        private static void Error(Exception ex)
        {
            string detalle = ex.Message;
            if (ex is MySqlException mx)
            {
                if (mx.Number == 1062) detalle = "Ya existe un cliente con esa cédula.";
                else if (mx.Number == 1451) detalle = "No se puede eliminar el cliente porque tiene alquileres registrados.";
                else detalle = "Error de base de datos: " + mx.Message;
            }
            MessageBox.Show(detalle, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
