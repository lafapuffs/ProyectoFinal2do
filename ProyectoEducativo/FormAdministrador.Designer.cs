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
			this.lblAdmin = new System.Windows.Forms.Label();
			this.btnGestionarModulos = new System.Windows.Forms.Button();
			this.btnGestionarUsuarios = new System.Windows.Forms.Button();
			this.btnGestionarPreguntas = new System.Windows.Forms.Button();
			this.btnCerrarSesion = new System.Windows.Forms.Button();
			this.picBanderaIngles = new System.Windows.Forms.PictureBox();
			this.picBanderaEspanol = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.picBanderaIngles)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picBanderaEspanol)).BeginInit();
			this.SuspendLayout();
			// 
			// lblAdmin
			// 
			this.lblAdmin.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAdmin.ForeColor = System.Drawing.Color.SteelBlue;
			this.lblAdmin.Location = new System.Drawing.Point(93, 55);
			this.lblAdmin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblAdmin.Name = "lblAdmin";
			this.lblAdmin.Size = new System.Drawing.Size(324, 33);
			this.lblAdmin.TabIndex = 0;
			this.lblAdmin.Text = "MENU  ADMINISTRADOR";
			this.lblAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnGestionarModulos
			// 
			this.btnGestionarModulos.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGestionarModulos.ForeColor = System.Drawing.SystemColors.Control;
			this.btnGestionarModulos.Image = ((System.Drawing.Image)(resources.GetObject("btnGestionarModulos.Image")));
			this.btnGestionarModulos.Location = new System.Drawing.Point(215, 131);
			this.btnGestionarModulos.Margin = new System.Windows.Forms.Padding(2);
			this.btnGestionarModulos.Name = "btnGestionarModulos";
			this.btnGestionarModulos.Size = new System.Drawing.Size(90, 44);
			this.btnGestionarModulos.TabIndex = 1;
			this.btnGestionarModulos.Text = "Gestionar Modulos";
			this.btnGestionarModulos.UseVisualStyleBackColor = true;
			this.btnGestionarModulos.Click += new System.EventHandler(this.ButtonGestionarModulosClick);
			// 
			// btnGestionarUsuarios
			// 
			this.btnGestionarUsuarios.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGestionarUsuarios.BackgroundImage")));
			this.btnGestionarUsuarios.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGestionarUsuarios.ForeColor = System.Drawing.SystemColors.Control;
			this.btnGestionarUsuarios.Location = new System.Drawing.Point(79, 131);
			this.btnGestionarUsuarios.Margin = new System.Windows.Forms.Padding(2);
			this.btnGestionarUsuarios.Name = "btnGestionarUsuarios";
			this.btnGestionarUsuarios.Size = new System.Drawing.Size(98, 44);
			this.btnGestionarUsuarios.TabIndex = 2;
			this.btnGestionarUsuarios.Text = "Gestionar Usuarios";
			this.btnGestionarUsuarios.UseVisualStyleBackColor = true;
			this.btnGestionarUsuarios.Click += new System.EventHandler(this.GestionarUsuariosClick);
			// 
			// btnGestionarPreguntas
			// 
			this.btnGestionarPreguntas.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGestionarPreguntas.ForeColor = System.Drawing.SystemColors.Control;
			this.btnGestionarPreguntas.Image = ((System.Drawing.Image)(resources.GetObject("btnGestionarPreguntas.Image")));
			this.btnGestionarPreguntas.Location = new System.Drawing.Point(342, 131);
			this.btnGestionarPreguntas.Margin = new System.Windows.Forms.Padding(2);
			this.btnGestionarPreguntas.Name = "btnGestionarPreguntas";
			this.btnGestionarPreguntas.Size = new System.Drawing.Size(90, 44);
			this.btnGestionarPreguntas.TabIndex = 4;
			this.btnGestionarPreguntas.Text = "Gestionar Preguntas";
			this.btnGestionarPreguntas.UseVisualStyleBackColor = true;
			this.btnGestionarPreguntas.Click += new System.EventHandler(this.ButtonGestionarPreguntasClick);
			// 
			// btnCerrarSesion
			// 
			this.btnCerrarSesion.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCerrarSesion.ForeColor = System.Drawing.SystemColors.Control;
			this.btnCerrarSesion.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarSesion.Image")));
			this.btnCerrarSesion.Location = new System.Drawing.Point(215, 293);
			this.btnCerrarSesion.Margin = new System.Windows.Forms.Padding(2);
			this.btnCerrarSesion.Name = "btnCerrarSesion";
			this.btnCerrarSesion.Size = new System.Drawing.Size(90, 44);
			this.btnCerrarSesion.TabIndex = 5;
			this.btnCerrarSesion.Text = "Cerrar Sesion";
			this.btnCerrarSesion.UseVisualStyleBackColor = true;
			this.btnCerrarSesion.Click += new System.EventHandler(this.ButtonCerrarSesionClick);
			// 
			// picBanderaIngles
			// 
			this.picBanderaIngles.Cursor = System.Windows.Forms.Cursors.Hand;
			this.picBanderaIngles.Image = ((System.Drawing.Image)(resources.GetObject("picBanderaIngles.Image")));
			this.picBanderaIngles.Location = new System.Drawing.Point(433, 12);
			this.picBanderaIngles.Name = "picBanderaIngles";
			this.picBanderaIngles.Size = new System.Drawing.Size(24, 19);
			this.picBanderaIngles.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picBanderaIngles.TabIndex = 6;
			this.picBanderaIngles.TabStop = false;
			this.picBanderaIngles.Click += new System.EventHandler(this.PicBanderaInglesClick);
			// 
			// picBanderaEspanol
			// 
			this.picBanderaEspanol.Cursor = System.Windows.Forms.Cursors.Hand;
			this.picBanderaEspanol.Image = ((System.Drawing.Image)(resources.GetObject("picBanderaEspanol.Image")));
			this.picBanderaEspanol.Location = new System.Drawing.Point(463, 10);
			this.picBanderaEspanol.Name = "picBanderaEspanol";
			this.picBanderaEspanol.Size = new System.Drawing.Size(25, 21);
			this.picBanderaEspanol.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picBanderaEspanol.TabIndex = 7;
			this.picBanderaEspanol.TabStop = false;
			this.picBanderaEspanol.Click += new System.EventHandler(this.PicBanderaEspanolClick);
			// 
			// FormAdministrador
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.ClientSize = new System.Drawing.Size(508, 367);
			this.Controls.Add(this.picBanderaEspanol);
			this.Controls.Add(this.picBanderaIngles);
			this.Controls.Add(this.btnCerrarSesion);
			this.Controls.Add(this.btnGestionarPreguntas);
			this.Controls.Add(this.btnGestionarUsuarios);
			this.Controls.Add(this.btnGestionarModulos);
			this.Controls.Add(this.lblAdmin);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "FormAdministrador";
			this.Text = "FormAdministrador";
			((System.ComponentModel.ISupportInitialize)(this.picBanderaIngles)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picBanderaEspanol)).EndInit();
			this.ResumeLayout(false);

		}
		private System.Windows.Forms.Button btnCerrarSesion;
		private System.Windows.Forms.Button btnGestionarPreguntas;
		private System.Windows.Forms.Button btnGestionarUsuarios;
		private System.Windows.Forms.Button btnGestionarModulos;
		private System.Windows.Forms.Label lblAdmin;
		private System.Windows.Forms.PictureBox picBanderaIngles;
		private System.Windows.Forms.PictureBox picBanderaEspanol;
	}
}
