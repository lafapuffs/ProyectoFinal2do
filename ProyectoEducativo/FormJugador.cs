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
    		AplicarIdioma();
    
	}
        
        void ButtonModuloCalculoClick(object sender, EventArgs e)
        {
             MessageBox.Show("Accediendo a: Calculo.", "Módulo Iniciado");
             
             FormCalculo frmCalculo = new FormCalculo();
    		frmCalculo.ShowDialog(); 
        }

        void ButtonModuloDeporteClick(object sender, EventArgs e)
        {
             MessageBox.Show("Accediendo a: Deporte.", "Módulo Iniciado");
             
             FormDeporte frmDeporte = new FormDeporte();
    		frmDeporte.ShowDialog(); 
        }

		 void ButtonCerrarSesionClick(object sender, EventArgs e)
        {
            MessageBox.Show("Cerrando sesión...", "Aviso");
            Application.Exit();
        }
		
		void ButtonModuloArquitecturaClick(object sender, EventArgs e)
		{
			 MessageBox.Show("Accediendo a: Arquitectura del computador.", "Módulo Iniciado");
			 
			 FormArquitectura frmArquitectura = new FormArquitectura();
    		frmArquitectura.ShowDialog(); 
		}
		
		void ButtonModuloAntropologiaClick(object sender, EventArgs e)
		{
			MessageBox.Show("Accediendo a: Antropología.", "Módulo Iniciado");
				
    		FormAntropologia frmAntropologia = new FormAntropologia();
    		frmAntropologia.ShowDialog(); 
		}
			void PicBanderaInglesClick(object sender, EventArgs e)
		{
    		Configuracion.EsIngles = true;
    		AplicarIdioma();
		}
		void PicBanderaEspanolClick(object sender, EventArgs e)
		{
			Configuracion.EsIngles = false;
    		AplicarIdioma();
		}
		
		void AplicarIdioma(){
			
			if (Configuracion.EsIngles) {
				lblJugador.Text = "PLAYER MENU";
				btnModuloAntropologia.Text = "Anthropology Module";
				btnModuloArquitectura.Text = "Arquitecture Module";
				btnModuloCalculo.Text = "Calculus Module";
				btnModuloDeporte.Text = "Sports Module";
				btnCerrarSesion.Text = "Log Out";
			} else {
				lblJugador.Text = "MENU JUGADOR";
				btnModuloAntropologia.Text = "Modulo Antroplogia";
				btnModuloArquitectura.Text = "Modulo Arquitectura";
				btnModuloCalculo.Text = "Modulo Calculo";
				btnModuloDeporte.Text = "Modulo Deporte";
				btnCerrarSesion.Text = "Cerrar Sesion";
			}
		}
    }
}