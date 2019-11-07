﻿using ProgramaContable.Controlador;
using ProgramaContable.Modelo;
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
        private static ControladorLibroMayor controlador;
        public static ControladorLibroMayor Controlador { get => controlador; set => controlador = value; }

        public LibroMayor(ControladorLibroMayor control)
        {
            Controlador = control;
            InitializeComponent();
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            controlador.Volver();
            this.Dispose();
        }

        private void botonVerCuenta_Click(object sender, EventArgs e)
        {
            VerLibroMayor verlibro = new VerLibroMayor();
            verlibro.Visible = true;
        }

        private void botonVerTipoCuenta_Click(object sender, EventArgs e)
        {
            VerLibroMayor verlibro = new VerLibroMayor();
            verlibro.Visible = true;
        }

        private void botonVerTodo_Click(object sender, EventArgs e)
        {
            VerLibroMayor verlibro = new VerLibroMayor();
            verlibro.Visible = true;
        }

        private void LibroMayor_Load(object sender, EventArgs e)
        {
            setearComboBoxTipo();
            setearComboBoxNombre();
            comboBoxTipo.SelectedIndex = 0;
            comboBoxNombre.SelectedIndex = 0;
            comboBoxMes.SelectedIndex = 0;
            comboBoxAnio.SelectedIndex = comboBoxAnio.Items.Count-1;
        }

        private void setearComboBoxTipo()
        {
            TipodeCuenta tp = new TipodeCuenta();
            List<TipodeCuenta> lista = tp.TraerTipos();
            foreach (TipodeCuenta i in lista)
            {
                this.comboBoxTipo.Items.Add(new ComboBoxItem(i.DescripcionTipo,i.Id));
            }
        }
        private void setearComboBoxNombre()
        {
            List<Cuenta> lista = Cuenta.ListarCuentas(1);
            foreach (Cuenta i in lista)
            {
                this.comboBoxNombre.Items.Add(new ComboBoxItem(i.NombreCuenta, i.IdCuenta));
            }
        }

        private void comboBoxTipo_SelectedIndexChanged(object sender, EventArgs e)
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

        
    }
}
