using ClasesBiblioteca;
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
    public partial class frmCargo : Form
    {
        public frmCargo()
        {
            InitializeComponent();
        }

        private void frmCargo_Load(object sender, EventArgs e)
        {
            ActualizarListaCargo();
        }

        private void ActualizarListaCargo()
        {
            lstCargo.DataSource = null;
            lstCargo.DataSource = Cargo.ObtenerCargo();
        }

        private void lstCargo_Click(object sender, EventArgs e)
        {
            Cargo car = (Cargo)lstCargo.SelectedItem;
            if (car != null)
            {
                txtNuevoCargo.Text = car.cargo;
                
            }
    
        }

        private void LimpiarFormulario()
        {
            txtNuevoCargo.Text = "";
           

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var unu = ObtenerDatosCargo();
            Cargo.AgregarCargo(unu);
            LimpiarFormulario();
            ActualizarListaCargo();
        }

        private Cargo ObtenerDatosCargo()
        {
            Cargo cargo = new Cargo();
            cargo.cargo = txtNuevoCargo.Text;
            return cargo;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int index = lstCargo.SelectedIndex;

            Cargo.listaCargo[index] = ObtenerDatosCargo();

            LimpiarFormulario();
            ActualizarListaCargo();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (this.lstCargo.SelectedItems.Count == 0)
            {
                MessageBox.Show("Favor seleccione una fila");
            }
            else
            {
                Cargo c = (Cargo)lstCargo.SelectedItem;
                Cargo.EliminarCargo(c);
                ActualizarListaCargo();
                LimpiarFormulario();
            }
        }
    }
}
