/*
 * Created by SharpDevelop.
 * User: rafae
 * Date: 5/11/2026
 * Time: 6:39 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ProyectoEducativo
{
	partial class FormGestionUsuario
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button Agregar;
		private System.Windows.Forms.Button Eliminar;
		private System.Windows.Forms.Button Modificar;
		private System.Windows.Forms.Button Consultar;
		private System.Windows.Forms.Button btnCerrarSesion;
		private System.Windows.Forms.Button btnVolver;
		private System.Windows.Forms.DataGridView dgvUsuario;
		private System.Windows.Forms.Label lblEstado;
		private System.Windows.Forms.TextBox txtConsultar;
		
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
			this.Agregar = new System.Windows.Forms.Button();
			this.dgvUsuario = new System.Windows.Forms.DataGridView();
			this.Eliminar = new System.Windows.Forms.Button();
			this.Modificar = new System.Windows.Forms.Button();
			this.Consultar = new System.Windows.Forms.Button();
			this.btnCerrarSesion = new System.Windows.Forms.Button();
			this.btnVolver = new System.Windows.Forms.Button();
			this.lblEstado = new System.Windows.Forms.Label();
			this.txtConsultar = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).BeginInit();
			this.SuspendLayout();
			// 
			// Agregar
			// 
			this.Agregar.Location = new System.Drawing.Point(44, 264);
			this.Agregar.Name = "Agregar";
			this.Agregar.Size = new System.Drawing.Size(101, 49);
			this.Agregar.TabIndex = 0;
			this.Agregar.Text = "Agregar";
			this.Agregar.UseVisualStyleBackColor = true;
			this.Agregar.Click += new System.EventHandler(this.AgregarClick);
			// 
			// dgvUsuario
			// 
			this.dgvUsuario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvUsuario.Location = new System.Drawing.Point(44, 22);
			this.dgvUsuario.Name = "dgvUsuario";
			this.dgvUsuario.ReadOnly = true;
			this.dgvUsuario.Size = new System.Drawing.Size(461, 212);
			this.dgvUsuario.TabIndex = 1;
			// 
			// Eliminar
			// 
			this.Eliminar.Location = new System.Drawing.Point(166, 264);
			this.Eliminar.Name = "Eliminar";
			this.Eliminar.Size = new System.Drawing.Size(99, 49);
			this.Eliminar.TabIndex = 2;
			this.Eliminar.Text = "Eliminar";
			this.Eliminar.UseVisualStyleBackColor = true;
			this.Eliminar.Click += new System.EventHandler(this.EliminarClick);
			// 
			// Modificar
			// 
			this.Modificar.Location = new System.Drawing.Point(288, 264);
			this.Modificar.Name = "Modificar";
			this.Modificar.Size = new System.Drawing.Size(99, 49);
			this.Modificar.TabIndex = 3;
			this.Modificar.Text = "Modificar";
			this.Modificar.UseVisualStyleBackColor = true;
			this.Modificar.Click += new System.EventHandler(this.ModificarClick);
			// 
			// Consultar
			// 
			this.Consultar.Location = new System.Drawing.Point(405, 290);
			this.Consultar.Name = "Consultar";
			this.Consultar.Size = new System.Drawing.Size(100, 23);
			this.Consultar.TabIndex = 4;
			this.Consultar.Text = "Consultar";
			this.Consultar.UseVisualStyleBackColor = true;
			this.Consultar.Click += new System.EventHandler(this.ConsultarClick);
			// 
			// btnCerrarSesion
			// 
			this.btnCerrarSesion.Location = new System.Drawing.Point(288, 332);
			this.btnCerrarSesion.Name = "btnCerrarSesion";
			this.btnCerrarSesion.Size = new System.Drawing.Size(99, 23);
			this.btnCerrarSesion.TabIndex = 5;
			this.btnCerrarSesion.Text = "Cerrar Sesion";
			this.btnCerrarSesion.UseVisualStyleBackColor = true;
			this.btnCerrarSesion.Click += new System.EventHandler(this.BtnCerrarSesionClick);
			// 
			// btnVolver
			// 
			this.btnVolver.Location = new System.Drawing.Point(166, 332);
			this.btnVolver.Name = "btnVolver";
			this.btnVolver.Size = new System.Drawing.Size(99, 23);
			this.btnVolver.TabIndex = 6;
			this.btnVolver.Text = "Volver";
			this.btnVolver.UseVisualStyleBackColor = true;
			this.btnVolver.Click += new System.EventHandler(this.BtnVolverClick);
			// 
			// lblEstado
			// 
			this.lblEstado.Location = new System.Drawing.Point(199, 238);
			this.lblEstado.Name = "lblEstado";
			this.lblEstado.Size = new System.Drawing.Size(164, 23);
			this.lblEstado.TabIndex = 7;
			this.lblEstado.Text = "Estado";
			// 
			// txtConsultar
			// 
			this.txtConsultar.Location = new System.Drawing.Point(405, 264);
			this.txtConsultar.Name = "txtConsultar";
			this.txtConsultar.Size = new System.Drawing.Size(100, 20);
			this.txtConsultar.TabIndex = 8;
			// 
			// FormGestionUsuario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(559, 367);
			this.Controls.Add(this.txtConsultar);
			this.Controls.Add(this.lblEstado);
			this.Controls.Add(this.btnVolver);
			this.Controls.Add(this.btnCerrarSesion);
			this.Controls.Add(this.Consultar);
			this.Controls.Add(this.Modificar);
			this.Controls.Add(this.Eliminar);
			this.Controls.Add(this.dgvUsuario);
			this.Controls.Add(this.Agregar);
			this.Name = "FormGestionUsuario";
			this.Text = "FormGestionUsuario";
			((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
