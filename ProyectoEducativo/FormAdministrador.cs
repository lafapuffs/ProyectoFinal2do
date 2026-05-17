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
        }

		void GestionarUsuariosClick(object sender, EventArgs e)
		{
		
			FormGestionUsuario frmGestion = new FormGestionUsuario();
			frmGestion.Show();
			
			this.Hide();
		
		}
		
		
		void ButtonGestionarModulosClick(object sender, EventArgs e)
		{
			 MessageBox.Show("En proceso...", "Gestión de Módulos");
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
    }
}