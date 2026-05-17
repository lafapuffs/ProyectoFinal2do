using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace ProyectoEducativo
{
	
	public partial class FormAgregarPregunta : Form
	{
		private string cadenaConexion =  "Server=localhost;Database=proyectin;Uid=root;Pwd=;";
		
		public FormAgregarPregunta()
		{
			
			InitializeComponent();
			
	
		}
		void BtnGuardarClick(object sender, EventArgs e)
		{
			
   		if (cmbCorrecta.SelectedIndex == -1) { 
        MessageBox.Show("Seleccione la respuesta correcta."); 
        return; 
    }

    string sql = "INSERT INTO preguntas_antropologia (pregunta, opcion_a, opcion_b, opcion_c, opcion_d, respuesta_correcta) " +
                 "VALUES (@pre, @a, @b, @c, @d, @res)";

    try {
        using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
        {
            MySqlCommand cmd = new MySqlCommand(sql, conexion);
            cmd.Parameters.AddWithValue("@pre", txtPregunta.Text);
            cmd.Parameters.AddWithValue("@a", txtA.Text);
            cmd.Parameters.AddWithValue("@b", txtB.Text);
            cmd.Parameters.AddWithValue("@c", txtC.Text);
            cmd.Parameters.AddWithValue("@d", txtD.Text);
            cmd.Parameters.AddWithValue("@res", cmbCorrecta.SelectedItem.ToString());

            conexion.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Pregunta añadida.");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    } catch (Exception ex) {
        MessageBox.Show("Error: " + ex.Message);
    }
}
	
		}
		
	}