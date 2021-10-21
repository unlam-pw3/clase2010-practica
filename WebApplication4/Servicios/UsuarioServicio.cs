using System;
using System.Collections.Generic;
using System.Linq;
using WebApplication4.Models;

namespace WebApplication4.Servicios
{
    public class UsuarioServicio
    {
        private EF_AppContext _contexto;
        public UsuarioServicio()
        {

            _contexto = new EF_AppContext();
        }

        public bool ValidarUsuario(string email, string password)
        {
            var usuario = _contexto.Usuarios.FirstOrDefault(u => u.Email == email && u.Password == password);
            return usuario != null;
        }

        public bool ExisteElUsuario(Usuario usuario)
        {
            var u = from u1 in _contexto.Usuarios
                    where u1.Email == usuario.Email
                    select u1;

            return u != null;
        }

        public void Registrar(Usuario usuario)
        {
            _contexto.Usuarios.Add(usuario);
            _contexto.SaveChanges();
        }

        public Usuario ObtenerUsuario(string email)
        {
            return _contexto.Usuarios.First(u => u.Email == email);
        }
    }
}
