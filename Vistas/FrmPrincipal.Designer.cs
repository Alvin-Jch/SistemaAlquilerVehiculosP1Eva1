namespace SistemaAlquilerVehiculos.Vistas
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lb_titulo = new Label();
            btn_vehiculos = new Button();
            btn_clientes = new Button();
            btn_alquileres = new Button();
            btn_salir = new Button();
            SuspendLayout();
            // 
            // lb_titulo
            // 
            lb_titulo.BackColor = Color.FromArgb(63, 58, 58);
            lb_titulo.Dock = DockStyle.Top;
            lb_titulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lb_titulo.ForeColor = Color.White;
            lb_titulo.Location = new Point(0, 0);
            lb_titulo.Name = "lb_titulo";
            lb_titulo.Size = new Size(440, 80);
            lb_titulo.TabIndex = 0;
            lb_titulo.Text = "Sistema de Alquiler de Vehículos";
            lb_titulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_vehiculos
            // 
            btn_vehiculos.BackColor = Color.FromArgb(110, 91, 91);
            btn_vehiculos.Cursor = Cursors.Hand;
            btn_vehiculos.FlatAppearance.BorderSize = 0;
            btn_vehiculos.FlatStyle = FlatStyle.Flat;
            btn_vehiculos.ForeColor = Color.White;
            btn_vehiculos.Location = new Point(85, 125);
            btn_vehiculos.Name = "btn_vehiculos";
            btn_vehiculos.Size = new Size(270, 50);
            btn_vehiculos.TabIndex = 1;
            btn_vehiculos.Text = "Vehículos";
            btn_vehiculos.UseVisualStyleBackColor = false;
            btn_vehiculos.Click += btn_vehiculos_Click;
            // 
            // btn_clientes
            // 
            btn_clientes.BackColor = Color.FromArgb(110, 91, 91);
            btn_clientes.Cursor = Cursors.Hand;
            btn_clientes.FlatAppearance.BorderSize = 0;
            btn_clientes.FlatStyle = FlatStyle.Flat;
            btn_clientes.ForeColor = Color.White;
            btn_clientes.Location = new Point(85, 195);
            btn_clientes.Name = "btn_clientes";
            btn_clientes.Size = new Size(270, 50);
            btn_clientes.TabIndex = 2;
            btn_clientes.Text = "Clientes";
            btn_clientes.UseVisualStyleBackColor = false;
            btn_clientes.Click += btn_clientes_Click;
            // 
            // btn_alquileres
            // 
            btn_alquileres.BackColor = Color.FromArgb(110, 91, 91);
            btn_alquileres.Cursor = Cursors.Hand;
            btn_alquileres.FlatAppearance.BorderSize = 0;
            btn_alquileres.FlatStyle = FlatStyle.Flat;
            btn_alquileres.ForeColor = Color.White;
            btn_alquileres.Location = new Point(85, 265);
            btn_alquileres.Name = "btn_alquileres";
            btn_alquileres.Size = new Size(270, 50);
            btn_alquileres.TabIndex = 3;
            btn_alquileres.Text = "Alquileres";
            btn_alquileres.UseVisualStyleBackColor = false;
            btn_alquileres.Click += btn_alquileres_Click;
            // 
            // btn_salir
            // 
            btn_salir.BackColor = Color.FromArgb(167, 138, 127);
            btn_salir.Cursor = Cursors.Hand;
            btn_salir.FlatAppearance.BorderSize = 0;
            btn_salir.FlatStyle = FlatStyle.Flat;
            btn_salir.ForeColor = Color.White;
            btn_salir.Location = new Point(85, 345);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(270, 40);
            btn_salir.TabIndex = 4;
            btn_salir.Text = "Salir";
            btn_salir.UseVisualStyleBackColor = false;
            btn_salir.Click += btn_salir_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(228, 213, 183);
            ClientSize = new Size(440, 420);
            Controls.Add(btn_salir);
            Controls.Add(btn_alquileres);
            Controls.Add(btn_clientes);
            Controls.Add(btn_vehiculos);
            Controls.Add(lb_titulo);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Alquiler de Vehículos";
            ResumeLayout(false);
        }

        #endregion

        private Label lb_titulo;
        private Button btn_vehiculos;
        private Button btn_clientes;
        private Button btn_alquileres;
        private Button btn_salir;
    }
}
