﻿
namespace VeterinariaElBuenAmigo.views
{
    partial class VentanaInicial
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_Clave = new Guna.UI.WinForms.GunaTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Ingresar = new Guna.UI.WinForms.GunaButton();
            this.lblError = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(900, 46);
            this.panelTop.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.label1.Location = new System.Drawing.Point(350, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 38);
            this.label1.TabIndex = 16;
            this.label1.Text = "BIENVENIDO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VeterinariaElBuenAmigo.Properties.Resources.Recurso_3;
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(216, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(471, 306);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // txt_Clave
            // 
            this.txt_Clave.BackColor = System.Drawing.Color.Transparent;
            this.txt_Clave.BaseColor = System.Drawing.Color.White;
            this.txt_Clave.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.txt_Clave.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Clave.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_Clave.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.txt_Clave.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.txt_Clave.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txt_Clave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.txt_Clave.Location = new System.Drawing.Point(216, 431);
            this.txt_Clave.Name = "txt_Clave";
            this.txt_Clave.PasswordChar = '●';
            this.txt_Clave.Radius = 15;
            this.txt_Clave.Size = new System.Drawing.Size(471, 42);
            this.txt_Clave.TabIndex = 1;
            this.txt_Clave.TextOffsetX = 10;
            this.txt_Clave.UseSystemPasswordChar = true;
            this.txt_Clave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Clave_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.label3.Location = new System.Drawing.Point(212, 394);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(240, 24);
            this.label3.TabIndex = 39;
            this.label3.Text = "Ingrese la Clave de Acceso";
            // 
            // btn_Ingresar
            // 
            this.btn_Ingresar.AnimationHoverSpeed = 0.07F;
            this.btn_Ingresar.AnimationSpeed = 0.03F;
            this.btn_Ingresar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Ingresar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.btn_Ingresar.BorderColor = System.Drawing.Color.Black;
            this.btn_Ingresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Ingresar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Ingresar.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Ingresar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Ingresar.ForeColor = System.Drawing.Color.White;
            this.btn_Ingresar.Image = null;
            this.btn_Ingresar.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Ingresar.Location = new System.Drawing.Point(216, 516);
            this.btn_Ingresar.Name = "btn_Ingresar";
            this.btn_Ingresar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.btn_Ingresar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Ingresar.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Ingresar.OnHoverImage = null;
            this.btn_Ingresar.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Ingresar.Radius = 5;
            this.btn_Ingresar.Size = new System.Drawing.Size(471, 42);
            this.btn_Ingresar.TabIndex = 2;
            this.btn_Ingresar.Text = "Ingresar";
            this.btn_Ingresar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Ingresar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // lblError
            // 
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(59)))), ((int)(((byte)(87)))));
            this.lblError.Location = new System.Drawing.Point(216, 478);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(471, 28);
            this.lblError.TabIndex = 40;
            this.lblError.Text = "La clave es incorrecta";
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblError.Visible = false;
            // 
            // VentanaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btn_Ingresar);
            this.Controls.Add(this.txt_Clave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "VentanaInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VentanaInicial";
            this.panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI.WinForms.GunaTextBox txt_Clave;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaButton btn_Ingresar;
        private System.Windows.Forms.Label lblError;
    }
}