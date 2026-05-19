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
			AplicarIdioma();
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
			this.Close();
			
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
		
		
		
			void BtnModificarClick(object sender, EventArgs e)
{
    // 1. Verificamos que haya al menos una fila seleccionada
   		 if (dgvUsuario.SelectedRows.Count > 0)
    {
        // Solo si hay una fila, extraemos el ID
       	 int id = Convert.ToInt32(dgvUsuario.SelectedRows[0].Cells["id"].Value);
        string nombre = dgvUsuario.SelectedRows[0].Cells["nombre"].Value.ToString();
		string clave = dgvUsuario.SelectedRows[0].Cells["clave"].Value.ToString();
		int rol = Convert.ToInt32(dgvUsuario.SelectedRows[0].Cells["id_rol"].Value);
       	 
       	 
       	 FormModificarUsuario frm = new FormModificarUsuario(id, nombre, clave, rol);
       	 if (frm.ShowDialog() == DialogResult.OK)
        {
          	  CargarUsuarios(); // Recargamos la tabla
        }
    }
   		 else
    {
        // 2. Si no hay nada seleccionado, le avisamos al usuario en el idioma actual
        if (Configuracion.EsIngles) {
            MessageBox.Show("Please select a user from the list first.", "Selection Required");
        } else {
            MessageBox.Show("Por favor, seleccione un usuario de la lista primero.", "Selección Requerida");
        }
    }
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
				btnCerrarSesion.Text = "Log Out";
				btnVolver.Text = "Back";
				btnAgregar.Text = "Add";
				btnModificar.Text = "Modify";
				btnEliminar.Text = "Delete";
				btnConsultar.Text = "Consult";
			} else
			{
				btnCerrarSesion.Text = "Cerrar Sesion";
				btnVolver.Text = "Volver";
				btnAgregar.Text = "Agregar";
				btnModificar.Text = "Modificar";
				btnEliminar.Text = "Eliminar";
				btnConsultar.Text = "Consultar";
			}
		
		}
		
		void DgvUsuariosSelectionChanged(object sender, EventArgs e)
{
    // Si hay selección, activamos los botones; si no, los apagamos
    bool haySeleccion = dgvUsuario.SelectedRows.Count > 0;
    btnModificar.Enabled = haySeleccion;
    btnEliminar.Enabled = haySeleccion;
}
		
}
}
