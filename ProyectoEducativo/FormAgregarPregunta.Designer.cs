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
		private System.Windows.Forms.TextBox txtAEn;
		private System.Windows.Forms.TextBox txtDEn;
		private System.Windows.Forms.TextBox txtCEn;
		private System.Windows.Forms.TextBox txtBEn;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtPreguntaEn;
		private System.Windows.Forms.TextBox txtImagenRuta;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		
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
			this.txtAEn = new System.Windows.Forms.TextBox();
			this.txtDEn = new System.Windows.Forms.TextBox();
			this.txtCEn = new System.Windows.Forms.TextBox();
			this.txtBEn = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.txtPreguntaEn = new System.Windows.Forms.TextBox();
			this.txtImagenRuta = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblPregunta
			// 
			this.lblPregunta.Location = new System.Drawing.Point(254, 49);
			this.lblPregunta.Name = "lblPregunta";
			this.lblPregunta.Size = new System.Drawing.Size(156, 23);
			this.lblPregunta.TabIndex = 0;
			this.lblPregunta.Text = "Pregunta a agregar:";
			// 
			// lblA
			// 
			this.lblA.Location = new System.Drawing.Point(57, 38);
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
			this.lblC.Location = new System.Drawing.Point(57, 174);
			this.lblC.Name = "lblC";
			this.lblC.Size = new System.Drawing.Size(100, 23);
			this.lblC.TabIndex = 3;
			this.lblC.Text = "Opcion C";
			// 
			// lblD
			// 
			this.lblD.Location = new System.Drawing.Point(57, 250);
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
			this.txtPregunta.Location = new System.Drawing.Point(254, 70);
			this.txtPregunta.Name = "txtPregunta";
			this.txtPregunta.Size = new System.Drawing.Size(168, 20);
			this.txtPregunta.TabIndex = 7;
			// 
			// txtA
			// 
			this.txtA.Location = new System.Drawing.Point(57, 52);
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
			this.txtC.Location = new System.Drawing.Point(57, 200);
			this.txtC.Name = "txtC";
			this.txtC.Size = new System.Drawing.Size(100, 20);
			this.txtC.TabIndex = 10;
			// 
			// txtD
			// 
			this.txtD.Location = new System.Drawing.Point(57, 265);
			this.txtD.Name = "txtD";
			this.txtD.Size = new System.Drawing.Size(100, 20);
			this.txtD.TabIndex = 11;
			// 
			// lblRespuesta
			// 
			this.lblRespuesta.Location = new System.Drawing.Point(254, 145);
			this.lblRespuesta.Name = "lblRespuesta";
			this.lblRespuesta.Size = new System.Drawing.Size(180, 20);
			this.lblRespuesta.TabIndex = 12;
			this.lblRespuesta.Text = "Respuesta correcta (Correct Option)";
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
			// txtAEn
			// 
			this.txtAEn.Location = new System.Drawing.Point(57, 73);
			this.txtAEn.Name = "txtAEn";
			this.txtAEn.Size = new System.Drawing.Size(100, 20);
			this.txtAEn.TabIndex = 14;
			// 
			// txtDEn
			// 
			this.txtDEn.Location = new System.Drawing.Point(57, 291);
			this.txtDEn.Name = "txtDEn";
			this.txtDEn.Size = new System.Drawing.Size(100, 20);
			this.txtDEn.TabIndex = 15;
			// 
			// txtCEn
			// 
			this.txtCEn.Location = new System.Drawing.Point(57, 226);
			this.txtCEn.Name = "txtCEn";
			this.txtCEn.Size = new System.Drawing.Size(100, 20);
			this.txtCEn.TabIndex = 16;
			// 
			// txtBEn
			// 
			this.txtBEn.Location = new System.Drawing.Point(57, 142);
			this.txtBEn.Name = "txtBEn";
			this.txtBEn.Size = new System.Drawing.Size(100, 20);
			this.txtBEn.TabIndex = 17;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(0, 116);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(52, 23);
			this.label1.TabIndex = 18;
			this.label1.Text = "Español";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(0, 200);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(52, 23);
			this.label2.TabIndex = 19;
			this.label2.Text = "Español";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(-1, 265);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(52, 23);
			this.label3.TabIndex = 20;
			this.label3.Text = "Español";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(-1, 49);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(52, 23);
			this.label4.TabIndex = 21;
			this.label4.Text = "Español";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(-1, 142);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(52, 23);
			this.label5.TabIndex = 22;
			this.label5.Text = "English";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(-1, 73);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(52, 23);
			this.label6.TabIndex = 23;
			this.label6.Text = "English";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(-1, 226);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(52, 23);
			this.label7.TabIndex = 24;
			this.label7.Text = "English";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(-1, 288);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(52, 23);
			this.label8.TabIndex = 25;
			this.label8.Text = "English";
			// 
			// txtPreguntaEn
			// 
			this.txtPreguntaEn.Location = new System.Drawing.Point(254, 113);
			this.txtPreguntaEn.Name = "txtPreguntaEn";
			this.txtPreguntaEn.Size = new System.Drawing.Size(168, 20);
			this.txtPreguntaEn.TabIndex = 26;
			// 
			// txtImagenRuta
			// 
			this.txtImagenRuta.Location = new System.Drawing.Point(254, 215);
			this.txtImagenRuta.Name = "txtImagenRuta";
			this.txtImagenRuta.Size = new System.Drawing.Size(100, 20);
			this.txtImagenRuta.TabIndex = 27;
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(254, 189);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(156, 23);
			this.label9.TabIndex = 28;
			this.label9.Text = "Ruta de Imagen (Image route)";
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(254, 93);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(156, 17);
			this.label10.TabIndex = 29;
			this.label10.Text = "Question to Add";
			// 
			// FormAgregarPregunta
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(529, 352);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.txtImagenRuta);
			this.Controls.Add(this.txtPreguntaEn);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtBEn);
			this.Controls.Add(this.txtCEn);
			this.Controls.Add(this.txtDEn);
			this.Controls.Add(this.txtAEn);
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
