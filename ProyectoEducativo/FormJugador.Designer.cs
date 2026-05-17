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
			this.buttonModuloArquitectura = new System.Windows.Forms.Button();
			this.buttonCerrarSesion = new System.Windows.Forms.Button();
			this.buttonModuloCalculo = new System.Windows.Forms.Button();
			this.buttonModuloAntropologia = new System.Windows.Forms.Button();
			this.buttonModuloDeporte = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// buttonModuloArquitectura
			// 
			this.buttonModuloArquitectura.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonModuloArquitectura.BackgroundImage")));
			this.buttonModuloArquitectura.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonModuloArquitectura.ForeColor = System.Drawing.SystemColors.Control;
			this.buttonModuloArquitectura.Location = new System.Drawing.Point(59, 114);
			this.buttonModuloArquitectura.Margin = new System.Windows.Forms.Padding(2);
			this.buttonModuloArquitectura.Name = "buttonModuloArquitectura";
			this.buttonModuloArquitectura.Size = new System.Drawing.Size(90, 50);
			this.buttonModuloArquitectura.TabIndex = 0;
			this.buttonModuloArquitectura.Text = "Modulo Arquitectura";
			this.buttonModuloArquitectura.UseVisualStyleBackColor = true;
			this.buttonModuloArquitectura.Click += new System.EventHandler(this.ButtonModuloArquitecturaClick);
			// 
			// buttonCerrarSesion
			// 
			this.buttonCerrarSesion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonCerrarSesion.BackgroundImage")));
			this.buttonCerrarSesion.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonCerrarSesion.ForeColor = System.Drawing.SystemColors.Control;
			this.buttonCerrarSesion.Location = new System.Drawing.Point(195, 380);
			this.buttonCerrarSesion.Margin = new System.Windows.Forms.Padding(2);
			this.buttonCerrarSesion.Name = "buttonCerrarSesion";
			this.buttonCerrarSesion.Size = new System.Drawing.Size(95, 26);
			this.buttonCerrarSesion.TabIndex = 1;
			this.buttonCerrarSesion.Text = "Cerrar Sesion";
			this.buttonCerrarSesion.UseVisualStyleBackColor = true;
			this.buttonCerrarSesion.Click += new System.EventHandler(this.ButtonCerrarSesionClick);
			// 
			// buttonModuloCalculo
			// 
			this.buttonModuloCalculo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonModuloCalculo.BackgroundImage")));
			this.buttonModuloCalculo.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonModuloCalculo.ForeColor = System.Drawing.SystemColors.Control;
			this.buttonModuloCalculo.Location = new System.Drawing.Point(347, 114);
			this.buttonModuloCalculo.Margin = new System.Windows.Forms.Padding(2);
			this.buttonModuloCalculo.Name = "buttonModuloCalculo";
			this.buttonModuloCalculo.Size = new System.Drawing.Size(90, 50);
			this.buttonModuloCalculo.TabIndex = 2;
			this.buttonModuloCalculo.Text = "Modulo Calculo";
			this.buttonModuloCalculo.UseVisualStyleBackColor = true;
			this.buttonModuloCalculo.Click += new System.EventHandler(this.ButtonModuloCalculoClick);
			// 
			// buttonModuloAntropologia
			// 
			this.buttonModuloAntropologia.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonModuloAntropologia.BackgroundImage")));
			this.buttonModuloAntropologia.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonModuloAntropologia.ForeColor = System.Drawing.SystemColors.Control;
			this.buttonModuloAntropologia.Location = new System.Drawing.Point(347, 213);
			this.buttonModuloAntropologia.Margin = new System.Windows.Forms.Padding(2);
			this.buttonModuloAntropologia.Name = "buttonModuloAntropologia";
			this.buttonModuloAntropologia.Size = new System.Drawing.Size(90, 50);
			this.buttonModuloAntropologia.TabIndex = 3;
			this.buttonModuloAntropologia.Text = "Modulo Antropologia";
			this.buttonModuloAntropologia.UseVisualStyleBackColor = true;
			this.buttonModuloAntropologia.Click += new System.EventHandler(this.ButtonModuloAntropologiaClick);
			// 
			// buttonModuloDeporte
			// 
			this.buttonModuloDeporte.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonModuloDeporte.BackgroundImage")));
			this.buttonModuloDeporte.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonModuloDeporte.ForeColor = System.Drawing.SystemColors.Control;
			this.buttonModuloDeporte.Location = new System.Drawing.Point(59, 213);
			this.buttonModuloDeporte.Margin = new System.Windows.Forms.Padding(2);
			this.buttonModuloDeporte.Name = "buttonModuloDeporte";
			this.buttonModuloDeporte.Size = new System.Drawing.Size(90, 50);
			this.buttonModuloDeporte.TabIndex = 4;
			this.buttonModuloDeporte.Text = "Modulo Deporte";
			this.buttonModuloDeporte.UseVisualStyleBackColor = true;
			this.buttonModuloDeporte.Click += new System.EventHandler(this.ButtonModuloDeporteClick);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label1.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.Control;
			this.label1.Location = new System.Drawing.Point(155, 51);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(197, 26);
			this.label1.TabIndex = 5;
			this.label1.Text = "MENU JUGADOR";
			// 
			// FormJugador
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.ClientSize = new System.Drawing.Size(501, 417);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.buttonModuloDeporte);
			this.Controls.Add(this.buttonModuloAntropologia);
			this.Controls.Add(this.buttonModuloCalculo);
			this.Controls.Add(this.buttonCerrarSesion);
			this.Controls.Add(this.buttonModuloArquitectura);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "FormJugador";
			this.Text = "FormJugador";
			this.ResumeLayout(false);

		}
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button buttonModuloDeporte;
		private System.Windows.Forms.Button buttonModuloAntropologia;
		private System.Windows.Forms.Button buttonModuloCalculo;
		private System.Windows.Forms.Button buttonCerrarSesion;
		private System.Windows.Forms.Button buttonModuloArquitectura;
	}
}
