namespace SistemaAlquilerVehiculos.Vistas
{
    partial class FrmAlquileres
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            lb_id = new Label();
            lb_cliente = new Label();
            lb_vehiculo = new Label();
            lb_inicio = new Label();
            lb_fin = new Label();
            lb_total = new Label();
            txt_id = new TextBox();
            cmb_cliente = new ComboBox();
            cmb_vehiculo = new ComboBox();
            dtp_inicio = new DateTimePicker();
            dtp_fin = new DateTimePicker();
            txt_total = new TextBox();
            btn_nuevo = new Button();
            btn_guardar = new Button();
            btn_eliminar = new Button();
            btn_salir = new Button();
            dgv_alquileres = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgv_alquileres).BeginInit();
            SuspendLayout();
            // 
            // lb_id
            // 
            lb_id.AutoSize = true;
            lb_id.ForeColor = Color.FromArgb(63, 58, 58);
            lb_id.Location = new Point(28, 20);
            lb_id.Name = "lb_id";
            lb_id.Size = new Size(27, 20);
            lb_id.TabIndex = 0;
            lb_id.Text = "ID:";
            // 
            // lb_cliente
            // 
            lb_cliente.AutoSize = true;
            lb_cliente.ForeColor = Color.FromArgb(63, 58, 58);
            lb_cliente.Location = new Point(28, 64);
            lb_cliente.Name = "lb_cliente";
            lb_cliente.Size = new Size(58, 20);
            lb_cliente.TabIndex = 1;
            lb_cliente.Text = "Cliente:";
            // 
            // lb_vehiculo
            // 
            lb_vehiculo.AutoSize = true;
            lb_vehiculo.ForeColor = Color.FromArgb(63, 58, 58);
            lb_vehiculo.Location = new Point(28, 108);
            lb_vehiculo.Name = "lb_vehiculo";
            lb_vehiculo.Size = new Size(68, 20);
            lb_vehiculo.TabIndex = 2;
            lb_vehiculo.Text = "Vehículo:";
            // 
            // lb_inicio
            // 
            lb_inicio.AutoSize = true;
            lb_inicio.ForeColor = Color.FromArgb(63, 58, 58);
            lb_inicio.Location = new Point(402, 20);
            lb_inicio.Name = "lb_inicio";
            lb_inicio.Size = new Size(90, 20);
            lb_inicio.TabIndex = 3;
            lb_inicio.Text = "Fecha inicio:";
            // 
            // lb_fin
            // 
            lb_fin.AutoSize = true;
            lb_fin.ForeColor = Color.FromArgb(63, 58, 58);
            lb_fin.Location = new Point(402, 64);
            lb_fin.Name = "lb_fin";
            lb_fin.Size = new Size(71, 20);
            lb_fin.TabIndex = 4;
            lb_fin.Text = "Fecha fin:";
            // 
            // lb_total
            // 
            lb_total.AutoSize = true;
            lb_total.ForeColor = Color.FromArgb(63, 58, 58);
            lb_total.Location = new Point(402, 108);
            lb_total.Name = "lb_total";
            lb_total.Size = new Size(100, 20);
            lb_total.TabIndex = 5;
            lb_total.Text = "Total a pagar:";
            // 
            // txt_id
            // 
            txt_id.BackColor = Color.White;
            txt_id.Location = new Point(130, 20);
            txt_id.Name = "txt_id";
            txt_id.ReadOnly = true;
            txt_id.Size = new Size(205, 27);
            txt_id.TabIndex = 6;
            txt_id.TabStop = false;
            // 
            // cmb_cliente
            // 
            cmb_cliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_cliente.FormattingEnabled = true;
            cmb_cliente.Location = new Point(130, 64);
            cmb_cliente.Name = "cmb_cliente";
            cmb_cliente.Size = new Size(250, 28);
            cmb_cliente.TabIndex = 7;
            // 
            // cmb_vehiculo
            // 
            cmb_vehiculo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_vehiculo.FormattingEnabled = true;
            cmb_vehiculo.Location = new Point(130, 108);
            cmb_vehiculo.Name = "cmb_vehiculo";
            cmb_vehiculo.Size = new Size(250, 28);
            cmb_vehiculo.TabIndex = 8;
            cmb_vehiculo.SelectedIndexChanged += Combo_Cambio;
            // 
            // dtp_inicio
            // 
            dtp_inicio.Format = DateTimePickerFormat.Short;
            dtp_inicio.Location = new Point(525, 20);
            dtp_inicio.Name = "dtp_inicio";
            dtp_inicio.Size = new Size(197, 27);
            dtp_inicio.TabIndex = 9;
            dtp_inicio.ValueChanged += Combo_Cambio;
            // 
            // dtp_fin
            // 
            dtp_fin.Format = DateTimePickerFormat.Short;
            dtp_fin.Location = new Point(525, 64);
            dtp_fin.Name = "dtp_fin";
            dtp_fin.Size = new Size(197, 27);
            dtp_fin.TabIndex = 10;
            dtp_fin.ValueChanged += Combo_Cambio;
            // 
            // txt_total
            // 
            txt_total.BackColor = Color.White;
            txt_total.Location = new Point(525, 108);
            txt_total.Name = "txt_total";
            txt_total.ReadOnly = true;
            txt_total.Size = new Size(197, 27);
            txt_total.TabIndex = 11;
            txt_total.TabStop = false;
            // 
            // btn_nuevo
            // 
            btn_nuevo.BackColor = Color.FromArgb(110, 91, 91);
            btn_nuevo.Cursor = Cursors.Hand;
            btn_nuevo.FlatAppearance.BorderSize = 0;
            btn_nuevo.FlatStyle = FlatStyle.Flat;
            btn_nuevo.ForeColor = Color.White;
            btn_nuevo.Location = new Point(28, 160);
            btn_nuevo.Name = "btn_nuevo";
            btn_nuevo.Size = new Size(126, 31);
            btn_nuevo.TabIndex = 12;
            btn_nuevo.Text = "Nuevo";
            btn_nuevo.UseVisualStyleBackColor = false;
            btn_nuevo.Click += btn_nuevo_Click;
            // 
            // btn_guardar
            // 
            btn_guardar.BackColor = Color.FromArgb(110, 91, 91);
            btn_guardar.Cursor = Cursors.Hand;
            btn_guardar.FlatAppearance.BorderSize = 0;
            btn_guardar.FlatStyle = FlatStyle.Flat;
            btn_guardar.ForeColor = Color.White;
            btn_guardar.Location = new Point(169, 160);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(126, 31);
            btn_guardar.TabIndex = 13;
            btn_guardar.Text = "Guardar";
            btn_guardar.UseVisualStyleBackColor = false;
            btn_guardar.Click += btn_guardar_Click;
            // 
            // btn_eliminar
            // 
            btn_eliminar.BackColor = Color.FromArgb(63, 58, 58);
            btn_eliminar.Cursor = Cursors.Hand;
            btn_eliminar.FlatAppearance.BorderSize = 0;
            btn_eliminar.FlatStyle = FlatStyle.Flat;
            btn_eliminar.ForeColor = Color.White;
            btn_eliminar.Location = new Point(310, 160);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(126, 31);
            btn_eliminar.TabIndex = 14;
            btn_eliminar.Text = "Eliminar";
            btn_eliminar.UseVisualStyleBackColor = false;
            btn_eliminar.Click += btn_eliminar_Click;
            // 
            // btn_salir
            // 
            btn_salir.BackColor = Color.FromArgb(167, 138, 127);
            btn_salir.Cursor = Cursors.Hand;
            btn_salir.FlatAppearance.BorderSize = 0;
            btn_salir.FlatStyle = FlatStyle.Flat;
            btn_salir.ForeColor = Color.White;
            btn_salir.Location = new Point(596, 160);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(126, 31);
            btn_salir.TabIndex = 15;
            btn_salir.Text = "Salir";
            btn_salir.UseVisualStyleBackColor = false;
            btn_salir.Click += btn_salir_Click;
            // 
            // dgv_alquileres
            // 
            dgv_alquileres.AllowUserToAddRows = false;
            dgv_alquileres.AllowUserToDeleteRows = false;
            dgv_alquileres.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(201, 183, 156);
            dgv_alquileres.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgv_alquileres.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_alquileres.BackgroundColor = Color.FromArgb(228, 213, 183);
            dgv_alquileres.BorderStyle = BorderStyle.None;
            dgv_alquileres.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(63, 58, 58);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(63, 58, 58);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dgv_alquileres.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgv_alquileres.ColumnHeadersHeight = 34;
            dgv_alquileres.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(228, 213, 183);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(63, 58, 58);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(110, 91, 91);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgv_alquileres.DefaultCellStyle = dataGridViewCellStyle3;
            dgv_alquileres.EnableHeadersVisualStyles = false;
            dgv_alquileres.GridColor = Color.FromArgb(167, 138, 127);
            dgv_alquileres.Location = new Point(28, 210);
            dgv_alquileres.MultiSelect = false;
            dgv_alquileres.Name = "dgv_alquileres";
            dgv_alquileres.ReadOnly = true;
            dgv_alquileres.RowHeadersVisible = false;
            dgv_alquileres.RowHeadersWidth = 51;
            dgv_alquileres.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_alquileres.Size = new Size(694, 280);
            dgv_alquileres.TabIndex = 16;
            dgv_alquileres.SelectionChanged += dgv_alquileres_SelectionChanged;
            // 
            // FrmAlquileres
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(228, 213, 183);
            ClientSize = new Size(773, 510);
            Controls.Add(dgv_alquileres);
            Controls.Add(btn_salir);
            Controls.Add(btn_eliminar);
            Controls.Add(btn_guardar);
            Controls.Add(btn_nuevo);
            Controls.Add(txt_total);
            Controls.Add(dtp_fin);
            Controls.Add(dtp_inicio);
            Controls.Add(cmb_vehiculo);
            Controls.Add(cmb_cliente);
            Controls.Add(txt_id);
            Controls.Add(lb_total);
            Controls.Add(lb_fin);
            Controls.Add(lb_inicio);
            Controls.Add(lb_vehiculo);
            Controls.Add(lb_cliente);
            Controls.Add(lb_id);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmAlquileres";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de Alquileres";
            Load += FrmAlquileres_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_alquileres).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_id;
        private Label lb_cliente;
        private Label lb_vehiculo;
        private Label lb_inicio;
        private Label lb_fin;
        private Label lb_total;
        private TextBox txt_id;
        private ComboBox cmb_cliente;
        private ComboBox cmb_vehiculo;
        private DateTimePicker dtp_inicio;
        private DateTimePicker dtp_fin;
        private TextBox txt_total;
        private Button btn_nuevo;
        private Button btn_guardar;
        private Button btn_eliminar;
        private Button btn_salir;
        private DataGridView dgv_alquileres;
    }
}
