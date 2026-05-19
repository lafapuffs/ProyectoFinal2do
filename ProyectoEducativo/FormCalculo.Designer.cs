/*
 * Created by SharpDevelop.
 * User: rafae
 * Date: 5/19/2026
 * Time: 1:07 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ProyectoEducativo
{
	partial class FormCalculo
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.PictureBox picBanderaEspanol;
		private System.Windows.Forms.PictureBox picBanderaIngles;
		private System.Windows.Forms.Button btnD;
		private System.Windows.Forms.Button btnC;
		private System.Windows.Forms.Button btnB;
		private System.Windows.Forms.Button btnA;
		private System.Windows.Forms.Label lblPregunta;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCalculo));
			this.picBanderaEspanol = new System.Windows.Forms.PictureBox();
			this.picBanderaIngles = new System.Windows.Forms.PictureBox();
			this.btnD = new System.Windows.Forms.Button();
			this.btnC = new System.Windows.Forms.Button();
			this.btnB = new System.Windows.Forms.Button();
			this.btnA = new System.Windows.Forms.Button();
			this.lblPregunta = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.picBanderaEspanol)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picBanderaIngles)).BeginInit();
			this.SuspendLayout();
			// 
			// picBanderaEspanol
			// 
			this.picBanderaEspanol.Cursor = System.Windows.Forms.Cursors.Hand;
			this.picBanderaEspanol.Image = ((System.Drawing.Image)(resources.GetObject("picBanderaEspanol.Image")));
			this.picBanderaEspanol.Location = new System.Drawing.Point(558, 356);
			this.picBanderaEspanol.Name = "picBanderaEspanol";
			this.picBanderaEspanol.Size = new System.Drawing.Size(25, 21);
			this.picBanderaEspanol.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picBanderaEspanol.TabIndex = 18;
			this.picBanderaEspanol.TabStop = false;
			this.picBanderaEspanol.Click += new System.EventHandler(this.PicBanderaEspanolClick);
			// 
			// picBanderaIngles
			// 
			this.picBanderaIngles.Cursor = System.Windows.Forms.Cursors.Hand;
			this.picBanderaIngles.Image = ((System.Drawing.Image)(resources.GetObject("picBanderaIngles.Image")));
			this.picBanderaIngles.Location = new System.Drawing.Point(528, 356);
			this.picBanderaIngles.Name = "picBanderaIngles";
			this.picBanderaIngles.Size = new System.Drawing.Size(24, 21);
			this.picBanderaIngles.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picBanderaIngles.TabIndex = 17;
			this.picBanderaIngles.TabStop = false;
			this.picBanderaIngles.Click += new System.EventHandler(this.PicBanderaInglesClick);
			// 
			// btnD
			// 
			this.btnD.Location = new System.Drawing.Point(351, 276);
			this.btnD.Name = "btnD";
			this.btnD.Size = new System.Drawing.Size(138, 53);
			this.btnD.TabIndex = 16;
			this.btnD.Text = "Opcion D";
			this.btnD.UseVisualStyleBackColor = true;
			this.btnD.Click += new System.EventHandler(this.BtnDClick);
			// 
			// btnC
			// 
			this.btnC.Location = new System.Drawing.Point(114, 276);
			this.btnC.Name = "btnC";
			this.btnC.Size = new System.Drawing.Size(138, 53);
			this.btnC.TabIndex = 15;
			this.btnC.Text = "Opcion C";
			this.btnC.UseVisualStyleBackColor = true;
			this.btnC.Click += new System.EventHandler(this.BtnCClick);
			// 
			// btnB
			// 
			this.btnB.Location = new System.Drawing.Point(351, 190);
			this.btnB.Name = "btnB";
			this.btnB.Size = new System.Drawing.Size(138, 53);
			this.btnB.TabIndex = 14;
			this.btnB.Text = "Opcion B";
			this.btnB.UseVisualStyleBackColor = true;
			this.btnB.Click += new System.EventHandler(this.BtnBClick);
			// 
			// btnA
			// 
			this.btnA.Location = new System.Drawing.Point(114, 190);
			this.btnA.Name = "btnA";
			this.btnA.Size = new System.Drawing.Size(138, 53);
			this.btnA.TabIndex = 13;
			this.btnA.Text = "Opcion A";
			this.btnA.UseVisualStyleBackColor = true;
			this.btnA.Click += new System.EventHandler(this.BtnAClick);
			// 
			// lblPregunta
			// 
			this.lblPregunta.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPregunta.Location = new System.Drawing.Point(114, 24);
			this.lblPregunta.Name = "lblPregunta";
			this.lblPregunta.Size = new System.Drawing.Size(375, 134);
			this.lblPregunta.TabIndex = 12;
			this.lblPregunta.Text = "Pregunta";
			this.lblPregunta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// FormCalculo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(617, 401);
			this.Controls.Add(this.picBanderaEspanol);
			this.Controls.Add(this.picBanderaIngles);
			this.Controls.Add(this.btnD);
			this.Controls.Add(this.btnC);
			this.Controls.Add(this.btnB);
			this.Controls.Add(this.btnA);
			this.Controls.Add(this.lblPregunta);
			this.Name = "FormCalculo";
			this.Text = "FormCalculo";
			((System.ComponentModel.ISupportInitialize)(this.picBanderaEspanol)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picBanderaIngles)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
