using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProyectoEducativo
{
    public partial class FormAntropologia : Form
    {
        private string cadenaConexion = "Server=localhost;Database=proyectin;Uid=root;Pwd=;";
        private DataTable dtPreguntas; // Guarda todas las preguntas en memoria
        private int indiceActual = 0;  // Controla en qué pregunta vamos

        public FormAntropologia()
        {
            InitializeComponent();
            CargarPreguntasDesdeBD();
        }

        // 1. Descargamos las preguntas de MySQL
        private void CargarPreguntasDesdeBD()
        {
            dtPreguntas = new DataTable();
            try
            {
                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                {
                    string consulta = "SELECT pregunta, opcion_a, opcion_b, opcion_c, opcion_d, respuesta_correcta FROM preguntas_antropologia";
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
            // Verificamos si aún hay preguntas disponibles
            if (indiceActual < dtPreguntas.Rows.Count)
            {
                DataRow fila = dtPreguntas.Rows[indiceActual];
                
                lblPregunta.Text = fila["pregunta"].ToString();
                btnA.Text = "A: " + fila["opcion_a"].ToString();
                btnB.Text = "B: " + fila["opcion_b"].ToString();
                btnC.Text = "C: " + fila["opcion_c"].ToString();
                btnD.Text = "D: " + fila["opcion_d"].ToString();
            }
            else
            {
                MessageBox.Show("Has completado el módulo.", "Módulo Terminado");
                this.Close(); // Cierra esta ventana y devuelve al jugador al menú
            }
        }

        // 3. Lógica para evaluar si el jugador acertó
        private void VerificarRespuesta(string opcionElegida)
        {
            DataRow fila = dtPreguntas.Rows[indiceActual];
            string respuestaCorrecta = fila["respuesta_correcta"].ToString();
            
            // Obtenemos el texto completo de la respuesta correcta para el MessageBox
            string columnaCorrecta = "opcion_" + respuestaCorrecta.ToLower(); 
            string textoCorrecta = fila[columnaCorrecta].ToString();

            if (opcionElegida == respuestaCorrecta)
            {
                MessageBox.Show("¡Correcto!\nLa respuesta es la " + respuestaCorrecta + ": " + textoCorrecta, "Resultado");
            }
            else
            {
                MessageBox.Show("Incorrecto.");
            }

            // Avanzamos a la siguiente pregunta y la mostramos
            indiceActual++;
            MostrarPregunta();
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
    }
}