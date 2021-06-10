
namespace VeterinariaElBuenAmigo.views.pacientes
{
    partial class FormGuardarMascota
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
            this.gunaResize1 = new Guna.UI.WinForms.GunaResize(this.components);
            this.panelTop = new Guna.UI.WinForms.GunaPanel();
            this.btnMin = new FontAwesome.Sharp.IconButton();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreMascota = new Guna.UI.WinForms.GunaTextBox();
            this.fechaMascota = new Guna.UI.WinForms.GunaDateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.generMascota = new Guna.UI.WinForms.GunaComboBox();
            this.especieMascota = new Guna.UI.WinForms.GunaComboBox();
            this.descripcionMascota = new Guna.UI.WinForms.GunaTextBox();
            this.btnAddMascota = new Guna.UI.WinForms.GunaButton();
            this.label8 = new System.Windows.Forms.Label();
            this.idEspe = new System.Windows.Forms.Label();
            this.txtcolor = new Guna.UI.WinForms.GunaTextBox();
            this.gener = new System.Windows.Forms.Label();
            this.idclienteActivo = new System.Windows.Forms.Label();
            this.animales_razas = new Guna.UI.WinForms.GunaComboBox();
            this.animal_raza = new System.Windows.Forms.Label();
            this.dgvDatosPropietarios = new Guna.UI.WinForms.GunaDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearch = new Guna.UI.WinForms.GunaButton();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSearch = new Guna.UI.WinForms.GunaTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosPropietarios)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaResize1
            // 
            this.gunaResize1.TargetForm = this;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.panelTop.Controls.Add(this.btnMin);
            this.panelTop.Controls.Add(this.btnClose);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(4);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1940, 37);
            this.panelTop.TabIndex = 3;
            // 
            // btnMin
            // 
            this.btnMin.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMin.IconColor = System.Drawing.Color.White;
            this.btnMin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMin.IconSize = 32;
            this.btnMin.Location = new System.Drawing.Point(1834, 0);
            this.btnMin.Margin = new System.Windows.Forms.Padding(0);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(53, 37);
            this.btnMin.TabIndex = 11;
            this.btnMin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btnClose.IconColor = System.Drawing.Color.White;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 32;
            this.btnClose.Location = new System.Drawing.Point(1887, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(53, 37);
            this.btnClose.TabIndex = 4;
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this.panelTop;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(61, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 34);
            this.label2.TabIndex = 25;
            this.label2.Text = "Nombre o Alias";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(491, 83);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(970, 59);
            this.label1.TabIndex = 24;
            this.label1.Text = "Datos de paciente";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNombreMascota
            // 
            this.txtNombreMascota.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombreMascota.BackColor = System.Drawing.Color.Transparent;
            this.txtNombreMascota.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.txtNombreMascota.BorderColor = System.Drawing.Color.White;
            this.txtNombreMascota.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombreMascota.FocusedBaseColor = System.Drawing.Color.White;
            this.txtNombreMascota.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.txtNombreMascota.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNombreMascota.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtNombreMascota.ForeColor = System.Drawing.Color.White;
            this.txtNombreMascota.Location = new System.Drawing.Point(63, 145);
            this.txtNombreMascota.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreMascota.Name = "txtNombreMascota";
            this.txtNombreMascota.PasswordChar = '\0';
            this.txtNombreMascota.Radius = 5;
            this.txtNombreMascota.Size = new System.Drawing.Size(363, 52);
            this.txtNombreMascota.TabIndex = 23;
            // 
            // fechaMascota
            // 
            this.fechaMascota.BackColor = System.Drawing.Color.Transparent;
            this.fechaMascota.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.fechaMascota.BorderColor = System.Drawing.Color.White;
            this.fechaMascota.CustomFormat = null;
            this.fechaMascota.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.fechaMascota.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.fechaMascota.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.fechaMascota.ForeColor = System.Drawing.Color.White;
            this.fechaMascota.Location = new System.Drawing.Point(474, 145);
            this.fechaMascota.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fechaMascota.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.fechaMascota.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.fechaMascota.Name = "fechaMascota";
            this.fechaMascota.OnHoverBaseColor = System.Drawing.Color.White;
            this.fechaMascota.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.fechaMascota.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.fechaMascota.OnPressedColor = System.Drawing.Color.Black;
            this.fechaMascota.Radius = 5;
            this.fechaMascota.Size = new System.Drawing.Size(523, 52);
            this.fechaMascota.TabIndex = 27;
            this.fechaMascota.Text = "lunes, 7 de junio de 2021";
            this.fechaMascota.Value = new System.DateTime(2021, 6, 7, 13, 4, 55, 439);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(469, 100);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(539, 34);
            this.label3.TabIndex = 28;
            this.label3.Text = "Fecha de nacimimiento";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(59, 218);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(539, 34);
            this.label4.TabIndex = 29;
            this.label4.Text = "Genero";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(61, 331);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(325, 34);
            this.label5.TabIndex = 30;
            this.label5.Text = "Especie";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(469, 331);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(539, 34);
            this.label6.TabIndex = 31;
            this.label6.Text = "Raza";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(58, 442);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(481, 34);
            this.label7.TabIndex = 32;
            this.label7.Text = "Caracteristicas Especiales";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // generMascota
            // 
            this.generMascota.BackColor = System.Drawing.Color.Transparent;
            this.generMascota.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.generMascota.BorderColor = System.Drawing.Color.White;
            this.generMascota.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.generMascota.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.generMascota.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.generMascota.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.generMascota.ForeColor = System.Drawing.Color.White;
            this.generMascota.FormattingEnabled = true;
            this.generMascota.Items.AddRange(new object[] {
            "Macho",
            "Hembra"});
            this.generMascota.Location = new System.Drawing.Point(63, 263);
            this.generMascota.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.generMascota.Name = "generMascota";
            this.generMascota.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.generMascota.OnHoverItemForeColor = System.Drawing.Color.White;
            this.generMascota.Radius = 5;
            this.generMascota.Size = new System.Drawing.Size(367, 40);
            this.generMascota.TabIndex = 34;
            this.generMascota.SelectedIndexChanged += new System.EventHandler(this.generMascota_SelectedIndexChanged);
            // 
            // especieMascota
            // 
            this.especieMascota.BackColor = System.Drawing.Color.Transparent;
            this.especieMascota.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.especieMascota.BorderColor = System.Drawing.Color.White;
            this.especieMascota.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.especieMascota.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.especieMascota.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.especieMascota.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.especieMascota.ForeColor = System.Drawing.Color.White;
            this.especieMascota.FormattingEnabled = true;
            this.especieMascota.Location = new System.Drawing.Point(63, 375);
            this.especieMascota.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.especieMascota.Name = "especieMascota";
            this.especieMascota.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.especieMascota.OnHoverItemForeColor = System.Drawing.Color.White;
            this.especieMascota.Radius = 5;
            this.especieMascota.Size = new System.Drawing.Size(367, 40);
            this.especieMascota.TabIndex = 35;
            this.especieMascota.SelectedIndexChanged += new System.EventHandler(this.especieMascota_SelectedIndexChanged);
            // 
            // descripcionMascota
            // 
            this.descripcionMascota.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descripcionMascota.BackColor = System.Drawing.Color.Transparent;
            this.descripcionMascota.BaseColor = System.Drawing.Color.White;
            this.descripcionMascota.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(211)))));
            this.descripcionMascota.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.descripcionMascota.FocusedBaseColor = System.Drawing.Color.White;
            this.descripcionMascota.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.descripcionMascota.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.descripcionMascota.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.descripcionMascota.Location = new System.Drawing.Point(63, 493);
            this.descripcionMascota.Margin = new System.Windows.Forms.Padding(4);
            this.descripcionMascota.MultiLine = true;
            this.descripcionMascota.Name = "descripcionMascota";
            this.descripcionMascota.PasswordChar = '\0';
            this.descripcionMascota.Radius = 4;
            this.descripcionMascota.Size = new System.Drawing.Size(925, 184);
            this.descripcionMascota.TabIndex = 37;
            // 
            // btnAddMascota
            // 
            this.btnAddMascota.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddMascota.AnimationHoverSpeed = 0.07F;
            this.btnAddMascota.AnimationSpeed = 0.03F;
            this.btnAddMascota.BackColor = System.Drawing.Color.Transparent;
            this.btnAddMascota.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.btnAddMascota.BorderColor = System.Drawing.Color.Black;
            this.btnAddMascota.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddMascota.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddMascota.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddMascota.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddMascota.ForeColor = System.Drawing.Color.White;
            this.btnAddMascota.Image = null;
            this.btnAddMascota.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAddMascota.Location = new System.Drawing.Point(62, 734);
            this.btnAddMascota.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddMascota.Name = "btnAddMascota";
            this.btnAddMascota.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(211)))));
            this.btnAddMascota.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddMascota.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAddMascota.OnHoverImage = null;
            this.btnAddMascota.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddMascota.Radius = 5;
            this.btnAddMascota.Size = new System.Drawing.Size(929, 43);
            this.btnAddMascota.TabIndex = 38;
            this.btnAddMascota.Text = "Guardar";
            this.btnAddMascota.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddMascota.Click += new System.EventHandler(this.btnAddMascota_Click);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(469, 218);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(539, 34);
            this.label8.TabIndex = 40;
            this.label8.Text = "Color";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // idEspe
            // 
            this.idEspe.AutoSize = true;
            this.idEspe.Location = new System.Drawing.Point(292, 41);
            this.idEspe.Name = "idEspe";
            this.idEspe.Size = new System.Drawing.Size(46, 17);
            this.idEspe.TabIndex = 42;
            this.idEspe.Text = "label9";
            this.idEspe.Visible = false;
            // 
            // txtcolor
            // 
            this.txtcolor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtcolor.BackColor = System.Drawing.Color.Transparent;
            this.txtcolor.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.txtcolor.BorderColor = System.Drawing.Color.White;
            this.txtcolor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcolor.FocusedBaseColor = System.Drawing.Color.White;
            this.txtcolor.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.txtcolor.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtcolor.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtcolor.ForeColor = System.Drawing.Color.White;
            this.txtcolor.Location = new System.Drawing.Point(473, 263);
            this.txtcolor.Margin = new System.Windows.Forms.Padding(4);
            this.txtcolor.Name = "txtcolor";
            this.txtcolor.PasswordChar = '\0';
            this.txtcolor.Radius = 5;
            this.txtcolor.Size = new System.Drawing.Size(520, 42);
            this.txtcolor.TabIndex = 44;
            // 
            // gener
            // 
            this.gener.AutoSize = true;
            this.gener.Location = new System.Drawing.Point(1211, 41);
            this.gener.Name = "gener";
            this.gener.Size = new System.Drawing.Size(46, 17);
            this.gener.TabIndex = 45;
            this.gener.Text = "label9";
            this.gener.Visible = false;
            // 
            // idclienteActivo
            // 
            this.idclienteActivo.AutoSize = true;
            this.idclienteActivo.Location = new System.Drawing.Point(12, 41);
            this.idclienteActivo.Name = "idclienteActivo";
            this.idclienteActivo.Size = new System.Drawing.Size(46, 17);
            this.idclienteActivo.TabIndex = 46;
            this.idclienteActivo.Text = "label9";
            this.idclienteActivo.Visible = false;
            // 
            // animales_razas
            // 
            this.animales_razas.BackColor = System.Drawing.Color.Transparent;
            this.animales_razas.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.animales_razas.BorderColor = System.Drawing.Color.White;
            this.animales_razas.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.animales_razas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.animales_razas.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.animales_razas.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.animales_razas.ForeColor = System.Drawing.Color.White;
            this.animales_razas.FormattingEnabled = true;
            this.animales_razas.Location = new System.Drawing.Point(473, 375);
            this.animales_razas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.animales_razas.Name = "animales_razas";
            this.animales_razas.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.animales_razas.OnHoverItemForeColor = System.Drawing.Color.White;
            this.animales_razas.Radius = 5;
            this.animales_razas.Size = new System.Drawing.Size(520, 40);
            this.animales_razas.TabIndex = 50;
            this.animales_razas.SelectedIndexChanged += new System.EventHandler(this.animales_razas_SelectedIndexChanged);
            // 
            // animal_raza
            // 
            this.animal_raza.AutoSize = true;
            this.animal_raza.Location = new System.Drawing.Point(941, 41);
            this.animal_raza.Name = "animal_raza";
            this.animal_raza.Size = new System.Drawing.Size(54, 17);
            this.animal_raza.TabIndex = 52;
            this.animal_raza.Text = "label10";
            this.animal_raza.Visible = false;
            // 
            // dgvDatosPropietarios
            // 
            this.dgvDatosPropietarios.AllowUserToAddRows = false;
            this.dgvDatosPropietarios.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(223)))), ((int)(((byte)(219)))));
            this.dgvDatosPropietarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDatosPropietarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDatosPropietarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDatosPropietarios.BackgroundColor = System.Drawing.Color.White;
            this.dgvDatosPropietarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDatosPropietarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDatosPropietarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDatosPropietarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDatosPropietarios.ColumnHeadersHeight = 40;
            this.dgvDatosPropietarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(233)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 14F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(185)))), ((int)(((byte)(175)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDatosPropietarios.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDatosPropietarios.EnableHeadersVisualStyles = false;
            this.dgvDatosPropietarios.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(222)))), ((int)(((byte)(218)))));
            this.dgvDatosPropietarios.Location = new System.Drawing.Point(68, 255);
            this.dgvDatosPropietarios.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDatosPropietarios.Name = "dgvDatosPropietarios";
            this.dgvDatosPropietarios.RowHeadersVisible = false;
            this.dgvDatosPropietarios.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvDatosPropietarios.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDatosPropietarios.RowTemplate.Height = 40;
            this.dgvDatosPropietarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatosPropietarios.Size = new System.Drawing.Size(715, 745);
            this.dgvDatosPropietarios.TabIndex = 53;
            this.dgvDatosPropietarios.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Teal;
            this.dgvDatosPropietarios.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(223)))), ((int)(((byte)(219)))));
            this.dgvDatosPropietarios.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvDatosPropietarios.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvDatosPropietarios.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvDatosPropietarios.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvDatosPropietarios.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvDatosPropietarios.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(222)))), ((int)(((byte)(218)))));
            this.dgvDatosPropietarios.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.dgvDatosPropietarios.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDatosPropietarios.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.dgvDatosPropietarios.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDatosPropietarios.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvDatosPropietarios.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvDatosPropietarios.ThemeStyle.ReadOnly = false;
            this.dgvDatosPropietarios.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(233)))), ((int)(((byte)(231)))));
            this.dgvDatosPropietarios.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDatosPropietarios.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.dgvDatosPropietarios.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvDatosPropietarios.ThemeStyle.RowsStyle.Height = 40;
            this.dgvDatosPropietarios.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(185)))), ((int)(((byte)(175)))));
            this.dgvDatosPropietarios.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvDatosPropietarios.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatosPropietarios_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.FillWeight = 50F;
            this.Column1.HeaderText = "Id";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 150F;
            this.Column2.HeaderText = "Nombre y Apellido";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // btnSearch
            // 
            this.btnSearch.AnimationHoverSpeed = 0.07F;
            this.btnSearch.AnimationSpeed = 0.03F;
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.btnSearch.BorderColor = System.Drawing.Color.Black;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSearch.FocusedColor = System.Drawing.Color.Empty;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = global::VeterinariaElBuenAmigo.Properties.Resources.search;
            this.btnSearch.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSearch.Location = new System.Drawing.Point(571, 177);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.btnSearch.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSearch.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSearch.OnHoverImage = null;
            this.btnSearch.OnPressedColor = System.Drawing.Color.Black;
            this.btnSearch.Radius = 5;
            this.btnSearch.Size = new System.Drawing.Size(212, 49);
            this.btnSearch.TabIndex = 56;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(63, 189);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 40);
            this.label9.TabIndex = 55;
            this.label9.Text = "Nombre";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.Transparent;
            this.txtSearch.BaseColor = System.Drawing.Color.White;
            this.txtSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(211)))));
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.FocusedBaseColor = System.Drawing.Color.White;
            this.txtSearch.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.txtSearch.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtSearch.Location = new System.Drawing.Point(187, 177);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.Radius = 4;
            this.txtSearch.Size = new System.Drawing.Size(376, 49);
            this.txtSearch.TabIndex = 54;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtNombreMascota);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.fechaMascota);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.animales_razas);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.generMascota);
            this.panel1.Controls.Add(this.txtcolor);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.especieMascota);
            this.panel1.Controls.Add(this.btnAddMascota);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.descripcionMascota);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(809, 180);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1068, 823);
            this.panel1.TabIndex = 57;
            // 
            // FormGuardarMascota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.ClientSize = new System.Drawing.Size(1940, 1100);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvDatosPropietarios);
            this.Controls.Add(this.animal_raza);
            this.Controls.Add(this.idclienteActivo);
            this.Controls.Add(this.gener);
            this.Controls.Add(this.idEspe);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormGuardarMascota";
            this.Text = "FormGuardarMascota";
            this.panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosPropietarios)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaResize gunaResize1;
        private Guna.UI.WinForms.GunaPanel panelTop;
        private FontAwesome.Sharp.IconButton btnMin;
        private FontAwesome.Sharp.IconButton btnClose;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaTextBox txtNombreMascota;
        private Guna.UI.WinForms.GunaTextBox descripcionMascota;
        private Guna.UI.WinForms.GunaComboBox especieMascota;
        private Guna.UI.WinForms.GunaComboBox generMascota;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaDateTimePicker fechaMascota;
        private Guna.UI.WinForms.GunaButton btnAddMascota;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label idEspe;
        private Guna.UI.WinForms.GunaTextBox txtcolor;
        private System.Windows.Forms.Label gener;
        private System.Windows.Forms.Label idclienteActivo;
        private System.Windows.Forms.Label animal_raza;
        private Guna.UI.WinForms.GunaComboBox animales_razas;
        private Guna.UI.WinForms.GunaDataGridView dgvDatosPropietarios;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaButton btnSearch;
        private System.Windows.Forms.Label label9;
        private Guna.UI.WinForms.GunaTextBox txtSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}