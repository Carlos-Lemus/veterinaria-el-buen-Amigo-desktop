
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
            this.btnSingOut = new FontAwesome.Sharp.IconButton();
            this.panelContenido = new Guna.UI.WinForms.GunaPanel();
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
            this.panelNavegacion.Name = "panelNavegacion";
            this.panelNavegacion.Size = new System.Drawing.Size(270, 720);
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
            this.btnConfiguracion.Location = new System.Drawing.Point(0, 510);
            this.btnConfiguracion.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfiguracion.MinimumSize = new System.Drawing.Size(262, 57);
            this.btnConfiguracion.Name = "btnConfiguracion";
            this.btnConfiguracion.Size = new System.Drawing.Size(270, 65);
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
            this.btnInventario.Location = new System.Drawing.Point(0, 445);
            this.btnInventario.Margin = new System.Windows.Forms.Padding(2);
            this.btnInventario.MinimumSize = new System.Drawing.Size(262, 57);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(270, 65);
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
            this.btnConsulta.Location = new System.Drawing.Point(0, 380);
            this.btnConsulta.Margin = new System.Windows.Forms.Padding(2);
            this.btnConsulta.MinimumSize = new System.Drawing.Size(262, 57);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(270, 65);
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
            this.btnCitas.Location = new System.Drawing.Point(0, 315);
            this.btnCitas.Margin = new System.Windows.Forms.Padding(2);
            this.btnCitas.MinimumSize = new System.Drawing.Size(262, 57);
            this.btnCitas.Name = "btnCitas";
            this.btnCitas.Size = new System.Drawing.Size(270, 65);
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
            this.btnPacientes.Location = new System.Drawing.Point(0, 250);
            this.btnPacientes.Margin = new System.Windows.Forms.Padding(2);
            this.btnPacientes.MinimumSize = new System.Drawing.Size(262, 57);
            this.btnPacientes.Name = "btnPacientes";
            this.btnPacientes.Size = new System.Drawing.Size(270, 65);
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
            this.btnPropietario.Location = new System.Drawing.Point(0, 185);
            this.btnPropietario.Margin = new System.Windows.Forms.Padding(2);
            this.btnPropietario.MinimumSize = new System.Drawing.Size(262, 57);
            this.btnPropietario.Name = "btnPropietario";
            this.btnPropietario.Size = new System.Drawing.Size(270, 65);
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
            this.btnDashboard.Location = new System.Drawing.Point(0, 120);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(2);
            this.btnDashboard.MinimumSize = new System.Drawing.Size(262, 57);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(270, 65);
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
            this.pbLogo.Margin = new System.Windows.Forms.Padding(2);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(270, 120);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.White;
            this.panelTop.Controls.Add(this.btnSingOut);
            this.AnimacionPanelNavegacion.SetDecoration(this.panelTop, Guna.UI.Animation.DecorationType.None);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(270, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(930, 30);
            this.panelTop.TabIndex = 1;
            // 
            // btnSingOut
            // 
            this.btnSingOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionPanelNavegacion.SetDecoration(this.btnSingOut, Guna.UI.Animation.DecorationType.None);
            this.btnSingOut.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSingOut.FlatAppearance.BorderSize = 0;
            this.btnSingOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSingOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSingOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(82)))), ((int)(((byte)(83)))));
            this.btnSingOut.IconChar = FontAwesome.Sharp.IconChar.SignInAlt;
            this.btnSingOut.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(82)))), ((int)(((byte)(83)))));
            this.btnSingOut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSingOut.IconSize = 30;
            this.btnSingOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSingOut.Location = new System.Drawing.Point(768, 0);
            this.btnSingOut.Margin = new System.Windows.Forms.Padding(2);
            this.btnSingOut.Name = "btnSingOut";
            this.btnSingOut.Size = new System.Drawing.Size(162, 30);
            this.btnSingOut.TabIndex = 10;
            this.btnSingOut.Text = "Cerrar Sesion";
            this.btnSingOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSingOut.UseVisualStyleBackColor = true;
            this.btnSingOut.Click += new System.EventHandler(this.btnSingOut_Click);
            // 
            // panelContenido
            // 
            this.panelContenido.BackColor = System.Drawing.Color.White;
            this.AnimacionPanelNavegacion.SetDecoration(this.panelContenido, Guna.UI.Animation.DecorationType.None);
            this.panelContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenido.Location = new System.Drawing.Point(270, 30);
            this.panelContenido.Margin = new System.Windows.Forms.Padding(0);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Size = new System.Drawing.Size(930, 690);
            this.panelContenido.TabIndex = 2;
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.Controls.Add(this.panelContenido);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelNavegacion);
            this.AnimacionPanelNavegacion.SetDecoration(this, Guna.UI.Animation.DecorationType.None);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Veterinaria";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.panelNavegacion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel panelNavegacion;
        private Guna.UI.WinForms.GunaPanel panelTop;
        private System.Windows.Forms.PictureBox pbLogo;
        private FontAwesome.Sharp.IconButton btnConfiguracion;
        private FontAwesome.Sharp.IconButton btnInventario;
        private FontAwesome.Sharp.IconButton btnConsulta;
        private FontAwesome.Sharp.IconButton btnCitas;
        private FontAwesome.Sharp.IconButton btnPacientes;
        private FontAwesome.Sharp.IconButton btnPropietario;
        private FontAwesome.Sharp.IconButton btnDashboard;
        private Guna.UI.WinForms.GunaPanel panelContenido;
        private Guna.UI.WinForms.GunaTransition AnimacionPanelNavegacion;
        private FontAwesome.Sharp.IconButton btnSingOut;
    }
}

