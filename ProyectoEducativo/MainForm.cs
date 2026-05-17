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
              
        }
		
		void ButtonIngresarClick(object sender, EventArgs e)
{
    string user = txtUsuario.Text.Trim();
    string pass = txtPassword.Text;
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
                string consulta = "SELECT COUNT(*) FROM usuario WHERE nombre = @user AND clave = @pass AND rol = @rol";
                
                MySqlCommand cmd = new MySqlCommand(consulta, conexion);
                cmd.Parameters.AddWithValue("@user", user);
                cmd.Parameters.AddWithValue("@pass", pass);
                cmd.Parameters.AddWithValue("@rol", rolId);

                int resultado = Convert.ToInt32(cmd.ExecuteScalar());

                // --- AQUÍ ESTABA EL ERROR: Faltaban las llaves del IF ---
                if (resultado > 0)
                {
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
                            this.Show();
                            break;
                    }
                } 
                else 
                {
                    MessageBox.Show("EL USUARIO NO EXISTE O EL ROL ES INCORRECTO", "ERROR");
                }
                
            } 
        } 
        catch (Exception ex) 
        {
            MessageBox.Show("Error de conexión: " + ex.Message);
        }
    } 
}
    }
}