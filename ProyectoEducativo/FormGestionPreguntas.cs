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
        
        // Esta variable guardará el nombre de la tabla según lo que elijas en el ComboBox
        private string tablaActual = "preguntas_antropologia"; 

        public FormGestionPreguntas()
        {
            InitializeComponent();
            // Seleccionamos el primer ítem por defecto
            cmbModulos.SelectedIndex = 0; 
            AplicarIdioma();
            CargarPreguntas();
        }

        // Evento que se dispara al cambiar la opción en el ComboBox
        void CmbModulosSelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbModulos.Text)
            {
                case "Antropologia": tablaActual = "preguntas_antropologia"; break;
                case "Arquitectura": tablaActual = "preguntas_arquitectura"; break;
                case "Calculo":      tablaActual = "preguntas_calculo"; break;
                case "Deporte":      tablaActual = "preguntas_deporte"; break;
            }
            CargarPreguntas();
        }

        public void CargarPreguntas()
{
    try {
        using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
        {
            string consulta = string.Format("SELECT * FROM {0}", tablaActual);
            
            MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, conexion);
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dgvPreguntas.DataSource = tabla;
        }
    } catch (Exception ex) {
        MessageBox.Show("Error: " + ex.Message);
    }
}

        void BtnEliminarClick(object sender, EventArgs e)
        {
            if (dgvPreguntas.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvPreguntas.SelectedRows[0].Cells["id"].Value);
                if (MessageBox.Show("¿Eliminar esta pregunta de " + cmbModulos.Text + "?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    // Ejecutamos el DELETE en la tabla que esté seleccionada
                    EjecutarQuery(string.Format("DELETE FROM {0} WHERE id = {1}", tablaActual, id));
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
            // Le pasamos al formulario de agregar el nombre de la tabla para que sepa dónde guardar
            FormAgregarPregunta frm = new FormAgregarPregunta(tablaActual);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                CargarPreguntas();
            }
        }
		void BtnModificarClick(object sender, EventArgs e)
		{
            if (dgvPreguntas.SelectedRows.Count > 0)
            {
                // Obtenemos los datos de la fila seleccionada
                int id = Convert.ToInt32(dgvPreguntas.SelectedRows[0].Cells["id"].Value);
                
                // Abrimos el formulario de modificar pasando la tabla y el ID
                FormModificarPregunta frm = new FormModificarPregunta(tablaActual, id);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    CargarPreguntas();
                }
            }
        }
		void BtnActualizarClick(object sender, EventArgs e)
		{
			CargarPreguntas();
		}
		
		void AplicarIdioma()
{
    if (Configuracion.EsIngles) {
        this.Text = "Manage Questions";
        btnAgregar.Text = "Add";
        btnEliminar.Text = "Delete";
        btnModificar.Text = "Modify";
        btnActualizar.Text = "Update";
        btnVolver.Text = "Back";
        btnCerrarSesion.Text = "Log Out";
       
    } else {
        this.Text = "Gestión de Preguntas";
        btnAgregar.Text = "Agregar";
        btnEliminar.Text = "Eliminar";
        btnModificar.Text = "Modificar";
        btnActualizar.Text = "Actualizar";
        btnCerrarSesion.Text = "Cerrar Sesion";
        btnVolver.Text = "Volver";
    }
}
		void BtnCerrarSesionClick(object sender, EventArgs e)
		{
	 		MessageBox.Show("Cerrando sesión...", "Aviso");
            Application.Exit();
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