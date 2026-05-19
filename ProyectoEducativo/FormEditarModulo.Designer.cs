/*
 * Created by SharpDevelop.
 * User: usuario
 * Date: 18/5/2026
 * Time: 8:39 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ProyectoEducativo
{
	partial class FormEditarModulo
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox txtNombreES;
		private System.Windows.Forms.Label lblNombreES;
		private System.Windows.Forms.Label lblNombreEN;
		private System.Windows.Forms.TextBox txtNombreEN;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.Button btnVolver;
		private System.Windows.Forms.PictureBox picBanderaIngles;
		private System.Windows.Forms.PictureBox picBanderaEspanol;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditarModulo));
			this.txtNombreES = new System.Windows.Forms.TextBox();
			this.lblNombreES = new System.Windows.Forms.Label();
			this.lblNombreEN = new System.Windows.Forms.Label();
			this.txtNombreEN = new System.Windows.Forms.TextBox();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.btnVolver = new System.Windows.Forms.Button();
			this.picBanderaIngles = new System.Windows.Forms.PictureBox();
			this.picBanderaEspanol = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.picBanderaIngles)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picBanderaEspanol)).BeginInit();
			this.SuspendLayout();
			// 
			// txtNombreES
			// 
			this.txtNombreES.Location = new System.Drawing.Point(163, 69);
			this.txtNombreES.Name = "txtNombreES";
			this.txtNombreES.Size = new System.Drawing.Size(141, 20);
			this.txtNombreES.TabIndex = 0;
			// 
			// lblNombreES
			// 
			this.lblNombreES.Location = new System.Drawing.Point(65, 69);
			this.lblNombreES.Name = "lblNombreES";
			this.lblNombreES.Size = new System.Drawing.Size(92, 30);
			this.lblNombreES.TabIndex = 1;
			this.lblNombreES.Text = "Nombre (Español)";
			// 
			// lblNombreEN
			// 
			this.lblNombreEN.Location = new System.Drawing.Point(65, 111);
			this.lblNombreEN.Name = "lblNombreEN";
			this.lblNombreEN.Size = new System.Drawing.Size(92, 30);
			this.lblNombreEN.TabIndex = 2;
			this.lblNombreEN.Text = "Nombre (Inglés)";
			// 
			// txtNombreEN
			// 
			this.txtNombreEN.Location = new System.Drawing.Point(163, 111);
			this.txtNombreEN.Name = "txtNombreEN";
			this.txtNombreEN.Size = new System.Drawing.Size(141, 20);
			this.txtNombreEN.TabIndex = 4;
			// 
			// btnGuardar
			// 
			this.btnGuardar.Location = new System.Drawing.Point(82, 183);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(93, 36);
			this.btnGuardar.TabIndex = 5;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.UseVisualStyleBackColor = true;
			this.btnGuardar.Click += new System.EventHandler(this.BtnGuardarClick);
			// 
			// btnVolver
			// 
			this.btnVolver.Location = new System.Drawing.Point(190, 183);
			this.btnVolver.Name = "btnVolver";
			this.btnVolver.Size = new System.Drawing.Size(93, 36);
			this.btnVolver.TabIndex = 6;
			this.btnVolver.Text = "Volver";
			this.btnVolver.UseVisualStyleBackColor = true;
			this.btnVolver.Click += new System.EventHandler(this.BtnVolverClick);
			// 
			// picBanderaIngles
			// 
			this.picBanderaIngles.Cursor = System.Windows.Forms.Cursors.Hand;
			this.picBanderaIngles.Image = ((System.Drawing.Image)(resources.GetObject("picBanderaIngles.Image")));
			this.picBanderaIngles.Location = new System.Drawing.Point(273, 12);
			this.picBanderaIngles.Name = "picBanderaIngles";
			this.picBanderaIngles.Size = new System.Drawing.Size(24, 21);
			this.picBanderaIngles.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picBanderaIngles.TabIndex = 9;
			this.picBanderaIngles.TabStop = false;
			this.picBanderaIngles.Click += new System.EventHandler(this.PicBanderaInglesClick);
			// 
			// picBanderaEspanol
			// 
			this.picBanderaEspanol.Cursor = System.Windows.Forms.Cursors.Hand;
			this.picBanderaEspanol.Image = ((System.Drawing.Image)(resources.GetObject("picBanderaEspanol.Image")));
			this.picBanderaEspanol.Location = new System.Drawing.Point(303, 12);
			this.picBanderaEspanol.Name = "picBanderaEspanol";
			this.picBanderaEspanol.Size = new System.Drawing.Size(25, 21);
			this.picBanderaEspanol.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picBanderaEspanol.TabIndex = 10;
			this.picBanderaEspanol.TabStop = false;
			// 
			// FormEditarModulo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(351, 271);
			this.Controls.Add(this.picBanderaEspanol);
			this.Controls.Add(this.picBanderaIngles);
			this.Controls.Add(this.btnVolver);
			this.Controls.Add(this.btnGuardar);
			this.Controls.Add(this.txtNombreEN);
			this.Controls.Add(this.lblNombreEN);
			this.Controls.Add(this.lblNombreES);
			this.Controls.Add(this.txtNombreES);
			this.Name = "FormEditarModulo";
			this.Text = "FormEditarModulo";
			((System.ComponentModel.ISupportInitialize)(this.picBanderaIngles)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picBanderaEspanol)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
