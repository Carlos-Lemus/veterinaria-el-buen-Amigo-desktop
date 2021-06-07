
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
            this.razaMascota = new Guna.UI.WinForms.GunaComboBox();
            this.descripcionMascota = new Guna.UI.WinForms.GunaTextBox();
            this.btnEditMascota = new Guna.UI.WinForms.GunaButton();
            this.btnAddMascota = new Guna.UI.WinForms.GunaButton();
            this.label8 = new System.Windows.Forms.Label();
            this.idEspe = new System.Windows.Forms.Label();
            this.idraza = new System.Windows.Forms.Label();
            this.txtcolor = new Guna.UI.WinForms.GunaTextBox();
            this.gener = new System.Windows.Forms.Label();
            this.idclienteActivo = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaResize1
            // 
            this.gunaResize1.TargetForm = this;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.panelTop.Controls.Add(this.btnMin);
            this.panelTop.Controls.Add(this.btnClose);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(4);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(800, 37);
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
            this.btnMin.Location = new System.Drawing.Point(694, 0);
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
            this.btnClose.Location = new System.Drawing.Point(747, 0);
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
            this.label2.Location = new System.Drawing.Point(132, 128);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(539, 34);
            this.label2.TabIndex = 25;
            this.label2.Text = "Nombre o Alias";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(201, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(407, 59);
            this.label1.TabIndex = 24;
            this.label1.Text = "Datos del propietario";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNombreMascota
            // 
            this.txtNombreMascota.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombreMascota.BackColor = System.Drawing.Color.Transparent;
            this.txtNombreMascota.BaseColor = System.Drawing.Color.White;
            this.txtNombreMascota.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(211)))));
            this.txtNombreMascota.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombreMascota.FocusedBaseColor = System.Drawing.Color.White;
            this.txtNombreMascota.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.txtNombreMascota.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNombreMascota.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtNombreMascota.Location = new System.Drawing.Point(136, 166);
            this.txtNombreMascota.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreMascota.Name = "txtNombreMascota";
            this.txtNombreMascota.PasswordChar = '\0';
            this.txtNombreMascota.Radius = 4;
            this.txtNombreMascota.Size = new System.Drawing.Size(533, 52);
            this.txtNombreMascota.TabIndex = 23;
            // 
            // fechaMascota
            // 
            this.fechaMascota.BaseColor = System.Drawing.Color.White;
            this.fechaMascota.BorderColor = System.Drawing.Color.Silver;
            this.fechaMascota.CustomFormat = null;
            this.fechaMascota.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.fechaMascota.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.fechaMascota.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.fechaMascota.ForeColor = System.Drawing.Color.Black;
            this.fechaMascota.Location = new System.Drawing.Point(137, 273);
            this.fechaMascota.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.fechaMascota.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.fechaMascota.Name = "fechaMascota";
            this.fechaMascota.OnHoverBaseColor = System.Drawing.Color.White;
            this.fechaMascota.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.fechaMascota.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.fechaMascota.OnPressedColor = System.Drawing.Color.Black;
            this.fechaMascota.Size = new System.Drawing.Size(532, 52);
            this.fechaMascota.TabIndex = 27;
            this.fechaMascota.Text = "lunes, 7 de junio de 2021";
            this.fechaMascota.Value = new System.DateTime(2021, 6, 7, 13, 4, 55, 439);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(132, 228);
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
            this.label4.Location = new System.Drawing.Point(132, 337);
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
            this.label5.Location = new System.Drawing.Point(131, 525);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(539, 34);
            this.label5.TabIndex = 30;
            this.label5.Text = "Especie";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(132, 628);
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
            this.label7.Location = new System.Drawing.Point(128, 725);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(539, 34);
            this.label7.TabIndex = 32;
            this.label7.Text = "Caracteristicas Especiales";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // generMascota
            // 
            this.generMascota.BackColor = System.Drawing.Color.Transparent;
            this.generMascota.BaseColor = System.Drawing.Color.White;
            this.generMascota.BorderColor = System.Drawing.Color.Silver;
            this.generMascota.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.generMascota.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.generMascota.FocusedColor = System.Drawing.Color.Empty;
            this.generMascota.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.generMascota.ForeColor = System.Drawing.Color.Black;
            this.generMascota.FormattingEnabled = true;
            this.generMascota.Items.AddRange(new object[] {
            "Seleccionar",
            "Macho",
            "Hembra"});
            this.generMascota.Location = new System.Drawing.Point(137, 377);
            this.generMascota.Name = "generMascota";
            this.generMascota.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.generMascota.OnHoverItemForeColor = System.Drawing.Color.White;
            this.generMascota.Size = new System.Drawing.Size(534, 48);
            this.generMascota.TabIndex = 34;
            this.generMascota.SelectedIndexChanged += new System.EventHandler(this.generMascota_SelectedIndexChanged);
            // 
            // especieMascota
            // 
            this.especieMascota.BackColor = System.Drawing.Color.Transparent;
            this.especieMascota.BaseColor = System.Drawing.Color.White;
            this.especieMascota.BorderColor = System.Drawing.Color.Silver;
            this.especieMascota.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.especieMascota.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.especieMascota.FocusedColor = System.Drawing.Color.Empty;
            this.especieMascota.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.especieMascota.ForeColor = System.Drawing.Color.Black;
            this.especieMascota.FormattingEnabled = true;
            this.especieMascota.Location = new System.Drawing.Point(137, 562);
            this.especieMascota.Name = "especieMascota";
            this.especieMascota.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.especieMascota.OnHoverItemForeColor = System.Drawing.Color.White;
            this.especieMascota.Size = new System.Drawing.Size(534, 48);
            this.especieMascota.TabIndex = 35;
            this.especieMascota.SelectedIndexChanged += new System.EventHandler(this.especieMascota_SelectedIndexChanged);
            // 
            // razaMascota
            // 
            this.razaMascota.BackColor = System.Drawing.Color.Transparent;
            this.razaMascota.BaseColor = System.Drawing.Color.White;
            this.razaMascota.BorderColor = System.Drawing.Color.Silver;
            this.razaMascota.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.razaMascota.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.razaMascota.FocusedColor = System.Drawing.Color.Empty;
            this.razaMascota.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.razaMascota.ForeColor = System.Drawing.Color.Black;
            this.razaMascota.FormattingEnabled = true;
            this.razaMascota.Location = new System.Drawing.Point(137, 665);
            this.razaMascota.Name = "razaMascota";
            this.razaMascota.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.razaMascota.OnHoverItemForeColor = System.Drawing.Color.White;
            this.razaMascota.Size = new System.Drawing.Size(534, 48);
            this.razaMascota.TabIndex = 36;
            this.razaMascota.SelectedIndexChanged += new System.EventHandler(this.razaMascota_SelectedIndexChanged);
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
            this.descripcionMascota.Location = new System.Drawing.Point(136, 764);
            this.descripcionMascota.Margin = new System.Windows.Forms.Padding(4);
            this.descripcionMascota.Name = "descripcionMascota";
            this.descripcionMascota.PasswordChar = '\0';
            this.descripcionMascota.Radius = 4;
            this.descripcionMascota.Size = new System.Drawing.Size(533, 183);
            this.descripcionMascota.TabIndex = 37;
            // 
            // btnEditMascota
            // 
            this.btnEditMascota.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditMascota.AnimationHoverSpeed = 0.07F;
            this.btnEditMascota.AnimationSpeed = 0.03F;
            this.btnEditMascota.BackColor = System.Drawing.Color.Transparent;
            this.btnEditMascota.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(67)))));
            this.btnEditMascota.BorderColor = System.Drawing.Color.Black;
            this.btnEditMascota.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditMascota.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEditMascota.FocusedColor = System.Drawing.Color.Empty;
            this.btnEditMascota.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnEditMascota.ForeColor = System.Drawing.Color.White;
            this.btnEditMascota.Image = null;
            this.btnEditMascota.ImageSize = new System.Drawing.Size(20, 20);
            this.btnEditMascota.Location = new System.Drawing.Point(136, 1006);
            this.btnEditMascota.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditMascota.Name = "btnEditMascota";
            this.btnEditMascota.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(211)))));
            this.btnEditMascota.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnEditMascota.OnHoverForeColor = System.Drawing.Color.White;
            this.btnEditMascota.OnHoverImage = null;
            this.btnEditMascota.OnPressedColor = System.Drawing.Color.Black;
            this.btnEditMascota.Radius = 5;
            this.btnEditMascota.Size = new System.Drawing.Size(533, 43);
            this.btnEditMascota.TabIndex = 39;
            this.btnEditMascota.Text = "Editar";
            this.btnEditMascota.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAddMascota
            // 
            this.btnAddMascota.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddMascota.AnimationHoverSpeed = 0.07F;
            this.btnAddMascota.AnimationSpeed = 0.03F;
            this.btnAddMascota.BackColor = System.Drawing.Color.Transparent;
            this.btnAddMascota.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.btnAddMascota.BorderColor = System.Drawing.Color.Black;
            this.btnAddMascota.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddMascota.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddMascota.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddMascota.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddMascota.ForeColor = System.Drawing.Color.White;
            this.btnAddMascota.Image = null;
            this.btnAddMascota.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAddMascota.Location = new System.Drawing.Point(137, 955);
            this.btnAddMascota.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddMascota.Name = "btnAddMascota";
            this.btnAddMascota.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(211)))));
            this.btnAddMascota.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddMascota.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAddMascota.OnHoverImage = null;
            this.btnAddMascota.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddMascota.Radius = 5;
            this.btnAddMascota.Size = new System.Drawing.Size(533, 43);
            this.btnAddMascota.TabIndex = 38;
            this.btnAddMascota.Text = "Guardar";
            this.btnAddMascota.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddMascota.Click += new System.EventHandler(this.btnAddMascota_Click);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(131, 432);
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
            this.idEspe.Location = new System.Drawing.Point(683, 342);
            this.idEspe.Name = "idEspe";
            this.idEspe.Size = new System.Drawing.Size(46, 17);
            this.idEspe.TabIndex = 42;
            this.idEspe.Text = "label9";
            // 
            // idraza
            // 
            this.idraza.AutoSize = true;
            this.idraza.Location = new System.Drawing.Point(691, 428);
            this.idraza.Name = "idraza";
            this.idraza.Size = new System.Drawing.Size(54, 17);
            this.idraza.TabIndex = 43;
            this.idraza.Text = "label10";
            // 
            // txtcolor
            // 
            this.txtcolor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtcolor.BackColor = System.Drawing.Color.Transparent;
            this.txtcolor.BaseColor = System.Drawing.Color.White;
            this.txtcolor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(211)))));
            this.txtcolor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcolor.FocusedBaseColor = System.Drawing.Color.White;
            this.txtcolor.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.txtcolor.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtcolor.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtcolor.Location = new System.Drawing.Point(136, 468);
            this.txtcolor.Margin = new System.Windows.Forms.Padding(4);
            this.txtcolor.Name = "txtcolor";
            this.txtcolor.PasswordChar = '\0';
            this.txtcolor.Radius = 4;
            this.txtcolor.Size = new System.Drawing.Size(533, 52);
            this.txtcolor.TabIndex = 44;
            // 
            // gener
            // 
            this.gener.AutoSize = true;
            this.gener.Location = new System.Drawing.Point(646, 94);
            this.gener.Name = "gener";
            this.gener.Size = new System.Drawing.Size(46, 17);
            this.gener.TabIndex = 45;
            this.gener.Text = "label9";
            // 
            // idclienteActivo
            // 
            this.idclienteActivo.AutoSize = true;
            this.idclienteActivo.Location = new System.Drawing.Point(46, 73);
            this.idclienteActivo.Name = "idclienteActivo";
            this.idclienteActivo.Size = new System.Drawing.Size(46, 17);
            this.idclienteActivo.TabIndex = 46;
            this.idclienteActivo.Text = "label9";
            // 
            // FormGuardarMascota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 1102);
            this.Controls.Add(this.idclienteActivo);
            this.Controls.Add(this.gener);
            this.Controls.Add(this.txtcolor);
            this.Controls.Add(this.idraza);
            this.Controls.Add(this.idEspe);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnEditMascota);
            this.Controls.Add(this.btnAddMascota);
            this.Controls.Add(this.descripcionMascota);
            this.Controls.Add(this.razaMascota);
            this.Controls.Add(this.especieMascota);
            this.Controls.Add(this.generMascota);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fechaMascota);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombreMascota);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGuardarMascota";
            this.Text = "FormGuardarMascota";
            this.panelTop.ResumeLayout(false);
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
        private Guna.UI.WinForms.GunaComboBox razaMascota;
        private Guna.UI.WinForms.GunaComboBox especieMascota;
        private Guna.UI.WinForms.GunaComboBox generMascota;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaDateTimePicker fechaMascota;
        private Guna.UI.WinForms.GunaButton btnEditMascota;
        private Guna.UI.WinForms.GunaButton btnAddMascota;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label idEspe;
        private System.Windows.Forms.Label idraza;
        private Guna.UI.WinForms.GunaTextBox txtcolor;
        private System.Windows.Forms.Label gener;
        private System.Windows.Forms.Label idclienteActivo;
    }
}