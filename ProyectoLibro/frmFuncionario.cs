﻿using ClasesBiblioteca;
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
    public partial class frmFuncionario : Form
    {
        public frmFuncionario()
        {
            InitializeComponent();
        }

    

        private void frmFuncionario_Load(object sender, EventArgs e)
        {
            ActualizarListaFuncionarios();
            txtId.Enabled = false;
            dtpFechaIngreso.Enabled = false;
            txtNroDocumento.Focus();
        }

        private void ActualizarListaFuncionarios()
        {
            lstFuncionario.DataSource = null;
            lstFuncionario.DataSource = Funcionario.ObtenerFuncionario();
        }

        
        private void LimpiarFormulario()
        {
            txtId.Text = "";
            txtNroDocumento.Text = "";
            txtNombre.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtUsuario.Text = "";
            dtpFechaIngreso.Value = System.DateTime.Now;
            txtContrasena.Text = "";
            
        }

       

        private Funcionario ObtenerFuncionarioOtro()
        {
            Funcionario fun = new Funcionario();
            fun.id = Convert.ToInt16(txtId.Text);
            fun.nroDocumento = txtNroDocumento.Text;
            fun.nombre = txtNombre.Text;
            fun.direccion = txtDireccion.Text;
            fun.telefono = txtTelefono.Text;
            fun.fechaInicio = dtpFechaIngreso.Value.Date;
            fun.usuario = txtUsuario.Text;
            fun.constrasena = txtContrasena.Text;
            return fun;
        }

     

        
        private void lstFuncionario_Click(object sender, EventArgs e)
        {
            Funcionario func = (Funcionario)lstFuncionario.SelectedItem;

            if (func != null)
            {
                txtId.Text = Convert.ToString(func.id);
                txtNroDocumento.Text = func.nroDocumento;
                txtNombre.Text = func.nombre;
                txtDireccion.Text = func.direccion;
                txtTelefono.Text = func.telefono;
                dtpFechaIngreso.Value = func.fechaInicio;
                txtUsuario.Text = func.usuario;
                txtContrasena.Text = func.constrasena;
            }
        }

        private void btnAgregar2_Click(object sender, EventArgs e)
        {
            try {
            
            Funcionario fun = new Funcionario();

            fun.nroDocumento = txtNroDocumento.Text;
            fun.nombre = txtNombre.Text;
            fun.direccion = txtDireccion.Text;
            fun.telefono = txtTelefono.Text;
            fun.usuario = txtUsuario.Text;
            fun.fechaInicio = dtpFechaIngreso.Value;
            fun.constrasena = txtContrasena.Text;
            Funcionario.AgregarFuncionario(fun);
            LimpiarFormulario();
            ActualizarListaFuncionarios();
            }
             catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }



        }

        private void btnModificar2_Click(object sender, EventArgs e)
        {
            try {
            Funcionario func = (Funcionario)lstFuncionario.SelectedItem;
            if (func != null)
            {
                int index = lstFuncionario.SelectedIndex;
                Funcionario funcionario = ObtenerFuncionarioOtro();
                Funcionario.EditarFuncionario(index, func);


                LimpiarFormulario();
                ActualizarListaFuncionarios();
            }
            else
            {
                MessageBox.Show("Ojo, Selecciona un Item");
            }
             }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnEliminar2_Click(object sender, EventArgs e)
        {
             try
            {
            Funcionario func = (Funcionario)lstFuncionario.SelectedItem;
            if (func != null)
            {
                Funcionario funcionario = (Funcionario)lstFuncionario.SelectedItem;
                Funcionario.EliminarFuncionario(funcionario);
                ActualizarListaFuncionarios();
                LimpiarFormulario();
            }
            else
            {
                MessageBox.Show("Ojo, Selecciona un Item");
            }
            }
             catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnLimpiar2_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void btnSalir2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
    }
}
