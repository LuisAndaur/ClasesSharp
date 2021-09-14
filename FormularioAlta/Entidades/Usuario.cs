using System;
using System.Collections.Generic;

namespace Entidades
{
    public class Usuario
    {
        private string nombre;
        private string apellido;
        private string dni;
        private string genero;
        private bool esArgentino;
        static List<Usuario> usuarios;

        static Usuario()
        {
            Usuario.usuarios = new List<Usuario>();
        }

        public Usuario(string nombre, string apellido, string dni, string genero, bool esArgentino)
        {
            this.SetNombre(nombre);
            this.SetApellido(apellido);
            this.SetDni(dni);
            this.SetGenero(genero);
            this.SetEsArgentino(esArgentino);
        }

        public void SetNombre(string nombre)
        {
            if (!String.IsNullOrEmpty(nombre))
            {
                this.nombre = nombre;
            }
        }

        public void SetApellido(string apellido)
        {
            if (!String.IsNullOrEmpty(apellido))
            {
                this.apellido = apellido;
            }
        }

        public void SetDni(string dni)
        {
            if (!String.IsNullOrEmpty(dni))
            {
                this.dni = dni;
            }
        }

        public void SetGenero(string genero)
        {
            if (!String.IsNullOrEmpty(genero))
            {
                this.genero = genero;
            }
        }

        public void SetEsArgentino(bool esArgentino)
        {
            this.esArgentino = esArgentino;
        }

        public static void CargarLista(Usuario usuario)
        {
            Usuario.usuarios.Add(usuario);
        }

        public static List<Usuario> ObtenerLista()
        {
            return Usuario.usuarios;
        }
  
    }
}
