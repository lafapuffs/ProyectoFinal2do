/*
 * Created by SharpDevelop.
 * User: rafae
 * Date: 5/14/2026
 * Time: 6:04 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ProyectoEducativo
{
	partial class FormModificarUsuario
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lblNombre;
		private System.Windows.Forms.Label lblClave;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.TextBox txtClave;
		private System.Windows.Forms.ComboBox cmbRol;
		private System.Windows.Forms.Label lblRol;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.Button btnCancelar;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormModificarUsuario));
			this.lblNombre = new System.Windows.Forms.Label();
			this.lblClave = new System.Windows.Forms.Label();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.txtClave = new System.Windows.Forms.TextBox();
			this.cmbRol = new System.Windows.Forms.ComboBox();
			this.lblRol = new System.Windows.Forms.Label();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblNombre
			// 
			this.lblNombre.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.lblNombre.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNombre.ForeColor = System.Drawing.Color.DarkOrange;
			this.lblNombre.Location = new System.Drawing.Point(260, 47);
			this.lblNombre.Name = "lblNombre";
			this.lblNombre.Size = new System.Drawing.Size(95, 26);
			this.lblNombre.TabIndex = 0;
			this.lblNombre.Text = "Nombre";
			// 
			// lblClave
			// 
			this.lblClave.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.lblClave.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblClave.ForeColor = System.Drawing.Color.DarkOrange;
			this.lblClave.Location = new System.Drawing.Point(260, 108);
			this.lblClave.Name = "lblClave";
			this.lblClave.Size = new System.Drawing.Size(95, 23);
			this.lblClave.TabIndex = 1;
			this.lblClave.Text = "Clave";
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(263, 76);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(103, 20);
			this.txtNombre.TabIndex = 2;
			// 
			// txtClave
			// 
			this.txtClave.Location = new System.Drawing.Point(263, 134);
			this.txtClave.Name = "txtClave";
			this.txtClave.Size = new System.Drawing.Size(103, 20);
			this.txtClave.TabIndex = 3;
			// 
			// cmbRol
			// 
			this.cmbRol.FormattingEnabled = true;
			this.cmbRol.Items.AddRange(new object[] {
			"Administrador",
			" Jugador"});
			this.cmbRol.Location = new System.Drawing.Point(263, 198);
			this.cmbRol.Name = "cmbRol";
			this.cmbRol.Size = new System.Drawing.Size(124, 21);
			this.cmbRol.TabIndex = 4;
			// 
			// lblRol
			// 
			this.lblRol.BackColor = System.Drawing.SystemColors.WindowFrame;
			this.lblRol.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRol.ForeColor = System.Drawing.Color.DarkOrange;
			this.lblRol.Image = ((System.Drawing.Image)(resources.GetObject("lblRol.Image")));
			this.lblRol.Location = new System.Drawing.Point(263, 172);
			this.lblRol.Name = "lblRol";
			this.lblRol.Size = new System.Drawing.Size(115, 23);
			this.lblRol.TabIndex = 5;
			this.lblRol.Text = "Rol";
			// 
			// btnGuardar
			// 
			this.btnGuardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuardar.BackgroundImage")));
			this.btnGuardar.ForeColor = System.Drawing.Color.DarkOrange;
			this.btnGuardar.Location = new System.Drawing.Point(247, 248);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(98, 38);
			this.btnGuardar.TabIndex = 6;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.UseVisualStyleBackColor = true;
			this.btnGuardar.Click += new System.EventHandler(this.BtnGuardarClick);
			// 
			// btnCancelar
			// 
			this.btnCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelar.BackgroundImage")));
			this.btnCancelar.ForeColor = System.Drawing.Color.DarkOrange;
			this.btnCancelar.Location = new System.Drawing.Point(351, 248);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(111, 38);
			this.btnCancelar.TabIndex = 7;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.BtnCancelarClick);
			// 
			// FormModificarUsuario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(731, 413);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnGuardar);
			this.Controls.Add(this.lblRol);
			this.Controls.Add(this.cmbRol);
			this.Controls.Add(this.txtClave);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.lblClave);
			this.Controls.Add(this.lblNombre);
			this.ForeColor = System.Drawing.Color.DarkOrange;
			this.Name = "FormModificarUsuario";
			this.Text = "FormModificarUsuario";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
