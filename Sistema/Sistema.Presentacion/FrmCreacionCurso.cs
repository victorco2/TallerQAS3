using System;
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
    public partial class FrmCreacionCurso : Form
    {
        public FrmCreacionCurso()
        {
            InitializeComponent();
        }
        private void FormatoDocente()
        {
            DgvDocente.Columns[1].Visible = false;
            DgvDocente.Columns[2].Width = 100;
            DgvDocente.Columns[2].HeaderText = "Nombre";
            DgvDocente.Columns[3].Width = 100;
            DgvDocente.Columns[3].HeaderText = "Apellido_Paterno";
            DgvDocente.Columns[4].Width = 150;
            DgvDocente.Columns[5].Width = 100;
            DgvDocente.Columns[5].HeaderText = "Apellido_Materno";
            DgvDocente.Columns[6].Width = 60;
            DgvDocente.Columns[7].Width = 200;
            DgvDocente.Columns[7].HeaderText = "Rut";
            DgvDocente.Columns[8].Width = 100;
        }

        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema de Calificaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MensajeOk(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema de Calificaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CargarPeriodo()
        {
            try
            {
                cboperiodo.DataSource = NCursos.Seleccionar();
                cboperiodo.ValueMember = "Id";
                cboperiodo.DisplayMember = "Periodos";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmCreacionCurso_Load(object sender, EventArgs e)
        {
            this.CargarPeriodo();
        }

        private void BtnInsertar_Click(object sender, EventArgs e)
        {
           
                try
                {
                    string Rpta = "";
                    if (TxtNCurso.Text == string.Empty || TxtCupo.Text == string.Empty)
                    {
                        this.MensajeError("Falta ingresar algunos datos, serán remarcados.");
                        ErrorIcono.SetError(TxtNCurso, "Ingrese nombre del curso.");
                        ErrorIcono.SetError(TxtCupo, "Ingrese el cupo.");
                    }
                    else
                    {
                    Rpta = NCursos.insertar(TxtNCurso.Text.Trim(),Convert.ToInt32(TxtCupo.Text.Trim()),Convert.ToInt32(cboperiodo.SelectedValue));                       
                        
                        if (Rpta.Equals("OK"))
                        {
                            this.MensajeOk("Se insertó de forma correcta el registro");

                           
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

       

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            paneldocente.Visible = false;
        }

        private void BtnAgregarDocente_Click(object sender, EventArgs e)
        {
            paneldocente.Visible = true;
        }

        private void BtnFiltrarDocente_Click(object sender, EventArgs e)
        {
            try
            {
                DgvDocente.DataSource = NDocente.Buscar(TxtBuscarDocente.Text.Trim());
                this.FormatoDocente();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
