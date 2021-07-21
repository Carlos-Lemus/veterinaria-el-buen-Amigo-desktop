
namespace VeterinariaElBuenAmigo.views.consulta
{
    partial class AccionesConsultas
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
            this.panelTop = new Guna.UI.WinForms.GunaPanel();
            this.Nombre_Paciente = new System.Windows.Forms.Label();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.campos_comentarios = new System.Windows.Forms.Label();
            this.campos_control = new System.Windows.Forms.Label();
            this.campos_peso = new System.Windows.Forms.Label();
            this.campos_temperatura = new System.Windows.Forms.Label();
            this.campos_padecimineto = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.btn_Guardar = new Guna.UI.WinForms.GunaButton();
            this.txt_Comentarios = new Guna.UI.WinForms.GunaTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_controlCelo = new Guna.UI.WinForms.GunaTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Peso = new Guna.UI.WinForms.GunaTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Temperatura = new Guna.UI.WinForms.GunaTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Padecimineto = new Guna.UI.WinForms.GunaTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbl_ConsultasAnteriores = new Guna.UI.WinForms.GunaDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEdit = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColumnSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.iconButton5 = new FontAwesome.Sharp.IconButton();
            this.btnDelete = new Guna.UI.WinForms.GunaButton();
            this.btn_Vitaminas = new Guna.UI.WinForms.GunaButton();
            this.btn_Vacunas = new Guna.UI.WinForms.GunaButton();
            this.easyHTMLReports1 = new KimToo.EasyHTMLReports(this.components);
            this.windowDragControl = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.gunaVScrollBar1 = new Guna.UI.WinForms.GunaVScrollBar();
            this.gunaPanel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_ConsultasAnteriores)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1289, 20);
            this.panelTop.TabIndex = 24;
            // 
            // Nombre_Paciente
            // 
            this.Nombre_Paciente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Nombre_Paciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre_Paciente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.Nombre_Paciente.Location = new System.Drawing.Point(431, 23);
            this.Nombre_Paciente.Name = "Nombre_Paciente";
            this.Nombre_Paciente.Size = new System.Drawing.Size(832, 38);
            this.Nombre_Paciente.TabIndex = 23;
            this.Nombre_Paciente.Text = "Consulta Paciente";
            this.Nombre_Paciente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gunaPanel1.Controls.Add(this.campos_comentarios);
            this.gunaPanel1.Controls.Add(this.campos_control);
            this.gunaPanel1.Controls.Add(this.campos_peso);
            this.gunaPanel1.Controls.Add(this.campos_temperatura);
            this.gunaPanel1.Controls.Add(this.campos_padecimineto);
            this.gunaPanel1.Controls.Add(this.panel5);
            this.gunaPanel1.Controls.Add(this.btn_Guardar);
            this.gunaPanel1.Controls.Add(this.txt_Comentarios);
            this.gunaPanel1.Controls.Add(this.label7);
            this.gunaPanel1.Controls.Add(this.txt_controlCelo);
            this.gunaPanel1.Controls.Add(this.label6);
            this.gunaPanel1.Controls.Add(this.txt_Peso);
            this.gunaPanel1.Controls.Add(this.label5);
            this.gunaPanel1.Controls.Add(this.txt_Temperatura);
            this.gunaPanel1.Controls.Add(this.label4);
            this.gunaPanel1.Controls.Add(this.txt_Padecimineto);
            this.gunaPanel1.Controls.Add(this.label3);
            this.gunaPanel1.Controls.Add(this.panel4);
            this.gunaPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaPanel1.Location = new System.Drawing.Point(12, 71);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(413, 638);
            this.gunaPanel1.TabIndex = 25;
            // 
            // campos_comentarios
            // 
            this.campos_comentarios.AutoSize = true;
            this.campos_comentarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campos_comentarios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(59)))), ((int)(((byte)(87)))));
            this.campos_comentarios.Location = new System.Drawing.Point(15, 506);
            this.campos_comentarios.Name = "campos_comentarios";
            this.campos_comentarios.Size = new System.Drawing.Size(173, 20);
            this.campos_comentarios.TabIndex = 52;
            this.campos_comentarios.Text = "El campo es obligatorio";
            // 
            // campos_control
            // 
            this.campos_control.AutoSize = true;
            this.campos_control.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campos_control.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(59)))), ((int)(((byte)(87)))));
            this.campos_control.Location = new System.Drawing.Point(13, 315);
            this.campos_control.Name = "campos_control";
            this.campos_control.Size = new System.Drawing.Size(173, 20);
            this.campos_control.TabIndex = 51;
            this.campos_control.Text = "El campo es obligatorio";
            // 
            // campos_peso
            // 
            this.campos_peso.AutoSize = true;
            this.campos_peso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campos_peso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(59)))), ((int)(((byte)(87)))));
            this.campos_peso.Location = new System.Drawing.Point(217, 193);
            this.campos_peso.Name = "campos_peso";
            this.campos_peso.Size = new System.Drawing.Size(121, 20);
            this.campos_peso.TabIndex = 50;
            this.campos_peso.Text = "Agregar el peso";
            // 
            // campos_temperatura
            // 
            this.campos_temperatura.AutoSize = true;
            this.campos_temperatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campos_temperatura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(59)))), ((int)(((byte)(87)))));
            this.campos_temperatura.Location = new System.Drawing.Point(15, 194);
            this.campos_temperatura.Name = "campos_temperatura";
            this.campos_temperatura.Size = new System.Drawing.Size(168, 20);
            this.campos_temperatura.TabIndex = 49;
            this.campos_temperatura.Text = "Agrega la temperatura";
            // 
            // campos_padecimineto
            // 
            this.campos_padecimineto.AutoSize = true;
            this.campos_padecimineto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campos_padecimineto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(59)))), ((int)(((byte)(87)))));
            this.campos_padecimineto.Location = new System.Drawing.Point(13, 83);
            this.campos_padecimineto.Name = "campos_padecimineto";
            this.campos_padecimineto.Size = new System.Drawing.Size(192, 20);
            this.campos_padecimineto.TabIndex = 48;
            this.campos_padecimineto.Text = "Este campo es obligatorio";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.iconButton3);
            this.panel5.Controls.Add(this.iconButton4);
            this.panel5.Location = new System.Drawing.Point(362, 152);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(35, 36);
            this.panel5.TabIndex = 47;
            // 
            // iconButton3
            // 
            this.iconButton3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.ChevronDown;
            this.iconButton3.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 32;
            this.iconButton3.Location = new System.Drawing.Point(0, 18);
            this.iconButton3.Margin = new System.Windows.Forms.Padding(0);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(35, 18);
            this.iconButton3.TabIndex = 1;
            this.iconButton3.UseVisualStyleBackColor = true;
            this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // iconButton4
            // 
            this.iconButton4.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton4.FlatAppearance.BorderSize = 0;
            this.iconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.ChevronUp;
            this.iconButton4.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.IconSize = 32;
            this.iconButton4.Location = new System.Drawing.Point(0, 0);
            this.iconButton4.Margin = new System.Windows.Forms.Padding(0);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Size = new System.Drawing.Size(35, 18);
            this.iconButton4.TabIndex = 0;
            this.iconButton4.UseVisualStyleBackColor = true;
            this.iconButton4.Click += new System.EventHandler(this.iconButton4_Click);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.AnimationHoverSpeed = 0.07F;
            this.btn_Guardar.AnimationSpeed = 0.03F;
            this.btn_Guardar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Guardar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.btn_Guardar.BorderColor = System.Drawing.Color.Black;
            this.btn_Guardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Guardar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Guardar.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Guardar.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btn_Guardar.ForeColor = System.Drawing.Color.White;
            this.btn_Guardar.Image = null;
            this.btn_Guardar.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Guardar.Location = new System.Drawing.Point(72, 565);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.btn_Guardar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Guardar.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Guardar.OnHoverImage = null;
            this.btn_Guardar.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Guardar.Radius = 5;
            this.btn_Guardar.Size = new System.Drawing.Size(250, 42);
            this.btn_Guardar.TabIndex = 45;
            this.btn_Guardar.Text = "Guardar Consulta";
            this.btn_Guardar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // txt_Comentarios
            // 
            this.txt_Comentarios.BackColor = System.Drawing.Color.Transparent;
            this.txt_Comentarios.BaseColor = System.Drawing.Color.White;
            this.txt_Comentarios.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(211)))));
            this.txt_Comentarios.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Comentarios.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_Comentarios.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.txt_Comentarios.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.txt_Comentarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txt_Comentarios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.txt_Comentarios.Location = new System.Drawing.Point(18, 400);
            this.txt_Comentarios.MultiLine = true;
            this.txt_Comentarios.Name = "txt_Comentarios";
            this.txt_Comentarios.PasswordChar = '\0';
            this.txt_Comentarios.Radius = 5;
            this.txt_Comentarios.Size = new System.Drawing.Size(380, 105);
            this.txt_Comentarios.TabIndex = 44;
            this.txt_Comentarios.TextOffsetX = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.label7.Location = new System.Drawing.Point(14, 373);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(242, 24);
            this.label7.TabIndex = 43;
            this.label7.Text = "Comentarios o Anotaciones";
            // 
            // txt_controlCelo
            // 
            this.txt_controlCelo.BackColor = System.Drawing.Color.Transparent;
            this.txt_controlCelo.BaseColor = System.Drawing.Color.White;
            this.txt_controlCelo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(211)))));
            this.txt_controlCelo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_controlCelo.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_controlCelo.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.txt_controlCelo.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.txt_controlCelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txt_controlCelo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.txt_controlCelo.Location = new System.Drawing.Point(17, 277);
            this.txt_controlCelo.Name = "txt_controlCelo";
            this.txt_controlCelo.PasswordChar = '\0';
            this.txt_controlCelo.Radius = 5;
            this.txt_controlCelo.Size = new System.Drawing.Size(380, 35);
            this.txt_controlCelo.TabIndex = 42;
            this.txt_controlCelo.TextOffsetX = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.label6.Location = new System.Drawing.Point(13, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 24);
            this.label6.TabIndex = 41;
            this.label6.Text = "Control de Celo";
            // 
            // txt_Peso
            // 
            this.txt_Peso.BackColor = System.Drawing.Color.Transparent;
            this.txt_Peso.BaseColor = System.Drawing.Color.White;
            this.txt_Peso.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(211)))));
            this.txt_Peso.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Peso.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_Peso.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.txt_Peso.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.txt_Peso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txt_Peso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.txt_Peso.Location = new System.Drawing.Point(219, 152);
            this.txt_Peso.Name = "txt_Peso";
            this.txt_Peso.PasswordChar = '\0';
            this.txt_Peso.Radius = 5;
            this.txt_Peso.Size = new System.Drawing.Size(137, 35);
            this.txt_Peso.TabIndex = 40;
            this.txt_Peso.TextOffsetX = 10;
            this.txt_Peso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Peso_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.label5.Location = new System.Drawing.Point(218, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 24);
            this.label5.TabIndex = 39;
            this.label5.Text = "Peso";
            // 
            // txt_Temperatura
            // 
            this.txt_Temperatura.BackColor = System.Drawing.Color.Transparent;
            this.txt_Temperatura.BaseColor = System.Drawing.Color.White;
            this.txt_Temperatura.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(211)))));
            this.txt_Temperatura.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Temperatura.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_Temperatura.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.txt_Temperatura.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.txt_Temperatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txt_Temperatura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.txt_Temperatura.Location = new System.Drawing.Point(17, 152);
            this.txt_Temperatura.Name = "txt_Temperatura";
            this.txt_Temperatura.PasswordChar = '\0';
            this.txt_Temperatura.Radius = 5;
            this.txt_Temperatura.Size = new System.Drawing.Size(137, 35);
            this.txt_Temperatura.TabIndex = 38;
            this.txt_Temperatura.TextOffsetX = 10;
            this.txt_Temperatura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Temperatura_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.label4.Location = new System.Drawing.Point(14, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 24);
            this.label4.TabIndex = 37;
            this.label4.Text = "Temperatura";
            // 
            // txt_Padecimineto
            // 
            this.txt_Padecimineto.BackColor = System.Drawing.Color.Transparent;
            this.txt_Padecimineto.BaseColor = System.Drawing.Color.White;
            this.txt_Padecimineto.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(211)))));
            this.txt_Padecimineto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Padecimineto.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_Padecimineto.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.txt_Padecimineto.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.txt_Padecimineto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txt_Padecimineto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.txt_Padecimineto.Location = new System.Drawing.Point(17, 35);
            this.txt_Padecimineto.Name = "txt_Padecimineto";
            this.txt_Padecimineto.PasswordChar = '\0';
            this.txt_Padecimineto.Radius = 5;
            this.txt_Padecimineto.Size = new System.Drawing.Size(380, 35);
            this.txt_Padecimineto.TabIndex = 36;
            this.txt_Padecimineto.TextOffsetX = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.label3.Location = new System.Drawing.Point(13, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 24);
            this.label3.TabIndex = 35;
            this.label3.Text = "Padecimiento";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.iconButton2);
            this.panel4.Controls.Add(this.iconButton1);
            this.panel4.Location = new System.Drawing.Point(160, 151);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(35, 36);
            this.panel4.TabIndex = 46;
            // 
            // iconButton2
            // 
            this.iconButton2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.ChevronDown;
            this.iconButton2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 32;
            this.iconButton2.Location = new System.Drawing.Point(0, 19);
            this.iconButton2.Margin = new System.Windows.Forms.Padding(0);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(35, 17);
            this.iconButton2.TabIndex = 1;
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.ChevronUp;
            this.iconButton1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 32;
            this.iconButton1.Location = new System.Drawing.Point(0, 0);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(0);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(35, 18);
            this.iconButton1.TabIndex = 0;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoScroll = true;
            this.panel2.AutoScrollMargin = new System.Drawing.Size(0, 100);
            this.panel2.Controls.Add(this.tbl_ConsultasAnteriores);
            this.panel2.Controls.Add(this.iconButton5);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btn_Vitaminas);
            this.panel2.Controls.Add(this.btn_Vacunas);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(431, 71);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(832, 639);
            this.panel2.TabIndex = 26;
            // 
            // tbl_ConsultasAnteriores
            // 
            this.tbl_ConsultasAnteriores.AllowUserToAddRows = false;
            this.tbl_ConsultasAnteriores.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.tbl_ConsultasAnteriores.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tbl_ConsultasAnteriores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbl_ConsultasAnteriores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tbl_ConsultasAnteriores.BackgroundColor = System.Drawing.Color.White;
            this.tbl_ConsultasAnteriores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbl_ConsultasAnteriores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tbl_ConsultasAnteriores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tbl_ConsultasAnteriores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tbl_ConsultasAnteriores.ColumnHeadersHeight = 40;
            this.tbl_ConsultasAnteriores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.ColumnEdit,
            this.ColumnSelect});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tbl_ConsultasAnteriores.DefaultCellStyle = dataGridViewCellStyle3;
            this.tbl_ConsultasAnteriores.EnableHeadersVisualStyles = false;
            this.tbl_ConsultasAnteriores.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.tbl_ConsultasAnteriores.Location = new System.Drawing.Point(50, 112);
            this.tbl_ConsultasAnteriores.Name = "tbl_ConsultasAnteriores";
            this.tbl_ConsultasAnteriores.RowHeadersVisible = false;
            this.tbl_ConsultasAnteriores.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.tbl_ConsultasAnteriores.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.tbl_ConsultasAnteriores.RowTemplate.Height = 40;
            this.tbl_ConsultasAnteriores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tbl_ConsultasAnteriores.Size = new System.Drawing.Size(756, 484);
            this.tbl_ConsultasAnteriores.TabIndex = 44;
            this.tbl_ConsultasAnteriores.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.tbl_ConsultasAnteriores.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.tbl_ConsultasAnteriores.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.tbl_ConsultasAnteriores.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.tbl_ConsultasAnteriores.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.tbl_ConsultasAnteriores.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.tbl_ConsultasAnteriores.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.tbl_ConsultasAnteriores.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.tbl_ConsultasAnteriores.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.tbl_ConsultasAnteriores.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tbl_ConsultasAnteriores.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbl_ConsultasAnteriores.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.tbl_ConsultasAnteriores.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.tbl_ConsultasAnteriores.ThemeStyle.HeaderStyle.Height = 40;
            this.tbl_ConsultasAnteriores.ThemeStyle.ReadOnly = false;
            this.tbl_ConsultasAnteriores.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.tbl_ConsultasAnteriores.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tbl_ConsultasAnteriores.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbl_ConsultasAnteriores.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.tbl_ConsultasAnteriores.ThemeStyle.RowsStyle.Height = 40;
            this.tbl_ConsultasAnteriores.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            this.tbl_ConsultasAnteriores.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.tbl_ConsultasAnteriores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbl_ConsultasAnteriores_CellClick);
            // 
            // Column1
            // 
            this.Column1.FillWeight = 30F;
            this.Column1.HeaderText = "Id";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.FillWeight = 120F;
            this.Column2.HeaderText = "Procedimiento";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 80F;
            this.Column3.HeaderText = "Temperatura";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.FillWeight = 50F;
            this.Column4.HeaderText = "Peso";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Control de Celo";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.FillWeight = 90F;
            this.Column6.HeaderText = "Comentarios";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // ColumnEdit
            // 
            this.ColumnEdit.FillWeight = 25F;
            this.ColumnEdit.HeaderText = "";
            this.ColumnEdit.Image = global::VeterinariaElBuenAmigo.Properties.Resources.edit;
            this.ColumnEdit.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.ColumnEdit.MinimumWidth = 6;
            this.ColumnEdit.Name = "ColumnEdit";
            this.ColumnEdit.ReadOnly = true;
            // 
            // ColumnSelect
            // 
            this.ColumnSelect.FillWeight = 25F;
            this.ColumnSelect.HeaderText = "";
            this.ColumnSelect.MinimumWidth = 6;
            this.ColumnSelect.Name = "ColumnSelect";
            // 
            // iconButton5
            // 
            this.iconButton5.BackColor = System.Drawing.Color.Transparent;
            this.iconButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton5.FlatAppearance.BorderSize = 0;
            this.iconButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.iconButton5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.iconButton5.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.iconButton5.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton5.IconSize = 32;
            this.iconButton5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton5.Location = new System.Drawing.Point(397, 57);
            this.iconButton5.Name = "iconButton5";
            this.iconButton5.Size = new System.Drawing.Size(118, 35);
            this.iconButton5.TabIndex = 38;
            this.iconButton5.Text = "Imprimir";
            this.iconButton5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton5.UseVisualStyleBackColor = false;
            this.iconButton5.Click += new System.EventHandler(this.iconButton5_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.AnimationHoverSpeed = 0.07F;
            this.btnDelete.AnimationSpeed = 0.03F;
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(82)))), ((int)(((byte)(83)))));
            this.btnDelete.BorderColor = System.Drawing.Color.Black;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDelete.FocusedColor = System.Drawing.Color.Empty;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = global::VeterinariaElBuenAmigo.Properties.Resources.delete;
            this.btnDelete.ImageSize = new System.Drawing.Size(20, 20);
            this.btnDelete.Location = new System.Drawing.Point(673, 57);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(117)))));
            this.btnDelete.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDelete.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDelete.OnHoverImage = null;
            this.btnDelete.OnPressedColor = System.Drawing.Color.Black;
            this.btnDelete.Radius = 5;
            this.btnDelete.Size = new System.Drawing.Size(133, 35);
            this.btnDelete.TabIndex = 36;
            this.btnDelete.Text = "Eliminar ";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btn_Vitaminas
            // 
            this.btn_Vitaminas.AnimationHoverSpeed = 0.07F;
            this.btn_Vitaminas.AnimationSpeed = 0.03F;
            this.btn_Vitaminas.BackColor = System.Drawing.Color.Transparent;
            this.btn_Vitaminas.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.btn_Vitaminas.BorderColor = System.Drawing.Color.Black;
            this.btn_Vitaminas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Vitaminas.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Vitaminas.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Vitaminas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Vitaminas.ForeColor = System.Drawing.Color.White;
            this.btn_Vitaminas.Image = null;
            this.btn_Vitaminas.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Vitaminas.Location = new System.Drawing.Point(50, 57);
            this.btn_Vitaminas.Name = "btn_Vitaminas";
            this.btn_Vitaminas.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.btn_Vitaminas.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Vitaminas.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Vitaminas.OnHoverImage = null;
            this.btn_Vitaminas.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Vitaminas.Radius = 5;
            this.btn_Vitaminas.Size = new System.Drawing.Size(173, 35);
            this.btn_Vitaminas.TabIndex = 26;
            this.btn_Vitaminas.Text = "Control de Vitaminas";
            this.btn_Vitaminas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Vitaminas.Click += new System.EventHandler(this.btn_Vitaminas_Click);
            // 
            // btn_Vacunas
            // 
            this.btn_Vacunas.AnimationHoverSpeed = 0.07F;
            this.btn_Vacunas.AnimationSpeed = 0.03F;
            this.btn_Vacunas.BackColor = System.Drawing.Color.Transparent;
            this.btn_Vacunas.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.btn_Vacunas.BorderColor = System.Drawing.Color.Black;
            this.btn_Vacunas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Vacunas.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Vacunas.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Vacunas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Vacunas.ForeColor = System.Drawing.Color.White;
            this.btn_Vacunas.Image = null;
            this.btn_Vacunas.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Vacunas.Location = new System.Drawing.Point(229, 57);
            this.btn_Vacunas.Name = "btn_Vacunas";
            this.btn_Vacunas.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.btn_Vacunas.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Vacunas.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Vacunas.OnHoverImage = null;
            this.btn_Vacunas.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Vacunas.Radius = 5;
            this.btn_Vacunas.Size = new System.Drawing.Size(162, 35);
            this.btn_Vacunas.TabIndex = 20;
            this.btn_Vacunas.Text = "Control de Vacunas";
            this.btn_Vacunas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Vacunas.Click += new System.EventHandler(this.btn_Vacunas_Click);
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
            // windowDragControl
            // 
            this.windowDragControl.TargetControl = this.panelTop;
            // 
            // gunaVScrollBar1
            // 
            this.gunaVScrollBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaVScrollBar1.LargeChange = 10;
            this.gunaVScrollBar1.Location = new System.Drawing.Point(1269, 183);
            this.gunaVScrollBar1.Maximum = 100;
            this.gunaVScrollBar1.Name = "gunaVScrollBar1";
            this.gunaVScrollBar1.ScrollIdleColor = System.Drawing.Color.Teal;
            this.gunaVScrollBar1.Size = new System.Drawing.Size(16, 514);
            this.gunaVScrollBar1.TabIndex = 45;
            this.gunaVScrollBar1.ThumbColor = System.Drawing.Color.LightBlue;
            this.gunaVScrollBar1.ThumbHoverColor = System.Drawing.Color.LightBlue;
            this.gunaVScrollBar1.ThumbPressedColor = System.Drawing.Color.LightBlue;
            // 
            // AccionesConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1289, 721);
            this.Controls.Add(this.gunaVScrollBar1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.gunaPanel1);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.Nombre_Paciente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AccionesConsultas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Consultas";
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_ConsultasAnteriores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel panelTop;
        private System.Windows.Forms.Label Nombre_Paciente;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private System.Windows.Forms.Label campos_comentarios;
        private System.Windows.Forms.Label campos_control;
        private System.Windows.Forms.Label campos_peso;
        private System.Windows.Forms.Label campos_temperatura;
        private System.Windows.Forms.Label campos_padecimineto;
        private System.Windows.Forms.Panel panel5;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton4;
        private Guna.UI.WinForms.GunaButton btn_Guardar;
        private Guna.UI.WinForms.GunaTextBox txt_Comentarios;
        private System.Windows.Forms.Label label7;
        private Guna.UI.WinForms.GunaTextBox txt_controlCelo;
        private System.Windows.Forms.Label label6;
        private Guna.UI.WinForms.GunaTextBox txt_Peso;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaTextBox txt_Temperatura;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaTextBox txt_Padecimineto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaDataGridView tbl_ConsultasAnteriores;
        private FontAwesome.Sharp.IconButton iconButton5;
        private Guna.UI.WinForms.GunaButton btnDelete;
        private Guna.UI.WinForms.GunaButton btn_Vitaminas;
        private Guna.UI.WinForms.GunaButton btn_Vacunas;
        private KimToo.EasyHTMLReports easyHTMLReports1;
        private Guna.UI.WinForms.GunaDragControl windowDragControl;
        private Guna.UI.WinForms.GunaVScrollBar gunaVScrollBar1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewImageColumn ColumnEdit;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnSelect;
    }
}