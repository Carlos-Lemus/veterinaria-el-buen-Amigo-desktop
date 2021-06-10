
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblproducto = new System.Windows.Forms.Label();
            this.txtBuscarProducto = new Guna.UI.WinForms.GunaTextBox();
            this.dgvInventario = new Guna.UI.WinForms.GunaDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnClear = new Guna.UI.WinForms.GunaButton();
            this.btnDelete = new Guna.UI.WinForms.GunaButton();
            this.btnAddProducto = new Guna.UI.WinForms.GunaButton();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.iconButton5 = new FontAwesome.Sharp.IconButton();
            this.easyHTMLReports1 = new KimToo.EasyHTMLReports(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).BeginInit();
            this.SuspendLayout();
            // 
            // lblproducto
            // 
            this.lblproducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblproducto.Location = new System.Drawing.Point(48, 111);
            this.lblproducto.Name = "lblproducto";
            this.lblproducto.Size = new System.Drawing.Size(111, 35);
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
            this.txtBuscarProducto.Location = new System.Drawing.Point(165, 111);
            this.txtBuscarProducto.Name = "txtBuscarProducto";
            this.txtBuscarProducto.PasswordChar = '\0';
            this.txtBuscarProducto.Radius = 4;
            this.txtBuscarProducto.Size = new System.Drawing.Size(318, 35);
            this.txtBuscarProducto.TabIndex = 13;
            this.txtBuscarProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscarProducto_KeyPress);
            // 
            // dgvInventario
            // 
            this.dgvInventario.AllowUserToAddRows = false;
            this.dgvInventario.AllowUserToResizeRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            this.dgvInventario.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvInventario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInventario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInventario.BackgroundColor = System.Drawing.Color.White;
            this.dgvInventario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvInventario.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvInventario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInventario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvInventario.ColumnHeadersHeight = 40;
            this.dgvInventario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Editar,
            this.Eliminar});
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 14F);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInventario.DefaultCellStyle = dataGridViewCellStyle15;
            this.dgvInventario.EnableHeadersVisualStyles = false;
            this.dgvInventario.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.dgvInventario.Location = new System.Drawing.Point(49, 153);
            this.dgvInventario.Name = "dgvInventario";
            this.dgvInventario.RowHeadersVisible = false;
            this.dgvInventario.RowHeadersWidth = 51;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvInventario.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvInventario.RowTemplate.Height = 40;
            this.dgvInventario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInventario.Size = new System.Drawing.Size(825, 413);
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
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.FillWeight = 30F;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::VeterinariaElBuenAmigo.Properties.Resources.edit;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 31;
            // 
            // btnClear
            // 
            this.btnClear.AnimationHoverSpeed = 0.07F;
            this.btnClear.AnimationSpeed = 0.03F;
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.BaseColor = System.Drawing.Color.White;
            this.btnClear.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.btnClear.BorderSize = 2;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnClear.FocusedColor = System.Drawing.Color.White;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.Transparent;
            this.btnClear.Image = global::VeterinariaElBuenAmigo.Properties.Resources.ios_close1;
            this.btnClear.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnClear.ImageSize = new System.Drawing.Size(42, 42);
            this.btnClear.Location = new System.Drawing.Point(489, 111);
            this.btnClear.Name = "btnClear";
            this.btnClear.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(211)))));
            this.btnClear.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnClear.OnHoverForeColor = System.Drawing.Color.White;
            this.btnClear.OnHoverImage = null;
            this.btnClear.OnPressedColor = System.Drawing.Color.Black;
            this.btnClear.Radius = 5;
            this.btnClear.Size = new System.Drawing.Size(32, 35);
            this.btnClear.TabIndex = 34;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
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
            this.btnDelete.Location = new System.Drawing.Point(746, 110);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(117)))));
            this.btnDelete.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDelete.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDelete.OnHoverImage = null;
            this.btnDelete.OnPressedColor = System.Drawing.Color.Black;
            this.btnDelete.Radius = 5;
            this.btnDelete.Size = new System.Drawing.Size(131, 35);
            this.btnDelete.TabIndex = 32;
            this.btnDelete.Text = "Eliminar ";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
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
            this.btnAddProducto.Location = new System.Drawing.Point(49, 50);
            this.btnAddProducto.Name = "btnAddProducto";
            this.btnAddProducto.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.btnAddProducto.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddProducto.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAddProducto.OnHoverImage = null;
            this.btnAddProducto.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddProducto.Radius = 5;
            this.btnAddProducto.Size = new System.Drawing.Size(225, 35);
            this.btnAddProducto.TabIndex = 12;
            this.btnAddProducto.Text = "Agregar Producto";
            this.btnAddProducto.Click += new System.EventHandler(this.btnAddProducto_Click);
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
            // iconButton5
            // 
            this.iconButton5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.iconButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton5.FlatAppearance.BorderSize = 0;
            this.iconButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton5.ForeColor = System.Drawing.Color.White;
            this.iconButton5.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.iconButton5.IconColor = System.Drawing.Color.White;
            this.iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton5.IconSize = 32;
            this.iconButton5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton5.Location = new System.Drawing.Point(700, 110);
            this.iconButton5.Name = "iconButton5";
            this.iconButton5.Size = new System.Drawing.Size(40, 35);
            this.iconButton5.TabIndex = 40;
            this.iconButton5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton5.UseVisualStyleBackColor = false;
            this.iconButton5.Click += new System.EventHandler(this.iconButton5_Click);
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
            // FormInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(930, 640);
            this.Controls.Add(this.iconButton5);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.dgvInventario);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblproducto);
            this.Controls.Add(this.txtBuscarProducto);
            this.Controls.Add(this.btnAddProducto);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormInventario";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaButton btnAddProducto;
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
        private Guna.UI.WinForms.GunaButton btnClear;
        private FontAwesome.Sharp.IconButton iconButton5;
        private KimToo.EasyHTMLReports easyHTMLReports1;
    }
}