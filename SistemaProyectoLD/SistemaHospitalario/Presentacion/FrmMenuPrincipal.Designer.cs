namespace SistemaHospitalario
{
    partial class FrmMenuPrincipal
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnCitas;
        private System.Windows.Forms.Button btnPagoCitas;
        private System.Windows.Forms.Button btnPagoEmpleados;
        private System.Windows.Forms.Label lblTitulo;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnCitas = new System.Windows.Forms.Button();
            this.btnPagoCitas = new System.Windows.Forms.Button();
            this.btnPagoEmpleados = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Location = new System.Drawing.Point(50, 70);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(200, 40);
            this.btnUsuarios.TabIndex = 1;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnCitas
            // 
            this.btnCitas.Location = new System.Drawing.Point(50, 120);
            this.btnCitas.Name = "btnCitas";
            this.btnCitas.Size = new System.Drawing.Size(200, 40);
            this.btnCitas.TabIndex = 2;
            this.btnCitas.Text = "Citas";
            this.btnCitas.Click += new System.EventHandler(this.btnCitas_Click);
            // 
            // btnPagoCitas
            // 
            this.btnPagoCitas.Location = new System.Drawing.Point(50, 170);
            this.btnPagoCitas.Name = "btnPagoCitas";
            this.btnPagoCitas.Size = new System.Drawing.Size(200, 40);
            this.btnPagoCitas.TabIndex = 3;
            this.btnPagoCitas.Text = "Pago de Citas";
            this.btnPagoCitas.Click += new System.EventHandler(this.btnPagoCitas_Click);
            // 
            // btnPagoEmpleados
            // 
            this.btnPagoEmpleados.Location = new System.Drawing.Point(50, 220);
            this.btnPagoEmpleados.Name = "btnPagoEmpleados";
            this.btnPagoEmpleados.Size = new System.Drawing.Size(200, 40);
            this.btnPagoEmpleados.TabIndex = 4;
            this.btnPagoEmpleados.Text = "Pago de Empleados";
            this.btnPagoEmpleados.Click += new System.EventHandler(this.btnPagoEmpleados_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(-33, 1);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(400, 66);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Menú Principal \r\nSistema Hospitalario";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // FrmMenuPrincipal
            // 
            this.ClientSize = new System.Drawing.Size(320, 300);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnUsuarios);
            this.Controls.Add(this.btnCitas);
            this.Controls.Add(this.btnPagoCitas);
            this.Controls.Add(this.btnPagoEmpleados);
            this.Name = "FrmMenuPrincipal";
            this.Text = "Menú Principal";
            this.ResumeLayout(false);

        }
    }
}