namespace Proyecto_Final
{
    partial class FRMMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMMenu));
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.PanelFormularios = new System.Windows.Forms.Panel();
            this.btnSalir = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.iconUsuarios = new FontAwesome.Sharp.IconButton();
            this.iconPagoEmp = new FontAwesome.Sharp.IconButton();
            this.iconPagoCitas = new FontAwesome.Sharp.IconButton();
            this.iconCita = new FontAwesome.Sharp.IconButton();
            this.iconGestionHab = new FontAwesome.Sharp.IconButton();
            this.iconEmpleados = new FontAwesome.Sharp.IconButton();
            this.iconPacientes = new FontAwesome.Sharp.IconButton();
            this.iconHabitaciones = new FontAwesome.Sharp.IconButton();
            this.iconTratamientos = new FontAwesome.Sharp.IconButton();
            this.iconMedicamentos = new FontAwesome.Sharp.IconButton();
            this.PanelTitulo = new System.Windows.Forms.Panel();
            this.FechaHoy = new System.Windows.Forms.Label();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.PanelContenedor.SuspendLayout();
            this.PanelFormularios.SuspendLayout();
            this.PanelMenu.SuspendLayout();
            this.PanelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PanelContenedor.Controls.Add(this.PanelFormularios);
            this.PanelContenedor.Controls.Add(this.PanelMenu);
            this.PanelContenedor.Controls.Add(this.PanelTitulo);
            this.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenedor.Location = new System.Drawing.Point(0, 0);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(821, 650);
            this.PanelContenedor.TabIndex = 0;
            this.PanelContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelContenedor_Paint);
            // 
            // PanelFormularios
            // 
            this.PanelFormularios.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PanelFormularios.Controls.Add(this.btnSalir);
            this.PanelFormularios.Controls.Add(this.label2);
            this.PanelFormularios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelFormularios.Location = new System.Drawing.Point(200, 40);
            this.PanelFormularios.Name = "PanelFormularios";
            this.PanelFormularios.Size = new System.Drawing.Size(621, 610);
            this.PanelFormularios.TabIndex = 3;
            this.PanelFormularios.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelFormularios_Paint);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSalir.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.btnSalir.IconColor = System.Drawing.Color.Black;
            this.btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSalir.IconSize = 25;
            this.btnSalir.Location = new System.Drawing.Point(507, 570);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(88, 28);
            this.btnSalir.TabIndex = 27;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(252, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "MENU PRINCIPAL";
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.SystemColors.Highlight;
            this.PanelMenu.Controls.Add(this.iconUsuarios);
            this.PanelMenu.Controls.Add(this.iconPagoEmp);
            this.PanelMenu.Controls.Add(this.iconPagoCitas);
            this.PanelMenu.Controls.Add(this.iconCita);
            this.PanelMenu.Controls.Add(this.iconGestionHab);
            this.PanelMenu.Controls.Add(this.iconEmpleados);
            this.PanelMenu.Controls.Add(this.iconPacientes);
            this.PanelMenu.Controls.Add(this.iconHabitaciones);
            this.PanelMenu.Controls.Add(this.iconTratamientos);
            this.PanelMenu.Controls.Add(this.iconMedicamentos);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.Location = new System.Drawing.Point(0, 40);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(200, 610);
            this.PanelMenu.TabIndex = 2;
            // 
            // iconUsuarios
            // 
            this.iconUsuarios.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.iconUsuarios.IconChar = FontAwesome.Sharp.IconChar.UsersRectangle;
            this.iconUsuarios.IconColor = System.Drawing.Color.Black;
            this.iconUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconUsuarios.IconSize = 30;
            this.iconUsuarios.Location = new System.Drawing.Point(25, 502);
            this.iconUsuarios.Name = "iconUsuarios";
            this.iconUsuarios.Size = new System.Drawing.Size(115, 34);
            this.iconUsuarios.TabIndex = 12;
            this.iconUsuarios.Text = "Usuarios";
            this.iconUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconUsuarios.UseVisualStyleBackColor = false;
            this.iconUsuarios.Click += new System.EventHandler(this.iconUsuarios_Click);
            // 
            // iconPagoEmp
            // 
            this.iconPagoEmp.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.iconPagoEmp.IconChar = FontAwesome.Sharp.IconChar.MoneyCheckDollar;
            this.iconPagoEmp.IconColor = System.Drawing.Color.Black;
            this.iconPagoEmp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPagoEmp.IconSize = 30;
            this.iconPagoEmp.Location = new System.Drawing.Point(26, 449);
            this.iconPagoEmp.Name = "iconPagoEmp";
            this.iconPagoEmp.Size = new System.Drawing.Size(115, 34);
            this.iconPagoEmp.TabIndex = 11;
            this.iconPagoEmp.Text = "Pago Emplea.";
            this.iconPagoEmp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconPagoEmp.UseVisualStyleBackColor = false;
            this.iconPagoEmp.Click += new System.EventHandler(this.iconPagoEmp_Click);
            // 
            // iconPagoCitas
            // 
            this.iconPagoCitas.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.iconPagoCitas.IconChar = FontAwesome.Sharp.IconChar.CreditCardAlt;
            this.iconPagoCitas.IconColor = System.Drawing.Color.Black;
            this.iconPagoCitas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPagoCitas.IconSize = 30;
            this.iconPagoCitas.Location = new System.Drawing.Point(25, 390);
            this.iconPagoCitas.Name = "iconPagoCitas";
            this.iconPagoCitas.Size = new System.Drawing.Size(115, 34);
            this.iconPagoCitas.TabIndex = 10;
            this.iconPagoCitas.Text = "Pago Citas";
            this.iconPagoCitas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconPagoCitas.UseVisualStyleBackColor = false;
            this.iconPagoCitas.Click += new System.EventHandler(this.iconPagoCitas_Click);
            // 
            // iconCita
            // 
            this.iconCita.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.iconCita.IconChar = FontAwesome.Sharp.IconChar.CalendarCheck;
            this.iconCita.IconColor = System.Drawing.Color.Black;
            this.iconCita.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCita.IconSize = 30;
            this.iconCita.Location = new System.Drawing.Point(25, 327);
            this.iconCita.Name = "iconCita";
            this.iconCita.Size = new System.Drawing.Size(115, 41);
            this.iconCita.TabIndex = 9;
            this.iconCita.Text = "Citas";
            this.iconCita.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconCita.UseVisualStyleBackColor = false;
            this.iconCita.Click += new System.EventHandler(this.iconCita_Click);
            // 
            // iconGestionHab
            // 
            this.iconGestionHab.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.iconGestionHab.IconChar = FontAwesome.Sharp.IconChar.ListCheck;
            this.iconGestionHab.IconColor = System.Drawing.Color.Black;
            this.iconGestionHab.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconGestionHab.IconSize = 30;
            this.iconGestionHab.Location = new System.Drawing.Point(26, 271);
            this.iconGestionHab.Name = "iconGestionHab";
            this.iconGestionHab.Size = new System.Drawing.Size(115, 36);
            this.iconGestionHab.TabIndex = 8;
            this.iconGestionHab.Text = "Gestion Hab.";
            this.iconGestionHab.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconGestionHab.UseVisualStyleBackColor = false;
            this.iconGestionHab.Click += new System.EventHandler(this.iconGestionHab_Click);
            // 
            // iconEmpleados
            // 
            this.iconEmpleados.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.iconEmpleados.IconChar = FontAwesome.Sharp.IconChar.UserMd;
            this.iconEmpleados.IconColor = System.Drawing.Color.Black;
            this.iconEmpleados.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconEmpleados.IconSize = 30;
            this.iconEmpleados.Location = new System.Drawing.Point(26, 220);
            this.iconEmpleados.Name = "iconEmpleados";
            this.iconEmpleados.Size = new System.Drawing.Size(115, 36);
            this.iconEmpleados.TabIndex = 7;
            this.iconEmpleados.Text = "Empleados";
            this.iconEmpleados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconEmpleados.UseVisualStyleBackColor = false;
            this.iconEmpleados.Click += new System.EventHandler(this.iconEmpleados_Click);
            // 
            // iconPacientes
            // 
            this.iconPacientes.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.iconPacientes.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.iconPacientes.IconColor = System.Drawing.Color.Black;
            this.iconPacientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPacientes.IconSize = 30;
            this.iconPacientes.Location = new System.Drawing.Point(26, 164);
            this.iconPacientes.Name = "iconPacientes";
            this.iconPacientes.Size = new System.Drawing.Size(115, 41);
            this.iconPacientes.TabIndex = 6;
            this.iconPacientes.Text = "Pacientes";
            this.iconPacientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconPacientes.UseVisualStyleBackColor = false;
            this.iconPacientes.Click += new System.EventHandler(this.iconPacientes_Click);
            // 
            // iconHabitaciones
            // 
            this.iconHabitaciones.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.iconHabitaciones.IconChar = FontAwesome.Sharp.IconChar.ShopLock;
            this.iconHabitaciones.IconColor = System.Drawing.Color.Black;
            this.iconHabitaciones.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconHabitaciones.IconSize = 30;
            this.iconHabitaciones.Location = new System.Drawing.Point(25, 110);
            this.iconHabitaciones.Name = "iconHabitaciones";
            this.iconHabitaciones.Size = new System.Drawing.Size(115, 35);
            this.iconHabitaciones.TabIndex = 5;
            this.iconHabitaciones.Text = "Habitaciones";
            this.iconHabitaciones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconHabitaciones.UseVisualStyleBackColor = false;
            this.iconHabitaciones.Click += new System.EventHandler(this.iconHabitaciones_Click);
            // 
            // iconTratamientos
            // 
            this.iconTratamientos.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.iconTratamientos.IconChar = FontAwesome.Sharp.IconChar.PrescriptionBottle;
            this.iconTratamientos.IconColor = System.Drawing.Color.Black;
            this.iconTratamientos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconTratamientos.IconSize = 30;
            this.iconTratamientos.Location = new System.Drawing.Point(25, 59);
            this.iconTratamientos.Name = "iconTratamientos";
            this.iconTratamientos.Size = new System.Drawing.Size(115, 35);
            this.iconTratamientos.TabIndex = 4;
            this.iconTratamientos.Text = "Tratamientos";
            this.iconTratamientos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconTratamientos.UseVisualStyleBackColor = false;
            this.iconTratamientos.Click += new System.EventHandler(this.iconTratamientos_Click);
            // 
            // iconMedicamentos
            // 
            this.iconMedicamentos.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.iconMedicamentos.IconChar = FontAwesome.Sharp.IconChar.BookMedical;
            this.iconMedicamentos.IconColor = System.Drawing.Color.Black;
            this.iconMedicamentos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMedicamentos.IconSize = 30;
            this.iconMedicamentos.Location = new System.Drawing.Point(25, 6);
            this.iconMedicamentos.Name = "iconMedicamentos";
            this.iconMedicamentos.Size = new System.Drawing.Size(115, 35);
            this.iconMedicamentos.TabIndex = 3;
            this.iconMedicamentos.Text = "Medicamentos";
            this.iconMedicamentos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconMedicamentos.UseVisualStyleBackColor = false;
            this.iconMedicamentos.Click += new System.EventHandler(this.iconMedicamentos_Click);
            // 
            // PanelTitulo
            // 
            this.PanelTitulo.BackColor = System.Drawing.SystemColors.Highlight;
            this.PanelTitulo.Controls.Add(this.FechaHoy);
            this.PanelTitulo.Controls.Add(this.btnRestaurar);
            this.PanelTitulo.Controls.Add(this.label1);
            this.PanelTitulo.Controls.Add(this.btnMinimizar);
            this.PanelTitulo.Controls.Add(this.btnMaximizar);
            this.PanelTitulo.Controls.Add(this.btnCerrar);
            this.PanelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTitulo.Location = new System.Drawing.Point(0, 0);
            this.PanelTitulo.Name = "PanelTitulo";
            this.PanelTitulo.Size = new System.Drawing.Size(821, 40);
            this.PanelTitulo.TabIndex = 1;
            this.PanelTitulo.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelTitulo_Paint);
            this.PanelTitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelTitulo_MouseMove);
            // 
            // FechaHoy
            // 
            this.FechaHoy.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.FechaHoy.AutoSize = true;
            this.FechaHoy.Location = new System.Drawing.Point(609, 14);
            this.FechaHoy.Name = "FechaHoy";
            this.FechaHoy.Size = new System.Drawing.Size(72, 13);
            this.FechaHoy.TabIndex = 3;
            this.FechaHoy.Text = "imprimeFecha";
            this.FechaHoy.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.FechaHoy.Click += new System.EventHandler(this.FechaHoy_Click);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("btnRestaurar.Image")));
            this.btnRestaurar.Location = new System.Drawing.Point(747, 12);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(16, 16);
            this.btnRestaurar.TabIndex = 0;
            this.btnRestaurar.TabStop = false;
            this.btnRestaurar.Visible = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(186, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(382, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "HOSPITAL SALUD INTEGRAL S. A.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(725, 12);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(16, 16);
            this.btnMinimizar.TabIndex = 0;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.Image")));
            this.btnMaximizar.Location = new System.Drawing.Point(747, 12);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(16, 16);
            this.btnMaximizar.TabIndex = 1;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(769, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(16, 15);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // FRMMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 650);
            this.Controls.Add(this.PanelContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(650, 400);
            this.Name = "FRMMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.PanelContenedor.ResumeLayout(false);
            this.PanelFormularios.ResumeLayout(false);
            this.PanelFormularios.PerformLayout();
            this.PanelMenu.ResumeLayout(false);
            this.PanelTitulo.ResumeLayout(false);
            this.PanelTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelContenedor;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Panel PanelTitulo;
        private System.Windows.Forms.Panel PanelFormularios;
        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.PictureBox btnRestaurar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton iconMedicamentos;
        private FontAwesome.Sharp.IconButton iconTratamientos;
        private System.Windows.Forms.Label FechaHoy;
        private FontAwesome.Sharp.IconButton iconHabitaciones;
        private FontAwesome.Sharp.IconButton iconPacientes;
        private FontAwesome.Sharp.IconButton iconEmpleados;
        private FontAwesome.Sharp.IconButton iconGestionHab;
        private FontAwesome.Sharp.IconButton iconCita;
        private FontAwesome.Sharp.IconButton iconPagoEmp;
        private FontAwesome.Sharp.IconButton iconPagoCitas;
        private FontAwesome.Sharp.IconButton iconUsuarios;
        private FontAwesome.Sharp.IconButton btnSalir;
    }
}