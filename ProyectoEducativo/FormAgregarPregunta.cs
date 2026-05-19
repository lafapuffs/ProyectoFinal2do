using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace ProyectoEducativo
{
    public partial class FormAgregarPregunta : Form
    {
        private string cadenaConexion = "Server=localhost;Database=proyectin;Uid=root;Pwd=;";
        
        // Variable que guardará la tabla enviada desde FormGestionPreguntas
        private string tablaDestino;

        // Modificamos el constructor para recibir el nombre de la tabla
        public FormAgregarPregunta(string tabla)
        {
            InitializeComponent();
            this.tablaDestino = tabla;
        }
       

        // Botón para seleccionar imagen (Necesario para el módulo de Arquitectura)
        void BtnSeleccionarImagenClick(object sender, EventArgs e)
        {
            OpenFileDialog buscar = new OpenFileDialog();
            buscar.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png";
            
            if (buscar.ShowDialog() == DialogResult.OK)
            {
                txtImagenRuta.Text = buscar.FileName;
            }
        }
        

        void BtnGuardarClick(object sender, EventArgs e)
        {
            if (cmbCorrecta.SelectedIndex == -1) 
            { 
                MessageBox.Show("Seleccione la respuesta correcta."); 
                return; 
            }

            // Usamos string.Format para insertar el nombre de la tabla dinámicamente
            // Incluimos los campos en inglés y la ruta de imagen según el requerimiento
            string sql = string.Format(@"INSERT INTO {0} 
                (pregunta, pregunta_en, opcion_a, opcion_a_en, opcion_b, opcion_b_en, 
                 opcion_c, opcion_c_en, opcion_d, opcion_d_en, respuesta_correcta, imagen_ruta) 
                VALUES (@pre, @pre_en, @a, @a_en, @b, @b_en, @c, @c_en, @d, @d_en, @res, @img)", 
                tablaDestino);

            try {
                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                {
                    MySqlCommand cmd = new MySqlCommand(sql, conexion);
                    
                    // Parámetros en Español
                    cmd.Parameters.AddWithValue("@pre", txtPregunta.Text);
                    cmd.Parameters.AddWithValue("@a", txtA.Text);
                    cmd.Parameters.AddWithValue("@b", txtB.Text);
                    cmd.Parameters.AddWithValue("@c", txtC.Text);
                    cmd.Parameters.AddWithValue("@d", txtD.Text);
                    
                    // Parámetros en Inglés (Asegúrate de tener estos TextBox en tu diseño)
                    cmd.Parameters.AddWithValue("@pre_en", txtPreguntaEn.Text);
                    cmd.Parameters.AddWithValue("@a_en", txtAEn.Text);
                    cmd.Parameters.AddWithValue("@b_en", txtBEn.Text);
                    cmd.Parameters.AddWithValue("@c_en", txtCEn.Text);
                    cmd.Parameters.AddWithValue("@d_en", txtDEn.Text);

                    // Respuesta y Ruta de Imagen
                    cmd.Parameters.AddWithValue("@res", cmbCorrecta.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@img", txtImagenRuta.Text);

                    conexion.Open();
                    cmd.ExecuteNonQuery();
                    
                    MessageBox.Show("Pregunta añadida exitosamente en " + tablaDestino);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            } catch (Exception ex) {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }
		void BtnCancelarClick(object sender, EventArgs e)
		{
			this.Close();
		}
    }
}	