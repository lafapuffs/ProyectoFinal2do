/*
 * Created by SharpDevelop.
 * User: rafae
 * Date: 5/12/2026
 * Time: 3:42 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ProyectoEducativo
{
	partial class FormAgregar
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Label lblNombre;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.Label lblClave;
		private System.Windows.Forms.TextBox txtClave;
		private System.Windows.Forms.ComboBox cmbRol;
		private System.Windows.Forms.Label lblRol;
		private System.Windows.Forms.Button btnAceptar;
		
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
			this.btnCancelar = new System.Windows.Forms.Button();
			this.lblNombre = new System.Windows.Forms.Label();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.lblClave = new System.Windows.Forms.Label();
			this.txtClave = new System.Windows.Forms.TextBox();
			this.cmbRol = new System.Windows.Forms.ComboBox();
			this.lblRol = new System.Windows.Forms.Label();
			this.btnAceptar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnCancelar
			// 
			this.btnCancelar.Location = new System.Drawing.Point(149, 226);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(78, 23);
			this.btnCancelar.TabIndex = 1;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.BtnCancelarClick);
			// 
			// lblNombre
			// 
			this.lblNombre.Location = new System.Drawing.Point(68, 32);
			this.lblNombre.Name = "lblNombre";
			this.lblNombre.Size = new System.Drawing.Size(100, 23);
			this.lblNombre.TabIndex = 2;
			this.lblNombre.Text = "Ingrese Nombre:";
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(68, 49);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(156, 20);
			this.txtNombre.TabIndex = 3;
			// 
			// lblClave
			// 
			this.lblClave.Location = new System.Drawing.Point(68, 84);
			this.lblClave.Name = "lblClave";
			this.lblClave.Size = new System.Drawing.Size(100, 23);
			this.lblClave.TabIndex = 4;
			this.lblClave.Text = "Ingrese Clave:";
			// 
			// txtClave
			// 
			this.txtClave.Location = new System.Drawing.Point(68, 101);
			this.txtClave.Name = "txtClave";
			this.txtClave.Size = new System.Drawing.Size(156, 20);
			this.txtClave.TabIndex = 5;
			// 
			// cmbRol
			// 
			this.cmbRol.FormattingEnabled = true;
			this.cmbRol.Items.AddRange(new object[] {
			"Administrador",
			"Jugador"});
			this.cmbRol.Location = new System.Drawing.Point(68, 170);
			this.cmbRol.Name = "cmbRol";
			this.cmbRol.Size = new System.Drawing.Size(156, 21);
			this.cmbRol.TabIndex = 6;
			// 
			// lblRol
			// 
			this.lblRol.Location = new System.Drawing.Point(68, 152);
			this.lblRol.Name = "lblRol";
			this.lblRol.Size = new System.Drawing.Size(100, 15);
			this.lblRol.TabIndex = 7;
			this.lblRol.Text = "Ingrese Rol:";
			// 
			// btnAceptar
			// 
			this.btnAceptar.Location = new System.Drawing.Point(68, 226);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(75, 23);
			this.btnAceptar.TabIndex = 8;
			this.btnAceptar.Text = "Aceptar";
			this.btnAceptar.UseVisualStyleBackColor = true;
			this.btnAceptar.Click += new System.EventHandler(this.BtnAceptarClick);
			// 
			// FormAgregar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(343, 261);
			this.Controls.Add(this.btnAceptar);
			this.Controls.Add(this.lblRol);
			this.Controls.Add(this.cmbRol);
			this.Controls.Add(this.txtClave);
			this.Controls.Add(this.lblClave);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.lblNombre);
			this.Controls.Add(this.btnCancelar);
			this.Name = "FormAgregar";
			this.Text = "FormAgregar";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
