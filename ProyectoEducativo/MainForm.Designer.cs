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
			this.buttonIngresar = new System.Windows.Forms.Button();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.txtUsuario = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.cmbRol = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// buttonIngresar
			// 
			this.buttonIngresar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.buttonIngresar.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonIngresar.ForeColor = System.Drawing.SystemColors.Control;
			this.buttonIngresar.Location = new System.Drawing.Point(182, 290);
			this.buttonIngresar.Margin = new System.Windows.Forms.Padding(2);
			this.buttonIngresar.Name = "buttonIngresar";
			this.buttonIngresar.Size = new System.Drawing.Size(118, 58);
			this.buttonIngresar.TabIndex = 0;
			this.buttonIngresar.Text = "Ingresar";
			this.buttonIngresar.UseVisualStyleBackColor = false;
			this.buttonIngresar.Click += new System.EventHandler(this.ButtonIngresarClick);
			// 
			// txtPassword
			// 
			this.txtPassword.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.txtPassword.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPassword.ForeColor = System.Drawing.SystemColors.Control;
			this.txtPassword.Location = new System.Drawing.Point(125, 150);
			this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
			this.txtPassword.Multiline = true;
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(222, 34);
			this.txtPassword.TabIndex = 1;
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
			this.txtUsuario.Size = new System.Drawing.Size(222, 34);
			this.txtUsuario.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label1.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.SteelBlue;
			this.label1.Location = new System.Drawing.Point(125, 27);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(140, 26);
			this.label1.TabIndex = 3;
			this.label1.Text = "USUARIO";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label2.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.SteelBlue;
			this.label2.Location = new System.Drawing.Point(125, 121);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(183, 27);
			this.label2.TabIndex = 4;
			this.label2.Text = "CONTRASEÑA";
			// 
			// cmbRol
			// 
			this.cmbRol.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.cmbRol.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbRol.ForeColor = System.Drawing.SystemColors.Control;
			this.cmbRol.FormattingEnabled = true;
			this.cmbRol.Items.AddRange(new object[] {
			"Administrador",
			"Jugador"});
			this.cmbRol.Location = new System.Drawing.Point(269, 223);
			this.cmbRol.Margin = new System.Windows.Forms.Padding(2);
			this.cmbRol.Name = "cmbRol";
			this.cmbRol.Size = new System.Drawing.Size(92, 23);
			this.cmbRol.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label3.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.SteelBlue;
			this.label3.Location = new System.Drawing.Point(113, 223);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(152, 23);
			this.label3.TabIndex = 6;
			this.label3.Text = "Seleccione su rol:";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(730, 388);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.cmbRol);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtUsuario);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.buttonIngresar);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "MainForm";
			this.Text = "ProyectoEducativo";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cmbRol;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtUsuario;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.Button buttonIngresar;
	}
}
