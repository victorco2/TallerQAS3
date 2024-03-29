﻿namespace Sistema.Presentacion
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.MnuAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionProfesoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuPlanificacion = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeAlumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoCursoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SeccionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AsignaturasCupoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.semestresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.promoverEstudiantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuCalificaciones = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuAccesos = new System.Windows.Forms.ToolStripMenuItem();
            this.rolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajustesGeneralesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajustesGeneralesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuAdmin,
            this.MnuPlanificacion,
            this.viewMenu,
            this.windowsMenu,
            this.MnuCalificaciones,
            this.MnuAccesos,
            this.ajustesGeneralesToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.MdiWindowListItem = this.windowsMenu;
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(836, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // MnuAdmin
            // 
            this.MnuAdmin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionProfesoresToolStripMenuItem});
            this.MnuAdmin.Name = "MnuAdmin";
            this.MnuAdmin.Size = new System.Drawing.Size(74, 20);
            this.MnuAdmin.Text = "Profesores";
            // 
            // gestionProfesoresToolStripMenuItem
            // 
            this.gestionProfesoresToolStripMenuItem.Name = "gestionProfesoresToolStripMenuItem";
            this.gestionProfesoresToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.gestionProfesoresToolStripMenuItem.Text = "Gestion Profesores";
            this.gestionProfesoresToolStripMenuItem.Click += new System.EventHandler(this.GestionProfesoresToolStripMenuItem_Click);
            // 
            // MnuPlanificacion
            // 
            this.MnuPlanificacion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDeAlumnosToolStripMenuItem});
            this.MnuPlanificacion.Name = "MnuPlanificacion";
            this.MnuPlanificacion.Size = new System.Drawing.Size(67, 20);
            this.MnuPlanificacion.Text = "Alumnos";
            // 
            // gestionDeAlumnosToolStripMenuItem
            // 
            this.gestionDeAlumnosToolStripMenuItem.Name = "gestionDeAlumnosToolStripMenuItem";
            this.gestionDeAlumnosToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.gestionDeAlumnosToolStripMenuItem.Text = "Gestion de Alumnos";
            this.gestionDeAlumnosToolStripMenuItem.Click += new System.EventHandler(this.GestionDeAlumnosToolStripMenuItem_Click);
            // 
            // viewMenu
            // 
            this.viewMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoCursoToolStripMenuItem,
            this.SeccionToolStripMenuItem,
            this.AsignaturasCupoToolStripMenuItem,
            this.semestresToolStripMenuItem});
            this.viewMenu.Name = "viewMenu";
            this.viewMenu.Size = new System.Drawing.Size(69, 20);
            this.viewMenu.Text = "Gestionar";
            // 
            // nuevoCursoToolStripMenuItem
            // 
            this.nuevoCursoToolStripMenuItem.Name = "nuevoCursoToolStripMenuItem";
            this.nuevoCursoToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.nuevoCursoToolStripMenuItem.Text = "Cursos";
            this.nuevoCursoToolStripMenuItem.Click += new System.EventHandler(this.NuevoCursoToolStripMenuItem_Click);
            // 
            // SeccionToolStripMenuItem
            // 
            this.SeccionToolStripMenuItem.Name = "SeccionToolStripMenuItem";
            this.SeccionToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.SeccionToolStripMenuItem.Text = "Secciones";
            this.SeccionToolStripMenuItem.Click += new System.EventHandler(this.SeccionToolStripMenuItem_Click);
            // 
            // AsignaturasCupoToolStripMenuItem
            // 
            this.AsignaturasCupoToolStripMenuItem.Name = "AsignaturasCupoToolStripMenuItem";
            this.AsignaturasCupoToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.AsignaturasCupoToolStripMenuItem.Text = "Asignaturas";
            this.AsignaturasCupoToolStripMenuItem.Click += new System.EventHandler(this.AsignaturasCupoToolStripMenuItem_Click);
            // 
            // semestresToolStripMenuItem
            // 
            this.semestresToolStripMenuItem.Name = "semestresToolStripMenuItem";
            this.semestresToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.semestresToolStripMenuItem.Text = "Semestres";
            // 
            // windowsMenu
            // 
            this.windowsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.promoverEstudiantesToolStripMenuItem});
            this.windowsMenu.Name = "windowsMenu";
            this.windowsMenu.Size = new System.Drawing.Size(71, 20);
            this.windowsMenu.Text = "Promover";
            // 
            // promoverEstudiantesToolStripMenuItem
            // 
            this.promoverEstudiantesToolStripMenuItem.Name = "promoverEstudiantesToolStripMenuItem";
            this.promoverEstudiantesToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.promoverEstudiantesToolStripMenuItem.Text = "Promover Estudiantes";
            // 
            // MnuCalificaciones
            // 
            this.MnuCalificaciones.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.proveedoresToolStripMenuItem,
            this.reporteToolStripMenuItem,
            this.informesToolStripMenuItem});
            this.MnuCalificaciones.Name = "MnuCalificaciones";
            this.MnuCalificaciones.Size = new System.Drawing.Size(92, 20);
            this.MnuCalificaciones.Text = "Calificaciones";
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.proveedoresToolStripMenuItem.Text = "Ingresar";
            // 
            // reporteToolStripMenuItem
            // 
            this.reporteToolStripMenuItem.Name = "reporteToolStripMenuItem";
            this.reporteToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.reporteToolStripMenuItem.Text = "Reporte";
            // 
            // informesToolStripMenuItem
            // 
            this.informesToolStripMenuItem.Name = "informesToolStripMenuItem";
            this.informesToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.informesToolStripMenuItem.Text = "Informes";
            // 
            // MnuAccesos
            // 
            this.MnuAccesos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rolesToolStripMenuItem,
            this.usuariosToolStripMenuItem});
            this.MnuAccesos.Name = "MnuAccesos";
            this.MnuAccesos.Size = new System.Drawing.Size(62, 20);
            this.MnuAccesos.Text = "Accesos";
            // 
            // rolesToolStripMenuItem
            // 
            this.rolesToolStripMenuItem.Name = "rolesToolStripMenuItem";
            this.rolesToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.rolesToolStripMenuItem.Text = "&Roles";
            this.rolesToolStripMenuItem.Click += new System.EventHandler(this.RolesToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.usuariosToolStripMenuItem.Text = "&Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.UsuariosToolStripMenuItem_Click);
            // 
            // ajustesGeneralesToolStripMenuItem
            // 
            this.ajustesGeneralesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajustesGeneralesToolStripMenuItem1});
            this.ajustesGeneralesToolStripMenuItem.Name = "ajustesGeneralesToolStripMenuItem";
            this.ajustesGeneralesToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.ajustesGeneralesToolStripMenuItem.Text = "Ajustes";
            // 
            // ajustesGeneralesToolStripMenuItem1
            // 
            this.ajustesGeneralesToolStripMenuItem1.Name = "ajustesGeneralesToolStripMenuItem1";
            this.ajustesGeneralesToolStripMenuItem1.Size = new System.Drawing.Size(166, 22);
            this.ajustesGeneralesToolStripMenuItem1.Text = "Ajustes Generales";
            this.ajustesGeneralesToolStripMenuItem1.Click += new System.EventHandler(this.AjustesGeneralesToolStripMenuItem1_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.SalirToolStripMenuItem_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(836, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "ToolStrip";
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Location = new System.Drawing.Point(0, 587);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(836, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(257, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "HOLA VICTOR CONTRERAS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(266, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "GORDITOOOOOO";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 609);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FrmPrincipal";
            this.Text = "Sistema Ingreso de calificaciones";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripMenuItem viewMenu;
        private System.Windows.Forms.ToolStripMenuItem windowsMenu;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem MnuAdmin;
        private System.Windows.Forms.ToolStripMenuItem MnuCalificaciones;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MnuPlanificacion;
        private System.Windows.Forms.ToolStripMenuItem MnuAccesos;
        private System.Windows.Forms.ToolStripMenuItem rolesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoCursoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SeccionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AsignaturasCupoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionProfesoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeAlumnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem semestresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem promoverEstudiantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajustesGeneralesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajustesGeneralesToolStripMenuItem1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}



