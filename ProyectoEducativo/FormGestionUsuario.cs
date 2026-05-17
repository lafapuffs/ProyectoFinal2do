using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;


namespace ProyectoEducativo
{
	
	public partial class FormGestionUsuario : Form
	{
		private string cadenaConexion =  "Server=localhost;Database=proyectin;Uid=root;Pwd=;";
		
		public FormGestionUsuario()
		{
			
			InitializeComponent();
			CargarUsuarios();
			
		}
		
		public void CargarUsuarios(){
		
			try {
				
				using (MySqlConnection conexion = new MySqlConnection(cadenaConexion)) 
				{
					string consulta = "SELECT  id, nombre, clave, rol from usuario";
					
					conexion.Open();
					
					MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, conexion);
					DataTable tabla = new DataTable(); 
					adaptador.Fill(tabla);
					
					dgvUsuario.DataSource = tabla;
					lblEstado.Text = string.Format("Cargados {0} usuarios.", tabla.Rows.Count);
					
				}
			} catch (Exception ex) {
				
				MessageBox.Show(string.Format("No se pudo realizar conexion por : {0}",ex.Message));
			}
		}
		
		void BtnVolverClick(object sender, EventArgs e)
		{
			
			this.Hide();
			FormAdministrador frmAdmin = new FormAdministrador();
             frmAdmin.Show();
			
		}
		void BtnCerrarSesionClick(object sender, EventArgs e)
		{
	 		MessageBox.Show("Cerrando sesión...", "Aviso");
            Application.Exit();
		}
		
		
		void AgregarClick(object sender, EventArgs e)
		{
			FormAgregar frmAgregar = new FormAgregar();
			
		if (frmAgregar.ShowDialog() == DialogResult.OK)
   	 {
        CargarUsuarios(); 
   	 }
			
		}
		
		void EliminarClick(object sender, EventArgs e)
{
   
    if (dgvUsuario.SelectedRows.Count > 0)
    {
       
        int idSeleccionado = Convert.ToInt32(dgvUsuario.SelectedRows[0].Cells["id"].Value);

     DialogResult confirmacion = MessageBox.Show("¿Está seguro de que desea eliminar este usuario?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

        if (confirmacion == DialogResult.Yes)
        {
            string consulta = "DELETE FROM usuario WHERE id = @id";

            try
            {
                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                using (MySqlCommand cmd = new MySqlCommand(consulta, conexion))
                {
                    cmd.Parameters.AddWithValue("@id", idSeleccionado);
                    conexion.Open();
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Usuario eliminado exitosamente.");
                CargarUsuarios(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
        }
    }
    else
    {
        MessageBox.Show("Por favor, seleccione toda la fila del usuario que desea eliminar (haga clic en el margen izquierdo de la tabla).");
    }
}
		
		
		
		void ModificarClick(object sender, EventArgs e)
{
		int id = Convert.ToInt32(dgvUsuario.SelectedRows[0].Cells["id"].Value);
		string nom = dgvUsuario.SelectedRows[0].Cells["nombre"].Value.ToString();
		string cla = dgvUsuario.SelectedRows[0].Cells["clave"].Value.ToString();
		int rol = Convert.ToInt32(dgvUsuario.SelectedRows[0].Cells["rol"].Value);


		FormModificarUsuario frm = new FormModificarUsuario(id, nom, cla, rol);
		frm.ShowDialog();
    }
		void ConsultarClick(object sender, EventArgs e)
		{
   
    string terminoBusqueda = txtConsultar.Text.Trim();
    if (terminoBusqueda == "")
    {
        CargarUsuarios();
        return;
    }
    

    string consulta = "SELECT id, nombre, clave, rol FROM usuario WHERE nombre LIKE @busqueda";

    try
    {
        using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
        {
            conexion.Open();
            using (MySqlCommand cmd = new MySqlCommand(consulta, conexion))
            {
                // Los % permiten buscar coincidencias parciales (ej: si buscas "ma", encuentra "maria")
                cmd.Parameters.AddWithValue("@busqueda", "%" + terminoBusqueda + "%");

                MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);

                dgvUsuario.DataSource = tabla;
                lblEstado.Text = string.Format("Búsqueda finalizada. {0} resultados.", tabla.Rows.Count);
            }
        }
    }
    catch (Exception ex)
    {
        MessageBox.Show("Error al consultar: " + ex.Message);
    }
}
		}
		
}
