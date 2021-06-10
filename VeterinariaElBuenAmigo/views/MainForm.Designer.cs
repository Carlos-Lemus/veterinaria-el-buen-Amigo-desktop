
namespace VeterinariaElBuenAmigo
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Guna.UI.Animation.Animation animation1 = new Guna.UI.Animation.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelNavegacion = new Guna.UI.WinForms.GunaPanel();
            this.btnConfiguracion = new FontAwesome.Sharp.IconButton();
            this.btnInventario = new FontAwesome.Sharp.IconButton();
            this.btnConsulta = new FontAwesome.Sharp.IconButton();
            this.btnCitas = new FontAwesome.Sharp.IconButton();
            this.btnPacientes = new FontAwesome.Sharp.IconButton();
            this.btnPropietario = new FontAwesome.Sharp.IconButton();
            this.btnDashboard = new FontAwesome.Sharp.IconButton();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.panelTop = new Guna.UI.WinForms.GunaPanel();
            this.btnMin = new FontAwesome.Sharp.IconButton();
            this.btnRestore = new FontAwesome.Sharp.IconButton();
            this.btnMax = new FontAwesome.Sharp.IconButton();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.windowDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.panelContenido = new Guna.UI.WinForms.GunaPanel();
            this.windowResize = new Guna.UI.WinForms.GunaResize(this.components);
            this.AnimacionPanelNavegacion = new Guna.UI.WinForms.GunaTransition(this.components);
            this.panelNavegacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNavegacion
            // 
            this.panelNavegacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.panelNavegacion.Controls.Add(this.btnConfiguracion);
            this.panelNavegacion.Controls.Add(this.btnInventario);
            this.panelNavegacion.Controls.Add(this.btnConsulta);
            this.panelNavegacion.Controls.Add(this.btnCitas);
            this.panelNavegacion.Controls.Add(this.btnPacientes);
            this.panelNavegacion.Controls.Add(this.btnPropietario);
            this.panelNavegacion.Controls.Add(this.btnDashboard);
            this.panelNavegacion.Controls.Add(this.pbLogo);
            this.AnimacionPanelNavegacion.SetDecoration(this.panelNavegacion, Guna.UI.Animation.DecorationType.None);
            this.panelNavegacion.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelNavegacion.Location = new System.Drawing.Point(0, 0);
            this.panelNavegacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelNavegacion.Name = "panelNavegacion";
            this.panelNavegacion.Size = new System.Drawing.Size(360, 886);
            this.panelNavegacion.TabIndex = 0;
            // 
            // btnConfiguracion
            // 
            this.btnConfiguracion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionPanelNavegacion.SetDecoration(this.btnConfiguracion, Guna.UI.Animation.DecorationType.None);
            this.btnConfiguracion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConfiguracion.FlatAppearance.BorderSize = 0;
            this.btnConfiguracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfiguracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfiguracion.ForeColor = System.Drawing.Color.White;
            this.btnConfiguracion.IconChar = FontAwesome.Sharp.IconChar.Cog;
            this.btnConfiguracion.IconColor = System.Drawing.Color.White;
            this.btnConfiguracion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnConfiguracion.IconSize = 52;
            this.btnConfiguracion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfiguracion.Location = new System.Drawing.Point(0, 628);
            this.btnConfiguracion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConfiguracion.MinimumSize = new System.Drawing.Size(349, 70);
            this.btnConfiguracion.Name = "btnConfiguracion";
            this.btnConfiguracion.Size = new System.Drawing.Size(360, 80);
            this.btnConfiguracion.TabIndex = 8;
            this.btnConfiguracion.Text = "Configuracion";
            this.btnConfiguracion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConfiguracion.UseVisualStyleBackColor = true;
            this.btnConfiguracion.Click += new System.EventHandler(this.btnConfiguracion_Click);
            // 
            // btnInventario
            // 
            this.btnInventario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionPanelNavegacion.SetDecoration(this.btnInventario, Guna.UI.Animation.DecorationType.None);
            this.btnInventario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInventario.FlatAppearance.BorderSize = 0;
            this.btnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventario.ForeColor = System.Drawing.Color.White;
            this.btnInventario.IconChar = FontAwesome.Sharp.IconChar.Bone;
            this.btnInventario.IconColor = System.Drawing.Color.White;
            this.btnInventario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInventario.IconSize = 52;
            this.btnInventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventario.Location = new System.Drawing.Point(0, 548);
            this.btnInventario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInventario.MinimumSize = new System.Drawing.Size(349, 70);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(360, 80);
            this.btnInventario.TabIndex = 7;
            this.btnInventario.Text = "Inventario";
            this.btnInventario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInventario.UseVisualStyleBackColor = true;
            this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click);
            // 
            // btnConsulta
            // 
            this.btnConsulta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionPanelNavegacion.SetDecoration(this.btnConsulta, Guna.UI.Animation.DecorationType.None);
            this.btnConsulta.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConsulta.FlatAppearance.BorderSize = 0;
            this.btnConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsulta.ForeColor = System.Drawing.Color.White;
            this.btnConsulta.IconChar = FontAwesome.Sharp.IconChar.Syringe;
            this.btnConsulta.IconColor = System.Drawing.Color.White;
            this.btnConsulta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnConsulta.IconSize = 52;
            this.btnConsulta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsulta.Location = new System.Drawing.Point(0, 468);
            this.btnConsulta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConsulta.MinimumSize = new System.Drawing.Size(349, 70);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(360, 80);
            this.btnConsulta.TabIndex = 5;
            this.btnConsulta.Text = "Consulta";
            this.btnConsulta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // btnCitas
            // 
            this.btnCitas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionPanelNavegacion.SetDecoration(this.btnCitas, Guna.UI.Animation.DecorationType.None);
            this.btnCitas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCitas.FlatAppearance.BorderSize = 0;
            this.btnCitas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCitas.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCitas.ForeColor = System.Drawing.Color.White;
            this.btnCitas.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            this.btnCitas.IconColor = System.Drawing.Color.White;
            this.btnCitas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCitas.IconSize = 52;
            this.btnCitas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCitas.Location = new System.Drawing.Point(0, 388);
            this.btnCitas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCitas.MinimumSize = new System.Drawing.Size(349, 70);
            this.btnCitas.Name = "btnCitas";
            this.btnCitas.Size = new System.Drawing.Size(360, 80);
            this.btnCitas.TabIndex = 4;
            this.btnCitas.Text = "Citas";
            this.btnCitas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCitas.UseVisualStyleBackColor = true;
            this.btnCitas.Click += new System.EventHandler(this.btnCitas_Click);
            // 
            // btnPacientes
            // 
            this.btnPacientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionPanelNavegacion.SetDecoration(this.btnPacientes, Guna.UI.Animation.DecorationType.None);
            this.btnPacientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPacientes.FlatAppearance.BorderSize = 0;
            this.btnPacientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPacientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPacientes.ForeColor = System.Drawing.Color.White;
            this.btnPacientes.IconChar = FontAwesome.Sharp.IconChar.Paw;
            this.btnPacientes.IconColor = System.Drawing.Color.White;
            this.btnPacientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPacientes.IconSize = 52;
            this.btnPacientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPacientes.Location = new System.Drawing.Point(0, 308);
            this.btnPacientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPacientes.MinimumSize = new System.Drawing.Size(349, 70);
            this.btnPacientes.Name = "btnPacientes";
            this.btnPacientes.Size = new System.Drawing.Size(360, 80);
            this.btnPacientes.TabIndex = 3;
            this.btnPacientes.Text = "Pacientes";
            this.btnPacientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPacientes.UseVisualStyleBackColor = true;
            this.btnPacientes.Click += new System.EventHandler(this.btnPacientes_Click);
            // 
            // btnPropietario
            // 
            this.btnPropietario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionPanelNavegacion.SetDecoration(this.btnPropietario, Guna.UI.Animation.DecorationType.None);
            this.btnPropietario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPropietario.FlatAppearance.BorderSize = 0;
            this.btnPropietario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPropietario.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPropietario.ForeColor = System.Drawing.Color.White;
            this.btnPropietario.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.btnPropietario.IconColor = System.Drawing.Color.White;
            this.btnPropietario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPropietario.IconSize = 52;
            this.btnPropietario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPropietario.Location = new System.Drawing.Point(0, 228);
            this.btnPropietario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPropietario.MinimumSize = new System.Drawing.Size(349, 70);
            this.btnPropietario.Name = "btnPropietario";
            this.btnPropietario.Size = new System.Drawing.Size(360, 80);
            this.btnPropietario.TabIndex = 2;
            this.btnPropietario.Text = "Propietarios";
            this.btnPropietario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPropietario.UseVisualStyleBackColor = true;
            this.btnPropietario.Click += new System.EventHandler(this.btnPropietario_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionPanelNavegacion.SetDecoration(this.btnDashboard, Guna.UI.Animation.DecorationType.None);
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.IconChar = FontAwesome.Sharp.IconChar.Bars;
            this.btnDashboard.IconColor = System.Drawing.Color.White;
            this.btnDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDashboard.IconSize = 52;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(0, 148);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDashboard.MinimumSize = new System.Drawing.Size(349, 70);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(360, 80);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // pbLogo
            // 
            this.AnimacionPanelNavegacion.SetDecoration(this.pbLogo, Guna.UI.Animation.DecorationType.None);
            this.pbLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbLogo.Image = global::VeterinariaElBuenAmigo.Properties.Resources.logo_menu;
            this.pbLogo.Location = new System.Drawing.Point(0, 0);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(360, 148);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.White;
            this.panelTop.Controls.Add(this.btnMin);
            this.panelTop.Controls.Add(this.btnRestore);
            this.panelTop.Controls.Add(this.btnMax);
            this.panelTop.Controls.Add(this.btnClose);
            this.AnimacionPanelNavegacion.SetDecoration(this.panelTop, Guna.UI.Animation.DecorationType.None);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(360, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1240, 37);
            this.panelTop.TabIndex = 1;
            // 
            // btnMin
            // 
            this.AnimacionPanelNavegacion.SetDecoration(this.btnMin, Guna.UI.Animation.DecorationType.None);
            this.btnMin.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMin.IconColor = System.Drawing.Color.Black;
            this.btnMin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMin.IconSize = 32;
            this.btnMin.Location = new System.Drawing.Point(1028, 0);
            this.btnMin.Margin = new System.Windows.Forms.Padding(0);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(53, 37);
            this.btnMin.TabIndex = 11;
            this.btnMin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnRestore
            // 
            this.AnimacionPanelNavegacion.SetDecoration(this.btnRestore, Guna.UI.Animation.DecorationType.None);
            this.btnRestore.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRestore.FlatAppearance.BorderSize = 0;
            this.btnRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestore.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            this.btnRestore.IconColor = System.Drawing.Color.Black;
            this.btnRestore.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRestore.IconSize = 32;
            this.btnRestore.Location = new System.Drawing.Point(1081, 0);
            this.btnRestore.Margin = new System.Windows.Forms.Padding(0);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(53, 37);
            this.btnRestore.TabIndex = 10;
            this.btnRestore.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Visible = false;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // btnMax
            // 
            this.AnimacionPanelNavegacion.SetDecoration(this.btnMax, Guna.UI.Animation.DecorationType.None);
            this.btnMax.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMax.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btnMax.IconColor = System.Drawing.Color.Black;
            this.btnMax.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMax.IconSize = 32;
            this.btnMax.Location = new System.Drawing.Point(1134, 0);
            this.btnMax.Margin = new System.Windows.Forms.Padding(0);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(53, 37);
            this.btnMax.TabIndex = 6;
            this.btnMax.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnClose
            // 
            this.AnimacionPanelNavegacion.SetDecoration(this.btnClose, Guna.UI.Animation.DecorationType.None);
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btnClose.IconColor = System.Drawing.Color.Black;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 32;
            this.btnClose.Location = new System.Drawing.Point(1187, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(53, 37);
            this.btnClose.TabIndex = 4;
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // windowDragControl1
            // 
            this.windowDragControl1.TargetControl = this.panelTop;
            // 
            // panelContenido
            // 
            this.panelContenido.BackColor = System.Drawing.Color.White;
            this.AnimacionPanelNavegacion.SetDecoration(this.panelContenido, Guna.UI.Animation.DecorationType.None);
            this.panelContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenido.Location = new System.Drawing.Point(360, 37);
            this.panelContenido.Margin = new System.Windows.Forms.Padding(0);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Size = new System.Drawing.Size(1240, 849);
            this.panelContenido.TabIndex = 2;
            // 
            // windowResize
            // 
            this.windowResize.TargetForm = this;
            // 
            // AnimacionPanelNavegacion
            // 
            this.AnimacionPanelNavegacion.AnimationType = Guna.UI.Animation.AnimationType.HorizSlide;
            this.AnimacionPanelNavegacion.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.AnimacionPanelNavegacion.DefaultAnimation = animation1;
            this.AnimacionPanelNavegacion.Interval = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 886);
            this.Controls.Add(this.panelContenido);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelNavegacion);
            this.AnimacionPanelNavegacion.SetDecoration(this, Guna.UI.Animation.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Veterinaria";
            this.panelNavegacion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel panelNavegacion;
        private Guna.UI.WinForms.GunaPanel panelTop;
        private FontAwesome.Sharp.IconButton btnMin;
        private FontAwesome.Sharp.IconButton btnRestore;
        private FontAwesome.Sharp.IconButton btnMax;
        private FontAwesome.Sharp.IconButton btnClose;
        private System.Windows.Forms.PictureBox pbLogo;
        private FontAwesome.Sharp.IconButton btnConfiguracion;
        private FontAwesome.Sharp.IconButton btnInventario;
        private FontAwesome.Sharp.IconButton btnConsulta;
        private FontAwesome.Sharp.IconButton btnCitas;
        private FontAwesome.Sharp.IconButton btnPacientes;
        private FontAwesome.Sharp.IconButton btnPropietario;
        private FontAwesome.Sharp.IconButton btnDashboard;
        private Guna.UI.WinForms.GunaDragControl windowDragControl1;
        private Guna.UI.WinForms.GunaPanel panelContenido;
        private Guna.UI.WinForms.GunaResize windowResize;
        private Guna.UI.WinForms.GunaTransition AnimacionPanelNavegacion;
    }
}

