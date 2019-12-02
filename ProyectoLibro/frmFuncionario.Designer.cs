namespace ProyectoLibro
{
    partial class frmFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFuncionario));
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtNroDocumento = new System.Windows.Forms.TextBox();
            this.dtpFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.lblFechaIngreso = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblNroDocumento = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lstFuncionario = new System.Windows.Forms.ListBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.btnSalir2 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnLimpiar2 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnEliminar2 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnModificar2 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnAgregar2 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.SuspendLayout();
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(628, 331);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(318, 26);
            this.txtTelefono.TabIndex = 4;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(628, 295);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(318, 26);
            this.txtDireccion.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(628, 259);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(318, 26);
            this.txtNombre.TabIndex = 2;
            // 
            // txtNroDocumento
            // 
            this.txtNroDocumento.Location = new System.Drawing.Point(629, 223);
            this.txtNroDocumento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNroDocumento.Name = "txtNroDocumento";
            this.txtNroDocumento.Size = new System.Drawing.Size(318, 26);
            this.txtNroDocumento.TabIndex = 1;
            // 
            // dtpFechaIngreso
            // 
            this.dtpFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaIngreso.Location = new System.Drawing.Point(628, 403);
            this.dtpFechaIngreso.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpFechaIngreso.Name = "dtpFechaIngreso";
            this.dtpFechaIngreso.Size = new System.Drawing.Size(169, 26);
            this.dtpFechaIngreso.TabIndex = 19;
            this.dtpFechaIngreso.TabStop = false;
            // 
            // lblFechaIngreso
            // 
            this.lblFechaIngreso.AutoSize = true;
            this.lblFechaIngreso.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFechaIngreso.Location = new System.Drawing.Point(462, 408);
            this.lblFechaIngreso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaIngreso.Name = "lblFechaIngreso";
            this.lblFechaIngreso.Size = new System.Drawing.Size(134, 20);
            this.lblFechaIngreso.TabIndex = 18;
            this.lblFechaIngreso.Text = "Fecha de Ingreso";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTelefono.Location = new System.Drawing.Point(462, 334);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(71, 20);
            this.lblTelefono.TabIndex = 17;
            this.lblTelefono.Text = "Telefono";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDireccion.Location = new System.Drawing.Point(462, 298);
            this.lblDireccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(75, 20);
            this.lblDireccion.TabIndex = 16;
            this.lblDireccion.Text = "Direccion";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNombre.Location = new System.Drawing.Point(462, 263);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(65, 20);
            this.lblNombre.TabIndex = 15;
            this.lblNombre.Text = "Nombre";
            // 
            // lblNroDocumento
            // 
            this.lblNroDocumento.AutoSize = true;
            this.lblNroDocumento.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNroDocumento.Location = new System.Drawing.Point(463, 226);
            this.lblNroDocumento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNroDocumento.Name = "lblNroDocumento";
            this.lblNroDocumento.Size = new System.Drawing.Size(121, 20);
            this.lblNroDocumento.TabIndex = 14;
            this.lblNroDocumento.Text = "Nro Documento";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitulo.Location = new System.Drawing.Point(572, 128);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(465, 46);
            this.lblTitulo.TabIndex = 27;
            this.lblTitulo.Text = "Registro de Funcionarios";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblUsuario.Location = new System.Drawing.Point(463, 371);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(64, 20);
            this.lblUsuario.TabIndex = 28;
            this.lblUsuario.Text = "Usuario";
            // 
            // lstFuncionario
            // 
            this.lstFuncionario.FormattingEnabled = true;
            this.lstFuncionario.ItemHeight = 20;
            this.lstFuncionario.Location = new System.Drawing.Point(398, 582);
            this.lstFuncionario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstFuncionario.Name = "lstFuncionario";
            this.lstFuncionario.Size = new System.Drawing.Size(548, 144);
            this.lstFuncionario.TabIndex = 33;
            this.lstFuncionario.TabStop = false;
            this.lstFuncionario.Click += new System.EventHandler(this.lstFuncionario_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(628, 187);
            this.txtId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(318, 26);
            this.txtId.TabIndex = 39;
            this.txtId.TabStop = false;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblId.Location = new System.Drawing.Point(462, 190);
            this.lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(23, 20);
            this.lblId.TabIndex = 38;
            this.lblId.Text = "Id";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(629, 367);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(319, 26);
            this.txtUsuario.TabIndex = 5;
            // 
            // btnSalir2
            // 
            this.btnSalir2.ActiveBorderThickness = 1;
            this.btnSalir2.ActiveCornerRadius = 20;
            this.btnSalir2.ActiveFillColor = System.Drawing.Color.Teal;
            this.btnSalir2.ActiveForecolor = System.Drawing.Color.White;
            this.btnSalir2.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnSalir2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.btnSalir2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalir2.BackgroundImage")));
            this.btnSalir2.ButtonText = "Salir";
            this.btnSalir2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir2.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnSalir2.IdleBorderThickness = 1;
            this.btnSalir2.IdleCornerRadius = 20;
            this.btnSalir2.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(4)))), ((int)(((byte)(89)))));
            this.btnSalir2.IdleForecolor = System.Drawing.Color.White;
            this.btnSalir2.IdleLineColor = System.Drawing.Color.White;
            this.btnSalir2.Location = new System.Drawing.Point(1028, 625);
            this.btnSalir2.Margin = new System.Windows.Forms.Padding(5);
            this.btnSalir2.Name = "btnSalir2";
            this.btnSalir2.Size = new System.Drawing.Size(145, 73);
            this.btnSalir2.TabIndex = 45;
            this.btnSalir2.TabStop = false;
            this.btnSalir2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSalir2.Click += new System.EventHandler(this.btnSalir2_Click);
            // 
            // btnLimpiar2
            // 
            this.btnLimpiar2.ActiveBorderThickness = 1;
            this.btnLimpiar2.ActiveCornerRadius = 20;
            this.btnLimpiar2.ActiveFillColor = System.Drawing.Color.Teal;
            this.btnLimpiar2.ActiveForecolor = System.Drawing.Color.White;
            this.btnLimpiar2.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnLimpiar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.btnLimpiar2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimpiar2.BackgroundImage")));
            this.btnLimpiar2.ButtonText = "Limpiar";
            this.btnLimpiar2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar2.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnLimpiar2.IdleBorderThickness = 1;
            this.btnLimpiar2.IdleCornerRadius = 20;
            this.btnLimpiar2.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(4)))), ((int)(((byte)(89)))));
            this.btnLimpiar2.IdleForecolor = System.Drawing.Color.White;
            this.btnLimpiar2.IdleLineColor = System.Drawing.Color.White;
            this.btnLimpiar2.Location = new System.Drawing.Point(857, 481);
            this.btnLimpiar2.Margin = new System.Windows.Forms.Padding(5);
            this.btnLimpiar2.Name = "btnLimpiar2";
            this.btnLimpiar2.Size = new System.Drawing.Size(145, 73);
            this.btnLimpiar2.TabIndex = 44;
            this.btnLimpiar2.TabStop = false;
            this.btnLimpiar2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLimpiar2.Click += new System.EventHandler(this.btnLimpiar2_Click);
            // 
            // btnEliminar2
            // 
            this.btnEliminar2.ActiveBorderThickness = 1;
            this.btnEliminar2.ActiveCornerRadius = 20;
            this.btnEliminar2.ActiveFillColor = System.Drawing.Color.Teal;
            this.btnEliminar2.ActiveForecolor = System.Drawing.Color.White;
            this.btnEliminar2.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnEliminar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.btnEliminar2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminar2.BackgroundImage")));
            this.btnEliminar2.ButtonText = "Eliminar";
            this.btnEliminar2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar2.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnEliminar2.IdleBorderThickness = 1;
            this.btnEliminar2.IdleCornerRadius = 20;
            this.btnEliminar2.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(4)))), ((int)(((byte)(89)))));
            this.btnEliminar2.IdleForecolor = System.Drawing.Color.White;
            this.btnEliminar2.IdleLineColor = System.Drawing.Color.White;
            this.btnEliminar2.Location = new System.Drawing.Point(702, 481);
            this.btnEliminar2.Margin = new System.Windows.Forms.Padding(5);
            this.btnEliminar2.Name = "btnEliminar2";
            this.btnEliminar2.Size = new System.Drawing.Size(145, 73);
            this.btnEliminar2.TabIndex = 43;
            this.btnEliminar2.TabStop = false;
            this.btnEliminar2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEliminar2.Click += new System.EventHandler(this.btnEliminar2_Click);
            // 
            // btnModificar2
            // 
            this.btnModificar2.ActiveBorderThickness = 1;
            this.btnModificar2.ActiveCornerRadius = 20;
            this.btnModificar2.ActiveFillColor = System.Drawing.Color.Teal;
            this.btnModificar2.ActiveForecolor = System.Drawing.Color.White;
            this.btnModificar2.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnModificar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.btnModificar2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnModificar2.BackgroundImage")));
            this.btnModificar2.ButtonText = "Modificar";
            this.btnModificar2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar2.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnModificar2.IdleBorderThickness = 1;
            this.btnModificar2.IdleCornerRadius = 20;
            this.btnModificar2.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(4)))), ((int)(((byte)(89)))));
            this.btnModificar2.IdleForecolor = System.Drawing.Color.White;
            this.btnModificar2.IdleLineColor = System.Drawing.Color.White;
            this.btnModificar2.Location = new System.Drawing.Point(547, 481);
            this.btnModificar2.Margin = new System.Windows.Forms.Padding(5);
            this.btnModificar2.Name = "btnModificar2";
            this.btnModificar2.Size = new System.Drawing.Size(145, 73);
            this.btnModificar2.TabIndex = 42;
            this.btnModificar2.TabStop = false;
            this.btnModificar2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnModificar2.Click += new System.EventHandler(this.btnModificar2_Click);
            // 
            // btnAgregar2
            // 
            this.btnAgregar2.ActiveBorderThickness = 1;
            this.btnAgregar2.ActiveCornerRadius = 20;
            this.btnAgregar2.ActiveFillColor = System.Drawing.Color.Teal;
            this.btnAgregar2.ActiveForecolor = System.Drawing.Color.White;
            this.btnAgregar2.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnAgregar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.btnAgregar2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgregar2.BackgroundImage")));
            this.btnAgregar2.ButtonText = "Agregar";
            this.btnAgregar2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar2.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnAgregar2.IdleBorderThickness = 1;
            this.btnAgregar2.IdleCornerRadius = 20;
            this.btnAgregar2.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(4)))), ((int)(((byte)(89)))));
            this.btnAgregar2.IdleForecolor = System.Drawing.Color.White;
            this.btnAgregar2.IdleLineColor = System.Drawing.Color.White;
            this.btnAgregar2.Location = new System.Drawing.Point(392, 481);
            this.btnAgregar2.Margin = new System.Windows.Forms.Padding(5);
            this.btnAgregar2.Name = "btnAgregar2";
            this.btnAgregar2.Size = new System.Drawing.Size(145, 73);
            this.btnAgregar2.TabIndex = 41;
            this.btnAgregar2.TabStop = false;
            this.btnAgregar2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAgregar2.Click += new System.EventHandler(this.btnAgregar2_Click);
            // 
            // frmFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(1472, 963);
            this.Controls.Add(this.btnSalir2);
            this.Controls.Add(this.btnLimpiar2);
            this.Controls.Add(this.btnEliminar2);
            this.Controls.Add(this.btnModificar2);
            this.Controls.Add(this.btnAgregar2);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lstFuncionario);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtNroDocumento);
            this.Controls.Add(this.dtpFechaIngreso);
            this.Controls.Add(this.lblFechaIngreso);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblNroDocumento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmFuncionario";
            this.Text = "Registro de Funcionarios";
            this.Load += new System.EventHandler(this.frmFuncionario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtNroDocumento;
        private System.Windows.Forms.DateTimePicker dtpFechaIngreso;
        private System.Windows.Forms.Label lblFechaIngreso;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblNroDocumento;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.ListBox lstFuncionario;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtUsuario;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSalir2;
        private Bunifu.Framework.UI.BunifuThinButton2 btnLimpiar2;
        private Bunifu.Framework.UI.BunifuThinButton2 btnEliminar2;
        private Bunifu.Framework.UI.BunifuThinButton2 btnModificar2;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAgregar2;
    }
}