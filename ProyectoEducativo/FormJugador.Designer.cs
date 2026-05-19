/*
 * Created by SharpDevelop.
 * User: Usuario
 * Date: 5/4/2026
 * Time: 12:38 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ProyectoEducativo
{
	partial class FormJugador
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormJugador));
			this.btnModuloArquitectura = new System.Windows.Forms.Button();
			this.btnCerrarSesion = new System.Windows.Forms.Button();
			this.btnModuloCalculo = new System.Windows.Forms.Button();
			this.btnModuloAntropologia = new System.Windows.Forms.Button();
			this.btnModuloDeporte = new System.Windows.Forms.Button();
			this.lblJugador = new System.Windows.Forms.Label();
			this.picBanderaIngles = new System.Windows.Forms.PictureBox();
			this.picBanderaEspanol = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.picBanderaIngles)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picBanderaEspanol)).BeginInit();
			this.SuspendLayout();
			// 
			// btnModuloArquitectura
			// 
			this.btnModuloArquitectura.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnModuloArquitectura.BackgroundImage")));
			this.btnModuloArquitectura.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnModuloArquitectura.ForeColor = System.Drawing.SystemColors.Control;
			this.btnModuloArquitectura.Location = new System.Drawing.Point(59, 114);
			this.btnModuloArquitectura.Margin = new System.Windows.Forms.Padding(2);
			this.btnModuloArquitectura.Name = "btnModuloArquitectura";
			this.btnModuloArquitectura.Size = new System.Drawing.Size(90, 50);
			this.btnModuloArquitectura.TabIndex = 0;
			this.btnModuloArquitectura.Text = "Modulo Arquitectura";
			this.btnModuloArquitectura.UseVisualStyleBackColor = true;
			this.btnModuloArquitectura.Click += new System.EventHandler(this.ButtonModuloArquitecturaClick);
			// 
			// btnCerrarSesion
			// 
			this.btnCerrarSesion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCerrarSesion.BackgroundImage")));
			this.btnCerrarSesion.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCerrarSesion.ForeColor = System.Drawing.SystemColors.Control;
			this.btnCerrarSesion.Location = new System.Drawing.Point(195, 380);
			this.btnCerrarSesion.Margin = new System.Windows.Forms.Padding(2);
			this.btnCerrarSesion.Name = "btnCerrarSesion";
			this.btnCerrarSesion.Size = new System.Drawing.Size(95, 26);
			this.btnCerrarSesion.TabIndex = 1;
			this.btnCerrarSesion.Text = "Cerrar Sesion";
			this.btnCerrarSesion.UseVisualStyleBackColor = true;
			this.btnCerrarSesion.Click += new System.EventHandler(this.ButtonCerrarSesionClick);
			// 
			// btnModuloCalculo
			// 
			this.btnModuloCalculo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnModuloCalculo.BackgroundImage")));
			this.btnModuloCalculo.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnModuloCalculo.ForeColor = System.Drawing.SystemColors.Control;
			this.btnModuloCalculo.Location = new System.Drawing.Point(347, 114);
			this.btnModuloCalculo.Margin = new System.Windows.Forms.Padding(2);
			this.btnModuloCalculo.Name = "btnModuloCalculo";
			this.btnModuloCalculo.Size = new System.Drawing.Size(90, 50);
			this.btnModuloCalculo.TabIndex = 2;
			this.btnModuloCalculo.Text = "Modulo Calculo";
			this.btnModuloCalculo.UseVisualStyleBackColor = true;
			this.btnModuloCalculo.Click += new System.EventHandler(this.ButtonModuloCalculoClick);
			// 
			// btnModuloAntropologia
			// 
			this.btnModuloAntropologia.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnModuloAntropologia.BackgroundImage")));
			this.btnModuloAntropologia.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnModuloAntropologia.ForeColor = System.Drawing.SystemColors.Control;
			this.btnModuloAntropologia.Location = new System.Drawing.Point(347, 213);
			this.btnModuloAntropologia.Margin = new System.Windows.Forms.Padding(2);
			this.btnModuloAntropologia.Name = "btnModuloAntropologia";
			this.btnModuloAntropologia.Size = new System.Drawing.Size(90, 50);
			this.btnModuloAntropologia.TabIndex = 3;
			this.btnModuloAntropologia.Text = "Modulo Antropologia";
			this.btnModuloAntropologia.UseVisualStyleBackColor = true;
			this.btnModuloAntropologia.Click += new System.EventHandler(this.ButtonModuloAntropologiaClick);
			// 
			// btnModuloDeporte
			// 
			this.btnModuloDeporte.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnModuloDeporte.BackgroundImage")));
			this.btnModuloDeporte.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnModuloDeporte.ForeColor = System.Drawing.SystemColors.Control;
			this.btnModuloDeporte.Location = new System.Drawing.Point(59, 213);
			this.btnModuloDeporte.Margin = new System.Windows.Forms.Padding(2);
			this.btnModuloDeporte.Name = "btnModuloDeporte";
			this.btnModuloDeporte.Size = new System.Drawing.Size(90, 50);
			this.btnModuloDeporte.TabIndex = 4;
			this.btnModuloDeporte.Text = "Modulo Deporte";
			this.btnModuloDeporte.UseVisualStyleBackColor = true;
			this.btnModuloDeporte.Click += new System.EventHandler(this.ButtonModuloDeporteClick);
			// 
			// lblJugador
			// 
			this.lblJugador.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.lblJugador.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblJugador.ForeColor = System.Drawing.SystemColors.Control;
			this.lblJugador.Location = new System.Drawing.Point(155, 51);
			this.lblJugador.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblJugador.Name = "lblJugador";
			this.lblJugador.Size = new System.Drawing.Size(197, 26);
			this.lblJugador.TabIndex = 5;
			this.lblJugador.Text = "MENU JUGADOR";
			this.lblJugador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// picBanderaIngles
			// 
			this.picBanderaIngles.Cursor = System.Windows.Forms.Cursors.Hand;
			this.picBanderaIngles.Image = ((System.Drawing.Image)(resources.GetObject("picBanderaIngles.Image")));
			this.picBanderaIngles.Location = new System.Drawing.Point(434, 40);
			this.picBanderaIngles.Name = "picBanderaIngles";
			this.picBanderaIngles.Size = new System.Drawing.Size(24, 21);
			this.picBanderaIngles.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picBanderaIngles.TabIndex = 7;
			this.picBanderaIngles.TabStop = false;
			this.picBanderaIngles.Click += new System.EventHandler(this.PicBanderaInglesClick);
			// 
			// picBanderaEspanol
			// 
			this.picBanderaEspanol.Cursor = System.Windows.Forms.Cursors.Hand;
			this.picBanderaEspanol.Image = ((System.Drawing.Image)(resources.GetObject("picBanderaEspanol.Image")));
			this.picBanderaEspanol.Location = new System.Drawing.Point(464, 40);
			this.picBanderaEspanol.Name = "picBanderaEspanol";
			this.picBanderaEspanol.Size = new System.Drawing.Size(25, 21);
			this.picBanderaEspanol.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picBanderaEspanol.TabIndex = 8;
			this.picBanderaEspanol.TabStop = false;
			this.picBanderaEspanol.Click += new System.EventHandler(this.PicBanderaEspanolClick);
			// 
			// FormJugador
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.ClientSize = new System.Drawing.Size(501, 417);
			this.Controls.Add(this.picBanderaEspanol);
			this.Controls.Add(this.picBanderaIngles);
			this.Controls.Add(this.lblJugador);
			this.Controls.Add(this.btnModuloDeporte);
			this.Controls.Add(this.btnModuloAntropologia);
			this.Controls.Add(this.btnModuloCalculo);
			this.Controls.Add(this.btnCerrarSesion);
			this.Controls.Add(this.btnModuloArquitectura);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "FormJugador";
			this.Text = "FormJugador";
			((System.ComponentModel.ISupportInitialize)(this.picBanderaIngles)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picBanderaEspanol)).EndInit();
			this.ResumeLayout(false);

		}
		private System.Windows.Forms.Label lblJugador;
		private System.Windows.Forms.Button btnModuloDeporte;
		private System.Windows.Forms.Button btnModuloAntropologia;
		private System.Windows.Forms.Button btnModuloCalculo;
		private System.Windows.Forms.Button btnCerrarSesion;
		private System.Windows.Forms.Button btnModuloArquitectura;
		private System.Windows.Forms.PictureBox picBanderaIngles;
		private System.Windows.Forms.PictureBox picBanderaEspanol;
	}
}
