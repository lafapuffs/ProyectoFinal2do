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
		private System.Windows.Forms.Button btnAgregar;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.Button btnModificar;
		private System.Windows.Forms.Button btnConsultar;
		private System.Windows.Forms.Button btnCerrarSesion;
		private System.Windows.Forms.Button btnVolver;
		private System.Windows.Forms.DataGridView dgvUsuario;
		private System.Windows.Forms.Label lblEstado;
		private System.Windows.Forms.TextBox txtConsultar;
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGestionUsuario));
			this.btnAgregar = new System.Windows.Forms.Button();
			this.dgvUsuario = new System.Windows.Forms.DataGridView();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.btnModificar = new System.Windows.Forms.Button();
			this.btnConsultar = new System.Windows.Forms.Button();
			this.btnCerrarSesion = new System.Windows.Forms.Button();
			this.btnVolver = new System.Windows.Forms.Button();
			this.lblEstado = new System.Windows.Forms.Label();
			this.txtConsultar = new System.Windows.Forms.TextBox();
			this.picBanderaIngles = new System.Windows.Forms.PictureBox();
			this.picBanderaEspanol = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picBanderaIngles)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picBanderaEspanol)).BeginInit();
			this.SuspendLayout();
			// 
			// btnAgregar
			// 
			this.btnAgregar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnAgregar.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.btnAgregar.Location = new System.Drawing.Point(44, 264);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(101, 49);
			this.btnAgregar.TabIndex = 0;
			this.btnAgregar.Text = "Agregar";
			this.btnAgregar.UseVisualStyleBackColor = false;
			this.btnAgregar.Click += new System.EventHandler(this.AgregarClick);
			// 
			// dgvUsuario
			// 
			this.dgvUsuario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvUsuario.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.dgvUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.WindowFrame;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvUsuario.DefaultCellStyle = dataGridViewCellStyle1;
			this.dgvUsuario.Location = new System.Drawing.Point(27, 30);
			this.dgvUsuario.Name = "dgvUsuario";
			this.dgvUsuario.ReadOnly = true;
			this.dgvUsuario.Size = new System.Drawing.Size(494, 204);
			this.dgvUsuario.TabIndex = 1;
			// 
			// btnEliminar
			// 
			this.btnEliminar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnEliminar.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.btnEliminar.Location = new System.Drawing.Point(166, 264);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(99, 49);
			this.btnEliminar.TabIndex = 2;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.UseVisualStyleBackColor = false;
			this.btnEliminar.Click += new System.EventHandler(this.EliminarClick);
			// 
			// btnModificar
			// 
			this.btnModificar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnModificar.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.btnModificar.Location = new System.Drawing.Point(288, 264);
			this.btnModificar.Name = "btnModificar";
			this.btnModificar.Size = new System.Drawing.Size(99, 49);
			this.btnModificar.TabIndex = 3;
			this.btnModificar.Text = "Modificar";
			this.btnModificar.UseVisualStyleBackColor = false;
			this.btnModificar.Click += new System.EventHandler(this.BtnModificarClick);
			// 
			// btnConsultar
			// 
			this.btnConsultar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnConsultar.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.btnConsultar.Location = new System.Drawing.Point(405, 290);
			this.btnConsultar.Name = "btnConsultar";
			this.btnConsultar.Size = new System.Drawing.Size(100, 23);
			this.btnConsultar.TabIndex = 4;
			this.btnConsultar.Text = "Consultar";
			this.btnConsultar.UseVisualStyleBackColor = false;
			this.btnConsultar.Click += new System.EventHandler(this.ConsultarClick);
			// 
			// btnCerrarSesion
			// 
			this.btnCerrarSesion.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnCerrarSesion.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.btnCerrarSesion.Location = new System.Drawing.Point(288, 332);
			this.btnCerrarSesion.Name = "btnCerrarSesion";
			this.btnCerrarSesion.Size = new System.Drawing.Size(99, 23);
			this.btnCerrarSesion.TabIndex = 5;
			this.btnCerrarSesion.Text = "Cerrar Sesion";
			this.btnCerrarSesion.UseVisualStyleBackColor = false;
			this.btnCerrarSesion.Click += new System.EventHandler(this.BtnCerrarSesionClick);
			// 
			// btnVolver
			// 
			this.btnVolver.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnVolver.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.btnVolver.Location = new System.Drawing.Point(166, 332);
			this.btnVolver.Name = "btnVolver";
			this.btnVolver.Size = new System.Drawing.Size(99, 23);
			this.btnVolver.TabIndex = 6;
			this.btnVolver.Text = "Volver";
			this.btnVolver.UseVisualStyleBackColor = false;
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
			// picBanderaIngles
			// 
			this.picBanderaIngles.Cursor = System.Windows.Forms.Cursors.Hand;
			this.picBanderaIngles.Image = ((System.Drawing.Image)(resources.GetObject("picBanderaIngles.Image")));
			this.picBanderaIngles.Location = new System.Drawing.Point(451, 3);
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
			this.picBanderaEspanol.Location = new System.Drawing.Point(480, 3);
			this.picBanderaEspanol.Name = "picBanderaEspanol";
			this.picBanderaEspanol.Size = new System.Drawing.Size(25, 21);
			this.picBanderaEspanol.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picBanderaEspanol.TabIndex = 10;
			this.picBanderaEspanol.TabStop = false;
			this.picBanderaEspanol.Click += new System.EventHandler(this.PicBanderaEspanolClick);
			// 
			// FormGestionUsuario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(559, 367);
			this.Controls.Add(this.picBanderaEspanol);
			this.Controls.Add(this.picBanderaIngles);
			this.Controls.Add(this.txtConsultar);
			this.Controls.Add(this.lblEstado);
			this.Controls.Add(this.btnVolver);
			this.Controls.Add(this.btnCerrarSesion);
			this.Controls.Add(this.btnConsultar);
			this.Controls.Add(this.btnModificar);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.dgvUsuario);
			this.Controls.Add(this.btnAgregar);
			this.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.Name = "FormGestionUsuario";
			this.Text = "FormGestionUsuario";
			((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picBanderaIngles)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picBanderaEspanol)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
