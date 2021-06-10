
namespace VeterinariaElBuenAmigo.views.pacientes
{
    partial class FormEditarMascota
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
            this.panelTop = new Guna.UI.WinForms.GunaPanel();
            this.btnMin = new FontAwesome.Sharp.IconButton();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEditMascota = new Guna.UI.WinForms.GunaButton();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNombreMascota1 = new Guna.UI.WinForms.GunaTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fechaMascota1 = new Guna.UI.WinForms.GunaDateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.animales_razas1 = new Guna.UI.WinForms.GunaComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.generMascota1 = new Guna.UI.WinForms.GunaComboBox();
            this.txtcolor1 = new Guna.UI.WinForms.GunaTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.especieMascota1 = new Guna.UI.WinForms.GunaComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.descripcionMascota1 = new Guna.UI.WinForms.GunaTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.id_client = new System.Windows.Forms.Label();
            this.genero_de_mascota = new System.Windows.Forms.Label();
            this.especie_de_mascota = new System.Windows.Forms.Label();
            this.rm = new System.Windows.Forms.Label();
            this.gunaResize1 = new Guna.UI.WinForms.GunaResize(this.components);
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.panelTop.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.panelTop.Controls.Add(this.btnMin);
            this.panelTop.Controls.Add(this.btnClose);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(778, 30);
            this.panelTop.TabIndex = 4;
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
            this.btnMin.Location = new System.Drawing.Point(698, 0);
            this.btnMin.Margin = new System.Windows.Forms.Padding(0);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(40, 30);
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
            this.btnClose.Location = new System.Drawing.Point(738, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 30);
            this.btnClose.TabIndex = 4;
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnEditMascota);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtNombreMascota1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.fechaMascota1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.animales_razas1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.generMascota1);
            this.panel1.Controls.Add(this.txtcolor1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.especieMascota1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.descripcionMascota1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(11, 77);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(727, 534);
            this.panel1.TabIndex = 59;
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
            this.btnEditMascota.Location = new System.Drawing.Point(41, 471);
            this.btnEditMascota.Name = "btnEditMascota";
            this.btnEditMascota.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(202)))), ((int)(((byte)(87)))));
            this.btnEditMascota.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnEditMascota.OnHoverForeColor = System.Drawing.Color.White;
            this.btnEditMascota.OnHoverImage = null;
            this.btnEditMascota.OnPressedColor = System.Drawing.Color.Black;
            this.btnEditMascota.Radius = 5;
            this.btnEditMascota.Size = new System.Drawing.Size(633, 35);
            this.btnEditMascota.TabIndex = 51;
            this.btnEditMascota.Text = "Editar";
            this.btnEditMascota.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnEditMascota.Click += new System.EventHandler(this.btnEditMascota_Click);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(384, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(209, 28);
            this.label8.TabIndex = 40;
            this.label8.Text = "Color";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNombreMascota1
            // 
            this.txtNombreMascota1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombreMascota1.BackColor = System.Drawing.Color.Transparent;
            this.txtNombreMascota1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.txtNombreMascota1.BorderColor = System.Drawing.Color.White;
            this.txtNombreMascota1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombreMascota1.FocusedBaseColor = System.Drawing.Color.White;
            this.txtNombreMascota1.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.txtNombreMascota1.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNombreMascota1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtNombreMascota1.ForeColor = System.Drawing.Color.White;
            this.txtNombreMascota1.Location = new System.Drawing.Point(42, 45);
            this.txtNombreMascota1.Name = "txtNombreMascota1";
            this.txtNombreMascota1.PasswordChar = '\0';
            this.txtNombreMascota1.Radius = 5;
            this.txtNombreMascota1.Size = new System.Drawing.Size(209, 42);
            this.txtNombreMascota1.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(38, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 28);
            this.label2.TabIndex = 25;
            this.label2.Text = "Nombre o Alias";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // fechaMascota1
            // 
            this.fechaMascota1.BackColor = System.Drawing.Color.Transparent;
            this.fechaMascota1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.fechaMascota1.BorderColor = System.Drawing.Color.White;
            this.fechaMascota1.CustomFormat = null;
            this.fechaMascota1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.fechaMascota1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.fechaMascota1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.fechaMascota1.ForeColor = System.Drawing.Color.White;
            this.fechaMascota1.Location = new System.Drawing.Point(388, 45);
            this.fechaMascota1.Margin = new System.Windows.Forms.Padding(2);
            this.fechaMascota1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.fechaMascota1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.fechaMascota1.Name = "fechaMascota1";
            this.fechaMascota1.OnHoverBaseColor = System.Drawing.Color.White;
            this.fechaMascota1.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.fechaMascota1.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.fechaMascota1.OnPressedColor = System.Drawing.Color.Black;
            this.fechaMascota1.Radius = 5;
            this.fechaMascota1.Size = new System.Drawing.Size(286, 42);
            this.fechaMascota1.TabIndex = 27;
            this.fechaMascota1.Text = "lunes, 7 de junio de 2021";
            this.fechaMascota1.Value = new System.DateTime(2021, 6, 7, 13, 4, 55, 439);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(384, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(404, 28);
            this.label3.TabIndex = 28;
            this.label3.Text = "Fecha de nacimimiento";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // animales_razas1
            // 
            this.animales_razas1.BackColor = System.Drawing.Color.Transparent;
            this.animales_razas1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.animales_razas1.BorderColor = System.Drawing.Color.White;
            this.animales_razas1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.animales_razas1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.animales_razas1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.animales_razas1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.animales_razas1.ForeColor = System.Drawing.Color.White;
            this.animales_razas1.FormattingEnabled = true;
            this.animales_razas1.Location = new System.Drawing.Point(386, 237);
            this.animales_razas1.Margin = new System.Windows.Forms.Padding(2);
            this.animales_razas1.Name = "animales_razas1";
            this.animales_razas1.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.animales_razas1.OnHoverItemForeColor = System.Drawing.Color.White;
            this.animales_razas1.Radius = 5;
            this.animales_razas1.Size = new System.Drawing.Size(288, 33);
            this.animales_razas1.TabIndex = 50;
            this.animales_razas1.SelectedIndexChanged += new System.EventHandler(this.animales_razas1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(38, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(299, 28);
            this.label4.TabIndex = 29;
            this.label4.Text = "Genero";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // generMascota1
            // 
            this.generMascota1.BackColor = System.Drawing.Color.Transparent;
            this.generMascota1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.generMascota1.BorderColor = System.Drawing.Color.White;
            this.generMascota1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.generMascota1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.generMascota1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.generMascota1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.generMascota1.ForeColor = System.Drawing.Color.White;
            this.generMascota1.FormattingEnabled = true;
            this.generMascota1.Items.AddRange(new object[] {
            "Macho",
            "Hembra"});
            this.generMascota1.Location = new System.Drawing.Point(42, 145);
            this.generMascota1.Margin = new System.Windows.Forms.Padding(2);
            this.generMascota1.Name = "generMascota1";
            this.generMascota1.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.generMascota1.OnHoverItemForeColor = System.Drawing.Color.White;
            this.generMascota1.Radius = 5;
            this.generMascota1.Size = new System.Drawing.Size(276, 33);
            this.generMascota1.TabIndex = 34;
            this.generMascota1.SelectedIndexChanged += new System.EventHandler(this.generMascota1_SelectedIndexChanged);
            // 
            // txtcolor1
            // 
            this.txtcolor1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtcolor1.BackColor = System.Drawing.Color.Transparent;
            this.txtcolor1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.txtcolor1.BorderColor = System.Drawing.Color.White;
            this.txtcolor1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcolor1.FocusedBaseColor = System.Drawing.Color.White;
            this.txtcolor1.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.txtcolor1.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtcolor1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtcolor1.ForeColor = System.Drawing.Color.White;
            this.txtcolor1.Location = new System.Drawing.Point(388, 145);
            this.txtcolor1.Name = "txtcolor1";
            this.txtcolor1.PasswordChar = '\0';
            this.txtcolor1.Radius = 5;
            this.txtcolor1.Size = new System.Drawing.Size(221, 35);
            this.txtcolor1.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(38, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(244, 28);
            this.label5.TabIndex = 30;
            this.label5.Text = "Especie";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // especieMascota1
            // 
            this.especieMascota1.BackColor = System.Drawing.Color.Transparent;
            this.especieMascota1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.especieMascota1.BorderColor = System.Drawing.Color.White;
            this.especieMascota1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.especieMascota1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.especieMascota1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.especieMascota1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.especieMascota1.ForeColor = System.Drawing.Color.White;
            this.especieMascota1.FormattingEnabled = true;
            this.especieMascota1.Location = new System.Drawing.Point(42, 232);
            this.especieMascota1.Margin = new System.Windows.Forms.Padding(2);
            this.especieMascota1.Name = "especieMascota1";
            this.especieMascota1.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.especieMascota1.OnHoverItemForeColor = System.Drawing.Color.White;
            this.especieMascota1.Radius = 5;
            this.especieMascota1.Size = new System.Drawing.Size(276, 33);
            this.especieMascota1.TabIndex = 35;
            this.especieMascota1.SelectedIndexChanged += new System.EventHandler(this.especieMascota1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(384, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 28);
            this.label6.TabIndex = 31;
            this.label6.Text = "Raza";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // descripcionMascota1
            // 
            this.descripcionMascota1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descripcionMascota1.BackColor = System.Drawing.Color.Transparent;
            this.descripcionMascota1.BaseColor = System.Drawing.Color.White;
            this.descripcionMascota1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(211)))));
            this.descripcionMascota1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.descripcionMascota1.FocusedBaseColor = System.Drawing.Color.White;
            this.descripcionMascota1.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.descripcionMascota1.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.descripcionMascota1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.descripcionMascota1.Location = new System.Drawing.Point(42, 319);
            this.descripcionMascota1.MultiLine = true;
            this.descripcionMascota1.Name = "descripcionMascota1";
            this.descripcionMascota1.PasswordChar = '\0';
            this.descripcionMascota1.Radius = 4;
            this.descripcionMascota1.Size = new System.Drawing.Size(632, 130);
            this.descripcionMascota1.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(38, 288);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(361, 28);
            this.label7.TabIndex = 32;
            this.label7.Text = "Caracteristicas Especiales";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(247, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 48);
            this.label1.TabIndex = 60;
            this.label1.Text = "Editar datos de paciente";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // id_client
            // 
            this.id_client.AutoSize = true;
            this.id_client.Location = new System.Drawing.Point(52, 56);
            this.id_client.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.id_client.Name = "id_client";
            this.id_client.Size = new System.Drawing.Size(35, 13);
            this.id_client.TabIndex = 61;
            this.id_client.Text = "label9";
            this.id_client.Visible = false;
            // 
            // genero_de_mascota
            // 
            this.genero_de_mascota.AutoSize = true;
            this.genero_de_mascota.Location = new System.Drawing.Point(52, 33);
            this.genero_de_mascota.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.genero_de_mascota.Name = "genero_de_mascota";
            this.genero_de_mascota.Size = new System.Drawing.Size(35, 13);
            this.genero_de_mascota.TabIndex = 62;
            this.genero_de_mascota.Text = "label9";
            this.genero_de_mascota.Visible = false;
            // 
            // especie_de_mascota
            // 
            this.especie_de_mascota.AutoSize = true;
            this.especie_de_mascota.Location = new System.Drawing.Point(710, 46);
            this.especie_de_mascota.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.especie_de_mascota.Name = "especie_de_mascota";
            this.especie_de_mascota.Size = new System.Drawing.Size(35, 13);
            this.especie_de_mascota.TabIndex = 63;
            this.especie_de_mascota.Text = "label9";
            this.especie_de_mascota.Visible = false;
            // 
            // rm
            // 
            this.rm.AutoSize = true;
            this.rm.Location = new System.Drawing.Point(710, 33);
            this.rm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.rm.Name = "rm";
            this.rm.Size = new System.Drawing.Size(35, 13);
            this.rm.TabIndex = 64;
            this.rm.Text = "label9";
            this.rm.Visible = false;
            // 
            // gunaResize1
            // 
            this.gunaResize1.TargetForm = this;
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this.panelTop;
            // 
            // FormEditarMascota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.ClientSize = new System.Drawing.Size(778, 640);
            this.Controls.Add(this.rm);
            this.Controls.Add(this.especie_de_mascota);
            this.Controls.Add(this.genero_de_mascota);
            this.Controls.Add(this.id_client);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormEditarMascota";
            this.Text = "FormEditarMascota";
            this.panelTop.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel panelTop;
        private FontAwesome.Sharp.IconButton btnMin;
        private FontAwesome.Sharp.IconButton btnClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private Guna.UI.WinForms.GunaTextBox txtNombreMascota1;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaDateTimePicker fechaMascota1;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaComboBox animales_razas1;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaComboBox generMascota1;
        private Guna.UI.WinForms.GunaTextBox txtcolor1;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaComboBox especieMascota1;
        private System.Windows.Forms.Label label6;
        private Guna.UI.WinForms.GunaTextBox descripcionMascota1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaButton btnEditMascota;
        private System.Windows.Forms.Label id_client;
        private System.Windows.Forms.Label genero_de_mascota;
        private System.Windows.Forms.Label especie_de_mascota;
        private System.Windows.Forms.Label rm;
        private Guna.UI.WinForms.GunaResize gunaResize1;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
    }
}