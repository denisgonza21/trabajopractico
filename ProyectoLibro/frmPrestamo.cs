using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoLibro
{
    public partial class frmPrestamo : Form
    {
        
            string modo;
            public frmPrestamo()
            {
                InitializeComponent();
            }

            private void frmPrestamo_Load(object sender, EventArgs e)
            {
                ActualizarPrestamos();
            }

            private void btnAgregar_Click(object sender, EventArgs e)
            {
                Prestamo prestamo = ObtenerDatosFormulario();
                Prestamo.AgreagarPrestamo(prestamo);
                ActualizarDatosLista();
                LimpiarFormulario();
            }


            private void LimpiarFormulario()
            {

            }

            private Prestamo ObtenerDatosFormulario()
            {
                Prestamo prestamo = new Prestamo();
                prestamo.Cliente = (ClasesBiblioteca.Cliente)cboCliente.SelectedItem;
                prestamo.Libro = (ClasesBiblioteca.Libro)cboLibro.SelectedItem;

                prestamo.FechaPrestamo = dtpFechaPrestamo.Value.Date;
                prestamo.FechaDevolucion = dtpFechaPrestamo.Value.Date;
                prestamo.FechaVencimiento = dtpFechaVencimiento.Value.Date;

                return Prestamo;

            }


            private void ActualizarDatosLista()
            {
                cboCliente.DataSource = null;
                cboLibro.DataSource = null;
            }


            private void ActualizarPrestamos()
            {
                cboCliente.DataSource = null;
                cboLibro.DataSource = null;
            }

            private void btnModificar_Click(object sender, EventArgs e)
            {
                modo = "EDITAR";
            }

            private void btnEliminar_Click(object sender, EventArgs e)
            {
                if (cboCliente.SelectedIndex > 0)
                {
                    Prestamo prestamo = (Prestamo)cboCliente.SelectedItem;

                    Prestamo.listaPrestamos.Remove(prestamo);
                    ActualizarPrestamos();
                    LimpiarFormulario();
                }
                else
                {
                    MessageBox.Show("Favor seleccionar de la lista para eliminar");
                }


            }

