/*
 * Created by SharpDevelop.
 * User: Usuario
 * Date: 5/4/2026
 * Time: 12:03 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ProyectoEducativo
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.btnIngresar = new System.Windows.Forms.Button();
			this.txtContrasena = new System.Windows.Forms.TextBox();
			this.txtUsuario = new System.Windows.Forms.TextBox();
			this.lblUsuario = new System.Windows.Forms.Label();
			this.lblContrasena = new System.Windows.Forms.Label();
			this.cmbRol = new System.Windows.Forms.ComboBox();
			this.lblRol = new System.Windows.Forms.Label();
			this.btnCambiarIdioma = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnIngresar
			// 
			this.btnIngresar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnIngresar.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnIngresar.ForeColor = System.Drawing.SystemColors.Control;
			this.btnIngresar.Location = new System.Drawing.Point(182, 290);
			this.btnIngresar.Margin = new System.Windows.Forms.Padding(2);
			this.btnIngresar.Name = "btnIngresar";
			this.btnIngresar.Size = new System.Drawing.Size(118, 58);
			this.btnIngresar.TabIndex = 0;
			this.btnIngresar.Text = "Ingresar";
			this.btnIngresar.UseVisualStyleBackColor = false;
			this.btnIngresar.Click += new System.EventHandler(this.ButtonIngresarClick);
			// 
			// txtContrasena
			// 
			this.txtContrasena.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.txtContrasena.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtContrasena.ForeColor = System.Drawing.SystemColors.Control;
			this.txtContrasena.Location = new System.Drawing.Point(125, 150);
			this.txtContrasena.Margin = new System.Windows.Forms.Padding(2);
			this.txtContrasena.Multiline = true;
			this.txtContrasena.Name = "txtContrasena";
			this.txtContrasena.Size = new System.Drawing.Size(235, 34);
			this.txtContrasena.TabIndex = 1;
			// 
			// txtUsuario
			// 
			this.txtUsuario.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.txtUsuario.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUsuario.ForeColor = System.Drawing.SystemColors.Control;
			this.txtUsuario.Location = new System.Drawing.Point(125, 55);
			this.txtUsuario.Margin = new System.Windows.Forms.Padding(2);
			this.txtUsuario.Multiline = true;
			this.txtUsuario.Name = "txtUsuario";
			this.txtUsuario.Size = new System.Drawing.Size(235, 34);
			this.txtUsuario.TabIndex = 2;
			// 
			// lblUsuario
			// 
			this.lblUsuario.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.lblUsuario.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblUsuario.ForeColor = System.Drawing.Color.SteelBlue;
			this.lblUsuario.Location = new System.Drawing.Point(125, 27);
			this.lblUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblUsuario.Name = "lblUsuario";
			this.lblUsuario.Size = new System.Drawing.Size(140, 26);
			this.lblUsuario.TabIndex = 3;
			this.lblUsuario.Text = "USUARIO";
			// 
			// lblContrasena
			// 
			this.lblContrasena.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.lblContrasena.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblContrasena.ForeColor = System.Drawing.Color.SteelBlue;
			this.lblContrasena.Location = new System.Drawing.Point(125, 121);
			this.lblContrasena.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblContrasena.Name = "lblContrasena";
			this.lblContrasena.Size = new System.Drawing.Size(183, 27);
			this.lblContrasena.TabIndex = 4;
			this.lblContrasena.Text = "CONTRASEÑA";
			// 
			// cmbRol
			// 
			this.cmbRol.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.cmbRol.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbRol.ForeColor = System.Drawing.SystemColors.Control;
			this.cmbRol.FormattingEnabled = true;
			this.cmbRol.Items.AddRange(new object[] {
			"Administrador - Admin",
			"Jugador - Player"});
			this.cmbRol.Location = new System.Drawing.Point(128, 223);
			this.cmbRol.Margin = new System.Windows.Forms.Padding(2);
			this.cmbRol.Name = "cmbRol";
			this.cmbRol.Size = new System.Drawing.Size(232, 23);
			this.cmbRol.TabIndex = 5;
			// 
			// lblRol
			// 
			this.lblRol.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.lblRol.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRol.ForeColor = System.Drawing.Color.SteelBlue;
			this.lblRol.Location = new System.Drawing.Point(126, 198);
			this.lblRol.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblRol.Name = "lblRol";
			this.lblRol.Size = new System.Drawing.Size(174, 23);
			this.lblRol.TabIndex = 6;
			this.lblRol.Text = "Seleccione su rol:";
			// 
			// btnCambiarIdioma
			// 
			this.btnCambiarIdioma.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnCambiarIdioma.ForeColor = System.Drawing.SystemColors.Control;
			this.btnCambiarIdioma.Location = new System.Drawing.Point(575, 27);
			this.btnCambiarIdioma.Name = "btnCambiarIdioma";
			this.btnCambiarIdioma.Size = new System.Drawing.Size(114, 23);
			this.btnCambiarIdioma.TabIndex = 7;
			this.btnCambiarIdioma.Text = "Cambiar Idioma";
			this.btnCambiarIdioma.UseVisualStyleBackColor = false;
			this.btnCambiarIdioma.Click += new System.EventHandler(this.BtnCambiarIdiomaClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(730, 388);
			this.Controls.Add(this.btnCambiarIdioma);
			this.Controls.Add(this.lblRol);
			this.Controls.Add(this.cmbRol);
			this.Controls.Add(this.lblContrasena);
			this.Controls.Add(this.lblUsuario);
			this.Controls.Add(this.txtUsuario);
			this.Controls.Add(this.txtContrasena);
			this.Controls.Add(this.btnIngresar);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "MainForm";
			this.Text = "ProyectoEducativo";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		private System.Windows.Forms.Label lblRol;
		private System.Windows.Forms.ComboBox cmbRol;
		private System.Windows.Forms.Label lblContrasena;
		private System.Windows.Forms.Label lblUsuario;
		private System.Windows.Forms.TextBox txtUsuario;
		private System.Windows.Forms.TextBox txtContrasena;
		private System.Windows.Forms.Button btnIngresar;
		private System.Windows.Forms.Button btnCambiarIdioma;
	}
}
