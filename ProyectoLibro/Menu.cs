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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void autorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAutores frmAutores = new frmAutores();
            frmAutores.Show();
        }

        private void cargoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCargo frmCargo = new frmCargo();
            frmCargo.Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCliente frmCliente = new frmCliente();
            frmCliente.Show();
        }

        private void editorialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditorial frmEditorial = new frmEditorial();
            frmEditorial.Show();
        }

        private void funcionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFuncionario frmFuncionario = new frmFuncionario();
            frmFuncionario.Show();
        }

        private void libroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLibro frmLibro = new frmLibro();
            frmLibro.Show();
        }

        private void prestamoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrestamo frmPrestamo = new frmPrestamo();
            frmPrestamo.Show();
        }

        private void devoluciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmDevolucion frmPrestamo = new frmDevolucion();
            //frmDevolucion.Show();

        }


        private void salirToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmMenu frmMenu = new frmMenu();
            this.Close();
        }
    }
}
