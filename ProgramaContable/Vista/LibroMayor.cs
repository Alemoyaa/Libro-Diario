﻿using ProgramaContable.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramaContable.Vista
{
    public partial class LibroMayor : Form
    {
        private Form vistaAnterior;

        public Form VistaAnterior { get => vistaAnterior; set => vistaAnterior = value; }

        public LibroMayor(Form vistaAnterior)
        {
            VistaAnterior = vistaAnterior;
            InitializeComponent();
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            VistaAnterior.Visible = true;
            this.Dispose();
        }

        private void botonVerCuenta_Click(object sender, EventArgs e)
        {
            int hValue = ((ComboBoxItem)comboBoxNombre.SelectedItem).HiddenValue;
            int mes = Convert.ToInt32(comboBoxMes.SelectedItem);
            int anio = Convert.ToInt32(comboBoxAnio.SelectedItem);
            VerLibroMayor verlibro = new VerLibroMayor(true, mes, anio, hValue);
        }

        private void botonVerTipoCuenta_Click(object sender, EventArgs e)
        {
            int hValue = ((ComboBoxItem)comboBoxTipo.SelectedItem).HiddenValue;
            int mes = Convert.ToInt32(comboBoxMes.SelectedItem);
            int anio = Convert.ToInt32(comboBoxAnio.SelectedItem);
            VerLibroMayor verlibro = new VerLibroMayor(false, mes, anio, hValue);
        }

        private void botonVerTodo_Click(object sender, EventArgs e)
        {
            int mes = Convert.ToInt32(comboBoxMes.SelectedItem);
            int anio = Convert.ToInt32(comboBoxAnio.SelectedItem);
            VerLibroMayor verlibro = new VerLibroMayor(mes, anio);
        }

        private void LibroMayor_Load(object sender, EventArgs e)
        {
            try
            {
                setearComboBoxTipo();
                setearComboBoxNombre();
                comboBoxTipo.SelectedIndex = 0;
                comboBoxNombre.SelectedIndex = 0;
                comboBoxMes.SelectedIndex = 0;
                comboBoxAnio.SelectedIndex = comboBoxAnio.Items.Count - 1;
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo cargar la base de datos. Revise su conexion");
                this.Close();
                Application.Exit();
            }
        }

        private void setearComboBoxTipo()
        {
            try
            {
                List<TipodeCuenta> lista = TipodeCuenta.TraerTipos();
                foreach (TipodeCuenta i in lista)
                {
                    this.comboBoxTipo.Items.Add(new ComboBoxItem(i.DescripcionTipo, i.Id));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
}
        private void setearComboBoxNombre()
        {
            try { 
                List<Cuenta> lista = Cuenta.ListarCuentas(1);
                foreach (Cuenta i in lista)
                {
                    this.comboBoxNombre.Items.Add(new ComboBoxItem(i.NombreCuenta, i.IdCuenta));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBoxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                comboBoxNombre.Items.Clear();
                int hValue = ((ComboBoxItem)comboBoxTipo.SelectedItem).HiddenValue;
                List<Cuenta> lista = Cuenta.ListarCuentas(hValue);
                foreach (Cuenta i in lista)
                {
                    this.comboBoxNombre.Items.Add(new ComboBoxItem(i.NombreCuenta, i.IdCuenta));
                }
                comboBoxNombre.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LibroMayor_FormClosing(object sender, FormClosingEventArgs e)
        {
            VistaAnterior.Visible = true;
            this.Dispose();
        }
    }
}
