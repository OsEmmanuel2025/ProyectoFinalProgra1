namespace Proyecto_Final
{
    partial class FRMTratamientos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCodigoTratamiento = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cboxEstado = new System.Windows.Forms.ComboBox();
            this.DtpFechaTratamiento = new System.Windows.Forms.DateTimePicker();
            this.lblCosto = new System.Windows.Forms.Label();
            this.dgvTratamientos = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new FontAwesome.Sharp.IconButton();
            this.btnEditar = new FontAwesome.Sharp.IconButton();
            this.btnCancelar = new FontAwesome.Sharp.IconButton();
            this.btnEliminar = new FontAwesome.Sharp.IconButton();
            this.btnSalir = new FontAwesome.Sharp.IconButton();
            this.cboxCodigoCita = new System.Windows.Forms.ComboBox();
            this.cboxCodigoMedicamento = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblFechaHoy = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTratamientos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(324, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "TRATAMIENTOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Codigo Tratamiento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Codigo Cita:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Codigo Medicamento:";
            // 
            // txtCodigoTratamiento
            // 
            this.txtCodigoTratamiento.Location = new System.Drawing.Point(208, 54);
            this.txtCodigoTratamiento.Name = "txtCodigoTratamiento";
            this.txtCodigoTratamiento.ReadOnly = true;
            this.txtCodigoTratamiento.Size = new System.Drawing.Size(121, 20);
            this.txtCodigoTratamiento.TabIndex = 28;
            this.txtCodigoTratamiento.TextChanged += new System.EventHandler(this.txtCodigoTratamiento_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(363, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 31;
            this.label5.Text = "Costo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(363, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 20);
            this.label6.TabIndex = 32;
            this.label6.Text = "Fecha Tratamiento:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(363, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 20);
            this.label7.TabIndex = 33;
            this.label7.Text = "Estado:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // cboxEstado
            // 
            this.cboxEstado.FormattingEnabled = true;
            this.cboxEstado.Items.AddRange(new object[] {
            "Pendiente",
            "Progreso",
            "Completado",
            "Suspendido",
            "Cancelado"});
            this.cboxEstado.Location = new System.Drawing.Point(533, 122);
            this.cboxEstado.Name = "cboxEstado";
            this.cboxEstado.Size = new System.Drawing.Size(121, 21);
            this.cboxEstado.TabIndex = 34;
            // 
            // DtpFechaTratamiento
            // 
            this.DtpFechaTratamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpFechaTratamiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechaTratamiento.Location = new System.Drawing.Point(534, 89);
            this.DtpFechaTratamiento.Margin = new System.Windows.Forms.Padding(2);
            this.DtpFechaTratamiento.Name = "DtpFechaTratamiento";
            this.DtpFechaTratamiento.Size = new System.Drawing.Size(120, 21);
            this.DtpFechaTratamiento.TabIndex = 35;
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.Location = new System.Drawing.Point(543, 52);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(36, 13);
            this.lblCosto.TabIndex = 36;
            this.lblCosto.Text = "precio";
            this.lblCosto.Click += new System.EventHandler(this.lblCosto_Click);
            // 
            // dgvTratamientos
            // 
            this.dgvTratamientos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvTratamientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTratamientos.Location = new System.Drawing.Point(16, 185);
            this.dgvTratamientos.Name = "dgvTratamientos";
            this.dgvTratamientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTratamientos.Size = new System.Drawing.Size(757, 150);
            this.dgvTratamientos.TabIndex = 37;
            this.dgvTratamientos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dgvTratamientos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnAgregar
            // 
            this.btnAgregar.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btnAgregar.IconColor = System.Drawing.Color.Black;
            this.btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregar.IconSize = 25;
            this.btnAgregar.Location = new System.Drawing.Point(700, 37);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(88, 28);
            this.btnAgregar.TabIndex = 38;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.IconChar = FontAwesome.Sharp.IconChar.Remove;
            this.btnEditar.IconColor = System.Drawing.Color.Black;
            this.btnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditar.IconSize = 25;
            this.btnEditar.Location = new System.Drawing.Point(700, 71);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(88, 28);
            this.btnEditar.TabIndex = 39;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.IconChar = FontAwesome.Sharp.IconChar.SquarePen;
            this.btnCancelar.IconColor = System.Drawing.Color.Black;
            this.btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelar.IconSize = 25;
            this.btnCancelar.Location = new System.Drawing.Point(700, 115);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(88, 28);
            this.btnCancelar.TabIndex = 40;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnEliminar.IconColor = System.Drawing.Color.Black;
            this.btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminar.IconSize = 25;
            this.btnEliminar.Location = new System.Drawing.Point(507, 372);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(88, 28);
            this.btnEliminar.TabIndex = 41;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.btnSalir.IconColor = System.Drawing.Color.Black;
            this.btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSalir.IconSize = 25;
            this.btnSalir.Location = new System.Drawing.Point(626, 372);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(88, 28);
            this.btnSalir.TabIndex = 42;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // cboxCodigoCita
            // 
            this.cboxCodigoCita.FormattingEnabled = true;
            this.cboxCodigoCita.Location = new System.Drawing.Point(208, 88);
            this.cboxCodigoCita.Name = "cboxCodigoCita";
            this.cboxCodigoCita.Size = new System.Drawing.Size(121, 21);
            this.cboxCodigoCita.TabIndex = 43;
            this.cboxCodigoCita.SelectedIndexChanged += new System.EventHandler(this.cboxCodigoCita_SelectedIndexChanged);
            // 
            // cboxCodigoMedicamento
            // 
            this.cboxCodigoMedicamento.FormattingEnabled = true;
            this.cboxCodigoMedicamento.Location = new System.Drawing.Point(208, 125);
            this.cboxCodigoMedicamento.Name = "cboxCodigoMedicamento";
            this.cboxCodigoMedicamento.Size = new System.Drawing.Size(121, 21);
            this.cboxCodigoMedicamento.TabIndex = 44;
            this.cboxCodigoMedicamento.SelectedIndexChanged += new System.EventHandler(this.cboxCodigoMedicamento_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(542, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 20);
            this.label8.TabIndex = 45;
            this.label8.Text = "Fecha:";
            // 
            // lblFechaHoy
            // 
            this.lblFechaHoy.AutoSize = true;
            this.lblFechaHoy.Location = new System.Drawing.Point(623, 9);
            this.lblFechaHoy.Name = "lblFechaHoy";
            this.lblFechaHoy.Size = new System.Drawing.Size(34, 13);
            this.lblFechaHoy.TabIndex = 46;
            this.lblFechaHoy.Text = "fecha";
            // 
            // FRMTratamientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblFechaHoy);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cboxCodigoMedicamento);
            this.Controls.Add(this.cboxCodigoCita);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvTratamientos);
            this.Controls.Add(this.lblCosto);
            this.Controls.Add(this.DtpFechaTratamiento);
            this.Controls.Add(this.cboxEstado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCodigoTratamiento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FRMTratamientos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TRATAMIENTOS";
            this.Load += new System.EventHandler(this.FRMTratamientos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTratamientos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCodigoTratamiento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboxEstado;
        private System.Windows.Forms.DateTimePicker DtpFechaTratamiento;
        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.DataGridView dgvTratamientos;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private FontAwesome.Sharp.IconButton btnEditar;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnSalir;
        private System.Windows.Forms.ComboBox cboxCodigoCita;
        private System.Windows.Forms.ComboBox cboxCodigoMedicamento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblFechaHoy;
    }
}