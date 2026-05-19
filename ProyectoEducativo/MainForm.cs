using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace ProyectoEducativo
{
    public partial class MainForm : Form
    {
    	private string cadenaConexion =  "Server=localhost;Database=proyectin;Uid=root;Pwd=;";

        public MainForm()
        {
            InitializeComponent();
            AplicarIdioma();
              
        }
		
		void ButtonIngresarClick(object sender, EventArgs e)
{
    string user = txtUsuario.Text.Trim();
    string pass = txtContrasena.Text;
    int rolId = cmbRol.SelectedIndex + 1;

    if (user == "" || pass == "" || cmbRol.SelectedIndex == -1)
    {
        MessageBox.Show("LLENE TODOS LOS CAMPOS Y SELECCIONE UN ROL", "CAMPOS VACÍOS");
    }
    else
    {
        try 
        {
          using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
{
    conexion.Open();
    string consulta = "SELECT id FROM usuario WHERE nombre = @user AND clave = @pass AND rol = @rol";
    
    // Declaramos 'cmd' AQUÍ, dentro del bloque donde 'conexion' está vivo
    using (MySqlCommand cmd = new MySqlCommand(consulta, conexion))
    {
        cmd.Parameters.AddWithValue("@user", user);
        cmd.Parameters.AddWithValue("@pass", pass);
        cmd.Parameters.AddWithValue("@rol", rolId);

        object resultado = cmd.ExecuteScalar();

        if (resultado != null)
        {
            Configuracion.IdUsuarioLogueado = Convert.ToInt32(resultado);
            MessageBox.Show("¡Bienvenido " + user + "!");
            this.Hide();
            switch (rolId)
            {
                case 1: // Administrador
                    FormAdministrador admin = new FormAdministrador();
                    admin.Show();
                    break;
                case 2: // Jugador
                    FormJugador jugador = new FormJugador(user); 
                    jugador.Show();
                    break;
                default:
                    MessageBox.Show("Rol no reconocido.");
                    this.Show(); // Regresamos al login si el rol no es válido
                    break;
            }
        }
        else
        {
            MessageBox.Show("EL USUARIO NO EXISTE O EL ROL ES INCORRECTO", "ERROR");
        }
    }
}
        }
        catch (Exception ex) 
        {
            MessageBox.Show("Error de conexión: " + ex.Message);
        }
    } 
}
		void BtnCambiarIdiomaClick(object sender, EventArgs e)
	{
    // Cambia al valor opuesto (si era true pasa a false y viceversa)
    Configuracion.EsIngles = !Configuracion.EsIngles;
    
    // Actualiza el formulario actual
    	AplicarIdioma();
	}
		
		void AplicarIdioma() 
		{
			if (Configuracion.EsIngles) {
				lblUsuario.Text = "USER";
				lblContrasena.Text = "PASSWORD";
				lblRol.Text = "Select your Role";
				btnCambiarIdioma.Text = "Change Language";
				btnIngresar.Text = "Log In";
			} else 
			{
				lblUsuario.Text = "USUARIO";
				lblContrasena.Text = "CONTRASEÑA";
				lblRol.Text = "Seleccione su Rol";
				btnCambiarIdioma.Text = "Cambiar Idioma";
				btnIngresar.Text = "Ingresar";
			}
		}
		
    }
}