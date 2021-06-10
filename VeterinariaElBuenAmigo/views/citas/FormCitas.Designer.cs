
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
            this.lblCitasProgramadas = new System.Windows.Forms.Label();
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
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnDelete1 = new Guna.UI.WinForms.GunaButton();
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
            this.btnAddCita.Location = new System.Drawing.Point(73, 39);
            this.btnAddCita.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddCita.Name = "btnAddCita";
            this.btnAddCita.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(211)))));
            this.btnAddCita.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddCita.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAddCita.OnHoverImage = null;
            this.btnAddCita.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddCita.Radius = 5;
            this.btnAddCita.Size = new System.Drawing.Size(250, 43);
            this.btnAddCita.TabIndex = 11;
            this.btnAddCita.Text = "Agregar Cita";
            this.btnAddCita.Click += new System.EventHandler(this.btnAddCita_Click);
            // 
            // lblCitasDelDia
            // 
            this.lblCitasDelDia.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCitasDelDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCitasDelDia.Location = new System.Drawing.Point(0, 0);
            this.lblCitasDelDia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCitasDelDia.Name = "lblCitasDelDia";
            this.lblCitasDelDia.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCitasDelDia.Size = new System.Drawing.Size(1071, 43);
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
            // lblCitasProgramadas
            // 
            this.lblCitasProgramadas.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCitasProgramadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCitasProgramadas.Location = new System.Drawing.Point(0, 0);
            this.lblCitasProgramadas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCitasProgramadas.Name = "lblCitasProgramadas";
            this.lblCitasProgramadas.Size = new System.Drawing.Size(1071, 37);
            this.lblCitasProgramadas.TabIndex = 6;
            this.lblCitasProgramadas.Text = "Citas programadas: N";
            this.lblCitasProgramadas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(73, 119);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dvgCitasProgramadas);
            this.splitContainer1.Panel1.Controls.Add(this.lblCitasProgramadas);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dvgCitasDelDia);
            this.splitContainer1.Panel2.Controls.Add(this.lblCitasDelDia);
            this.splitContainer1.Size = new System.Drawing.Size(1071, 654);
            this.splitContainer1.SplitterDistance = 247;
            this.splitContainer1.SplitterWidth = 62;
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
            this.dvgCitasProgramadas.Location = new System.Drawing.Point(0, 37);
            this.dvgCitasProgramadas.Margin = new System.Windows.Forms.Padding(4);
            this.dvgCitasProgramadas.Name = "dvgCitasProgramadas";
            this.dvgCitasProgramadas.RowHeadersVisible = false;
            this.dvgCitasProgramadas.RowHeadersWidth = 51;
            this.dvgCitasProgramadas.RowTemplate.Height = 40;
            this.dvgCitasProgramadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgCitasProgramadas.Size = new System.Drawing.Size(1071, 210);
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
            this.dataGridViewTextBoxColumn4,
            this.Edit,
            this.Delete});
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
            this.dvgCitasDelDia.Location = new System.Drawing.Point(0, 43);
            this.dvgCitasDelDia.Margin = new System.Windows.Forms.Padding(4);
            this.dvgCitasDelDia.Name = "dvgCitasDelDia";
            this.dvgCitasDelDia.RowHeadersVisible = false;
            this.dvgCitasDelDia.RowHeadersWidth = 51;
            this.dvgCitasDelDia.RowTemplate.Height = 40;
            this.dvgCitasDelDia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgCitasDelDia.Size = new System.Drawing.Size(1071, 302);
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
            this.dvgCitasDelDia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgCitasDelDia_CellClick);
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
            this.dataGridViewTextBoxColumn3.HeaderText = "Apellido";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Telefono";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // Edit
            // 
            this.Edit.FillWeight = 25F;
            this.Edit.HeaderText = "";
            this.Edit.Image = global::VeterinariaElBuenAmigo.Properties.Resources.edit;
            this.Edit.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Edit.MinimumWidth = 6;
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            // 
            // Delete
            // 
            this.Delete.FillWeight = 25F;
            this.Delete.HeaderText = "";
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
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
            this.btnDelete1.Location = new System.Drawing.Point(969, 72);
            this.btnDelete1.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete1.Name = "btnDelete1";
            this.btnDelete1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(117)))));
            this.btnDelete1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDelete1.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDelete1.OnHoverImage = null;
            this.btnDelete1.OnPressedColor = System.Drawing.Color.Black;
            this.btnDelete1.Radius = 5;
            this.btnDelete1.Size = new System.Drawing.Size(175, 43);
            this.btnDelete1.TabIndex = 33;
            this.btnDelete1.Text = "Eliminar ";
            this.btnDelete1.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // FormCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1240, 849);
            this.Controls.Add(this.btnDelete1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.btnAddCita);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Label lblCitasProgramadas;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Delete;
    }
}