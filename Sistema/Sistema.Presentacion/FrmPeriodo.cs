﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema.Negocio;
using System.Drawing.Imaging;
using System.IO;


namespace Sistema.Presentacion
{
    public partial class FrmPeriodo : Form
    {
        public FrmPeriodo()
        {
            InitializeComponent();
        }

        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema de Calificaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MensajeOk(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema de Calificaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";
                if (TxtDescripcion.Text == string.Empty || Finicio.Text==string.Empty ||  Ffinal.Text==string.Empty || TxtPeriodo.Text == string.Empty )


                {
                    this.MensajeError("Falta ingresar algunos datos, serán remarcados.");
                    ErrorIcono.SetError(TxtDescripcion, "Ingrese la descripcion.");
                    ErrorIcono.SetError(TxtPeriodo, "Ingrese un periodo.");
                    ErrorIcono.SetError(Finicio, "Debe ingresar la fecha de inicio del periodo.");
                    ErrorIcono.SetError(Ffinal, "debe ingresar la fecha de final del periodo.");
                }
                else
                {
                    Rpta = NPeriodo.Insertar(TxtDescripcion.Text.Trim(), Convert.ToDateTime(Finicio.Text.Trim()),Convert.ToDateTime(Ffinal.Text.Trim()), Convert.ToInt32(TxtPeriodo.Text.Trim()));

                    if (Rpta.Equals("OK"))
                    {
                        this.MensajeOk("Se insertó de forma correcta");

                       
                       // this.Listar();
                    }
                    else
                    {
                        this.MensajeError(Rpta);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void FrmPeriodo_Load(object sender, EventArgs e)
        {

        }
    }
}
