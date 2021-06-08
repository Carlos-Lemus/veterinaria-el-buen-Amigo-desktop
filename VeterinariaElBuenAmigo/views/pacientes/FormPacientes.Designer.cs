
namespace VeterinariaElBuenAmigo.views
{
    partial class FormPacientes
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
            this.btnBuscarPaciente = new Guna.UI.WinForms.GunaButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvMascotas = new Guna.UI.WinForms.GunaDataGridView();
            this.txtBuscarPaciente = new Guna.UI.WinForms.GunaTextBox();
            this.lblPacientes = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dueño = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMascotas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscarPaciente
            // 
            this.btnBuscarPaciente.AnimationHoverSpeed = 0.07F;
            this.btnBuscarPaciente.AnimationSpeed = 0.03F;
            this.btnBuscarPaciente.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarPaciente.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.btnBuscarPaciente.BorderColor = System.Drawing.Color.Black;
            this.btnBuscarPaciente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarPaciente.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBuscarPaciente.FocusedColor = System.Drawing.Color.Empty;
            this.btnBuscarPaciente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnBuscarPaciente.ForeColor = System.Drawing.Color.White;
            this.btnBuscarPaciente.Image = null;
            this.btnBuscarPaciente.ImageSize = new System.Drawing.Size(20, 20);
            this.btnBuscarPaciente.Location = new System.Drawing.Point(595, 135);
            this.btnBuscarPaciente.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarPaciente.Name = "btnBuscarPaciente";
            this.btnBuscarPaciente.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(211)))));
            this.btnBuscarPaciente.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnBuscarPaciente.OnHoverForeColor = System.Drawing.Color.White;
            this.btnBuscarPaciente.OnHoverImage = null;
            this.btnBuscarPaciente.OnPressedColor = System.Drawing.Color.Black;
            this.btnBuscarPaciente.Radius = 5;
            this.btnBuscarPaciente.Size = new System.Drawing.Size(137, 43);
            this.btnBuscarPaciente.TabIndex = 10;
            this.btnBuscarPaciente.Text = "Buscar";
            this.btnBuscarPaciente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 135);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 43);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nombre";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvMascotas
            // 
            this.dgvMascotas.AllowUserToAddRows = false;
            this.dgvMascotas.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvMascotas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMascotas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMascotas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMascotas.BackgroundColor = System.Drawing.Color.White;
            this.dgvMascotas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMascotas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMascotas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMascotas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMascotas.ColumnHeadersHeight = 40;
            this.dgvMascotas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Dueño,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 14F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMascotas.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMascotas.EnableHeadersVisualStyles = false;
            this.dgvMascotas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.dgvMascotas.Location = new System.Drawing.Point(73, 272);
            this.dgvMascotas.Margin = new System.Windows.Forms.Padding(4);
            this.dgvMascotas.Name = "dgvMascotas";
            this.dgvMascotas.ReadOnly = true;
            this.dgvMascotas.RowHeadersVisible = false;
            this.dgvMascotas.RowHeadersWidth = 51;
            this.dgvMascotas.RowTemplate.Height = 40;
            this.dgvMascotas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMascotas.Size = new System.Drawing.Size(1100, 508);
            this.dgvMascotas.TabIndex = 8;
            this.dgvMascotas.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgvMascotas.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvMascotas.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvMascotas.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvMascotas.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvMascotas.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvMascotas.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvMascotas.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.dgvMascotas.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.dgvMascotas.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvMascotas.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.dgvMascotas.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvMascotas.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvMascotas.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvMascotas.ThemeStyle.ReadOnly = true;
            this.dgvMascotas.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvMascotas.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMascotas.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.dgvMascotas.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.dgvMascotas.ThemeStyle.RowsStyle.Height = 40;
            this.dgvMascotas.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            this.dgvMascotas.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.dgvMascotas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMascotas_CellDoubleClick);
            // 
            // txtBuscarPaciente
            // 
            this.txtBuscarPaciente.BackColor = System.Drawing.Color.Transparent;
            this.txtBuscarPaciente.BaseColor = System.Drawing.Color.White;
            this.txtBuscarPaciente.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(211)))));
            this.txtBuscarPaciente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscarPaciente.FocusedBaseColor = System.Drawing.Color.White;
            this.txtBuscarPaciente.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.txtBuscarPaciente.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtBuscarPaciente.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtBuscarPaciente.Location = new System.Drawing.Point(192, 135);
            this.txtBuscarPaciente.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscarPaciente.Name = "txtBuscarPaciente";
            this.txtBuscarPaciente.PasswordChar = '\0';
            this.txtBuscarPaciente.Radius = 4;
            this.txtBuscarPaciente.Size = new System.Drawing.Size(376, 52);
            this.txtBuscarPaciente.TabIndex = 7;
            // 
            // lblPacientes
            // 
            this.lblPacientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPacientes.Location = new System.Drawing.Point(68, 69);
            this.lblPacientes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPacientes.Name = "lblPacientes";
            this.lblPacientes.Size = new System.Drawing.Size(353, 37);
            this.lblPacientes.TabIndex = 6;
            this.lblPacientes.Text = "Pacientes registrados: N";
            this.lblPacientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 30F;
            this.Column1.HeaderText = "Id";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 145F;
            this.Column2.HeaderText = "Nombre";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Dueño
            // 
            this.Dueño.HeaderText = "Dueño";
            this.Dueño.MinimumWidth = 6;
            this.Dueño.Name = "Dueño";
            this.Dueño.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 145F;
            this.Column3.HeaderText = "Color";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Genero";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // FormPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1240, 849);
            this.Controls.Add(this.btnBuscarPaciente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvMascotas);
            this.Controls.Add(this.txtBuscarPaciente);
            this.Controls.Add(this.lblPacientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormPacientes";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMascotas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaButton btnBuscarPaciente;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaDataGridView dgvMascotas;
        private Guna.UI.WinForms.GunaTextBox txtBuscarPaciente;
        private System.Windows.Forms.Label lblPacientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dueño;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}