
namespace VeterinariaElBuenAmigo.views.propietarios
{
    partial class FormPropietarioActions
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
            this.btnRestore = new FontAwesome.Sharp.IconButton();
            this.btnMax = new FontAwesome.Sharp.IconButton();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.windowDragControl = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.btnAdd = new Guna.UI.WinForms.GunaButton();
            this.txtNombre = new Guna.UI.WinForms.GunaTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDireccion = new Guna.UI.WinForms.GunaTextBox();
            this.txtTelefono = new Guna.UI.WinForms.GunaTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label123 = new System.Windows.Forms.Label();
            this.label1212 = new System.Windows.Forms.Label();
            this.txtCorreo = new Guna.UI.WinForms.GunaTextBox();
            this.btnEdit = new Guna.UI.WinForms.GunaButton();
            this.lblErrorTelefono = new System.Windows.Forms.Label();
            this.lblErrorDireccion = new System.Windows.Forms.Label();
            this.lblErrorNombre = new System.Windows.Forms.Label();
            this.windowResize = new Guna.UI.WinForms.GunaResize(this.components);
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.panelTop.Controls.Add(this.btnMin);
            this.panelTop.Controls.Add(this.btnRestore);
            this.panelTop.Controls.Add(this.btnMax);
            this.panelTop.Controls.Add(this.btnClose);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(550, 30);
            this.panelTop.TabIndex = 2;
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
            this.btnMin.Location = new System.Drawing.Point(390, 0);
            this.btnMin.Margin = new System.Windows.Forms.Padding(0);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(40, 30);
            this.btnMin.TabIndex = 11;
            this.btnMin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRestore.FlatAppearance.BorderSize = 0;
            this.btnRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestore.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            this.btnRestore.IconColor = System.Drawing.Color.White;
            this.btnRestore.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRestore.IconSize = 32;
            this.btnRestore.Location = new System.Drawing.Point(430, 0);
            this.btnRestore.Margin = new System.Windows.Forms.Padding(0);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(40, 30);
            this.btnRestore.TabIndex = 10;
            this.btnRestore.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Visible = false;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // btnMax
            // 
            this.btnMax.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMax.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btnMax.IconColor = System.Drawing.Color.White;
            this.btnMax.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMax.IconSize = 32;
            this.btnMax.Location = new System.Drawing.Point(470, 0);
            this.btnMax.Margin = new System.Windows.Forms.Padding(0);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(40, 30);
            this.btnMax.TabIndex = 6;
            this.btnMax.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
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
            this.btnClose.Location = new System.Drawing.Point(510, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 30);
            this.btnClose.TabIndex = 4;
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // windowDragControl
            // 
            this.windowDragControl.TargetControl = this.panelTop;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.AnimationHoverSpeed = 0.07F;
            this.btnAdd.AnimationSpeed = 0.03F;
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.btnAdd.BorderColor = System.Drawing.Color.Black;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAdd.FocusedColor = System.Drawing.Color.Empty;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = null;
            this.btnAdd.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAdd.Location = new System.Drawing.Point(70, 552);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(211)))));
            this.btnAdd.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAdd.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAdd.OnHoverImage = null;
            this.btnAdd.OnPressedColor = System.Drawing.Color.Black;
            this.btnAdd.Radius = 5;
            this.btnAdd.Size = new System.Drawing.Size(400, 35);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Guardar";
            this.btnAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.BackColor = System.Drawing.Color.Transparent;
            this.txtNombre.BaseColor = System.Drawing.Color.White;
            this.txtNombre.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(211)))));
            this.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombre.FocusedBaseColor = System.Drawing.Color.White;
            this.txtNombre.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.txtNombre.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtNombre.Location = new System.Drawing.Point(70, 146);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.Radius = 4;
            this.txtNombre.Size = new System.Drawing.Size(400, 35);
            this.txtNombre.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(120, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 48);
            this.label1.TabIndex = 7;
            this.label1.Text = "Datos del propietario";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDireccion.BackColor = System.Drawing.Color.Transparent;
            this.txtDireccion.BaseColor = System.Drawing.Color.White;
            this.txtDireccion.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(211)))));
            this.txtDireccion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDireccion.FocusedBaseColor = System.Drawing.Color.White;
            this.txtDireccion.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.txtDireccion.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtDireccion.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtDireccion.Location = new System.Drawing.Point(70, 255);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.PasswordChar = '\0';
            this.txtDireccion.Radius = 4;
            this.txtDireccion.Size = new System.Drawing.Size(400, 35);
            this.txtDireccion.TabIndex = 11;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTelefono.BackColor = System.Drawing.Color.Transparent;
            this.txtTelefono.BaseColor = System.Drawing.Color.White;
            this.txtTelefono.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(211)))));
            this.txtTelefono.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTelefono.FocusedBaseColor = System.Drawing.Color.White;
            this.txtTelefono.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.txtTelefono.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTelefono.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtTelefono.Location = new System.Drawing.Point(70, 363);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.PasswordChar = '\0';
            this.txtTelefono.Radius = 4;
            this.txtTelefono.Size = new System.Drawing.Size(400, 35);
            this.txtTelefono.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(404, 28);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nombre y Apellido";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(66, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(404, 28);
            this.label6.TabIndex = 16;
            this.label6.Text = "Direccion ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label123
            // 
            this.label123.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label123.Location = new System.Drawing.Point(66, 332);
            this.label123.Name = "label123";
            this.label123.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label123.Size = new System.Drawing.Size(404, 28);
            this.label123.TabIndex = 17;
            this.label123.Text = "Telefono ";
            this.label123.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1212
            // 
            this.label1212.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1212.Location = new System.Drawing.Point(66, 440);
            this.label1212.Name = "label1212";
            this.label1212.Size = new System.Drawing.Size(404, 28);
            this.label1212.TabIndex = 19;
            this.label1212.Text = "Correo ";
            this.label1212.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCorreo.BackColor = System.Drawing.Color.Transparent;
            this.txtCorreo.BaseColor = System.Drawing.Color.White;
            this.txtCorreo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(211)))));
            this.txtCorreo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCorreo.FocusedBaseColor = System.Drawing.Color.White;
            this.txtCorreo.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.txtCorreo.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCorreo.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtCorreo.Location = new System.Drawing.Point(70, 471);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.PasswordChar = '\0';
            this.txtCorreo.Radius = 4;
            this.txtCorreo.Size = new System.Drawing.Size(400, 35);
            this.txtCorreo.TabIndex = 18;
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
            this.btnEdit.Location = new System.Drawing.Point(70, 593);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(211)))));
            this.btnEdit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnEdit.OnHoverForeColor = System.Drawing.Color.White;
            this.btnEdit.OnHoverImage = null;
            this.btnEdit.OnPressedColor = System.Drawing.Color.Black;
            this.btnEdit.Radius = 5;
            this.btnEdit.Size = new System.Drawing.Size(400, 35);
            this.btnEdit.TabIndex = 20;
            this.btnEdit.Text = "Editar";
            this.btnEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lblErrorTelefono
            // 
            this.lblErrorTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(82)))), ((int)(((byte)(83)))));
            this.lblErrorTelefono.Location = new System.Drawing.Point(66, 401);
            this.lblErrorTelefono.Name = "lblErrorTelefono";
            this.lblErrorTelefono.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblErrorTelefono.Size = new System.Drawing.Size(404, 28);
            this.lblErrorTelefono.TabIndex = 24;
            this.lblErrorTelefono.Text = "El telefono es obligatorio";
            this.lblErrorTelefono.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblErrorTelefono.Visible = false;
            // 
            // lblErrorDireccion
            // 
            this.lblErrorDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorDireccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(82)))), ((int)(((byte)(83)))));
            this.lblErrorDireccion.Location = new System.Drawing.Point(66, 293);
            this.lblErrorDireccion.Name = "lblErrorDireccion";
            this.lblErrorDireccion.Size = new System.Drawing.Size(404, 28);
            this.lblErrorDireccion.TabIndex = 23;
            this.lblErrorDireccion.Text = "La direccion es obligatorio";
            this.lblErrorDireccion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblErrorDireccion.Visible = false;
            // 
            // lblErrorNombre
            // 
            this.lblErrorNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(82)))), ((int)(((byte)(83)))));
            this.lblErrorNombre.Location = new System.Drawing.Point(66, 184);
            this.lblErrorNombre.Name = "lblErrorNombre";
            this.lblErrorNombre.Size = new System.Drawing.Size(404, 28);
            this.lblErrorNombre.TabIndex = 22;
            this.lblErrorNombre.Text = "El nombre y apellido son obligatorios";
            this.lblErrorNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblErrorNombre.Visible = false;
            // 
            // windowResize
            // 
            this.windowResize.TargetForm = this;
            // 
            // FormPropietarioActions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(550, 650);
            this.Controls.Add(this.lblErrorTelefono);
            this.Controls.Add(this.lblErrorDireccion);
            this.Controls.Add(this.lblErrorNombre);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.label1212);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.label123);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPropietarioActions";
            this.Text = "FormPropietarioAdd";
            this.panelTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel panelTop;
        private FontAwesome.Sharp.IconButton btnMin;
        private FontAwesome.Sharp.IconButton btnRestore;
        private FontAwesome.Sharp.IconButton btnMax;
        private FontAwesome.Sharp.IconButton btnClose;
        private Guna.UI.WinForms.GunaDragControl windowDragControl;
        private Guna.UI.WinForms.GunaButton btnAdd;
        private Guna.UI.WinForms.GunaTextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaTextBox txtTelefono;
        private Guna.UI.WinForms.GunaTextBox txtDireccion;
        private System.Windows.Forms.Label label1212;
        private Guna.UI.WinForms.GunaTextBox txtCorreo;
        private System.Windows.Forms.Label label123;
        private System.Windows.Forms.Label label6;
        private Guna.UI.WinForms.GunaButton btnEdit;
        private System.Windows.Forms.Label lblErrorTelefono;
        private System.Windows.Forms.Label lblErrorDireccion;
        private System.Windows.Forms.Label lblErrorNombre;
        private Guna.UI.WinForms.GunaResize windowResize;
    }
}