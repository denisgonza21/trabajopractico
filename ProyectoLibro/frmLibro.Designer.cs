namespace ProyectoLibro
{
    partial class frmLibro
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblEditorial = new System.Windows.Forms.Label();
            this.lblCantidadCopias = new System.Windows.Forms.Label();
            this.lblCantidadDisponible = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtcantDisponible = new System.Windows.Forms.TextBox();
            this.txtcantEjemplares = new System.Windows.Forms.TextBox();
            this.cmbEditorial = new System.Windows.Forms.ComboBox();
            this.cmbAutor = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lstlibros = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(501, 45);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTitulo.Size = new System.Drawing.Size(252, 33);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Registro de Libros";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(87, 128);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(65, 20);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Location = new System.Drawing.Point(83, 176);
            this.lblAutor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(48, 20);
            this.lblAutor.TabIndex = 2;
            this.lblAutor.Text = "Autor";
            // 
            // lblEditorial
            // 
            this.lblEditorial.AutoSize = true;
            this.lblEditorial.Location = new System.Drawing.Point(87, 220);
            this.lblEditorial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEditorial.Name = "lblEditorial";
            this.lblEditorial.Size = new System.Drawing.Size(66, 20);
            this.lblEditorial.TabIndex = 3;
            this.lblEditorial.Text = "Editorial";
            // 
            // lblCantidadCopias
            // 
            this.lblCantidadCopias.AutoSize = true;
            this.lblCantidadCopias.Location = new System.Drawing.Point(88, 265);
            this.lblCantidadCopias.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidadCopias.Name = "lblCantidadCopias";
            this.lblCantidadCopias.Size = new System.Drawing.Size(178, 20);
            this.lblCantidadCopias.TabIndex = 4;
            this.lblCantidadCopias.Text = "Cantidad de Ejemplares";
            // 
            // lblCantidadDisponible
            // 
            this.lblCantidadDisponible.AutoSize = true;
            this.lblCantidadDisponible.Location = new System.Drawing.Point(87, 308);
            this.lblCantidadDisponible.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidadDisponible.Name = "lblCantidadDisponible";
            this.lblCantidadDisponible.Size = new System.Drawing.Size(151, 20);
            this.lblCantidadDisponible.TabIndex = 5;
            this.lblCantidadDisponible.Text = "Cantidad Disponible";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(208, 128);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(314, 26);
            this.txtNombre.TabIndex = 6;
            // 
            // txtcantDisponible
            // 
            this.txtcantDisponible.Location = new System.Drawing.Point(289, 305);
            this.txtcantDisponible.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtcantDisponible.Name = "txtcantDisponible";
            this.txtcantDisponible.Size = new System.Drawing.Size(90, 26);
            this.txtcantDisponible.TabIndex = 7;
            // 
            // txtcantEjemplares
            // 
            this.txtcantEjemplares.Location = new System.Drawing.Point(289, 265);
            this.txtcantEjemplares.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtcantEjemplares.Name = "txtcantEjemplares";
            this.txtcantEjemplares.Size = new System.Drawing.Size(92, 26);
            this.txtcantEjemplares.TabIndex = 8;
            this.txtcantEjemplares.Leave += new System.EventHandler(this.txtcantEjemplares_Leave);
            // 
            // cmbEditorial
            // 
            this.cmbEditorial.FormattingEnabled = true;
            this.cmbEditorial.Location = new System.Drawing.Point(208, 206);
            this.cmbEditorial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbEditorial.Name = "cmbEditorial";
            this.cmbEditorial.Size = new System.Drawing.Size(314, 28);
            this.cmbEditorial.TabIndex = 9;
            // 
            // cmbAutor
            // 
            this.cmbAutor.FormattingEnabled = true;
            this.cmbAutor.Location = new System.Drawing.Point(208, 168);
            this.cmbAutor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbAutor.Name = "cmbAutor";
            this.cmbAutor.Size = new System.Drawing.Size(314, 28);
            this.cmbAutor.TabIndex = 10;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(92, 435);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(112, 52);
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(269, 435);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(112, 52);
            this.btnModificar.TabIndex = 12;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(450, 435);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(112, 52);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lstlibros
            // 
            this.lstlibros.FormattingEnabled = true;
            this.lstlibros.ItemHeight = 20;
            this.lstlibros.Location = new System.Drawing.Point(667, 140);
            this.lstlibros.Name = "lstlibros";
            this.lstlibros.Size = new System.Drawing.Size(305, 364);
            this.lstlibros.TabIndex = 14;
            this.lstlibros.Click += new System.EventHandler(this.lstlibros_Click);
            // 
            // frmLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1200, 674);
            this.Controls.Add(this.lstlibros);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cmbAutor);
            this.Controls.Add(this.cmbEditorial);
            this.Controls.Add(this.txtcantEjemplares);
            this.Controls.Add(this.txtcantDisponible);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblCantidadDisponible);
            this.Controls.Add(this.lblCantidadCopias);
            this.Controls.Add(this.lblEditorial);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblTitulo);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmLibro";
            this.Text = "Registro de Libros";
            this.Load += new System.EventHandler(this.frmLibro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label lblEditorial;
        private System.Windows.Forms.Label lblCantidadCopias;
        private System.Windows.Forms.Label lblCantidadDisponible;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtcantDisponible;
        private System.Windows.Forms.TextBox txtcantEjemplares;
        private System.Windows.Forms.ComboBox cmbEditorial;
        private System.Windows.Forms.ComboBox cmbAutor;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ListBox lstlibros;
    }
}