using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace ProyectoEducativo
{
	
	public partial class FormGestionPreguntas : Form
{
    private string cadenaConexion = "Server=localhost;Database=proyectin;Uid=root;Pwd=;";

    public FormGestionPreguntas()
    {
        InitializeComponent();
        CargarPreguntas();
    }

    public void CargarPreguntas()
    {
        try {
            using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
            {
                string consulta = "SELECT id, pregunta, opcion_a, opcion_b, opcion_c, opcion_d, respuesta_correcta FROM preguntas_antropologia";
                MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, conexion);
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                dgvPreguntas.DataSource = tabla;
            }
        } catch (Exception ex) {
            MessageBox.Show("Error al cargar: " + ex.Message);
        }
    }

    void BtnEliminarClick(object sender, EventArgs e)
    {
        if (dgvPreguntas.SelectedRows.Count > 0)
        {
            int id = Convert.ToInt32(dgvPreguntas.SelectedRows[0].Cells["id"].Value);
            if (MessageBox.Show("¿Eliminar esta pregunta?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                EjecutarQuery("DELETE FROM preguntas_antropologia WHERE id = " + id);
                CargarPreguntas();
            }
        }
    }

    private void EjecutarQuery(string sql)
    {
        using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
        {
            conexion.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conexion);
            cmd.ExecuteNonQuery();
        }
    }
		void BtnAgregarClick(object sender, EventArgs e)
		{
			FormAgregarPregunta frmAgregarPregunta = new FormAgregarPregunta();
			frmAgregarPregunta.ShowDialog();
		}
		void BtnActualizarClick(object sender, EventArgs e)
		{
			CargarPreguntas();
		}
		
		
		
}
}