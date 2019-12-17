﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema.Presentacion
{
    public partial class FrmPrincipal : Form
    {
        private int childFormNumber = 0;
        public int IdUsuario;
        public int IdRol;
        public string Nombre;
        public string Rol;
        public bool Estado;

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNuevoPlanAcademico frm = new FrmNuevoPlanAcademico();
            frm.MdiParent = this;
            frm.Show();
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReasignarDocente frm = new FrmReasignarDocente();
            frm.MdiParent = this;
            frm.Show();
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void CategoríasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEstudiantes frm = new FrmEstudiantes();
            frm.MdiParent = this;
            frm.Show();
        }

        private void ArtículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void RolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRol frm = new FrmRol();
            frm.MdiParent = this;
            frm.Show();
        }

        private void UsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuario frm = new FrmUsuario();
            frm.MdiParent = this;
            frm.Show();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
          
            MessageBox.Show("Bienvenido: "+ this.Nombre,"Sistema de Calificaciones",MessageBoxButtons.OK,MessageBoxIcon.Information);

            if (this.Rol.Equals("Administrador"))
            {
                MnuAdmin.Enabled = true;
                MnuCalificaciones.Enabled = true;
                MnuPlanificacion.Enabled = true;
                MnuAccesos.Enabled = true;
               

            }
            else
            {
                if (this.Rol.Equals("Profesor"))
                {
                    MnuAdmin.Enabled = false;
                    MnuCalificaciones.Enabled = true;
                    MnuPlanificacion.Enabled = false;
                    MnuAccesos.Enabled = false;
                  

                }
                else
                {
                    if (this.Rol.Equals("JefeCarrera"))
                    {
                        MnuAdmin.Enabled = true;
                        MnuCalificaciones.Enabled = true;
                        MnuPlanificacion.Enabled = false;
                        MnuAccesos.Enabled = false;
                       

                    }
                    else
                    {
                        MnuAdmin.Enabled = false;
                        MnuCalificaciones.Enabled = false;
                        MnuPlanificacion.Enabled = false;
                        MnuAccesos.Enabled = false;
                      

                    }
                }
            }
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult Opcion;
            Opcion = MessageBox.Show("Deseas salir del Sistema?","Sistema de Calificaciones",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if (Opcion == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void DocenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDocente frm = new FrmDocente();
            frm.MdiParent = this;
            frm.Show();
        }

        private void CursosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void AsignaturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
 
        }

        private void ClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FrmIngresoMaterias frm = new FrmIngresoMaterias();
            //frm.MdiParent = this;
            //frm.Show();
        }

        private void SistemaCalificacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void PeriodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPeriodo frm = new FrmPeriodo();
            frm.MdiParent = this;
            frm.Show();
        }

        private void IngresoDeMateriasToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FrmIngresoMateria frm = new FrmIngresoMateria();
            frm.MdiParent = this;
            frm.Show();
        }

   
    

        private void NuevoCursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCreacionCurso frm = new FrmCreacionCurso();
            frm.MdiParent = this;
            frm.Show();
        }

  
   
        private void GestionProfesoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDocente frm = new FrmDocente();
            frm.MdiParent = this;
            frm.Show();
        }

        private void GestionDeAlumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEstudiantes frm = new FrmEstudiantes();
            frm.MdiParent = this;
            frm.Show();
            
        }

        private void SeccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSeccion frm = new FrmSeccion();
            frm.MdiParent = this;
            frm.Show();
        }

        private void AsignaturasCupoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmIngresoMateria frm = new FrmIngresoMateria();
            frm.MdiParent = this;
            frm.Show();
        }

        private void AjustesGeneralesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmPeriodo frm = new FrmPeriodo();
            frm.MdiParent = this;
            frm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
