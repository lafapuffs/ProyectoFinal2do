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
			this.dgvPreguntas = new System.Windows.Forms.DataGridView();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.btnModificar = new System.Windows.Forms.Button();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.btnActualizar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvPreguntas)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvPreguntas
			// 
			this.dgvPreguntas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvPreguntas.Location = new System.Drawing.Point(22, 29);
			this.dgvPreguntas.Name = "dgvPreguntas";
			this.dgvPreguntas.Size = new System.Drawing.Size(701, 268);
			this.dgvPreguntas.TabIndex = 0;
			// 
			// btnEliminar
			// 
			this.btnEliminar.Location = new System.Drawing.Point(740, 110);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(75, 23);
			this.btnEliminar.TabIndex = 2;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.UseVisualStyleBackColor = true;
			this.btnEliminar.Click += new System.EventHandler(this.BtnEliminarClick);
			// 
			// btnModificar
			// 
			this.btnModificar.Location = new System.Drawing.Point(740, 154);
			this.btnModificar.Name = "btnModificar";
			this.btnModificar.Size = new System.Drawing.Size(75, 23);
			this.btnModificar.TabIndex = 3;
			this.btnModificar.Text = "Modificar";
			this.btnModificar.UseVisualStyleBackColor = true;
			// 
			// btnAgregar
			// 
			this.btnAgregar.Location = new System.Drawing.Point(740, 68);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(75, 23);
			this.btnAgregar.TabIndex = 4;
			this.btnAgregar.Text = "Agregar";
			this.btnAgregar.UseVisualStyleBackColor = true;
			this.btnAgregar.Click += new System.EventHandler(this.BtnAgregarClick);
			// 
			// btnActualizar
			// 
			this.btnActualizar.Location = new System.Drawing.Point(740, 199);
			this.btnActualizar.Name = "btnActualizar";
			this.btnActualizar.Size = new System.Drawing.Size(75, 22);
			this.btnActualizar.TabIndex = 5;
			this.btnActualizar.Text = "Actualizar";
			this.btnActualizar.UseVisualStyleBackColor = true;
			this.btnActualizar.Click += new System.EventHandler(this.BtnActualizarClick);
			// 
			// FormGestionPreguntas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(843, 321);
			this.Controls.Add(this.btnActualizar);
			this.Controls.Add(this.btnAgregar);
			this.Controls.Add(this.btnModificar);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.dgvPreguntas);
			this.Name = "FormGestionPreguntas";
			this.Text = "FormGestionPreguntas";
			((System.ComponentModel.ISupportInitialize)(this.dgvPreguntas)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
