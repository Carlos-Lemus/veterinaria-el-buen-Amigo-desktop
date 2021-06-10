
namespace VeterinariaElBuenAmigo.views
{
    partial class FormConfiguracion
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dvgRazas = new Guna.UI.WinForms.GunaDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEditRaza = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColumnSelectRaza = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.dvgEspecies = new Guna.UI.WinForms.GunaDataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEditEspecie = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColumnSelectEspecie = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.txtChangeKey = new Guna.UI.WinForms.GunaTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new Guna.UI.WinForms.GunaButton();
            this.gunaSeparator1 = new Guna.UI.WinForms.GunaSeparator();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.btnDeleteDelete = new Guna.UI.WinForms.GunaButton();
            this.btnAddRaza = new Guna.UI.WinForms.GunaButton();
            this.btnDeleteEspecie = new Guna.UI.WinForms.GunaButton();
            this.btnAddEspecie = new Guna.UI.WinForms.GunaButton();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgRazas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgEspecies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(72, 223);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dvgRazas);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dvgEspecies);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Size = new System.Drawing.Size(594, 430);
            this.splitContainer1.SplitterDistance = 200;
            this.splitContainer1.SplitterWidth = 30;
            this.splitContainer1.TabIndex = 14;
            // 
            // dvgRazas
            // 
            this.dvgRazas.AllowUserToAddRows = false;
            this.dvgRazas.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dvgRazas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dvgRazas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgRazas.BackgroundColor = System.Drawing.Color.White;
            this.dvgRazas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dvgRazas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dvgRazas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgRazas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dvgRazas.ColumnHeadersHeight = 40;
            this.dvgRazas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column4,
            this.ColumnEditRaza,
            this.ColumnSelectRaza});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 14F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvgRazas.DefaultCellStyle = dataGridViewCellStyle3;
            this.dvgRazas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvgRazas.EnableHeadersVisualStyles = false;
            this.dvgRazas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.dvgRazas.Location = new System.Drawing.Point(0, 30);
            this.dvgRazas.Name = "dvgRazas";
            this.dvgRazas.RowHeadersVisible = false;
            this.dvgRazas.RowHeadersWidth = 51;
            this.dvgRazas.RowTemplate.Height = 40;
            this.dvgRazas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgRazas.Size = new System.Drawing.Size(594, 170);
            this.dvgRazas.TabIndex = 9;
            this.dvgRazas.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dvgRazas.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dvgRazas.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dvgRazas.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dvgRazas.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dvgRazas.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dvgRazas.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dvgRazas.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.dvgRazas.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.dvgRazas.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dvgRazas.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.dvgRazas.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dvgRazas.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dvgRazas.ThemeStyle.HeaderStyle.Height = 40;
            this.dvgRazas.ThemeStyle.ReadOnly = false;
            this.dvgRazas.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dvgRazas.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dvgRazas.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.dvgRazas.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dvgRazas.ThemeStyle.RowsStyle.Height = 40;
            this.dvgRazas.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            this.dvgRazas.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.dvgRazas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgRazas_CellClick);
            // 
            // Column1
            // 
            this.Column1.FillWeight = 30F;
            this.Column1.HeaderText = "Id";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Nombre de la raza";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // ColumnEditRaza
            // 
            this.ColumnEditRaza.FillWeight = 25F;
            this.ColumnEditRaza.HeaderText = "";
            this.ColumnEditRaza.Image = global::VeterinariaElBuenAmigo.Properties.Resources.edit;
            this.ColumnEditRaza.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.ColumnEditRaza.MinimumWidth = 6;
            this.ColumnEditRaza.Name = "ColumnEditRaza";
            this.ColumnEditRaza.ReadOnly = true;
            // 
            // ColumnSelectRaza
            // 
            this.ColumnSelectRaza.FillWeight = 25F;
            this.ColumnSelectRaza.HeaderText = "";
            this.ColumnSelectRaza.MinimumWidth = 6;
            this.ColumnSelectRaza.Name = "ColumnSelectRaza";
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(594, 30);
            this.label2.TabIndex = 6;
            this.label2.Text = "Listas de razas";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dvgEspecies
            // 
            this.dvgEspecies.AllowUserToAddRows = false;
            this.dvgEspecies.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dvgEspecies.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dvgEspecies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgEspecies.BackgroundColor = System.Drawing.Color.White;
            this.dvgEspecies.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dvgEspecies.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dvgEspecies.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgEspecies.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dvgEspecies.ColumnHeadersHeight = 40;
            this.dvgEspecies.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn4,
            this.ColumnEditEspecie,
            this.ColumnSelectEspecie});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 14F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvgEspecies.DefaultCellStyle = dataGridViewCellStyle6;
            this.dvgEspecies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvgEspecies.EnableHeadersVisualStyles = false;
            this.dvgEspecies.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.dvgEspecies.Location = new System.Drawing.Point(0, 35);
            this.dvgEspecies.Name = "dvgEspecies";
            this.dvgEspecies.RowHeadersVisible = false;
            this.dvgEspecies.RowHeadersWidth = 51;
            this.dvgEspecies.RowTemplate.Height = 40;
            this.dvgEspecies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgEspecies.Size = new System.Drawing.Size(594, 165);
            this.dvgEspecies.TabIndex = 14;
            this.dvgEspecies.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dvgEspecies.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dvgEspecies.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dvgEspecies.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dvgEspecies.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dvgEspecies.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dvgEspecies.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dvgEspecies.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.dvgEspecies.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.dvgEspecies.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dvgEspecies.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.dvgEspecies.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dvgEspecies.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dvgEspecies.ThemeStyle.HeaderStyle.Height = 40;
            this.dvgEspecies.ThemeStyle.ReadOnly = false;
            this.dvgEspecies.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dvgEspecies.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dvgEspecies.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.dvgEspecies.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dvgEspecies.ThemeStyle.RowsStyle.Height = 40;
            this.dvgEspecies.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            this.dvgEspecies.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.dvgEspecies.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgEspecies_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.FillWeight = 30F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Nombre de la especie";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // ColumnEditEspecie
            // 
            this.ColumnEditEspecie.FillWeight = 25F;
            this.ColumnEditEspecie.HeaderText = "";
            this.ColumnEditEspecie.Image = global::VeterinariaElBuenAmigo.Properties.Resources.edit;
            this.ColumnEditEspecie.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.ColumnEditEspecie.MinimumWidth = 6;
            this.ColumnEditEspecie.Name = "ColumnEditEspecie";
            this.ColumnEditEspecie.ReadOnly = true;
            // 
            // ColumnSelectEspecie
            // 
            this.ColumnSelectEspecie.FillWeight = 25F;
            this.ColumnSelectEspecie.HeaderText = "";
            this.ColumnSelectEspecie.MinimumWidth = 6;
            this.ColumnSelectEspecie.Name = "ColumnSelectEspecie";
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(594, 35);
            this.label3.TabIndex = 9;
            this.label3.Text = "Listas de especies";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtChangeKey
            // 
            this.txtChangeKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtChangeKey.BackColor = System.Drawing.Color.Transparent;
            this.txtChangeKey.BaseColor = System.Drawing.Color.White;
            this.txtChangeKey.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(211)))));
            this.txtChangeKey.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtChangeKey.FocusedBaseColor = System.Drawing.Color.White;
            this.txtChangeKey.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.txtChangeKey.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtChangeKey.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtChangeKey.Location = new System.Drawing.Point(334, 65);
            this.txtChangeKey.Name = "txtChangeKey";
            this.txtChangeKey.PasswordChar = '\0';
            this.txtChangeKey.Radius = 4;
            this.txtChangeKey.Size = new System.Drawing.Size(282, 42);
            this.txtChangeKey.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(330, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 30);
            this.label1.TabIndex = 15;
            this.label1.Text = "¿Quieres cambiar la clave?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.AnimationHoverSpeed = 0.07F;
            this.btnAdd.AnimationSpeed = 0.03F;
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.btnAdd.BorderColor = System.Drawing.Color.Black;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAdd.FocusedColor = System.Drawing.Color.Empty;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = null;
            this.btnAdd.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAdd.Location = new System.Drawing.Point(334, 125);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.btnAdd.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAdd.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAdd.OnHoverImage = null;
            this.btnAdd.OnPressedColor = System.Drawing.Color.Black;
            this.btnAdd.Radius = 5;
            this.btnAdd.Size = new System.Drawing.Size(282, 35);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.Text = "Guardar";
            this.btnAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // gunaSeparator1
            // 
            this.gunaSeparator1.LineColor = System.Drawing.Color.Silver;
            this.gunaSeparator1.Location = new System.Drawing.Point(72, 181);
            this.gunaSeparator1.Name = "gunaSeparator1";
            this.gunaSeparator1.Size = new System.Drawing.Size(772, 10);
            this.gunaSeparator1.TabIndex = 23;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer2.Location = new System.Drawing.Point(684, 253);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.btnDeleteDelete);
            this.splitContainer2.Panel1.Controls.Add(this.btnAddRaza);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.btnDeleteEspecie);
            this.splitContainer2.Panel2.Controls.Add(this.btnAddEspecie);
            this.splitContainer2.Size = new System.Drawing.Size(185, 430);
            this.splitContainer2.SplitterDistance = 205;
            this.splitContainer2.SplitterWidth = 30;
            this.splitContainer2.TabIndex = 24;
            // 
            // btnDeleteDelete
            // 
            this.btnDeleteDelete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteDelete.AnimationHoverSpeed = 0.07F;
            this.btnDeleteDelete.AnimationSpeed = 0.03F;
            this.btnDeleteDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteDelete.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(82)))), ((int)(((byte)(83)))));
            this.btnDeleteDelete.BorderColor = System.Drawing.Color.Black;
            this.btnDeleteDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteDelete.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDeleteDelete.FocusedColor = System.Drawing.Color.Empty;
            this.btnDeleteDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnDeleteDelete.ForeColor = System.Drawing.Color.White;
            this.btnDeleteDelete.Image = global::VeterinariaElBuenAmigo.Properties.Resources.delete;
            this.btnDeleteDelete.ImageSize = new System.Drawing.Size(20, 20);
            this.btnDeleteDelete.Location = new System.Drawing.Point(3, 62);
            this.btnDeleteDelete.Name = "btnDeleteDelete";
            this.btnDeleteDelete.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(117)))));
            this.btnDeleteDelete.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDeleteDelete.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDeleteDelete.OnHoverImage = null;
            this.btnDeleteDelete.OnPressedColor = System.Drawing.Color.Black;
            this.btnDeleteDelete.Radius = 5;
            this.btnDeleteDelete.Size = new System.Drawing.Size(179, 35);
            this.btnDeleteDelete.TabIndex = 34;
            this.btnDeleteDelete.Text = "Eliminar  Raza";
            this.btnDeleteDelete.Click += new System.EventHandler(this.btnDeleteDelete_Click);
            // 
            // btnAddRaza
            // 
            this.btnAddRaza.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddRaza.AnimationHoverSpeed = 0.07F;
            this.btnAddRaza.AnimationSpeed = 0.03F;
            this.btnAddRaza.BackColor = System.Drawing.Color.Transparent;
            this.btnAddRaza.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.btnAddRaza.BorderColor = System.Drawing.Color.Black;
            this.btnAddRaza.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddRaza.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddRaza.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddRaza.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddRaza.ForeColor = System.Drawing.Color.White;
            this.btnAddRaza.Image = global::VeterinariaElBuenAmigo.Properties.Resources.add;
            this.btnAddRaza.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAddRaza.Location = new System.Drawing.Point(3, 5);
            this.btnAddRaza.Name = "btnAddRaza";
            this.btnAddRaza.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(211)))));
            this.btnAddRaza.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddRaza.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAddRaza.OnHoverImage = null;
            this.btnAddRaza.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddRaza.Radius = 5;
            this.btnAddRaza.Size = new System.Drawing.Size(179, 35);
            this.btnAddRaza.TabIndex = 12;
            this.btnAddRaza.Text = "Agregar Raza";
            this.btnAddRaza.Click += new System.EventHandler(this.btnAddRaza_Click);
            // 
            // btnDeleteEspecie
            // 
            this.btnDeleteEspecie.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteEspecie.AnimationHoverSpeed = 0.07F;
            this.btnDeleteEspecie.AnimationSpeed = 0.03F;
            this.btnDeleteEspecie.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteEspecie.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(82)))), ((int)(((byte)(83)))));
            this.btnDeleteEspecie.BorderColor = System.Drawing.Color.Black;
            this.btnDeleteEspecie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteEspecie.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDeleteEspecie.FocusedColor = System.Drawing.Color.Empty;
            this.btnDeleteEspecie.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnDeleteEspecie.ForeColor = System.Drawing.Color.White;
            this.btnDeleteEspecie.Image = global::VeterinariaElBuenAmigo.Properties.Resources.delete;
            this.btnDeleteEspecie.ImageSize = new System.Drawing.Size(20, 20);
            this.btnDeleteEspecie.Location = new System.Drawing.Point(3, 60);
            this.btnDeleteEspecie.Name = "btnDeleteEspecie";
            this.btnDeleteEspecie.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(117)))));
            this.btnDeleteEspecie.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDeleteEspecie.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDeleteEspecie.OnHoverImage = null;
            this.btnDeleteEspecie.OnPressedColor = System.Drawing.Color.Black;
            this.btnDeleteEspecie.Radius = 5;
            this.btnDeleteEspecie.Size = new System.Drawing.Size(179, 35);
            this.btnDeleteEspecie.TabIndex = 36;
            this.btnDeleteEspecie.Text = "Eliminar  Especie";
            this.btnDeleteEspecie.Click += new System.EventHandler(this.btnDeleteEspecie_Click);
            // 
            // btnAddEspecie
            // 
            this.btnAddEspecie.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddEspecie.AnimationHoverSpeed = 0.07F;
            this.btnAddEspecie.AnimationSpeed = 0.03F;
            this.btnAddEspecie.BackColor = System.Drawing.Color.Transparent;
            this.btnAddEspecie.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.btnAddEspecie.BorderColor = System.Drawing.Color.Black;
            this.btnAddEspecie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddEspecie.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddEspecie.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddEspecie.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddEspecie.ForeColor = System.Drawing.Color.White;
            this.btnAddEspecie.Image = global::VeterinariaElBuenAmigo.Properties.Resources.add;
            this.btnAddEspecie.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAddEspecie.Location = new System.Drawing.Point(3, 3);
            this.btnAddEspecie.Name = "btnAddEspecie";
            this.btnAddEspecie.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(211)))));
            this.btnAddEspecie.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddEspecie.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAddEspecie.OnHoverImage = null;
            this.btnAddEspecie.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddEspecie.Radius = 5;
            this.btnAddEspecie.Size = new System.Drawing.Size(179, 35);
            this.btnAddEspecie.TabIndex = 35;
            this.btnAddEspecie.Text = "Agregar Especie";
            this.btnAddEspecie.Click += new System.EventHandler(this.btnAddEspecie_Click);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.FillWeight = 25F;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::VeterinariaElBuenAmigo.Properties.Resources.edit;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 82;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.FillWeight = 25F;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::VeterinariaElBuenAmigo.Properties.Resources.edit;
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.MinimumWidth = 6;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Width = 82;
            // 
            // FormConfiguracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(930, 690);
            this.Controls.Add(this.splitContainer2);
            this.Controls.Add(this.gunaSeparator1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtChangeKey);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.splitContainer1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormConfiguracion";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgRazas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgEspecies)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private Guna.UI.WinForms.GunaDataGridView dvgRazas;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaDataGridView dvgEspecies;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaTextBox txtChangeKey;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaButton btnAdd;
        private Guna.UI.WinForms.GunaSeparator gunaSeparator1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private Guna.UI.WinForms.GunaButton btnAddRaza;
        private Guna.UI.WinForms.GunaButton btnDeleteDelete;
        private Guna.UI.WinForms.GunaButton btnDeleteEspecie;
        private Guna.UI.WinForms.GunaButton btnAddEspecie;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewImageColumn ColumnEditEspecie;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnSelectEspecie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewImageColumn ColumnEditRaza;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnSelectRaza;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
    }
}