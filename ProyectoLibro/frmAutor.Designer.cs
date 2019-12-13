namespace ProyectoLibro
{
    partial class frmAutores
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAutores));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNroDocumento = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtNroDocumento = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lstAutor = new System.Windows.Forms.ListBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblid = new System.Windows.Forms.Label();
            this.btnSalir2 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnLimpiar2 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnEliminar2 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnModificar2 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnAgregar2 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitulo.Location = new System.Drawing.Point(553, 140);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(373, 46);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Registro de Autores";
            // 
            // lblNroDocumento
            // 
            this.lblNroDocumento.AutoSize = true;
            this.lblNroDocumento.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNroDocumento.Location = new System.Drawing.Point(436, 275);
            this.lblNroDocumento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNroDocumento.Name = "lblNroDocumento";
            this.lblNroDocumento.Size = new System.Drawing.Size(143, 20);
            this.lblNroDocumento.TabIndex = 1;
            this.lblNroDocumento.Text = "Nro de Documento";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNombre.Location = new System.Drawing.Point(436, 308);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(65, 20);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDireccion.Location = new System.Drawing.Point(436, 344);
            this.lblDireccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(75, 20);
            this.lblDireccion.TabIndex = 3;
            this.lblDireccion.Text = "Direccion";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTelefono.Location = new System.Drawing.Point(436, 380);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(71, 20);
            this.lblTelefono.TabIndex = 4;
            this.lblTelefono.Text = "Telefono";
            // 
            // txtNroDocumento
            // 
            this.txtNroDocumento.Location = new System.Drawing.Point(591, 269);
            this.txtNroDocumento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNroDocumento.Name = "txtNroDocumento";
            this.txtNroDocumento.Size = new System.Drawing.Size(294, 26);
            this.txtNroDocumento.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(591, 305);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(294, 26);
            this.txtNombre.TabIndex = 2;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(591, 341);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(294, 26);
            this.txtDireccion.TabIndex = 3;
            // 
            // lstAutor
            // 
            this.lstAutor.FormattingEnabled = true;
            this.lstAutor.ItemHeight = 20;
            this.lstAutor.Location = new System.Drawing.Point(372, 569);
            this.lstAutor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstAutor.Name = "lstAutor";
            this.lstAutor.Size = new System.Drawing.Size(636, 124);
            this.lstAutor.TabIndex = 14;
            this.lstAutor.Click += new System.EventHandler(this.lstAutor_Click);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(591, 377);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(294, 26);
            this.txtTelefono.TabIndex = 4;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(591, 233);
            this.txtId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(294, 26);
            this.txtId.TabIndex = 1;
            this.txtId.TabStop = false;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblid.Location = new System.Drawing.Point(436, 239);
            this.lblid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(23, 20);
            this.lblid.TabIndex = 20;
            this.lblid.Text = "Id";
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
            this.btnSalir2.Location = new System.Drawing.Point(1058, 594);
            this.btnSalir2.Margin = new System.Windows.Forms.Padding(5);
            this.btnSalir2.Name = "btnSalir2";
            this.btnSalir2.Size = new System.Drawing.Size(145, 73);
            this.btnSalir2.TabIndex = 9;
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
            this.btnLimpiar2.Location = new System.Drawing.Point(887, 450);
            this.btnLimpiar2.Margin = new System.Windows.Forms.Padding(5);
            this.btnLimpiar2.Name = "btnLimpiar2";
            this.btnLimpiar2.Size = new System.Drawing.Size(145, 73);
            this.btnLimpiar2.TabIndex = 8;
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
            this.btnEliminar2.Location = new System.Drawing.Point(732, 450);
            this.btnEliminar2.Margin = new System.Windows.Forms.Padding(5);
            this.btnEliminar2.Name = "btnEliminar2";
            this.btnEliminar2.Size = new System.Drawing.Size(145, 73);
            this.btnEliminar2.TabIndex = 7;
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
            this.btnModificar2.Location = new System.Drawing.Point(577, 450);
            this.btnModificar2.Margin = new System.Windows.Forms.Padding(5);
            this.btnModificar2.Name = "btnModificar2";
            this.btnModificar2.Size = new System.Drawing.Size(145, 73);
            this.btnModificar2.TabIndex = 6;
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
            this.btnAgregar2.Location = new System.Drawing.Point(422, 450);
            this.btnAgregar2.Margin = new System.Windows.Forms.Padding(5);
            this.btnAgregar2.Name = "btnAgregar2";
            this.btnAgregar2.Size = new System.Drawing.Size(145, 73);
            this.btnAgregar2.TabIndex = 5;
            this.btnAgregar2.TabStop = false;
            this.btnAgregar2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAgregar2.Click += new System.EventHandler(this.btnAgregar2_Click);
            // 
            // frmAutores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1472, 963);
            this.Controls.Add(this.btnSalir2);
            this.Controls.Add(this.btnLimpiar2);
            this.Controls.Add(this.btnEliminar2);
            this.Controls.Add(this.btnModificar2);
            this.Controls.Add(this.btnAgregar2);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.lstAutor);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtNroDocumento);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblNroDocumento);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAutores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Registro de Autores";
            this.Load += new System.EventHandler(this.frmAutores_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNroDocumento;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtNroDocumento;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.ListBox lstAutor;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblid;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSalir2;
        private Bunifu.Framework.UI.BunifuThinButton2 btnLimpiar2;
        private Bunifu.Framework.UI.BunifuThinButton2 btnEliminar2;
        private Bunifu.Framework.UI.BunifuThinButton2 btnModificar2;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAgregar2;
    }
}

