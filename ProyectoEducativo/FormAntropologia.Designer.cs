/*
 * Created by SharpDevelop.
 * User: rafae
 * Date: 5/12/2026
 * Time: 6:22 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ProyectoEducativo
{
	partial class FormAntropologia
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lblPregunta;
		private System.Windows.Forms.Button btnA;
		private System.Windows.Forms.Button btnB;
		private System.Windows.Forms.Button btnC;
		private System.Windows.Forms.Button btnD;
		
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
			this.btnA = new System.Windows.Forms.Button();
			this.btnB = new System.Windows.Forms.Button();
			this.btnC = new System.Windows.Forms.Button();
			this.btnD = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblPregunta
			// 
			this.lblPregunta.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPregunta.Location = new System.Drawing.Point(133, 30);
			this.lblPregunta.Name = "lblPregunta";
			this.lblPregunta.Size = new System.Drawing.Size(244, 66);
			this.lblPregunta.TabIndex = 0;
			this.lblPregunta.Text = "Pregunta";
			this.lblPregunta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnA
			// 
			this.btnA.Location = new System.Drawing.Point(96, 111);
			this.btnA.Name = "btnA";
			this.btnA.Size = new System.Drawing.Size(138, 53);
			this.btnA.TabIndex = 1;
			this.btnA.Text = "Opcion A";
			this.btnA.UseVisualStyleBackColor = true;
			this.btnA.Click += new System.EventHandler(this.BtnAClick);
			// 
			// btnB
			// 
			this.btnB.Location = new System.Drawing.Point(272, 111);
			this.btnB.Name = "btnB";
			this.btnB.Size = new System.Drawing.Size(138, 53);
			this.btnB.TabIndex = 2;
			this.btnB.Text = "Opcion B";
			this.btnB.UseVisualStyleBackColor = true;
			this.btnB.Click += new System.EventHandler(this.BtnBClick);
			// 
			// btnC
			// 
			this.btnC.Location = new System.Drawing.Point(96, 198);
			this.btnC.Name = "btnC";
			this.btnC.Size = new System.Drawing.Size(138, 53);
			this.btnC.TabIndex = 3;
			this.btnC.Text = "Opcion C";
			this.btnC.UseVisualStyleBackColor = true;
			this.btnC.Click += new System.EventHandler(this.BtnCClick);
			// 
			// btnD
			// 
			this.btnD.Location = new System.Drawing.Point(272, 198);
			this.btnD.Name = "btnD";
			this.btnD.Size = new System.Drawing.Size(138, 53);
			this.btnD.TabIndex = 4;
			this.btnD.Text = "Opcion D";
			this.btnD.UseVisualStyleBackColor = true;
			this.btnD.Click += new System.EventHandler(this.BtnDClick);
			// 
			// FormAntropologia
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(493, 318);
			this.Controls.Add(this.btnD);
			this.Controls.Add(this.btnC);
			this.Controls.Add(this.btnB);
			this.Controls.Add(this.btnA);
			this.Controls.Add(this.lblPregunta);
			this.Name = "FormAntropologia";
			this.Text = "FormAntropologia";
			this.ResumeLayout(false);

		}
	}
}
