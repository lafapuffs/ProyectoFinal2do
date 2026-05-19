using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProyectoEducativo
{
    public partial class FormCalculo : Form
    {
        private string cadenaConexion = "Server=localhost;Database=proyectin;Uid=root;Pwd=;";
        private DataTable dtPreguntas; // Guarda todas las preguntas en memoria
        private int indiceActual = 0;  // Controla en qué pregunta vamos

        public FormCalculo()
        {
            InitializeComponent();
            CargarPreguntasDesdeBD();
            AplicarIdioma();
        }

        // 1. Descargamos las preguntas de MySQL
        private void CargarPreguntasDesdeBD()
        {
            dtPreguntas = new DataTable();
            try
            {
                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                {
                    string consulta = "SELECT pregunta, pregunta_en, opcion_a, opcion_a_en, opcion_b, opcion_b_en, " + 
                  "opcion_c, opcion_c_en, opcion_d, opcion_d_en, respuesta_correcta FROM preguntas_calculo";
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, conexion);
                    adaptador.Fill(dtPreguntas);
                }

                if (dtPreguntas.Rows.Count > 0)
                {
                    MostrarPregunta(); // Mostramos la primera pregunta
                }
                else
                {
                    lblPregunta.Text = "No hay preguntas cargadas en la base de datos.";
                    DesactivarBotones();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión: " + ex.Message);
            }
        }

        // 2. Colocamos el texto en los botones y el label
       private void MostrarPregunta()
{
    if (indiceActual < dtPreguntas.Rows.Count)
    {
        DataRow fila = dtPreguntas.Rows[indiceActual];
        
        // Usamos una variable para decidir el sufijo de la columna
        string sufijo = Configuracion.EsIngles ? "_en" : "";

        // Si es inglés, buscará "pregunta_en", si es español, buscará "pregunta"
        lblPregunta.Text = fila["pregunta" + sufijo].ToString();
        btnA.Text = "A: " + fila["opcion_a" + sufijo].ToString();
        btnB.Text = "B: " + fila["opcion_b" + sufijo].ToString();
        btnC.Text = "C: " + fila["opcion_c" + sufijo].ToString();
        btnD.Text = "D: " + fila["opcion_d" + sufijo].ToString();
    }
    else
    {
        string msj = Configuracion.EsIngles ? "Module Completed" : "Módulo Terminado";
        MessageBox.Show(msj);
        this.Close();
    }
}

        // 3. Lógica para evaluar si el jugador acertó
       private void VerificarRespuesta(string opcionElegida)
{
    DataRow fila = dtPreguntas.Rows[indiceActual];
    string respuestaCorrecta = fila["respuesta_correcta"].ToString();
    
    int cambioPuntos = 0;

    if (opcionElegida == respuestaCorrecta) {
        MessageBox.Show(Configuracion.EsIngles ? "Correct!" : "¡Correcto!");
        cambioPuntos = 10;
    } else {
        MessageBox.Show(Configuracion.EsIngles ? "Incorrect." : "Incorrecto.");
        cambioPuntos = -5;
    }

    // Llamamos a una nueva función para actualizar BD
    ActualizarPuntajeUsuario(cambioPuntos);

    indiceActual++;
    MostrarPregunta();
}

	private void ActualizarPuntajeUsuario(int puntos)
{
    // MENSAJE DE DEPURACIÓN: Verifica qué ID está usando
    MessageBox.Show("Actualizando ID: " + Configuracion.IdUsuarioLogueado);

    string sql = "UPDATE usuario SET puntaje = GREATEST(0, puntaje + @puntos) WHERE id = @id";
    
    using (MySqlConnection con = new MySqlConnection(cadenaConexion)) {
        MySqlCommand cmd = new MySqlCommand(sql, con);
        cmd.Parameters.AddWithValue("@puntos", puntos);
        cmd.Parameters.AddWithValue("@id", Configuracion.IdUsuarioLogueado);
        con.Open();
        int filasAfectadas = cmd.ExecuteNonQuery(); // Guardamos el resultado
        
        if (filasAfectadas == 0) {
             MessageBox.Show("¡Advertencia! No se actualizó ningún usuario. ¿Es el ID correcto?");
        }
    }
}

        // 4. Eventos de los botones (Recuerda hacerles doble clic en el diseñador para conectarlos)
        void BtnAClick(object sender, EventArgs e)
        {
            VerificarRespuesta("A");
        }
        void BtnBClick(object sender, EventArgs e)
        {
            VerificarRespuesta("B");
        }
        void BtnCClick(object sender, EventArgs e)
        {
            VerificarRespuesta("C");
        }
        void BtnDClick(object sender, EventArgs e)
        {
            VerificarRespuesta("D");
        }

        private void DesactivarBotones()
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
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
		
		void AplicarIdioma()
{
    // 1. Traducir el título de la ventana
    this.Text = Configuracion.EsIngles ? "Sports Quiz" : "Cuestionario de Deporte";
    
    // 2. Refrescar la pregunta actual con las nuevas columnas
    if (dtPreguntas != null && dtPreguntas.Rows.Count > 0)
    {
        MostrarPregunta();
    }
}
    }
}