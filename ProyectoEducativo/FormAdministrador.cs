using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;


namespace ProyectoEducativo
{
    public partial class FormAdministrador : Form
    	
    {
        public FormAdministrador()
        {
            InitializeComponent();
            AplicarIdioma();
        }

		void GestionarUsuariosClick(object sender, EventArgs e)
		{
		
			FormGestionUsuario frmGestion = new FormGestionUsuario();
			frmGestion.Show();
		
		
		}
		
		void ButtonGestionarModulosClick(object sender, EventArgs e)
		{
			FormGestionModulos frmGestionMod = new FormGestionModulos();
			frmGestionMod.Show();
		}
		
		void ButtonGestionarPreguntasClick(object sender, EventArgs e)
		{
			FormGestionPreguntas frmGestionPreguntas = new FormGestionPreguntas();
			frmGestionPreguntas.Show();
			
		}
		
		void ButtonCerrarSesionClick(object sender, EventArgs e)
		{
			 MessageBox.Show("Cerrando sesión...", "Aviso");
            
            Application.Exit();
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
				lblAdmin.Text = "ADMIN MENU";
				btnGestionarModulos.Text = "Manage Modules";
				btnGestionarPreguntas.Text = "Manage Questions";
				btnGestionarUsuarios.Text = "Manage Users";
				btnCerrarSesion.Text = "Log Out";
		} else 
			{
				lblAdmin.Text = "MENU ADMINISTRADOR";
				btnGestionarModulos.Text = "Gestionar Modulos";
				btnGestionarPreguntas.Text = "Gestionar Preguntas";
				btnGestionarUsuarios.Text = "Gestionar Usuarios";
				btnCerrarSesion.Text = "Cerrar Sesion";
			}
		
   		 }
}
}