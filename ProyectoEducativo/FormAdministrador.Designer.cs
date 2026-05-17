/*
 * Created by SharpDevelop.
 * User: Usuario
 * Date: 5/4/2026
 * Time: 12:27 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ProyectoEducativo
{
	partial class FormAdministrador
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdministrador));
			this.label1 = new System.Windows.Forms.Label();
			this.buttonGestionarModulos = new System.Windows.Forms.Button();
			this.GestionarUsuarios = new System.Windows.Forms.Button();
			this.buttonGestionarPreguntas = new System.Windows.Forms.Button();
			this.buttonCerrarSesion = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.SteelBlue;
			this.label1.Location = new System.Drawing.Point(93, 55);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(324, 33);
			this.label1.TabIndex = 0;
			this.label1.Text = "MENU  ADMINISTRADOR";
			// 
			// buttonGestionarModulos
			// 
			this.buttonGestionarModulos.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonGestionarModulos.ForeColor = System.Drawing.SystemColors.Control;
			this.buttonGestionarModulos.Image = ((System.Drawing.Image)(resources.GetObject("buttonGestionarModulos.Image")));
			this.buttonGestionarModulos.Location = new System.Drawing.Point(215, 131);
			this.buttonGestionarModulos.Margin = new System.Windows.Forms.Padding(2);
			this.buttonGestionarModulos.Name = "buttonGestionarModulos";
			this.buttonGestionarModulos.Size = new System.Drawing.Size(90, 44);
			this.buttonGestionarModulos.TabIndex = 1;
			this.buttonGestionarModulos.Text = "Gestionar Modulos";
			this.buttonGestionarModulos.UseVisualStyleBackColor = true;
			this.buttonGestionarModulos.Click += new System.EventHandler(this.ButtonGestionarModulosClick);
			// 
			// GestionarUsuarios
			// 
			this.GestionarUsuarios.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GestionarUsuarios.BackgroundImage")));
			this.GestionarUsuarios.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.GestionarUsuarios.ForeColor = System.Drawing.SystemColors.Control;
			this.GestionarUsuarios.Location = new System.Drawing.Point(79, 131);
			this.GestionarUsuarios.Margin = new System.Windows.Forms.Padding(2);
			this.GestionarUsuarios.Name = "GestionarUsuarios";
			this.GestionarUsuarios.Size = new System.Drawing.Size(98, 44);
			this.GestionarUsuarios.TabIndex = 2;
			this.GestionarUsuarios.Text = "Gestionar Usuarios";
			this.GestionarUsuarios.UseVisualStyleBackColor = true;
			this.GestionarUsuarios.Click += new System.EventHandler(this.GestionarUsuariosClick);
			// 
			// buttonGestionarPreguntas
			// 
			this.buttonGestionarPreguntas.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonGestionarPreguntas.ForeColor = System.Drawing.SystemColors.Control;
			this.buttonGestionarPreguntas.Image = ((System.Drawing.Image)(resources.GetObject("buttonGestionarPreguntas.Image")));
			this.buttonGestionarPreguntas.Location = new System.Drawing.Point(342, 131);
			this.buttonGestionarPreguntas.Margin = new System.Windows.Forms.Padding(2);
			this.buttonGestionarPreguntas.Name = "buttonGestionarPreguntas";
			this.buttonGestionarPreguntas.Size = new System.Drawing.Size(90, 44);
			this.buttonGestionarPreguntas.TabIndex = 4;
			this.buttonGestionarPreguntas.Text = "Gestionar Preguntas";
			this.buttonGestionarPreguntas.UseVisualStyleBackColor = true;
			this.buttonGestionarPreguntas.Click += new System.EventHandler(this.ButtonGestionarPreguntasClick);
			// 
			// buttonCerrarSesion
			// 
			this.buttonCerrarSesion.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonCerrarSesion.ForeColor = System.Drawing.SystemColors.Control;
			this.buttonCerrarSesion.Image = ((System.Drawing.Image)(resources.GetObject("buttonCerrarSesion.Image")));
			this.buttonCerrarSesion.Location = new System.Drawing.Point(215, 293);
			this.buttonCerrarSesion.Margin = new System.Windows.Forms.Padding(2);
			this.buttonCerrarSesion.Name = "buttonCerrarSesion";
			this.buttonCerrarSesion.Size = new System.Drawing.Size(90, 44);
			this.buttonCerrarSesion.TabIndex = 5;
			this.buttonCerrarSesion.Text = "Cerrar Sesion";
			this.buttonCerrarSesion.UseVisualStyleBackColor = true;
			this.buttonCerrarSesion.Click += new System.EventHandler(this.ButtonCerrarSesionClick);
			// 
			// FormAdministrador
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.ClientSize = new System.Drawing.Size(508, 386);
			this.Controls.Add(this.buttonCerrarSesion);
			this.Controls.Add(this.buttonGestionarPreguntas);
			this.Controls.Add(this.GestionarUsuarios);
			this.Controls.Add(this.buttonGestionarModulos);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "FormAdministrador";
			this.Text = "FormAdministrador";
			this.ResumeLayout(false);

		}
		private System.Windows.Forms.Button buttonCerrarSesion;
		private System.Windows.Forms.Button buttonGestionarPreguntas;
		private System.Windows.Forms.Button GestionarUsuarios;
		private System.Windows.Forms.Button buttonGestionarModulos;
		private System.Windows.Forms.Label label1;
	}
}
