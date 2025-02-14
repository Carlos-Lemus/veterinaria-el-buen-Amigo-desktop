﻿
namespace VeterinariaElBuenAmigo.views
{
    partial class FormCitas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAddCita = new Guna.UI.WinForms.GunaButton();
            this.lblCitasDelDia = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dvgCitasProgramadas = new Guna.UI.WinForms.GunaDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dvgCitasDelDia = new Guna.UI.WinForms.GunaDataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelete1 = new Guna.UI.WinForms.GunaButton();
            this.btnClear = new Guna.UI.WinForms.GunaButton();
            this.txtBuscarCita = new Guna.UI.WinForms.GunaTextBox();
            this.lblCitasProgramadas = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gunaDateTimePickerCita = new Guna.UI.WinForms.GunaDateTimePicker();
            this.Imprimir = new FontAwesome.Sharp.IconButton();
            this.easyHTMLReports1 = new KimToo.EasyHTMLReports(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgCitasProgramadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgCitasDelDia)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddCita
            // 
            this.btnAddCita.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddCita.AnimationHoverSpeed = 0.07F;
            this.btnAddCita.AnimationSpeed = 0.03F;
            this.btnAddCita.BackColor = System.Drawing.Color.Transparent;
            this.btnAddCita.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.btnAddCita.BorderColor = System.Drawing.Color.Black;
            this.btnAddCita.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCita.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddCita.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddCita.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddCita.ForeColor = System.Drawing.Color.White;
            this.btnAddCita.Image = global::VeterinariaElBuenAmigo.Properties.Resources.add;
            this.btnAddCita.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAddCita.Location = new System.Drawing.Point(575, 92);
            this.btnAddCita.Name = "btnAddCita";
            this.btnAddCita.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.btnAddCita.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddCita.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAddCita.OnHoverImage = null;
            this.btnAddCita.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddCita.Radius = 5;
            this.btnAddCita.Size = new System.Drawing.Size(146, 35);
            this.btnAddCita.TabIndex = 11;
            this.btnAddCita.Text = "Agregar Cita";
            this.btnAddCita.Click += new System.EventHandler(this.btnAddCita_Click);
            // 
            // lblCitasDelDia
            // 
            this.lblCitasDelDia.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCitasDelDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCitasDelDia.Location = new System.Drawing.Point(0, 0);
            this.lblCitasDelDia.Name = "lblCitasDelDia";
            this.lblCitasDelDia.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCitasDelDia.Size = new System.Drawing.Size(803, 35);
            this.lblCitasDelDia.TabIndex = 9;
            this.lblCitasDelDia.Text = "Citas del dia YY/mm/dd : N";
            this.lblCitasDelDia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 159;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.MinimumWidth = 6;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 133;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(55, 133);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dvgCitasProgramadas);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dvgCitasDelDia);
            this.splitContainer1.Panel2.Controls.Add(this.lblCitasDelDia);
            this.splitContainer1.Size = new System.Drawing.Size(803, 495);
            this.splitContainer1.SplitterDistance = 186;
            this.splitContainer1.SplitterWidth = 50;
            this.splitContainer1.TabIndex = 13;
            // 
            // dvgCitasProgramadas
            // 
            this.dvgCitasProgramadas.AllowUserToAddRows = false;
            this.dvgCitasProgramadas.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dvgCitasProgramadas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dvgCitasProgramadas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgCitasProgramadas.BackgroundColor = System.Drawing.Color.White;
            this.dvgCitasProgramadas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dvgCitasProgramadas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dvgCitasProgramadas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgCitasProgramadas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dvgCitasProgramadas.ColumnHeadersHeight = 40;
            this.dvgCitasProgramadas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Editar,
            this.Eliminar});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 14F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvgCitasProgramadas.DefaultCellStyle = dataGridViewCellStyle3;
            this.dvgCitasProgramadas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvgCitasProgramadas.EnableHeadersVisualStyles = false;
            this.dvgCitasProgramadas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.dvgCitasProgramadas.Location = new System.Drawing.Point(0, 0);
            this.dvgCitasProgramadas.Name = "dvgCitasProgramadas";
            this.dvgCitasProgramadas.RowHeadersVisible = false;
            this.dvgCitasProgramadas.RowHeadersWidth = 51;
            this.dvgCitasProgramadas.RowTemplate.Height = 40;
            this.dvgCitasProgramadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgCitasProgramadas.Size = new System.Drawing.Size(803, 186);
            this.dvgCitasProgramadas.TabIndex = 9;
            this.dvgCitasProgramadas.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dvgCitasProgramadas.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dvgCitasProgramadas.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dvgCitasProgramadas.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dvgCitasProgramadas.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dvgCitasProgramadas.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dvgCitasProgramadas.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dvgCitasProgramadas.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.dvgCitasProgramadas.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.dvgCitasProgramadas.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dvgCitasProgramadas.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.dvgCitasProgramadas.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dvgCitasProgramadas.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dvgCitasProgramadas.ThemeStyle.HeaderStyle.Height = 40;
            this.dvgCitasProgramadas.ThemeStyle.ReadOnly = false;
            this.dvgCitasProgramadas.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dvgCitasProgramadas.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dvgCitasProgramadas.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.dvgCitasProgramadas.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.dvgCitasProgramadas.ThemeStyle.RowsStyle.Height = 40;
            this.dvgCitasProgramadas.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            this.dvgCitasProgramadas.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.dvgCitasProgramadas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgCitasProgramadas_CellClick);
            // 
            // Column1
            // 
            this.Column1.FillWeight = 30F;
            this.Column1.HeaderText = "Id";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 145F;
            this.Column2.HeaderText = "Paciente";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 145F;
            this.Column3.HeaderText = "Fecha";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Motivo";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Editar
            // 
            this.Editar.FillWeight = 25F;
            this.Editar.HeaderText = "";
            this.Editar.Image = global::VeterinariaElBuenAmigo.Properties.Resources.edit;
            this.Editar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Editar.MinimumWidth = 6;
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            // 
            // Eliminar
            // 
            this.Eliminar.FillWeight = 25F;
            this.Eliminar.HeaderText = "";
            this.Eliminar.MinimumWidth = 6;
            this.Eliminar.Name = "Eliminar";
            // 
            // dvgCitasDelDia
            // 
            this.dvgCitasDelDia.AllowUserToAddRows = false;
            this.dvgCitasDelDia.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dvgCitasDelDia.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dvgCitasDelDia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgCitasDelDia.BackgroundColor = System.Drawing.Color.White;
            this.dvgCitasDelDia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dvgCitasDelDia.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dvgCitasDelDia.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgCitasDelDia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dvgCitasDelDia.ColumnHeadersHeight = 40;
            this.dvgCitasDelDia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 14F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvgCitasDelDia.DefaultCellStyle = dataGridViewCellStyle6;
            this.dvgCitasDelDia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvgCitasDelDia.EnableHeadersVisualStyles = false;
            this.dvgCitasDelDia.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.dvgCitasDelDia.Location = new System.Drawing.Point(0, 35);
            this.dvgCitasDelDia.Name = "dvgCitasDelDia";
            this.dvgCitasDelDia.RowHeadersVisible = false;
            this.dvgCitasDelDia.RowHeadersWidth = 51;
            this.dvgCitasDelDia.RowTemplate.Height = 40;
            this.dvgCitasDelDia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgCitasDelDia.Size = new System.Drawing.Size(803, 224);
            this.dvgCitasDelDia.TabIndex = 14;
            this.dvgCitasDelDia.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dvgCitasDelDia.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dvgCitasDelDia.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dvgCitasDelDia.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dvgCitasDelDia.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dvgCitasDelDia.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dvgCitasDelDia.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dvgCitasDelDia.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.dvgCitasDelDia.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.dvgCitasDelDia.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dvgCitasDelDia.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.dvgCitasDelDia.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dvgCitasDelDia.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dvgCitasDelDia.ThemeStyle.HeaderStyle.Height = 40;
            this.dvgCitasDelDia.ThemeStyle.ReadOnly = false;
            this.dvgCitasDelDia.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dvgCitasDelDia.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dvgCitasDelDia.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.dvgCitasDelDia.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.dvgCitasDelDia.ThemeStyle.RowsStyle.Height = 40;
            this.dvgCitasDelDia.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            this.dvgCitasDelDia.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.FillWeight = 30F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.FillWeight = 145F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.FillWeight = 145F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Fecha";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Motivo";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // btnDelete1
            // 
            this.btnDelete1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete1.AnimationHoverSpeed = 0.07F;
            this.btnDelete1.AnimationSpeed = 0.03F;
            this.btnDelete1.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(82)))), ((int)(((byte)(83)))));
            this.btnDelete1.BorderColor = System.Drawing.Color.Black;
            this.btnDelete1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDelete1.FocusedColor = System.Drawing.Color.Empty;
            this.btnDelete1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnDelete1.ForeColor = System.Drawing.Color.White;
            this.btnDelete1.Image = global::VeterinariaElBuenAmigo.Properties.Resources.delete;
            this.btnDelete1.ImageSize = new System.Drawing.Size(20, 20);
            this.btnDelete1.Location = new System.Drawing.Point(727, 91);
            this.btnDelete1.Name = "btnDelete1";
            this.btnDelete1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(117)))));
            this.btnDelete1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDelete1.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDelete1.OnHoverImage = null;
            this.btnDelete1.OnPressedColor = System.Drawing.Color.Black;
            this.btnDelete1.Radius = 5;
            this.btnDelete1.Size = new System.Drawing.Size(131, 35);
            this.btnDelete1.TabIndex = 33;
            this.btnDelete1.Text = "Eliminar ";
            this.btnDelete1.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.AnimationHoverSpeed = 0.07F;
            this.btnClear.AnimationSpeed = 0.03F;
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.BaseColor = System.Drawing.Color.White;
            this.btnClear.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.btnClear.BorderSize = 2;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnClear.FocusedColor = System.Drawing.Color.White;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.Transparent;
            this.btnClear.Image = global::VeterinariaElBuenAmigo.Properties.Resources.ios_close1;
            this.btnClear.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnClear.ImageSize = new System.Drawing.Size(42, 42);
            this.btnClear.Location = new System.Drawing.Point(826, 50);
            this.btnClear.Name = "btnClear";
            this.btnClear.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(211)))));
            this.btnClear.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnClear.OnHoverForeColor = System.Drawing.Color.White;
            this.btnClear.OnHoverImage = null;
            this.btnClear.OnPressedColor = System.Drawing.Color.Black;
            this.btnClear.Radius = 5;
            this.btnClear.Size = new System.Drawing.Size(32, 35);
            this.btnClear.TabIndex = 37;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtBuscarCita
            // 
            this.txtBuscarCita.BackColor = System.Drawing.Color.Transparent;
            this.txtBuscarCita.BaseColor = System.Drawing.Color.White;
            this.txtBuscarCita.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(211)))));
            this.txtBuscarCita.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscarCita.FocusedBaseColor = System.Drawing.Color.White;
            this.txtBuscarCita.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.txtBuscarCita.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtBuscarCita.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtBuscarCita.Location = new System.Drawing.Point(166, 50);
            this.txtBuscarCita.Name = "txtBuscarCita";
            this.txtBuscarCita.PasswordChar = '\0';
            this.txtBuscarCita.Radius = 4;
            this.txtBuscarCita.Size = new System.Drawing.Size(300, 35);
            this.txtBuscarCita.TabIndex = 36;
            this.txtBuscarCita.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscarCita_KeyPress);
            // 
            // lblCitasProgramadas
            // 
            this.lblCitasProgramadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCitasProgramadas.Location = new System.Drawing.Point(55, 95);
            this.lblCitasProgramadas.Name = "lblCitasProgramadas";
            this.lblCitasProgramadas.Size = new System.Drawing.Size(276, 35);
            this.lblCitasProgramadas.TabIndex = 38;
            this.lblCitasProgramadas.Text = "Citas Programadas";
            this.lblCitasProgramadas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 35);
            this.label2.TabIndex = 39;
            this.label2.Text = "Buscar";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gunaDateTimePickerCita
            // 
            this.gunaDateTimePickerCita.BackColor = System.Drawing.Color.Transparent;
            this.gunaDateTimePickerCita.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.gunaDateTimePickerCita.BorderColor = System.Drawing.Color.White;
            this.gunaDateTimePickerCita.CustomFormat = null;
            this.gunaDateTimePickerCita.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.gunaDateTimePickerCita.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.gunaDateTimePickerCita.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.gunaDateTimePickerCita.ForeColor = System.Drawing.Color.White;
            this.gunaDateTimePickerCita.Location = new System.Drawing.Point(482, 50);
            this.gunaDateTimePickerCita.Margin = new System.Windows.Forms.Padding(2);
            this.gunaDateTimePickerCita.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.gunaDateTimePickerCita.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.gunaDateTimePickerCita.Name = "gunaDateTimePickerCita";
            this.gunaDateTimePickerCita.OnHoverBaseColor = System.Drawing.Color.White;
            this.gunaDateTimePickerCita.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.gunaDateTimePickerCita.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.gunaDateTimePickerCita.OnPressedColor = System.Drawing.Color.Black;
            this.gunaDateTimePickerCita.Radius = 5;
            this.gunaDateTimePickerCita.Size = new System.Drawing.Size(339, 36);
            this.gunaDateTimePickerCita.TabIndex = 40;
            this.gunaDateTimePickerCita.Text = "lunes, 7 de junio de 2021";
            this.gunaDateTimePickerCita.Value = new System.DateTime(2021, 6, 7, 13, 4, 55, 439);
            this.gunaDateTimePickerCita.ValueChanged += new System.EventHandler(this.gunaDateTimePickerCita_ValueChanged);
            // 
            // Imprimir
            // 
            this.Imprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Imprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Imprimir.FlatAppearance.BorderSize = 0;
            this.Imprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Imprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Imprimir.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.Imprimir.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.Imprimir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Imprimir.IconSize = 32;
            this.Imprimir.Location = new System.Drawing.Point(440, 90);
            this.Imprimir.Name = "Imprimir";
            this.Imprimir.Size = new System.Drawing.Size(129, 36);
            this.Imprimir.TabIndex = 41;
            this.Imprimir.Text = "Imprimir";
            this.Imprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Imprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Imprimir.UseVisualStyleBackColor = true;
            this.Imprimir.Click += new System.EventHandler(this.Imprimir_Click);
            // 
            // easyHTMLReports1
            // 
            this.easyHTMLReports1.AlternativeRowBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.easyHTMLReports1.AlternativeRowGridColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(61)))), ((int)(((byte)(65)))));
            this.easyHTMLReports1.HeaderBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(183)))), ((int)(((byte)(197)))));
            this.easyHTMLReports1.HeaderFontColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(46)))));
            this.easyHTMLReports1.HeaderGridColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(61)))), ((int)(((byte)(65)))));
            this.easyHTMLReports1.RowDefaultBackgroudColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.easyHTMLReports1.RowDefaultFontColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(46)))));
            this.easyHTMLReports1.RowDefaultGridColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(61)))), ((int)(((byte)(65)))));
            // 
            // FormCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(930, 640);
            this.Controls.Add(this.Imprimir);
            this.Controls.Add(this.gunaDateTimePickerCita);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCitasProgramadas);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtBuscarCita);
            this.Controls.Add(this.btnDelete1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.btnAddCita);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCitas";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgCitasProgramadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgCitasDelDia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaButton btnAddCita;
        private System.Windows.Forms.Label lblCitasDelDia;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private Guna.UI.WinForms.GunaDataGridView dvgCitasDelDia;
        private Guna.UI.WinForms.GunaDataGridView dvgCitasProgramadas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private Guna.UI.WinForms.GunaButton btnDelete1;
        private Guna.UI.WinForms.GunaButton btnClear;
        private Guna.UI.WinForms.GunaTextBox txtBuscarCita;
        private System.Windows.Forms.Label lblCitasProgramadas;
        private System.Windows.Forms.Label label2;
        public Guna.UI.WinForms.GunaDateTimePicker gunaDateTimePickerCita;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private FontAwesome.Sharp.IconButton Imprimir;
        private KimToo.EasyHTMLReports easyHTMLReports1;
    }
}