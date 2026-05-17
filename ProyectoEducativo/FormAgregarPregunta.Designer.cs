/*
 * Created by SharpDevelop.
 * User: rafae
 * Date: 5/14/2026
 * Time: 5:24 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ProyectoEducativo
{
	partial class FormAgregarPregunta
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lblPregunta;
		private System.Windows.Forms.Label lblA;
		private System.Windows.Forms.Label lblB;
		private System.Windows.Forms.Label lblC;
		private System.Windows.Forms.Label lblD;
		private System.Windows.Forms.ComboBox cmbCorrecta;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.TextBox txtPregunta;
		private System.Windows.Forms.TextBox txtA;
		private System.Windows.Forms.TextBox txtB;
		private System.Windows.Forms.TextBox txtC;
		private System.Windows.Forms.TextBox txtD;
		private System.Windows.Forms.Label lblRespuesta;
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
			this.lblPregunta = new System.Windows.Forms.Label();
			this.lblA = new System.Windows.Forms.Label();
			this.lblB = new System.Windows.Forms.Label();
			this.lblC = new System.Windows.Forms.Label();
			this.lblD = new System.Windows.Forms.Label();
			this.cmbCorrecta = new System.Windows.Forms.ComboBox();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.txtPregunta = new System.Windows.Forms.TextBox();
			this.txtA = new System.Windows.Forms.TextBox();
			this.txtB = new System.Windows.Forms.TextBox();
			this.txtC = new System.Windows.Forms.TextBox();
			this.txtD = new System.Windows.Forms.TextBox();
			this.lblRespuesta = new System.Windows.Forms.Label();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblPregunta
			// 
			this.lblPregunta.Location = new System.Drawing.Point(254, 61);
			this.lblPregunta.Name = "lblPregunta";
			this.lblPregunta.Size = new System.Drawing.Size(156, 23);
			this.lblPregunta.TabIndex = 0;
			this.lblPregunta.Text = "Pregunta a agregar:";
			// 
			// lblA
			// 
			this.lblA.Location = new System.Drawing.Point(57, 49);
			this.lblA.Name = "lblA";
			this.lblA.Size = new System.Drawing.Size(100, 23);
			this.lblA.TabIndex = 1;
			this.lblA.Text = "Opcion A";
			// 
			// lblB
			// 
			this.lblB.Location = new System.Drawing.Point(57, 99);
			this.lblB.Name = "lblB";
			this.lblB.Size = new System.Drawing.Size(100, 23);
			this.lblB.TabIndex = 2;
			this.lblB.Text = "Opcion B";
			// 
			// lblC
			// 
			this.lblC.Location = new System.Drawing.Point(57, 150);
			this.lblC.Name = "lblC";
			this.lblC.Size = new System.Drawing.Size(100, 23);
			this.lblC.TabIndex = 3;
			this.lblC.Text = "Opcion C";
			// 
			// lblD
			// 
			this.lblD.Location = new System.Drawing.Point(57, 200);
			this.lblD.Name = "lblD";
			this.lblD.Size = new System.Drawing.Size(100, 23);
			this.lblD.TabIndex = 4;
			this.lblD.Text = "Opcion D";
			// 
			// cmbCorrecta
			// 
			this.cmbCorrecta.FormattingEnabled = true;
			this.cmbCorrecta.Items.AddRange(new object[] {
			"A",
			"B",
			"C",
			"D"});
			this.cmbCorrecta.Location = new System.Drawing.Point(254, 165);
			this.cmbCorrecta.Name = "cmbCorrecta";
			this.cmbCorrecta.Size = new System.Drawing.Size(121, 21);
			this.cmbCorrecta.TabIndex = 5;
			// 
			// btnGuardar
			// 
			this.btnGuardar.Location = new System.Drawing.Point(254, 245);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(75, 23);
			this.btnGuardar.TabIndex = 6;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.UseVisualStyleBackColor = true;
			this.btnGuardar.Click += new System.EventHandler(this.BtnGuardarClick);
			// 
			// txtPregunta
			// 
			this.txtPregunta.Location = new System.Drawing.Point(254, 87);
			this.txtPregunta.Name = "txtPregunta";
			this.txtPregunta.Size = new System.Drawing.Size(100, 20);
			this.txtPregunta.TabIndex = 7;
			// 
			// txtA
			// 
			this.txtA.Location = new System.Drawing.Point(57, 64);
			this.txtA.Name = "txtA";
			this.txtA.Size = new System.Drawing.Size(100, 20);
			this.txtA.TabIndex = 8;
			// 
			// txtB
			// 
			this.txtB.Location = new System.Drawing.Point(57, 116);
			this.txtB.Name = "txtB";
			this.txtB.Size = new System.Drawing.Size(100, 20);
			this.txtB.TabIndex = 9;
			// 
			// txtC
			// 
			this.txtC.Location = new System.Drawing.Point(57, 166);
			this.txtC.Name = "txtC";
			this.txtC.Size = new System.Drawing.Size(100, 20);
			this.txtC.TabIndex = 10;
			// 
			// txtD
			// 
			this.txtD.Location = new System.Drawing.Point(57, 215);
			this.txtD.Name = "txtD";
			this.txtD.Size = new System.Drawing.Size(100, 20);
			this.txtD.TabIndex = 11;
			// 
			// lblRespuesta
			// 
			this.lblRespuesta.Location = new System.Drawing.Point(254, 136);
			this.lblRespuesta.Name = "lblRespuesta";
			this.lblRespuesta.Size = new System.Drawing.Size(136, 23);
			this.lblRespuesta.TabIndex = 12;
			this.lblRespuesta.Text = "Respuesta correcta";
			// 
			// btnCancelar
			// 
			this.btnCancelar.Location = new System.Drawing.Point(341, 245);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(81, 22);
			this.btnCancelar.TabIndex = 13;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = true;
			// 
			// FormAgregarPregunta
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(493, 352);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.lblRespuesta);
			this.Controls.Add(this.txtD);
			this.Controls.Add(this.txtC);
			this.Controls.Add(this.txtB);
			this.Controls.Add(this.txtA);
			this.Controls.Add(this.txtPregunta);
			this.Controls.Add(this.btnGuardar);
			this.Controls.Add(this.cmbCorrecta);
			this.Controls.Add(this.lblD);
			this.Controls.Add(this.lblC);
			this.Controls.Add(this.lblB);
			this.Controls.Add(this.lblA);
			this.Controls.Add(this.lblPregunta);
			this.Name = "FormAgregarPregunta";
			this.Text = "FormAgregarPregunta";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
