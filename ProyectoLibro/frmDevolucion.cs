using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClasesBiblioteca;

namespace ProyectoLibro
{
    public partial class frmDevolucion : Form
    {
        public frmDevolucion()
        {
            InitializeComponent();
        }

        private void frmDevolucion_Load(object sender, EventArgs e)
        {
            txtCliente.Enabled = false;
            comboBox1.DataSource = Cliente.ObtenerCliente();
            comboBox1.SelectedItem = null;
           
        }
        

        
    }
}
