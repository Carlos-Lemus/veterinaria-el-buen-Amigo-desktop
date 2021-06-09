
namespace VeterinariaElBuenAmigo.views.citas
{
    partial class FormCitaActions
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
            this.lblErrorMotivo = new System.Windows.Forms.Label();
            this.lblErrorPaciente = new System.Windows.Forms.Label();
            this.lblErrorFecha = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMotivo = new Guna.UI.WinForms.GunaTextBox();
            this.txtPaciente = new Guna.UI.WinForms.GunaTextBox();
            this.gunaDateTimePickerCita = new Guna.UI.WinForms.GunaDateTimePicker();
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
            this.panelTop.Margin = new System.Windows.Forms.Padding(4);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(733, 37);
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
            this.btnMin.Location = new System.Drawing.Point(627, 0);
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
            this.btnClose.Location = new System.Drawing.Point(680, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(53, 37);
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
            this.btnEdit.Location = new System.Drawing.Point(92, 709);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(211)))));
            this.btnEdit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnEdit.OnHoverForeColor = System.Drawing.Color.White;
            this.btnEdit.OnHoverImage = null;
            this.btnEdit.OnPressedColor = System.Drawing.Color.Black;
            this.btnEdit.Radius = 5;
            this.btnEdit.Size = new System.Drawing.Size(533, 43);
            this.btnEdit.TabIndex = 22;
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
            this.btnAdd.Location = new System.Drawing.Point(92, 658);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.OnHoverBaseColor = System.Drawing.Color.Empty;
            this.btnAdd.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAdd.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAdd.OnHoverImage = null;
            this.btnAdd.OnPressedColor = System.Drawing.Color.Black;
            this.btnAdd.Radius = 5;
            this.btnAdd.Size = new System.Drawing.Size(533, 43);
            this.btnAdd.TabIndex = 21;
            this.btnAdd.Text = "Guardar";
            this.btnAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblErrorMotivo
            // 
            this.lblErrorMotivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorMotivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(59)))), ((int)(((byte)(87)))));
            this.lblErrorMotivo.Location = new System.Drawing.Point(87, 502);
            this.lblErrorMotivo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblErrorMotivo.Name = "lblErrorMotivo";
            this.lblErrorMotivo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblErrorMotivo.Size = new System.Drawing.Size(539, 34);
            this.lblErrorMotivo.TabIndex = 35;
            this.lblErrorMotivo.Text = "Ingrese un motivo";
            this.lblErrorMotivo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblErrorMotivo.Visible = false;
            // 
            // lblErrorPaciente
            // 
            this.lblErrorPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorPaciente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(59)))), ((int)(((byte)(87)))));
            this.lblErrorPaciente.Location = new System.Drawing.Point(87, 297);
            this.lblErrorPaciente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblErrorPaciente.Name = "lblErrorPaciente";
            this.lblErrorPaciente.Size = new System.Drawing.Size(539, 34);
            this.lblErrorPaciente.TabIndex = 34;
            this.lblErrorPaciente.Text = "Seleccione un paciente";
            this.lblErrorPaciente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblErrorPaciente.Visible = false;
            // 
            // lblErrorFecha
            // 
            this.lblErrorFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(59)))), ((int)(((byte)(87)))));
            this.lblErrorFecha.Location = new System.Drawing.Point(87, 162);
            this.lblErrorFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblErrorFecha.Name = "lblErrorFecha";
            this.lblErrorFecha.Size = new System.Drawing.Size(539, 34);
            this.lblErrorFecha.TabIndex = 33;
            this.lblErrorFecha.Text = "La Fecha es Obligatoria";
            this.lblErrorFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblErrorFecha.Visible = false;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(87, 345);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(539, 34);
            this.label3.TabIndex = 30;
            this.label3.Text = "Motivo";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(87, 212);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(539, 34);
            this.label2.TabIndex = 29;
            this.label2.Text = "Paciente";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(87, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(539, 34);
            this.label1.TabIndex = 28;
            this.label1.Text = "Fecha";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMotivo
            // 
            this.txtMotivo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMotivo.BackColor = System.Drawing.Color.Transparent;
            this.txtMotivo.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.txtMotivo.BorderColor = System.Drawing.Color.White;
            this.txtMotivo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMotivo.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.txtMotivo.FocusedBorderColor = System.Drawing.Color.White;
            this.txtMotivo.FocusedForeColor = System.Drawing.Color.White;
            this.txtMotivo.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtMotivo.ForeColor = System.Drawing.Color.White;
            this.txtMotivo.Location = new System.Drawing.Point(92, 383);
            this.txtMotivo.Margin = new System.Windows.Forms.Padding(4);
            this.txtMotivo.MultiLine = true;
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.PasswordChar = '\0';
            this.txtMotivo.Radius = 4;
            this.txtMotivo.Size = new System.Drawing.Size(533, 116);
            this.txtMotivo.TabIndex = 27;
            // 
            // txtPaciente
            // 
            this.txtPaciente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPaciente.BackColor = System.Drawing.Color.Transparent;
            this.txtPaciente.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.txtPaciente.BorderColor = System.Drawing.Color.White;
            this.txtPaciente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPaciente.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.txtPaciente.FocusedBorderColor = System.Drawing.Color.White;
            this.txtPaciente.FocusedForeColor = System.Drawing.Color.White;
            this.txtPaciente.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtPaciente.ForeColor = System.Drawing.Color.White;
            this.txtPaciente.Location = new System.Drawing.Point(92, 250);
            this.txtPaciente.Margin = new System.Windows.Forms.Padding(4);
            this.txtPaciente.Name = "txtPaciente";
            this.txtPaciente.PasswordChar = '\0';
            this.txtPaciente.Radius = 4;
            this.txtPaciente.Size = new System.Drawing.Size(533, 52);
            this.txtPaciente.TabIndex = 26;
            // 
            // gunaDateTimePickerCita
            // 
            this.gunaDateTimePickerCita.BaseColor = System.Drawing.Color.White;
            this.gunaDateTimePickerCita.BorderColor = System.Drawing.Color.Silver;
            this.gunaDateTimePickerCita.CustomFormat = null;
            this.gunaDateTimePickerCita.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.gunaDateTimePickerCita.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaDateTimePickerCita.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaDateTimePickerCita.ForeColor = System.Drawing.Color.Black;
            this.gunaDateTimePickerCita.Location = new System.Drawing.Point(92, 114);
            this.gunaDateTimePickerCita.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaDateTimePickerCita.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.gunaDateTimePickerCita.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.gunaDateTimePickerCita.Name = "gunaDateTimePickerCita";
            this.gunaDateTimePickerCita.OnHoverBaseColor = System.Drawing.Color.White;
            this.gunaDateTimePickerCita.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaDateTimePickerCita.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaDateTimePickerCita.OnPressedColor = System.Drawing.Color.Black;
            this.gunaDateTimePickerCita.Size = new System.Drawing.Size(544, 44);
            this.gunaDateTimePickerCita.TabIndex = 36;
            this.gunaDateTimePickerCita.Text = "domingo, 6 de junio de 2021";
            this.gunaDateTimePickerCita.Value = new System.DateTime(2021, 6, 6, 21, 35, 28, 392);
            // 
            // FormCitaActions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.ClientSize = new System.Drawing.Size(733, 800);
            this.Controls.Add(this.gunaDateTimePickerCita);
            this.Controls.Add(this.lblErrorMotivo);
            this.Controls.Add(this.lblErrorPaciente);
            this.Controls.Add(this.lblErrorFecha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMotivo);
            this.Controls.Add(this.txtPaciente);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormCitaActions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Formulario de Citas";
            this.panelTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel panelTop;
        private FontAwesome.Sharp.IconButton btnMin;
        private FontAwesome.Sharp.IconButton btnClose;
        private Guna.UI.WinForms.GunaButton btnEdit;
        private Guna.UI.WinForms.GunaButton btnAdd;
        private System.Windows.Forms.Label lblErrorMotivo;
        private System.Windows.Forms.Label lblErrorPaciente;
        private System.Windows.Forms.Label lblErrorFecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaTextBox txtMotivo;
        private Guna.UI.WinForms.GunaTextBox txtPaciente;
        private Guna.UI.WinForms.GunaDateTimePicker gunaDateTimePickerCita;
    }
}