using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoEducativo
{
    public partial class FormJugador : Form
    {

			public FormJugador(string nombre) 
	{
    		InitializeComponent();
    
	}
        
        void ButtonModuloCalculoClick(object sender, EventArgs e)
        {
             MessageBox.Show("Accediendo a: Cálculo.", "Módulo Iniciado");
        }

        void ButtonModuloDeporteClick(object sender, EventArgs e)
        {
             MessageBox.Show("Accediendo a: Deporte.", "Módulo Iniciado");
        }

		 void ButtonCerrarSesionClick(object sender, EventArgs e)
        {
            MessageBox.Show("Cerrando sesión...", "Aviso");
            Application.Exit();
        }
		
		void ButtonModuloArquitecturaClick(object sender, EventArgs e)
		{
			 MessageBox.Show("Accediendo a: Arquitectura del computador.", "Módulo Iniciado");
		}
		
		void ButtonModuloAntropologiaClick(object sender, EventArgs e)
		{
			MessageBox.Show("Accediendo a: Antropología.", "Módulo Iniciado");
				
    		FormAntropologia frmAntropologia = new FormAntropologia();
    		frmAntropologia.ShowDialog(); 
		}	
    }
}