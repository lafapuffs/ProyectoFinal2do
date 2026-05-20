/*
 * Created by SharpDevelop.
 * User: rafae
 * Date: 5/14/2026
 * Time: 5:14 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ProyectoEducativo
{
	partial class FormGestionPreguntas
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.DataGridView dgvPreguntas;
		private System.Windows.Forms.Button btnAgregar;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.Button btnModificar;
		private System.Windows.Forms.Button btnActualizar;
		private System.Windows.Forms.ComboBox cmbModulos;
		private System.Windows.Forms.PictureBox picBanderaIngles;
		private System.Windows.Forms.PictureBox picBanderaEspanol;
		private System.Windows.Forms.Button btnVolver;
		private System.Windows.Forms.Button btnCerrarSesion;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGestionPreguntas));
			this.dgvPreguntas = new System.Windows.Forms.DataGridView();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.btnModificar = new System.Windows.Forms.Button();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.btnActualizar = new System.Windows.Forms.Button();
			this.cmbModulos = new System.Windows.Forms.ComboBox();
			this.picBanderaIngles = new System.Windows.Forms.PictureBox();
			this.picBanderaEspanol = new System.Windows.Forms.PictureBox();
			this.btnVolver = new System.Windows.Forms.Button();
			this.btnCerrarSesion = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvPreguntas)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picBanderaIngles)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picBanderaEspanol)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvPreguntas
			// 
			this.dgvPreguntas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvPreguntas.Location = new System.Drawing.Point(12, 12);
			this.dgvPreguntas.Name = "dgvPreguntas";
			this.dgvPreguntas.Size = new System.Drawing.Size(842, 176);
			this.dgvPreguntas.TabIndex = 0;
			// 
			// btnEliminar
			// 
			this.btnEliminar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnEliminar.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEliminar.ForeColor = System.Drawing.SystemColors.Control;
			this.btnEliminar.Location = new System.Drawing.Point(33, 275);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(98, 47);
			this.btnEliminar.TabIndex = 2;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.UseVisualStyleBackColor = false;
			this.btnEliminar.Click += new System.EventHandler(this.BtnEliminarClick);
			// 
			// btnModificar
			// 
			this.btnModificar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnModificar.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnModificar.ForeColor = System.Drawing.SystemColors.Control;
			this.btnModificar.Location = new System.Drawing.Point(194, 216);
			this.btnModificar.Name = "btnModificar";
			this.btnModificar.Size = new System.Drawing.Size(98, 47);
			this.btnModificar.TabIndex = 3;
			this.btnModificar.Text = "Modificar";
			this.btnModificar.UseVisualStyleBackColor = false;
			this.btnModificar.Click += new System.EventHandler(this.BtnModificarClick);
			// 
			// btnAgregar
			// 
			this.btnAgregar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnAgregar.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAgregar.ForeColor = System.Drawing.SystemColors.Control;
			this.btnAgregar.Location = new System.Drawing.Point(33, 216);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(98, 47);
			this.btnAgregar.TabIndex = 4;
			this.btnAgregar.Text = "Agregar";
			this.btnAgregar.UseVisualStyleBackColor = false;
			this.btnAgregar.Click += new System.EventHandler(this.BtnAgregarClick);
			// 
			// btnActualizar
			// 
			this.btnActualizar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnActualizar.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnActualizar.ForeColor = System.Drawing.SystemColors.Control;
			this.btnActualizar.Location = new System.Drawing.Point(194, 275);
			this.btnActualizar.Name = "btnActualizar";
			this.btnActualizar.Size = new System.Drawing.Size(98, 45);
			this.btnActualizar.TabIndex = 5;
			this.btnActualizar.Text = "Actualizar";
			this.btnActualizar.UseVisualStyleBackColor = false;
			this.btnActualizar.Click += new System.EventHandler(this.BtnActualizarClick);
			// 
			// cmbModulos
			// 
			this.cmbModulos.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.cmbModulos.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbModulos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.cmbModulos.FormattingEnabled = true;
			this.cmbModulos.Items.AddRange(new object[] {
			"Antropologia",
			"Arquitectura",
			"Calculo",
			"Deporte"});
			this.cmbModulos.Location = new System.Drawing.Point(681, 249);
			this.cmbModulos.Name = "cmbModulos";
			this.cmbModulos.Size = new System.Drawing.Size(174, 23);
			this.cmbModulos.TabIndex = 6;
			this.cmbModulos.SelectedIndexChanged += new System.EventHandler(this.CmbModulosSelectedIndexChanged);
			// 
			// picBanderaIngles
			// 
			this.picBanderaIngles.Cursor = System.Windows.Forms.Cursors.Hand;
			this.picBanderaIngles.Image = ((System.Drawing.Image)(resources.GetObject("picBanderaIngles.Image")));
			this.picBanderaIngles.Location = new System.Drawing.Point(780, 382);
			this.picBanderaIngles.Name = "picBanderaIngles";
			this.picBanderaIngles.Size = new System.Drawing.Size(28, 24);
			this.picBanderaIngles.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picBanderaIngles.TabIndex = 8;
			this.picBanderaIngles.TabStop = false;
			this.picBanderaIngles.Click += new System.EventHandler(this.PicBanderaInglesClick);
			// 
			// picBanderaEspanol
			// 
			this.picBanderaEspanol.Cursor = System.Windows.Forms.Cursors.Hand;
			this.picBanderaEspanol.Image = ((System.Drawing.Image)(resources.GetObject("picBanderaEspanol.Image")));
			this.picBanderaEspanol.Location = new System.Drawing.Point(827, 382);
			this.picBanderaEspanol.Name = "picBanderaEspanol";
			this.picBanderaEspanol.Size = new System.Drawing.Size(29, 24);
			this.picBanderaEspanol.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picBanderaEspanol.TabIndex = 9;
			this.picBanderaEspanol.TabStop = false;
			this.picBanderaEspanol.Click += new System.EventHandler(this.PicBanderaEspanolClick);
			// 
			// btnVolver
			// 
			this.btnVolver.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnVolver.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnVolver.ForeColor = System.Drawing.SystemColors.Control;
			this.btnVolver.Location = new System.Drawing.Point(650, 299);
			this.btnVolver.Name = "btnVolver";
			this.btnVolver.Size = new System.Drawing.Size(89, 47);
			this.btnVolver.TabIndex = 10;
			this.btnVolver.Text = "Volver";
			this.btnVolver.UseVisualStyleBackColor = false;
			this.btnVolver.Click += new System.EventHandler(this.BtnVolverClick);
			// 
			// btnCerrarSesion
			// 
			this.btnCerrarSesion.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnCerrarSesion.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCerrarSesion.ForeColor = System.Drawing.SystemColors.Control;
			this.btnCerrarSesion.Location = new System.Drawing.Point(745, 299);
			this.btnCerrarSesion.Name = "btnCerrarSesion";
			this.btnCerrarSesion.Size = new System.Drawing.Size(112, 47);
			this.btnCerrarSesion.TabIndex = 11;
			this.btnCerrarSesion.Text = "Cerrar Sesion";
			this.btnCerrarSesion.UseVisualStyleBackColor = false;
			this.btnCerrarSesion.Click += new System.EventHandler(this.BtnCerrarSesionClick);
			// 
			// FormGestionPreguntas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(870, 414);
			this.Controls.Add(this.btnCerrarSesion);
			this.Controls.Add(this.btnVolver);
			this.Controls.Add(this.picBanderaEspanol);
			this.Controls.Add(this.picBanderaIngles);
			this.Controls.Add(this.cmbModulos);
			this.Controls.Add(this.btnActualizar);
			this.Controls.Add(this.btnAgregar);
			this.Controls.Add(this.btnModificar);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.dgvPreguntas);
			this.DoubleBuffered = true;
			this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "FormGestionPreguntas";
			this.Text = "FormGestionPreguntas";
			((System.ComponentModel.ISupportInitialize)(this.dgvPreguntas)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picBanderaIngles)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picBanderaEspanol)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
