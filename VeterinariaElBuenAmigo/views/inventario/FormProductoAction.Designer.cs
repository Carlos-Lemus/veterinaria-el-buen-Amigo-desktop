
namespace VeterinariaElBuenAmigo.views.inventario
{
    partial class FormProductoAction
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
            this.panelTop = new Guna.UI.WinForms.GunaPanel();
            this.btnMin = new FontAwesome.Sharp.IconButton();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.btnEdit = new Guna.UI.WinForms.GunaButton();
            this.btnAdd = new Guna.UI.WinForms.GunaButton();
            this.lblErrorNombreProducto = new System.Windows.Forms.Label();
            this.txtNombreProducto = new Guna.UI.WinForms.GunaTextBox();
            this.gnExistencias = new Guna.UI.WinForms.GunaNumeric();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblErrorTipoProducto = new System.Windows.Forms.Label();
            this.txtTipoProducto = new Guna.UI.WinForms.GunaTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblErrorMarcaProducto = new System.Windows.Forms.Label();
            this.txtMarcaProducto = new Guna.UI.WinForms.GunaTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblErrorDescripcionProducto = new System.Windows.Forms.Label();
            this.dtFechaAdquisicion = new Guna.UI.WinForms.GunaDateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDescripcionProducto = new Guna.UI.WinForms.GunaTextBox();
            this.panelTop.SuspendLayout();
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
            this.panelTop.Size = new System.Drawing.Size(875, 30);
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
            this.btnMin.Location = new System.Drawing.Point(795, 0);
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
            this.btnClose.Location = new System.Drawing.Point(835, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 30);
            this.btnClose.TabIndex = 4;
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.AnimationHoverSpeed = 0.07F;
            this.btnEdit.AnimationSpeed = 0.03F;
            this.btnEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnEdit.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(67)))));
            this.btnEdit.BorderColor = System.Drawing.Color.Black;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEdit.FocusedColor = System.Drawing.Color.Empty;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Image = null;
            this.btnEdit.ImageSize = new System.Drawing.Size(20, 20);
            this.btnEdit.Location = new System.Drawing.Point(188, 571);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(211)))));
            this.btnEdit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnEdit.OnHoverForeColor = System.Drawing.Color.White;
            this.btnEdit.OnHoverImage = null;
            this.btnEdit.OnPressedColor = System.Drawing.Color.Black;
            this.btnEdit.Radius = 5;
            this.btnEdit.Size = new System.Drawing.Size(500, 35);
            this.btnEdit.TabIndex = 24;
            this.btnEdit.Text = "Editar";
            this.btnEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
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
            this.btnAdd.Location = new System.Drawing.Point(188, 530);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.OnHoverBaseColor = System.Drawing.Color.Empty;
            this.btnAdd.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAdd.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAdd.OnHoverImage = null;
            this.btnAdd.OnPressedColor = System.Drawing.Color.Black;
            this.btnAdd.Radius = 5;
            this.btnAdd.Size = new System.Drawing.Size(500, 35);
            this.btnAdd.TabIndex = 23;
            this.btnAdd.Text = "Guardar";
            this.btnAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblErrorNombreProducto
            // 
            this.lblErrorNombreProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorNombreProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(59)))), ((int)(((byte)(87)))));
            this.lblErrorNombreProducto.Location = new System.Drawing.Point(25, 123);
            this.lblErrorNombreProducto.Name = "lblErrorNombreProducto";
            this.lblErrorNombreProducto.Size = new System.Drawing.Size(400, 28);
            this.lblErrorNombreProducto.TabIndex = 36;
            this.lblErrorNombreProducto.Text = "Ingrese el nombre del producto";
            this.lblErrorNombreProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblErrorNombreProducto.Visible = false;
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombreProducto.BackColor = System.Drawing.Color.Transparent;
            this.txtNombreProducto.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.txtNombreProducto.BorderColor = System.Drawing.Color.White;
            this.txtNombreProducto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombreProducto.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.txtNombreProducto.FocusedBorderColor = System.Drawing.Color.White;
            this.txtNombreProducto.FocusedForeColor = System.Drawing.Color.White;
            this.txtNombreProducto.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtNombreProducto.ForeColor = System.Drawing.Color.White;
            this.txtNombreProducto.Location = new System.Drawing.Point(25, 80);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.PasswordChar = '\0';
            this.txtNombreProducto.Radius = 4;
            this.txtNombreProducto.Size = new System.Drawing.Size(400, 35);
            this.txtNombreProducto.TabIndex = 35;
            // 
            // gnExistencias
            // 
            this.gnExistencias.BackColor = System.Drawing.Color.Transparent;
            this.gnExistencias.BaseColor = System.Drawing.Color.White;
            this.gnExistencias.BorderColor = System.Drawing.Color.White;
            this.gnExistencias.BorderSize = 2;
            this.gnExistencias.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.gnExistencias.ButtonForeColor = System.Drawing.Color.Black;
            this.gnExistencias.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.gnExistencias.ForeColor = System.Drawing.Color.Black;
            this.gnExistencias.Location = new System.Drawing.Point(450, 80);
            this.gnExistencias.Maximum = ((long)(9999999));
            this.gnExistencias.Minimum = ((long)(0));
            this.gnExistencias.Name = "gnExistencias";
            this.gnExistencias.Size = new System.Drawing.Size(120, 30);
            this.gnExistencias.TabIndex = 37;
            this.gnExistencias.Value = ((long)(0));
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 28);
            this.label1.TabIndex = 38;
            this.label1.Text = "Producto";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(450, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(400, 28);
            this.label2.TabIndex = 39;
            this.label2.Text = "Existencias";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(25, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(400, 28);
            this.label3.TabIndex = 42;
            this.label3.Text = "Tipo de producto";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblErrorTipoProducto
            // 
            this.lblErrorTipoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorTipoProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(59)))), ((int)(((byte)(87)))));
            this.lblErrorTipoProducto.Location = new System.Drawing.Point(25, 250);
            this.lblErrorTipoProducto.Name = "lblErrorTipoProducto";
            this.lblErrorTipoProducto.Size = new System.Drawing.Size(400, 28);
            this.lblErrorTipoProducto.TabIndex = 41;
            this.lblErrorTipoProducto.Text = "Ingrese el tipo de producto";
            this.lblErrorTipoProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblErrorTipoProducto.Visible = false;
            // 
            // txtTipoProducto
            // 
            this.txtTipoProducto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTipoProducto.BackColor = System.Drawing.Color.Transparent;
            this.txtTipoProducto.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.txtTipoProducto.BorderColor = System.Drawing.Color.White;
            this.txtTipoProducto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTipoProducto.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.txtTipoProducto.FocusedBorderColor = System.Drawing.Color.White;
            this.txtTipoProducto.FocusedForeColor = System.Drawing.Color.White;
            this.txtTipoProducto.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtTipoProducto.ForeColor = System.Drawing.Color.White;
            this.txtTipoProducto.Location = new System.Drawing.Point(25, 205);
            this.txtTipoProducto.Name = "txtTipoProducto";
            this.txtTipoProducto.PasswordChar = '\0';
            this.txtTipoProducto.Radius = 4;
            this.txtTipoProducto.Size = new System.Drawing.Size(400, 35);
            this.txtTipoProducto.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(450, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(400, 28);
            this.label4.TabIndex = 45;
            this.label4.Text = "Marca";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblErrorMarcaProducto
            // 
            this.lblErrorMarcaProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorMarcaProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(59)))), ((int)(((byte)(87)))));
            this.lblErrorMarcaProducto.Location = new System.Drawing.Point(450, 250);
            this.lblErrorMarcaProducto.Name = "lblErrorMarcaProducto";
            this.lblErrorMarcaProducto.Size = new System.Drawing.Size(400, 28);
            this.lblErrorMarcaProducto.TabIndex = 44;
            this.lblErrorMarcaProducto.Text = "Ingrese la marca del producto";
            this.lblErrorMarcaProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblErrorMarcaProducto.Visible = false;
            // 
            // txtMarcaProducto
            // 
            this.txtMarcaProducto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMarcaProducto.BackColor = System.Drawing.Color.Transparent;
            this.txtMarcaProducto.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.txtMarcaProducto.BorderColor = System.Drawing.Color.White;
            this.txtMarcaProducto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMarcaProducto.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.txtMarcaProducto.FocusedBorderColor = System.Drawing.Color.White;
            this.txtMarcaProducto.FocusedForeColor = System.Drawing.Color.White;
            this.txtMarcaProducto.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtMarcaProducto.ForeColor = System.Drawing.Color.White;
            this.txtMarcaProducto.Location = new System.Drawing.Point(450, 205);
            this.txtMarcaProducto.Name = "txtMarcaProducto";
            this.txtMarcaProducto.PasswordChar = '\0';
            this.txtMarcaProducto.Radius = 4;
            this.txtMarcaProducto.Size = new System.Drawing.Size(400, 35);
            this.txtMarcaProducto.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(25, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(400, 28);
            this.label6.TabIndex = 48;
            this.label6.Text = "Descripcion";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblErrorDescripcionProducto
            // 
            this.lblErrorDescripcionProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorDescripcionProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(59)))), ((int)(((byte)(87)))));
            this.lblErrorDescripcionProducto.Location = new System.Drawing.Point(25, 468);
            this.lblErrorDescripcionProducto.Name = "lblErrorDescripcionProducto";
            this.lblErrorDescripcionProducto.Size = new System.Drawing.Size(400, 28);
            this.lblErrorDescripcionProducto.TabIndex = 47;
            this.lblErrorDescripcionProducto.Text = "Ingrese el nombre del producto";
            this.lblErrorDescripcionProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblErrorDescripcionProducto.Visible = false;
            // 
            // dtFechaAdquisicion
            // 
            this.dtFechaAdquisicion.BaseColor = System.Drawing.Color.White;
            this.dtFechaAdquisicion.BorderColor = System.Drawing.Color.Silver;
            this.dtFechaAdquisicion.CustomFormat = null;
            this.dtFechaAdquisicion.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtFechaAdquisicion.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtFechaAdquisicion.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.dtFechaAdquisicion.ForeColor = System.Drawing.Color.Black;
            this.dtFechaAdquisicion.Location = new System.Drawing.Point(450, 346);
            this.dtFechaAdquisicion.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtFechaAdquisicion.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtFechaAdquisicion.Name = "dtFechaAdquisicion";
            this.dtFechaAdquisicion.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtFechaAdquisicion.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtFechaAdquisicion.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtFechaAdquisicion.OnPressedColor = System.Drawing.Color.Black;
            this.dtFechaAdquisicion.Size = new System.Drawing.Size(400, 35);
            this.dtFechaAdquisicion.TabIndex = 49;
            this.dtFechaAdquisicion.Text = "martes, 8 de junio de 2021";
            this.dtFechaAdquisicion.Value = new System.DateTime(2021, 6, 8, 14, 4, 51, 604);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(450, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(400, 28);
            this.label5.TabIndex = 51;
            this.label5.Text = "Fecha de Adquisicion";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDescripcionProducto
            // 
            this.txtDescripcionProducto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescripcionProducto.BackColor = System.Drawing.Color.Transparent;
            this.txtDescripcionProducto.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.txtDescripcionProducto.BorderColor = System.Drawing.Color.White;
            this.txtDescripcionProducto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescripcionProducto.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.txtDescripcionProducto.FocusedBorderColor = System.Drawing.Color.White;
            this.txtDescripcionProducto.FocusedForeColor = System.Drawing.Color.White;
            this.txtDescripcionProducto.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtDescripcionProducto.ForeColor = System.Drawing.Color.White;
            this.txtDescripcionProducto.Location = new System.Drawing.Point(25, 346);
            this.txtDescripcionProducto.MultiLine = true;
            this.txtDescripcionProducto.Name = "txtDescripcionProducto";
            this.txtDescripcionProducto.PasswordChar = '\0';
            this.txtDescripcionProducto.Radius = 4;
            this.txtDescripcionProducto.Size = new System.Drawing.Size(400, 115);
            this.txtDescripcionProducto.TabIndex = 52;
            // 
            // FormProductoAction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.ClientSize = new System.Drawing.Size(875, 654);
            this.Controls.Add(this.txtDescripcionProducto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtFechaAdquisicion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblErrorDescripcionProducto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblErrorMarcaProducto);
            this.Controls.Add(this.txtMarcaProducto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblErrorTipoProducto);
            this.Controls.Add(this.txtTipoProducto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gnExistencias);
            this.Controls.Add(this.lblErrorNombreProducto);
            this.Controls.Add(this.txtNombreProducto);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormProductoAction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormProductoAction";
            this.panelTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel panelTop;
        private FontAwesome.Sharp.IconButton btnMin;
        private FontAwesome.Sharp.IconButton btnClose;
        private Guna.UI.WinForms.GunaButton btnEdit;
        private Guna.UI.WinForms.GunaButton btnAdd;
        private System.Windows.Forms.Label lblErrorNombreProducto;
        private Guna.UI.WinForms.GunaTextBox txtNombreProducto;
        private Guna.UI.WinForms.GunaNumeric gnExistencias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblErrorTipoProducto;
        private Guna.UI.WinForms.GunaTextBox txtTipoProducto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblErrorMarcaProducto;
        private Guna.UI.WinForms.GunaTextBox txtMarcaProducto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblErrorDescripcionProducto;
        private Guna.UI.WinForms.GunaDateTimePicker dtFechaAdquisicion;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaTextBox txtDescripcionProducto;
    }
}