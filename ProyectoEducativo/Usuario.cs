using System;

namespace ProyectoEducativo
{
    public class Usuario
    {
        public string NombreUsuario { get; set; }
        public string Contrasena { get; set; }
        public string Rol { get; set; } 
        public int Puntuacion { get; set; }

        public Usuario(string nombreUsuario, string contrasena, string rol)
        {
            this.NombreUsuario = nombreUsuario;
            this.Contrasena = contrasena;
            this.Rol = rol; 
            this.Puntuacion = 0; 
        }
    }
}