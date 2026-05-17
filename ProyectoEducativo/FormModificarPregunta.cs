using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace ProyectoEducativo
{
    public partial class FormModificarPregunta : Form
    {
        private string cadenaConexion = "Server=localhost;Database=proyectin;Uid=root;Pwd=;";
        private string tablaDestino;
        private int idPregunta;

        // El constructor recibe la tabla y el ID de la pregunta seleccionada
        public FormModificarPregunta(string tabla, int id)
        {
            InitializeComponent();
            this.tablaDestino = tabla;
            this.idPregunta = id;
            
            CargarDatosPregunta();
        }

        // Método para traer los datos actuales de la base de datos
        private void CargarDatosPregunta()
        {
            try {
                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                {
                    string sql = string.Format("SELECT * FROM {0} WHERE id = @id", tablaDestino);
                    MySqlCommand cmd = new MySqlCommand(sql, conexion);
                    cmd.Parameters.AddWithValue("@id", idPregunta);
                    
                    conexion.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    
                    if (reader.Read())
                    {
                        // Llenar los TextBox con lo que ya existe en la DB
                        txtPregunta.Text = reader["pregunta"].ToString();
                        txtPreguntaEn.Text = reader["pregunta_en"].ToString();
                        txtA.Text = reader["opcion_a"].ToString();
                        txtAEn.Text = reader["opcion_a_en"].ToString();
                        txtB.Text = reader["opcion_b"].ToString();
                        txtBEn.Text = reader["opcion_b_en"].ToString();
                        txtC.Text = reader["opcion_c"].ToString();
                        txtCEn.Text = reader["opcion_c_en"].ToString();
                        txtD.Text = reader["opcion_d"].ToString();
                        txtDEn.Text = reader["opcion_d_en"].ToString();
                        cmbCorrecta.SelectedItem = reader["respuesta_correcta"].ToString();
                        txtImagenRuta.Text = reader["imagen_ruta"].ToString();
                    }
                }
            } catch (Exception ex) {
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }
        }

        void BtnGuardarCambiosClick(object sender, EventArgs e)
        {
            // Usamos UPDATE en lugar de INSERT
            string sql = string.Format(@"UPDATE {0} SET 
                pregunta = @pre, pregunta_en = @pre_en, 
                opcion_a = @a, opcion_a_en = @a_en, 
                opcion_b = @b, opcion_b_en = @b_en, 
                opcion_c = @c, opcion_c_en = @c_en, 
                opcion_d = @d, opcion_d_en = @d_en, 
                respuesta_correcta = @res, imagen_ruta = @img 
                WHERE id = @id", tablaDestino);

            try {
                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                {
                    MySqlCommand cmd = new MySqlCommand(sql, conexion);
                    
                    cmd.Parameters.AddWithValue("@id", idPregunta);
                    cmd.Parameters.AddWithValue("@pre", txtPregunta.Text);
                    cmd.Parameters.AddWithValue("@pre_en", txtPreguntaEn.Text);
                    cmd.Parameters.AddWithValue("@a", txtA.Text);
                    cmd.Parameters.AddWithValue("@a_en", txtAEn.Text);
                    cmd.Parameters.AddWithValue("@b", txtB.Text);
                    cmd.Parameters.AddWithValue("@b_en", txtBEn.Text);
                    cmd.Parameters.AddWithValue("@c", txtC.Text);
                    cmd.Parameters.AddWithValue("@c_en", txtCEn.Text);
                    cmd.Parameters.AddWithValue("@d", txtD.Text);
                    cmd.Parameters.AddWithValue("@d_en", txtDEn.Text);
                    cmd.Parameters.AddWithValue("@res", cmbCorrecta.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@img", txtImagenRuta.Text);

                    conexion.Open();
                    cmd.ExecuteNonQuery();
                    
                    MessageBox.Show("Pregunta actualizada correctamente.");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            } catch (Exception ex) {
                MessageBox.Show("Error al actualizar: " + ex.Message);
            }
        }

        void BtnSeleccionarImagenClick(object sender, EventArgs e)
        {
            OpenFileDialog buscar = new OpenFileDialog();
            if (buscar.ShowDialog() == DialogResult.OK)
            {
                txtImagenRuta.Text = buscar.FileName;
            }
        }
    }
}