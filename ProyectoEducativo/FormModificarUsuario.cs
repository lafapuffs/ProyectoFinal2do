using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace ProyectoEducativo
{
	
		public partial class FormModificarUsuario : Form
	{
		private string cadenaConexion = "Server=localhost;Database=proyectin;Uid=root;Pwd=;";
  	  	private int idUsuario; // Para saber a quién estamos editando

    // Modificamos el constructor para recibir los datos
    
    	public FormModificarUsuario (int id, string nombre, string clave, int rol)
    {
        InitializeComponent();
        
        // Guardamos el ID y llenamos los campos con la info actual
        
        this.idUsuario = id;
        txtNombre.Text = nombre;
        txtClave.Text = clave;
        cmbRol.SelectedIndex = rol - 1; // Restamos 1 porque el índice empieza en 0
    }

    void BtnGuardarClick(object sender, EventArgs e)
    {
        string consulta = "UPDATE usuario SET nombre=@nom, clave=@cla, rol=@rol WHERE id=@id";

        try {
            using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
            {
                MySqlCommand cmd = new MySqlCommand(consulta, conexion);
                cmd.Parameters.AddWithValue("@nom", txtNombre.Text.Trim());
                cmd.Parameters.AddWithValue("@cla", txtClave.Text);
                cmd.Parameters.AddWithValue("@rol", cmbRol.SelectedIndex + 1);
                cmd.Parameters.AddWithValue("@id", idUsuario);

                conexion.Open();
                cmd.ExecuteNonQuery();
                
                MessageBox.Show("Usuario actualizado con éxito.");
                this.DialogResult = DialogResult.OK; // Aviso de éxito al padre
                this.Close();
            }
        } catch (Exception ex) {
            MessageBox.Show("Error al actualizar: " + ex.Message);
        }
    }
		void BtnCancelarClick(object sender, EventArgs e)
		{
			this.Close();
		}
    
		
}
}