using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace ProyectoEducativo
{
    public partial class FormGestionModulos : Form
    {
        private string cadenaConexion = "Server=localhost;Database=proyectin;Uid=root;Pwd=;";

        public FormGestionModulos()
        {
            InitializeComponent();
            AplicarIdioma();
            CargarModulos();
        }

        void AplicarIdioma()
        {
            if (Configuracion.EsIngles) {
                this.Text = "Module Management";
                lblTitulo.Text = "System Modules";
                btnAgregar.Text = "Add New";
                btnModificar.Text = "Edit";
                btnEliminar.Text = "Delete";
                btnCerrarSesion.Text = "Log Out";
                btnVolver.Text = "Back";
            } else {
                this.Text = "Gestión de Módulos";
                lblTitulo.Text = "Módulos del Sistema";
                btnAgregar.Text = "Agregar Nuevo";
                btnModificar.Text = "Modificar";
                btnEliminar.Text = "Eliminar";
                btnCerrarSesion.Text = "Cerrar Sesion";
                btnVolver.Text = "Volver";
            }
        }

        void CargarModulos()
        {
            try {
                using (MySqlConnection con = new MySqlConnection(cadenaConexion)) {
                    string query = "SELECT * FROM modulos";
                    MySqlDataAdapter da = new MySqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvModulos.DataSource = dt;
                    
                    // Traducir encabezados de la tabla
                    if (dgvModulos.Columns.Count > 0) {
                        dgvModulos.Columns["nombre_es"].HeaderText = Configuracion.EsIngles ? "Name (ES)" : "Nombre (ES)";
                        dgvModulos.Columns["nombre_en"].HeaderText = Configuracion.EsIngles ? "Name (EN)" : "Nombre (EN)";
                    }
                }
            } catch (Exception ex) {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // --- EVITAR EL ERROR DE SELECCIÓN ---
        void BtnModificarClick(object sender, EventArgs e)
        {
            if (dgvModulos.SelectedRows.Count > 0) 
            {
                int id = Convert.ToInt32(dgvModulos.SelectedRows[0].Cells["id"].Value);
                string n_es = dgvModulos.SelectedRows[0].Cells["nombre_es"].Value.ToString();
                string n_en = dgvModulos.SelectedRows[0].Cells["nombre_en"].Value.ToString();

                // Llamas al form de edición pasando los datos actuales
                FormEditarModulo frm = new FormEditarModulo(id, n_es, n_en);
                if (frm.ShowDialog() == DialogResult.OK) {
                    CargarModulos();
                }
            } 
            else 
            {
                string aviso = Configuracion.EsIngles ? "Select a module!" : "¡Seleccione un módulo!";
                MessageBox.Show(aviso);
            }
        }

        void BtnEliminarClick(object sender, EventArgs e)
        {
            if (dgvModulos.SelectedRows.Count > 0)
            {
                string confirm = Configuracion.EsIngles ? "Are you sure?" : "¿Está seguro?";
                if (MessageBox.Show(confirm, "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dgvModulos.SelectedRows[0].Cells["id"].Value);
                    EliminarDeBD(id);
                }
            }
        }

        void EliminarDeBD(int id)
        {
            using (MySqlConnection con = new MySqlConnection(cadenaConexion)) {
                string query = "DELETE FROM modulos WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                cmd.ExecuteNonQuery();
                CargarModulos();
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
		void BtnAgregarClick(object sender, EventArgs e)
		{
            // Usamos el mismo form de edición pero lo enviamos vacío o con ID 0
            FormEditarModulo frm = new FormEditarModulo(0, "", ""); 
            if (frm.ShowDialog() == DialogResult.OK) {
                CargarModulos();
            }
        }	
		
    }
}