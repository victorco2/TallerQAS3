namespace Sistema.Presentacion
{
    partial class FrmCreacionCurso
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
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboperiodo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtCupo = new System.Windows.Forms.TextBox();
            this.BtnAgregarDocente = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtNCurso = new System.Windows.Forms.TextBox();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.BtnInsertar = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.paneldocente = new System.Windows.Forms.Panel();
            this.DgvDocente = new System.Windows.Forms.DataGridView();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnFiltrarDocente = new System.Windows.Forms.Button();
            this.TxtBuscarDocente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TabGeneral = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnDesactivar = new System.Windows.Forms.Button();
            this.BtnActivar = new System.Windows.Forms.Button();
            this.ChkSeleccionar = new System.Windows.Forms.CheckBox();
            this.DgvListado = new System.Windows.Forms.DataGridView();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ErrorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.paneldocente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDocente)).BeginInit();
            this.TabGeneral.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorIcono)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Nombre Curso:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboperiodo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtCupo);
            this.groupBox1.Controls.Add(this.BtnAgregarDocente);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TxtNCurso);
            this.groupBox1.Controls.Add(this.BtnCancelar);
            this.groupBox1.Controls.Add(this.TxtId);
            this.groupBox1.Controls.Add(this.BtnActualizar);
            this.groupBox1.Controls.Add(this.BtnInsertar);
            this.groupBox1.Location = new System.Drawing.Point(17, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(472, 316);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Creacion de un Curso";
            // 
            // cboperiodo
            // 
            this.cboperiodo.FormattingEnabled = true;
            this.cboperiodo.Location = new System.Drawing.Point(120, 77);
            this.cboperiodo.Name = "cboperiodo";
            this.cboperiodo.Size = new System.Drawing.Size(187, 21);
            this.cboperiodo.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Periodo:";
            // 
            // TxtCupo
            // 
            this.TxtCupo.Location = new System.Drawing.Point(120, 139);
            this.TxtCupo.Name = "TxtCupo";
            this.TxtCupo.Size = new System.Drawing.Size(100, 20);
            this.TxtCupo.TabIndex = 33;
            // 
            // BtnAgregarDocente
            // 
            this.BtnAgregarDocente.Location = new System.Drawing.Point(108, 175);
            this.BtnAgregarDocente.Name = "BtnAgregarDocente";
            this.BtnAgregarDocente.Size = new System.Drawing.Size(100, 23);
            this.BtnAgregarDocente.TabIndex = 31;
            this.BtnAgregarDocente.Text = "Agregar";
            this.BtnAgregarDocente.UseVisualStyleBackColor = true;
            this.BtnAgregarDocente.Click += new System.EventHandler(this.BtnAgregarDocente_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 146);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Cupo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 185);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Profesor Jefe:";
            // 
            // TxtNCurso
            // 
            this.TxtNCurso.Location = new System.Drawing.Point(120, 104);
            this.TxtNCurso.Name = "TxtNCurso";
            this.TxtNCurso.Size = new System.Drawing.Size(187, 20);
            this.TxtNCurso.TabIndex = 28;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(232, 267);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(134, 19);
            this.BtnCancelar.TabIndex = 6;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(212, 30);
            this.TxtId.Margin = new System.Windows.Forms.Padding(2);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(95, 20);
            this.TxtId.TabIndex = 4;
            this.TxtId.Visible = false;
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.Location = new System.Drawing.Point(74, 244);
            this.BtnActualizar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(134, 19);
            this.BtnActualizar.TabIndex = 8;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.UseVisualStyleBackColor = true;
            // 
            // BtnInsertar
            // 
            this.BtnInsertar.Location = new System.Drawing.Point(74, 267);
            this.BtnInsertar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnInsertar.Name = "BtnInsertar";
            this.BtnInsertar.Size = new System.Drawing.Size(134, 19);
            this.BtnInsertar.TabIndex = 5;
            this.BtnInsertar.Text = "Insertar";
            this.BtnInsertar.UseVisualStyleBackColor = true;
            this.BtnInsertar.Click += new System.EventHandler(this.BtnInsertar_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.paneldocente);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(510, 358);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantenimiento";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // paneldocente
            // 
            this.paneldocente.BackColor = System.Drawing.Color.Azure;
            this.paneldocente.Controls.Add(this.DgvDocente);
            this.paneldocente.Controls.Add(this.BtnSalir);
            this.paneldocente.Controls.Add(this.BtnFiltrarDocente);
            this.paneldocente.Controls.Add(this.TxtBuscarDocente);
            this.paneldocente.Controls.Add(this.label3);
            this.paneldocente.Location = new System.Drawing.Point(23, 0);
            this.paneldocente.Name = "paneldocente";
            this.paneldocente.Size = new System.Drawing.Size(420, 202);
            this.paneldocente.TabIndex = 36;
            this.paneldocente.Visible = false;
            // 
            // DgvDocente
            // 
            this.DgvDocente.AllowUserToAddRows = false;
            this.DgvDocente.AllowUserToDeleteRows = false;
            this.DgvDocente.AllowUserToOrderColumns = true;
            this.DgvDocente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDocente.Location = new System.Drawing.Point(12, 39);
            this.DgvDocente.Name = "DgvDocente";
            this.DgvDocente.ReadOnly = true;
            this.DgvDocente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvDocente.Size = new System.Drawing.Size(383, 150);
            this.DgvDocente.TabIndex = 4;
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(368, 12);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(27, 20);
            this.BtnSalir.TabIndex = 3;
            this.BtnSalir.Text = "X";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnFiltrarDocente
            // 
            this.BtnFiltrarDocente.Location = new System.Drawing.Point(199, 12);
            this.BtnFiltrarDocente.Name = "BtnFiltrarDocente";
            this.BtnFiltrarDocente.Size = new System.Drawing.Size(75, 20);
            this.BtnFiltrarDocente.TabIndex = 2;
            this.BtnFiltrarDocente.Text = "Buscar";
            this.BtnFiltrarDocente.UseVisualStyleBackColor = true;
            this.BtnFiltrarDocente.Click += new System.EventHandler(this.BtnFiltrarDocente_Click);
            // 
            // TxtBuscarDocente
            // 
            this.TxtBuscarDocente.Location = new System.Drawing.Point(57, 13);
            this.TxtBuscarDocente.Name = "TxtBuscarDocente";
            this.TxtBuscarDocente.Size = new System.Drawing.Size(130, 20);
            this.TxtBuscarDocente.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Buscar:";
            // 
            // TabGeneral
            // 
            this.TabGeneral.Controls.Add(this.tabPage2);
            this.TabGeneral.Controls.Add(this.tabPage1);
            this.TabGeneral.Location = new System.Drawing.Point(19, 18);
            this.TabGeneral.Margin = new System.Windows.Forms.Padding(2);
            this.TabGeneral.Name = "TabGeneral";
            this.TabGeneral.SelectedIndex = 0;
            this.TabGeneral.Size = new System.Drawing.Size(518, 384);
            this.TabGeneral.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.comboBox3);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.BtnEliminar);
            this.tabPage1.Controls.Add(this.BtnDesactivar);
            this.tabPage1.Controls.Add(this.BtnActivar);
            this.tabPage1.Controls.Add(this.ChkSeleccionar);
            this.tabPage1.Controls.Add(this.DgvListado);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(510, 358);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(83, 12);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(134, 21);
            this.comboBox3.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Periodo:";
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(340, 322);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(94, 19);
            this.BtnEliminar.TabIndex = 7;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // BtnDesactivar
            // 
            this.BtnDesactivar.Location = new System.Drawing.Point(232, 322);
            this.BtnDesactivar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnDesactivar.Name = "BtnDesactivar";
            this.BtnDesactivar.Size = new System.Drawing.Size(94, 19);
            this.BtnDesactivar.TabIndex = 6;
            this.BtnDesactivar.Text = "Desactivar";
            this.BtnDesactivar.UseVisualStyleBackColor = true;
            // 
            // BtnActivar
            // 
            this.BtnActivar.Location = new System.Drawing.Point(123, 322);
            this.BtnActivar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnActivar.Name = "BtnActivar";
            this.BtnActivar.Size = new System.Drawing.Size(94, 19);
            this.BtnActivar.TabIndex = 5;
            this.BtnActivar.Text = "Activar";
            this.BtnActivar.UseVisualStyleBackColor = true;
            // 
            // ChkSeleccionar
            // 
            this.ChkSeleccionar.AutoSize = true;
            this.ChkSeleccionar.Location = new System.Drawing.Point(14, 324);
            this.ChkSeleccionar.Margin = new System.Windows.Forms.Padding(2);
            this.ChkSeleccionar.Name = "ChkSeleccionar";
            this.ChkSeleccionar.Size = new System.Drawing.Size(82, 17);
            this.ChkSeleccionar.TabIndex = 4;
            this.ChkSeleccionar.Text = "Seleccionar";
            this.ChkSeleccionar.UseVisualStyleBackColor = true;
            // 
            // DgvListado
            // 
            this.DgvListado.AllowUserToAddRows = false;
            this.DgvListado.AllowUserToDeleteRows = false;
            this.DgvListado.AllowUserToOrderColumns = true;
            this.DgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn1});
            this.DgvListado.Location = new System.Drawing.Point(14, 50);
            this.DgvListado.Margin = new System.Windows.Forms.Padding(2);
            this.DgvListado.Name = "DgvListado";
            this.DgvListado.ReadOnly = true;
            this.DgvListado.RowTemplate.Height = 24;
            this.DgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListado.Size = new System.Drawing.Size(480, 261);
            this.DgvListado.TabIndex = 0;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.HeaderText = "Seleccionar";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            // 
            // ErrorIcono
            // 
            this.ErrorIcono.ContainerControl = this;
            // 
            // FrmCreacionCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 413);
            this.Controls.Add(this.TabGeneral);
            this.Name = "FrmCreacionCurso";
            this.Text = "FrmCreacionCurso";
            this.Load += new System.EventHandler(this.FrmCreacionCurso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.paneldocente.ResumeLayout(false);
            this.paneldocente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDocente)).EndInit();
            this.TabGeneral.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorIcono)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TabControl TabGeneral;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.Button BtnInsertar;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnDesactivar;
        private System.Windows.Forms.Button BtnActivar;
        private System.Windows.Forms.CheckBox ChkSeleccionar;
        private System.Windows.Forms.DataGridView DgvListado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
        private System.Windows.Forms.ErrorProvider ErrorIcono;
        private System.Windows.Forms.TextBox TxtNCurso;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnAgregarDocente;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtCupo;
        private System.Windows.Forms.ComboBox cboperiodo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel paneldocente;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnFiltrarDocente;
        private System.Windows.Forms.TextBox TxtBuscarDocente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DgvDocente;
    }
}