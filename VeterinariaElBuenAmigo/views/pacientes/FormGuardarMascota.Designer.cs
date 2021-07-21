
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaResize1 = new Guna.UI.WinForms.GunaResize(this.components);
            this.panelTop = new Guna.UI.WinForms.GunaPanel();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.label2 = new System.Windows.Forms.Label();
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
            this.txtcolor = new Guna.UI.WinForms.GunaTextBox();
            this.animales_razas = new Guna.UI.WinForms.GunaComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSearch = new Guna.UI.WinForms.GunaTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblErrorDescripcion = new System.Windows.Forms.Label();
            this.lblErrorColor = new System.Windows.Forms.Label();
            this.lblErrorNombre = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvDatosPropietarios = new Guna.UI.WinForms.GunaDataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosPropietarios)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaResize1
            // 
            this.gunaResize1.TargetForm = this;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1289, 20);
            this.panelTop.TabIndex = 3;
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this.panelTop;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.label2.Location = new System.Drawing.Point(42, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 28);
            this.label2.TabIndex = 25;
            this.label2.Text = "Nombre o Alias";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.txtNombreMascota.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.txtNombreMascota.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtNombreMascota.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.txtNombreMascota.Location = new System.Drawing.Point(43, 53);
            this.txtNombreMascota.Name = "txtNombreMascota";
            this.txtNombreMascota.PasswordChar = '\0';
            this.txtNombreMascota.Radius = 5;
            this.txtNombreMascota.Size = new System.Drawing.Size(280, 42);
            this.txtNombreMascota.TabIndex = 23;
            // 
            // fechaMascota
            // 
            this.fechaMascota.BackColor = System.Drawing.Color.Transparent;
            this.fechaMascota.BaseColor = System.Drawing.Color.White;
            this.fechaMascota.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(211)))));
            this.fechaMascota.CustomFormat = null;
            this.fechaMascota.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.fechaMascota.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.fechaMascota.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.fechaMascota.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.fechaMascota.Location = new System.Drawing.Point(352, 53);
            this.fechaMascota.Margin = new System.Windows.Forms.Padding(2);
            this.fechaMascota.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.fechaMascota.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.fechaMascota.Name = "fechaMascota";
            this.fechaMascota.OnHoverBaseColor = System.Drawing.Color.White;
            this.fechaMascota.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.fechaMascota.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.fechaMascota.OnPressedColor = System.Drawing.Color.Black;
            this.fechaMascota.Radius = 5;
            this.fechaMascota.Size = new System.Drawing.Size(368, 42);
            this.fechaMascota.TabIndex = 24;
            this.fechaMascota.Text = "lunes, 7 de junio de 2021";
            this.fechaMascota.Value = new System.DateTime(2021, 6, 7, 13, 4, 55, 439);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.label3.Location = new System.Drawing.Point(348, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(404, 28);
            this.label3.TabIndex = 28;
            this.label3.Text = "Fecha de nacimimiento";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.label4.Location = new System.Drawing.Point(44, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(279, 28);
            this.label4.TabIndex = 29;
            this.label4.Text = "Genero";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.label5.Location = new System.Drawing.Point(46, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 28);
            this.label5.TabIndex = 30;
            this.label5.Text = "Especie";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.label6.Location = new System.Drawing.Point(352, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(368, 28);
            this.label6.TabIndex = 31;
            this.label6.Text = "Raza";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.label7.Location = new System.Drawing.Point(44, 306);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(361, 28);
            this.label7.TabIndex = 32;
            this.label7.Text = "Caracteristicas Especiales";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // generMascota
            // 
            this.generMascota.BackColor = System.Drawing.Color.Transparent;
            this.generMascota.BaseColor = System.Drawing.Color.White;
            this.generMascota.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(211)))));
            this.generMascota.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.generMascota.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.generMascota.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.generMascota.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.generMascota.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.generMascota.FormattingEnabled = true;
            this.generMascota.Items.AddRange(new object[] {
            "Macho",
            "Hembra"});
            this.generMascota.Location = new System.Drawing.Point(47, 154);
            this.generMascota.Margin = new System.Windows.Forms.Padding(2);
            this.generMascota.Name = "generMascota";
            this.generMascota.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.generMascota.OnHoverItemForeColor = System.Drawing.Color.White;
            this.generMascota.Radius = 5;
            this.generMascota.Size = new System.Drawing.Size(276, 33);
            this.generMascota.TabIndex = 25;
            this.generMascota.SelectedIndexChanged += new System.EventHandler(this.generMascota_SelectedIndexChanged);
            // 
            // especieMascota
            // 
            this.especieMascota.BackColor = System.Drawing.Color.Transparent;
            this.especieMascota.BaseColor = System.Drawing.Color.White;
            this.especieMascota.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(211)))));
            this.especieMascota.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.especieMascota.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.especieMascota.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.especieMascota.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.especieMascota.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.especieMascota.FormattingEnabled = true;
            this.especieMascota.Location = new System.Drawing.Point(47, 245);
            this.especieMascota.Margin = new System.Windows.Forms.Padding(2);
            this.especieMascota.Name = "especieMascota";
            this.especieMascota.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.especieMascota.OnHoverItemForeColor = System.Drawing.Color.White;
            this.especieMascota.Radius = 5;
            this.especieMascota.Size = new System.Drawing.Size(276, 33);
            this.especieMascota.TabIndex = 27;
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
            this.descripcionMascota.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.descripcionMascota.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.descripcionMascota.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.descripcionMascota.Location = new System.Drawing.Point(47, 348);
            this.descripcionMascota.MultiLine = true;
            this.descripcionMascota.Name = "descripcionMascota";
            this.descripcionMascota.PasswordChar = '\0';
            this.descripcionMascota.Radius = 4;
            this.descripcionMascota.Size = new System.Drawing.Size(671, 173);
            this.descripcionMascota.TabIndex = 29;
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
            this.btnAddMascota.Location = new System.Drawing.Point(256, 547);
            this.btnAddMascota.Name = "btnAddMascota";
            this.btnAddMascota.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.btnAddMascota.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddMascota.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAddMascota.OnHoverImage = null;
            this.btnAddMascota.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddMascota.Radius = 5;
            this.btnAddMascota.Size = new System.Drawing.Size(269, 42);
            this.btnAddMascota.TabIndex = 38;
            this.btnAddMascota.Text = "Guardar";
            this.btnAddMascota.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddMascota.Click += new System.EventHandler(this.btnAddMascota_Click);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.label8.Location = new System.Drawing.Point(352, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(404, 28);
            this.label8.TabIndex = 40;
            this.label8.Text = "Color";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.txtcolor.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.txtcolor.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtcolor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.txtcolor.Location = new System.Drawing.Point(355, 154);
            this.txtcolor.Name = "txtcolor";
            this.txtcolor.PasswordChar = '\0';
            this.txtcolor.Radius = 5;
            this.txtcolor.Size = new System.Drawing.Size(367, 35);
            this.txtcolor.TabIndex = 26;
            // 
            // animales_razas
            // 
            this.animales_razas.BackColor = System.Drawing.Color.Transparent;
            this.animales_razas.BaseColor = System.Drawing.Color.White;
            this.animales_razas.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(211)))));
            this.animales_razas.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.animales_razas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.animales_razas.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.animales_razas.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.animales_razas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.animales_razas.FormattingEnabled = true;
            this.animales_razas.Location = new System.Drawing.Point(355, 245);
            this.animales_razas.Margin = new System.Windows.Forms.Padding(2);
            this.animales_razas.Name = "animales_razas";
            this.animales_razas.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.animales_razas.OnHoverItemForeColor = System.Drawing.Color.White;
            this.animales_razas.Radius = 5;
            this.animales_razas.Size = new System.Drawing.Size(365, 33);
            this.animales_razas.TabIndex = 28;
            this.animales_razas.SelectedIndexChanged += new System.EventHandler(this.animales_razas_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.label9.Location = new System.Drawing.Point(24, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 32);
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
            this.txtSearch.Location = new System.Drawing.Point(117, 91);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.Radius = 5;
            this.txtSearch.Size = new System.Drawing.Size(347, 40);
            this.txtSearch.TabIndex = 54;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblErrorDescripcion);
            this.panel1.Controls.Add(this.lblErrorColor);
            this.panel1.Controls.Add(this.lblErrorNombre);
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
            this.panel1.Location = new System.Drawing.Point(504, 96);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(777, 610);
            this.panel1.TabIndex = 57;
            // 
            // lblErrorDescripcion
            // 
            this.lblErrorDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(59)))), ((int)(((byte)(87)))));
            this.lblErrorDescripcion.Location = new System.Drawing.Point(609, 306);
            this.lblErrorDescripcion.Name = "lblErrorDescripcion";
            this.lblErrorDescripcion.Size = new System.Drawing.Size(109, 28);
            this.lblErrorDescripcion.TabIndex = 53;
            this.lblErrorDescripcion.Text = "Obligatorio";
            this.lblErrorDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblErrorDescripcion.Visible = false;
            // 
            // lblErrorColor
            // 
            this.lblErrorColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(59)))), ((int)(((byte)(87)))));
            this.lblErrorColor.Location = new System.Drawing.Point(611, 117);
            this.lblErrorColor.Name = "lblErrorColor";
            this.lblErrorColor.Size = new System.Drawing.Size(109, 28);
            this.lblErrorColor.TabIndex = 52;
            this.lblErrorColor.Text = "Obligatorio";
            this.lblErrorColor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblErrorColor.Visible = false;
            // 
            // lblErrorNombre
            // 
            this.lblErrorNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(59)))), ((int)(((byte)(87)))));
            this.lblErrorNombre.Location = new System.Drawing.Point(214, 16);
            this.lblErrorNombre.Name = "lblErrorNombre";
            this.lblErrorNombre.Size = new System.Drawing.Size(109, 28);
            this.lblErrorNombre.TabIndex = 51;
            this.lblErrorNombre.Text = "Obligatorio";
            this.lblErrorNombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblErrorNombre.Visible = false;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.label10.Location = new System.Drawing.Point(23, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(328, 42);
            this.label10.TabIndex = 58;
            this.label10.Text = "Buscar";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvDatosPropietarios
            // 
            this.dgvDatosPropietarios.AllowUserToAddRows = false;
            this.dgvDatosPropietarios.AllowUserToResizeRows = false;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.White;
            this.dgvDatosPropietarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvDatosPropietarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDatosPropietarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDatosPropietarios.BackgroundColor = System.Drawing.Color.White;
            this.dgvDatosPropietarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDatosPropietarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDatosPropietarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDatosPropietarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dgvDatosPropietarios.ColumnHeadersHeight = 40;
            this.dgvDatosPropietarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Segoe UI", 14F);
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDatosPropietarios.DefaultCellStyle = dataGridViewCellStyle19;
            this.dgvDatosPropietarios.EnableHeadersVisualStyles = false;
            this.dgvDatosPropietarios.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.dgvDatosPropietarios.Location = new System.Drawing.Point(28, 150);
            this.dgvDatosPropietarios.Name = "dgvDatosPropietarios";
            this.dgvDatosPropietarios.RowHeadersVisible = false;
            this.dgvDatosPropietarios.RowHeadersWidth = 51;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvDatosPropietarios.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.dgvDatosPropietarios.RowTemplate.Height = 40;
            this.dgvDatosPropietarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatosPropietarios.Size = new System.Drawing.Size(436, 556);
            this.dgvDatosPropietarios.TabIndex = 59;
            this.dgvDatosPropietarios.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgvDatosPropietarios.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDatosPropietarios.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvDatosPropietarios.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvDatosPropietarios.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvDatosPropietarios.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvDatosPropietarios.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvDatosPropietarios.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.dgvDatosPropietarios.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.dgvDatosPropietarios.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDatosPropietarios.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.dgvDatosPropietarios.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDatosPropietarios.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvDatosPropietarios.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvDatosPropietarios.ThemeStyle.ReadOnly = false;
            this.dgvDatosPropietarios.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDatosPropietarios.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDatosPropietarios.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.dgvDatosPropietarios.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.dgvDatosPropietarios.ThemeStyle.RowsStyle.Height = 40;
            this.dgvDatosPropietarios.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            this.dgvDatosPropietarios.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.FillWeight = 50F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.FillWeight = 150F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre de Cliente";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.label1.Location = new System.Drawing.Point(504, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(777, 42);
            this.label1.TabIndex = 24;
            this.label1.Text = "Datos de paciente";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormGuardarMascota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1289, 737);
            this.Controls.Add(this.dgvDatosPropietarios);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FormGuardarMascota";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Registrar Nueva Mascota";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosPropietarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaResize gunaResize1;
        private Guna.UI.WinForms.GunaPanel panelTop;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private System.Windows.Forms.Label label2;
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
        private Guna.UI.WinForms.GunaTextBox txtcolor;
        private Guna.UI.WinForms.GunaComboBox animales_razas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private Guna.UI.WinForms.GunaTextBox txtSearch;
        private System.Windows.Forms.Label label10;
        private Guna.UI.WinForms.GunaDataGridView dgvDatosPropietarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label lblErrorDescripcion;
        private System.Windows.Forms.Label lblErrorColor;
        private System.Windows.Forms.Label lblErrorNombre;
        private System.Windows.Forms.Label label1;
    }
}