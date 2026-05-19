using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProyectoEducativo
{
    public partial class FormEditarModulo : Form
    {
        private string cadenaConexion = "Server=localhost;Database=proyectin;Uid=root;Pwd=;";
        private int idModulo;

        // Constructor que recibe los datos actuales
        public FormEditarModulo(int id, string n_es, string n_en)
        {
            InitializeComponent();
            AplicarIdioma();
            this.idModulo = id;
          
        }

        void AplicarIdioma()
        {
            if (Configuracion.EsIngles) {
        		this.Text = "Edit Module";
                lblNombreES.Text = "Name (Spanish):";
                lblNombreEN.Text = "Name (English):";
                btnGuardar.Text = "Save";
                btnVolver.Text = "Back";
            } else {
        		this.Text = "Edit Module";
                lblNombreES.Text = "Nombre (Español):";
                lblNombreEN.Text = "Nombre (Inglés):";
                btnGuardar.Text = "Guardar";
                btnVolver.Text = "Volver";
            }
        }

        void BtnGuardarClick(object sender, EventArgs e)
{
    // 1. Validación básica: Que los campos no estén vacíos
    if (string.IsNullOrEmpty(txtNombreES.Text) || string.IsNullOrEmpty(txtNombreEN.Text))
    {
        string aviso = Configuracion.EsIngles ? "Please fill in all fields." : "Por favor, llene todos los campos.";
        MessageBox.Show(aviso);
        return;
    }

    // 2. Definimos la consulta según la situación (Agregar o Modificar)
    string consulta;
    if (idModulo == 0) 
    {
        // Si el ID es 0, es porque venimos del botón "Agregar"
        consulta = "INSERT INTO modulos (nombre_es, nombre_en) VALUES (@es, @en)";
    }
    else 
    {
        // Si el ID no es 0, venimos de "Modificar"
        consulta = "UPDATE modulos SET nombre_es=@es, nombre_en=@en WHERE id=@id";
    }

    try 
    {
        using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
        {
            MySqlCommand cmd = new MySqlCommand(consulta, conexion);
            
            // Pasamos los parámetros de los TextBox
            cmd.Parameters.AddWithValue("@es", txtNombreES.Text.Trim());
            cmd.Parameters.AddWithValue("@en", txtNombreEN.Text.Trim());
            
            // Si es una edición, necesitamos el ID para el WHERE
            if (idModulo != 0)
            {
                cmd.Parameters.AddWithValue("@id", idModulo);
            }

            conexion.Open();
            cmd.ExecuteNonQuery();

            // Mensaje de éxito bilingüe
            string exito = Configuracion.EsIngles ? "Saved successfully!" : "¡Guardado con éxito!";
            MessageBox.Show(exito);

            // 3. Importante: Avisar al formulario anterior que hubo cambios y cerrar
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
    catch (Exception ex)
    {
        // Si algo falla (ej. base de datos apagada), lo atrapamos aquí
        MessageBox.Show("Error: " + ex.Message);
    }
}
		void BtnVolverClick(object sender, EventArgs e)
		{
			this.Close();
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
    }
}