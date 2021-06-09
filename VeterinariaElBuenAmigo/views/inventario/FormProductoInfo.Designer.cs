
namespace VeterinariaElBuenAmigo.views.inventario
{
    partial class FormProductoInfo
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
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLbNombreProducto = new Guna.UI.WinForms.GunaTextBox();
            this.txtLbTipoProducto = new Guna.UI.WinForms.GunaTextBox();
            this.txtLbDescripcionProducto = new Guna.UI.WinForms.GunaTextBox();
            this.txtLbCantidadProducto = new Guna.UI.WinForms.GunaTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLbFechaProducto = new Guna.UI.WinForms.GunaTextBox();
            this.txtLbMarcaProducto = new Guna.UI.WinForms.GunaTextBox();
            this.txtLbIdProducto = new Guna.UI.WinForms.GunaTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnOk = new Guna.UI.WinForms.GunaButton();
            this.btnEdit = new Guna.UI.WinForms.GunaButton();
            this.btnDlt = new Guna.UI.WinForms.GunaButton();
            this.windowDragControl = new Guna.UI.WinForms.GunaDragControl(this.components);
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
            this.panelTop.TabIndex = 5;
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
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(450, 424);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(400, 28);
            this.label6.TabIndex = 56;
            this.label6.Text = "Descripcion";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(450, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(400, 28);
            this.label4.TabIndex = 55;
            this.label4.Text = "Marca";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(25, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(400, 28);
            this.label3.TabIndex = 54;
            this.label3.Text = "Tipo de producto";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(450, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(400, 28);
            this.label2.TabIndex = 53;
            this.label2.Text = "Existencias";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 28);
            this.label1.TabIndex = 52;
            this.label1.Text = "Producto";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtLbNombreProducto
            // 
            this.txtLbNombreProducto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLbNombreProducto.BackColor = System.Drawing.Color.Transparent;
            this.txtLbNombreProducto.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.txtLbNombreProducto.BorderColor = System.Drawing.Color.White;
            this.txtLbNombreProducto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLbNombreProducto.Enabled = false;
            this.txtLbNombreProducto.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.txtLbNombreProducto.FocusedBorderColor = System.Drawing.Color.White;
            this.txtLbNombreProducto.FocusedForeColor = System.Drawing.Color.White;
            this.txtLbNombreProducto.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtLbNombreProducto.ForeColor = System.Drawing.Color.White;
            this.txtLbNombreProducto.Location = new System.Drawing.Point(25, 185);
            this.txtLbNombreProducto.MultiLine = true;
            this.txtLbNombreProducto.Name = "txtLbNombreProducto";
            this.txtLbNombreProducto.PasswordChar = '\0';
            this.txtLbNombreProducto.Radius = 4;
            this.txtLbNombreProducto.Size = new System.Drawing.Size(400, 115);
            this.txtLbNombreProducto.TabIndex = 59;
            // 
            // txtLbTipoProducto
            // 
            this.txtLbTipoProducto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLbTipoProducto.BackColor = System.Drawing.Color.Transparent;
            this.txtLbTipoProducto.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.txtLbTipoProducto.BorderColor = System.Drawing.Color.White;
            this.txtLbTipoProducto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLbTipoProducto.Enabled = false;
            this.txtLbTipoProducto.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.txtLbTipoProducto.FocusedBorderColor = System.Drawing.Color.White;
            this.txtLbTipoProducto.FocusedForeColor = System.Drawing.Color.White;
            this.txtLbTipoProducto.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtLbTipoProducto.ForeColor = System.Drawing.Color.White;
            this.txtLbTipoProducto.Location = new System.Drawing.Point(25, 363);
            this.txtLbTipoProducto.MultiLine = true;
            this.txtLbTipoProducto.Name = "txtLbTipoProducto";
            this.txtLbTipoProducto.PasswordChar = '\0';
            this.txtLbTipoProducto.Radius = 4;
            this.txtLbTipoProducto.Size = new System.Drawing.Size(400, 115);
            this.txtLbTipoProducto.TabIndex = 60;
            // 
            // txtLbDescripcionProducto
            // 
            this.txtLbDescripcionProducto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLbDescripcionProducto.BackColor = System.Drawing.Color.Transparent;
            this.txtLbDescripcionProducto.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.txtLbDescripcionProducto.BorderColor = System.Drawing.Color.White;
            this.txtLbDescripcionProducto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLbDescripcionProducto.Enabled = false;
            this.txtLbDescripcionProducto.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.txtLbDescripcionProducto.FocusedBorderColor = System.Drawing.Color.White;
            this.txtLbDescripcionProducto.FocusedForeColor = System.Drawing.Color.White;
            this.txtLbDescripcionProducto.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtLbDescripcionProducto.ForeColor = System.Drawing.Color.White;
            this.txtLbDescripcionProducto.Location = new System.Drawing.Point(450, 462);
            this.txtLbDescripcionProducto.MultiLine = true;
            this.txtLbDescripcionProducto.Name = "txtLbDescripcionProducto";
            this.txtLbDescripcionProducto.PasswordChar = '\0';
            this.txtLbDescripcionProducto.Radius = 4;
            this.txtLbDescripcionProducto.Size = new System.Drawing.Size(400, 166);
            this.txtLbDescripcionProducto.TabIndex = 61;
            // 
            // txtLbCantidadProducto
            // 
            this.txtLbCantidadProducto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLbCantidadProducto.BackColor = System.Drawing.Color.Transparent;
            this.txtLbCantidadProducto.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.txtLbCantidadProducto.BorderColor = System.Drawing.Color.White;
            this.txtLbCantidadProducto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLbCantidadProducto.Enabled = false;
            this.txtLbCantidadProducto.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.txtLbCantidadProducto.FocusedBorderColor = System.Drawing.Color.White;
            this.txtLbCantidadProducto.FocusedForeColor = System.Drawing.Color.White;
            this.txtLbCantidadProducto.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtLbCantidadProducto.ForeColor = System.Drawing.Color.White;
            this.txtLbCantidadProducto.Location = new System.Drawing.Point(450, 88);
            this.txtLbCantidadProducto.MultiLine = true;
            this.txtLbCantidadProducto.Name = "txtLbCantidadProducto";
            this.txtLbCantidadProducto.PasswordChar = '\0';
            this.txtLbCantidadProducto.Radius = 4;
            this.txtLbCantidadProducto.Size = new System.Drawing.Size(400, 35);
            this.txtLbCantidadProducto.TabIndex = 62;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(450, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(400, 28);
            this.label7.TabIndex = 57;
            this.label7.Text = "Fecha de Adquisicion";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtLbFechaProducto
            // 
            this.txtLbFechaProducto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLbFechaProducto.BackColor = System.Drawing.Color.Transparent;
            this.txtLbFechaProducto.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.txtLbFechaProducto.BorderColor = System.Drawing.Color.White;
            this.txtLbFechaProducto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLbFechaProducto.Enabled = false;
            this.txtLbFechaProducto.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.txtLbFechaProducto.FocusedBorderColor = System.Drawing.Color.White;
            this.txtLbFechaProducto.FocusedForeColor = System.Drawing.Color.White;
            this.txtLbFechaProducto.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtLbFechaProducto.ForeColor = System.Drawing.Color.White;
            this.txtLbFechaProducto.Location = new System.Drawing.Point(450, 185);
            this.txtLbFechaProducto.MultiLine = true;
            this.txtLbFechaProducto.Name = "txtLbFechaProducto";
            this.txtLbFechaProducto.PasswordChar = '\0';
            this.txtLbFechaProducto.Radius = 4;
            this.txtLbFechaProducto.Size = new System.Drawing.Size(400, 35);
            this.txtLbFechaProducto.TabIndex = 63;
            // 
            // txtLbMarcaProducto
            // 
            this.txtLbMarcaProducto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLbMarcaProducto.BackColor = System.Drawing.Color.Transparent;
            this.txtLbMarcaProducto.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.txtLbMarcaProducto.BorderColor = System.Drawing.Color.White;
            this.txtLbMarcaProducto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLbMarcaProducto.Enabled = false;
            this.txtLbMarcaProducto.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.txtLbMarcaProducto.FocusedBorderColor = System.Drawing.Color.White;
            this.txtLbMarcaProducto.FocusedForeColor = System.Drawing.Color.White;
            this.txtLbMarcaProducto.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtLbMarcaProducto.ForeColor = System.Drawing.Color.White;
            this.txtLbMarcaProducto.Location = new System.Drawing.Point(450, 284);
            this.txtLbMarcaProducto.MultiLine = true;
            this.txtLbMarcaProducto.Name = "txtLbMarcaProducto";
            this.txtLbMarcaProducto.PasswordChar = '\0';
            this.txtLbMarcaProducto.Radius = 4;
            this.txtLbMarcaProducto.Size = new System.Drawing.Size(400, 115);
            this.txtLbMarcaProducto.TabIndex = 64;
            // 
            // txtLbIdProducto
            // 
            this.txtLbIdProducto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLbIdProducto.BackColor = System.Drawing.Color.Transparent;
            this.txtLbIdProducto.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.txtLbIdProducto.BorderColor = System.Drawing.Color.White;
            this.txtLbIdProducto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLbIdProducto.Enabled = false;
            this.txtLbIdProducto.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.txtLbIdProducto.FocusedBorderColor = System.Drawing.Color.White;
            this.txtLbIdProducto.FocusedForeColor = System.Drawing.Color.White;
            this.txtLbIdProducto.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtLbIdProducto.ForeColor = System.Drawing.Color.White;
            this.txtLbIdProducto.Location = new System.Drawing.Point(25, 88);
            this.txtLbIdProducto.MultiLine = true;
            this.txtLbIdProducto.Name = "txtLbIdProducto";
            this.txtLbIdProducto.PasswordChar = '\0';
            this.txtLbIdProducto.Radius = 4;
            this.txtLbIdProducto.Size = new System.Drawing.Size(400, 35);
            this.txtLbIdProducto.TabIndex = 66;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(25, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(400, 28);
            this.label5.TabIndex = 65;
            this.label5.Text = "ID del producto";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.AnimationHoverSpeed = 0.07F;
            this.btnOk.AnimationSpeed = 0.03F;
            this.btnOk.BackColor = System.Drawing.Color.Transparent;
            this.btnOk.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.btnOk.BorderColor = System.Drawing.Color.Black;
            this.btnOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnOk.FocusedColor = System.Drawing.Color.Empty;
            this.btnOk.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnOk.ForeColor = System.Drawing.Color.White;
            this.btnOk.Image = null;
            this.btnOk.ImageSize = new System.Drawing.Size(20, 20);
            this.btnOk.Location = new System.Drawing.Point(29, 547);
            this.btnOk.Name = "btnOk";
            this.btnOk.OnHoverBaseColor = System.Drawing.Color.Empty;
            this.btnOk.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnOk.OnHoverForeColor = System.Drawing.Color.White;
            this.btnOk.OnHoverImage = null;
            this.btnOk.OnPressedColor = System.Drawing.Color.Black;
            this.btnOk.Radius = 5;
            this.btnOk.Size = new System.Drawing.Size(127, 35);
            this.btnOk.TabIndex = 67;
            this.btnOk.Text = "OK";
            this.btnOk.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
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
            this.btnEdit.Image = global::VeterinariaElBuenAmigo.Properties.Resources.edit;
            this.btnEdit.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnEdit.ImageSize = new System.Drawing.Size(30, 30);
            this.btnEdit.Location = new System.Drawing.Point(179, 547);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(211)))));
            this.btnEdit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnEdit.OnHoverForeColor = System.Drawing.Color.White;
            this.btnEdit.OnHoverImage = null;
            this.btnEdit.OnPressedColor = System.Drawing.Color.Black;
            this.btnEdit.Radius = 5;
            this.btnEdit.Size = new System.Drawing.Size(103, 35);
            this.btnEdit.TabIndex = 68;
            this.btnEdit.Text = "Editar";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDlt
            // 
            this.btnDlt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDlt.AnimationHoverSpeed = 0.07F;
            this.btnDlt.AnimationSpeed = 0.03F;
            this.btnDlt.BackColor = System.Drawing.Color.Transparent;
            this.btnDlt.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDlt.BorderColor = System.Drawing.Color.Black;
            this.btnDlt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDlt.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDlt.FocusedColor = System.Drawing.Color.Empty;
            this.btnDlt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnDlt.ForeColor = System.Drawing.Color.White;
            this.btnDlt.Image = global::VeterinariaElBuenAmigo.Properties.Resources.delete;
            this.btnDlt.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnDlt.ImageSize = new System.Drawing.Size(30, 30);
            this.btnDlt.Location = new System.Drawing.Point(304, 547);
            this.btnDlt.Name = "btnDlt";
            this.btnDlt.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(211)))));
            this.btnDlt.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDlt.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDlt.OnHoverImage = null;
            this.btnDlt.OnPressedColor = System.Drawing.Color.Black;
            this.btnDlt.Radius = 5;
            this.btnDlt.Size = new System.Drawing.Size(121, 35);
            this.btnDlt.TabIndex = 69;
            this.btnDlt.Text = "Eliminar";
            this.btnDlt.Click += new System.EventHandler(this.btnDlt_Click);
            // 
            // windowDragControl
            // 
            this.windowDragControl.TargetControl = this.panelTop;
            // 
            // FormProductoInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.ClientSize = new System.Drawing.Size(875, 650);
            this.Controls.Add(this.btnDlt);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtLbIdProducto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtLbMarcaProducto);
            this.Controls.Add(this.txtLbFechaProducto);
            this.Controls.Add(this.txtLbCantidadProducto);
            this.Controls.Add(this.txtLbDescripcionProducto);
            this.Controls.Add(this.txtLbTipoProducto);
            this.Controls.Add(this.txtLbNombreProducto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormProductoInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = " ";
            this.panelTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel panelTop;
        private FontAwesome.Sharp.IconButton btnMin;
        private FontAwesome.Sharp.IconButton btnClose;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaTextBox txtLbNombreProducto;
        private Guna.UI.WinForms.GunaTextBox txtLbTipoProducto;
        private Guna.UI.WinForms.GunaTextBox txtLbDescripcionProducto;
        private Guna.UI.WinForms.GunaTextBox txtLbCantidadProducto;
        private System.Windows.Forms.Label label7;
        private Guna.UI.WinForms.GunaTextBox txtLbFechaProducto;
        private Guna.UI.WinForms.GunaTextBox txtLbMarcaProducto;
        private Guna.UI.WinForms.GunaTextBox txtLbIdProducto;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaButton btnOk;
        private Guna.UI.WinForms.GunaButton btnEdit;
        private Guna.UI.WinForms.GunaButton btnDlt;
        private Guna.UI.WinForms.GunaDragControl windowDragControl;
    }
}