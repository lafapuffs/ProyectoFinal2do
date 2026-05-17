using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;


namespace ProyectoEducativo
{
	
	public partial class FormAgregar : Form
	{
		private string cadenaConexion =  "Server=localhost;Database=proyectin;Uid=root;Pwd=;";
		
		public FormAgregar()
		{
			InitializeComponent();
			
			
			}
		
		void BtnCancelarClick(object sender, EventArgs e)
		{
			this.Hide();
		}
		
		void BtnAceptarClick(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtNombre.Text))
			{
				MessageBox.Show("Escriba nombre para el usuario.");
				return;
			}
			if (string.IsNullOrWhiteSpace(txtClave.Text))
			{
				MessageBox.Show("Escriba clave para el usuario.");
				return;
			}
			// Validar que haya un rol seleccionado
			if (cmbRol.SelectedIndex == -1)
			{
				MessageBox.Show("Seleccione un rol.");
				return;
			}
			
			int idrol = (int)cmbRol.SelectedIndex + 1;
						
			// Paso 2: Consulta SQL con parámetros
			string consulta = "INSERT INTO usuario (nombre, clave, rol) VALUES (@nombre, @clave,@rol)";
			try
			{
				// Paso 3: Crear conexión y comando
				using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
					using (MySqlCommand cmd = new MySqlCommand(consulta, conexion))
				{
					// Paso 4: Asignar parámetros
					cmd.Parameters.AddWithValue("@nombre", txtNombre.Text.Trim());
					cmd.Parameters.AddWithValue("@clave", txtClave.Text);
					cmd.Parameters.AddWithValue("@rol", idrol);
					// Paso 5: Abrir y ejecutar
					conexion.Open();
					cmd.ExecuteNonQuery();
				}
				MessageBox.Show("Usuario agregada correctamente.");
				this.DialogResult = DialogResult.OK;   // Para que el padre sepa que se agregó
				this.Close();
				
			}
			catch (Exception ex)
			{
				MessageBox.Show(string.Format("Error al agregar: {0}", ex.Message));
			}
		}
		}
		
		}