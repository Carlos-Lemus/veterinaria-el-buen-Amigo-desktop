
namespace VeterinariaElBuenAmigo.views
{
    partial class FormInventario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAddProducto = new Guna.UI.WinForms.GunaButton();
            this.btnBuscarProducto = new Guna.UI.WinForms.GunaButton();
            this.lblproducto = new System.Windows.Forms.Label();
            this.txtBuscarProducto = new Guna.UI.WinForms.GunaTextBox();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnDelete = new Guna.UI.WinForms.GunaButton();
            this.dgvInventario = new Guna.UI.WinForms.GunaDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddProducto
            // 
            this.btnAddProducto.AnimationHoverSpeed = 0.07F;
            this.btnAddProducto.AnimationSpeed = 0.03F;
            this.btnAddProducto.BackColor = System.Drawing.Color.Transparent;
            this.btnAddProducto.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.btnAddProducto.BorderColor = System.Drawing.Color.Black;
            this.btnAddProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddProducto.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddProducto.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddProducto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddProducto.ForeColor = System.Drawing.Color.White;
            this.btnAddProducto.Image = global::VeterinariaElBuenAmigo.Properties.Resources.add;
            this.btnAddProducto.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAddProducto.Location = new System.Drawing.Point(65, 62);
            this.btnAddProducto.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddProducto.Name = "btnAddProducto";
            this.btnAddProducto.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(211)))));
            this.btnAddProducto.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddProducto.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAddProducto.OnHoverImage = null;
            this.btnAddProducto.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddProducto.Radius = 5;
            this.btnAddProducto.Size = new System.Drawing.Size(300, 43);
            this.btnAddProducto.TabIndex = 12;
            this.btnAddProducto.Text = "Agregar Producto";
            this.btnAddProducto.Click += new System.EventHandler(this.btnAddProducto_Click);
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.AnimationHoverSpeed = 0.07F;
            this.btnBuscarProducto.AnimationSpeed = 0.03F;
            this.btnBuscarProducto.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarProducto.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.btnBuscarProducto.BorderColor = System.Drawing.Color.Black;
            this.btnBuscarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarProducto.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBuscarProducto.FocusedColor = System.Drawing.Color.Empty;
            this.btnBuscarProducto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnBuscarProducto.ForeColor = System.Drawing.Color.White;
            this.btnBuscarProducto.Image = global::VeterinariaElBuenAmigo.Properties.Resources.search;
            this.btnBuscarProducto.ImageSize = new System.Drawing.Size(20, 20);
            this.btnBuscarProducto.Location = new System.Drawing.Point(652, 137);
            this.btnBuscarProducto.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(211)))));
            this.btnBuscarProducto.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnBuscarProducto.OnHoverForeColor = System.Drawing.Color.White;
            this.btnBuscarProducto.OnHoverImage = null;
            this.btnBuscarProducto.OnPressedColor = System.Drawing.Color.Black;
            this.btnBuscarProducto.Radius = 5;
            this.btnBuscarProducto.Size = new System.Drawing.Size(170, 43);
            this.btnBuscarProducto.TabIndex = 15;
            this.btnBuscarProducto.Text = "Buscar";
            // 
            // lblproducto
            // 
            this.lblproducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblproducto.Location = new System.Drawing.Point(64, 137);
            this.lblproducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblproducto.Name = "lblproducto";
            this.lblproducto.Size = new System.Drawing.Size(148, 43);
            this.lblproducto.TabIndex = 14;
            this.lblproducto.Text = "Producto";
            this.lblproducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtBuscarProducto
            // 
            this.txtBuscarProducto.BackColor = System.Drawing.Color.Transparent;
            this.txtBuscarProducto.BaseColor = System.Drawing.Color.White;
            this.txtBuscarProducto.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(211)))));
            this.txtBuscarProducto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscarProducto.FocusedBaseColor = System.Drawing.Color.White;
            this.txtBuscarProducto.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.txtBuscarProducto.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtBuscarProducto.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtBuscarProducto.Location = new System.Drawing.Point(220, 137);
            this.txtBuscarProducto.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscarProducto.Name = "txtBuscarProducto";
            this.txtBuscarProducto.PasswordChar = '\0';
            this.txtBuscarProducto.Radius = 4;
            this.txtBuscarProducto.Size = new System.Drawing.Size(424, 43);
            this.txtBuscarProducto.TabIndex = 13;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.FillWeight = 30F;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::VeterinariaElBuenAmigo.Properties.Resources.edit;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 31;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.FillWeight = 30F;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::VeterinariaElBuenAmigo.Properties.Resources.delete;
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.MinimumWidth = 6;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 32;
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
            this.btnDelete.Location = new System.Drawing.Point(994, 136);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(117)))));
            this.btnDelete.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDelete.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDelete.OnHoverImage = null;
            this.btnDelete.OnPressedColor = System.Drawing.Color.Black;
            this.btnDelete.Radius = 5;
            this.btnDelete.Size = new System.Drawing.Size(175, 43);
            this.btnDelete.TabIndex = 32;
            this.btnDelete.Text = "Eliminar ";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgvInventario
            // 
            this.dgvInventario.AllowUserToAddRows = false;
            this.dgvInventario.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.dgvInventario.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvInventario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInventario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInventario.BackgroundColor = System.Drawing.Color.White;
            this.dgvInventario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvInventario.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvInventario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInventario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvInventario.ColumnHeadersHeight = 40;
            this.dgvInventario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Editar,
            this.Eliminar});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 14F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInventario.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvInventario.EnableHeadersVisualStyles = false;
            this.dgvInventario.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.dgvInventario.Location = new System.Drawing.Point(65, 188);
            this.dgvInventario.Margin = new System.Windows.Forms.Padding(4);
            this.dgvInventario.Name = "dgvInventario";
            this.dgvInventario.RowHeadersVisible = false;
            this.dgvInventario.RowHeadersWidth = 51;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvInventario.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvInventario.RowTemplate.Height = 40;
            this.dgvInventario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInventario.Size = new System.Drawing.Size(1100, 508);
            this.dgvInventario.TabIndex = 33;
            this.dgvInventario.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgvInventario.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvInventario.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvInventario.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvInventario.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvInventario.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvInventario.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvInventario.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.dgvInventario.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.dgvInventario.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvInventario.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.dgvInventario.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvInventario.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvInventario.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvInventario.ThemeStyle.ReadOnly = false;
            this.dgvInventario.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvInventario.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvInventario.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.dgvInventario.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.dgvInventario.ThemeStyle.RowsStyle.Height = 40;
            this.dgvInventario.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            this.dgvInventario.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.dgvInventario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInventario_CellClick);
            this.dgvInventario.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInventario_CellDoubleClick);
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
            this.Column2.HeaderText = "Producto";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Existencias";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Tipo";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Editar
            // 
            this.Editar.FillWeight = 25F;
            this.Editar.HeaderText = "";
            this.Editar.Image = global::VeterinariaElBuenAmigo.Properties.Resources.edit;
            this.Editar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Editar.MinimumWidth = 6;
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            // 
            // Eliminar
            // 
            this.Eliminar.FillWeight = 25F;
            this.Eliminar.HeaderText = "";
            this.Eliminar.MinimumWidth = 6;
            this.Eliminar.Name = "Eliminar";
            // 
            // FormInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1240, 849);
            this.Controls.Add(this.dgvInventario);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnBuscarProducto);
            this.Controls.Add(this.lblproducto);
            this.Controls.Add(this.txtBuscarProducto);
            this.Controls.Add(this.btnAddProducto);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormInventario";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaButton btnAddProducto;
        private Guna.UI.WinForms.GunaButton btnBuscarProducto;
        private System.Windows.Forms.Label lblproducto;
        private Guna.UI.WinForms.GunaTextBox txtBuscarProducto;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private Guna.UI.WinForms.GunaButton btnDelete;
        private Guna.UI.WinForms.GunaDataGridView dgvInventario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
    }
}