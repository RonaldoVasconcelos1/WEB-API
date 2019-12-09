using System.Collections.Generic;
using System.Linq;
using ApiUsuario.Models;

namespace ApiUsuario.Repositorio
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
         private readonly UsuarioDdContext _contexto;
        public UsuarioRepositorio(UsuarioDdContext ctx)
        {
            _contexto = ctx;
        }
        public void Add(Usuario user)
        {
            _contexto.Usuarios.Add(user);
            _contexto.SaveChanges();
        }

        public Usuario Find(long id)
        {
            return _contexto.Usuarios.FirstOrDefault(u => u.UsuarioId ==id);
        }

        public IEnumerable<Usuario> getAll()
        {
            return _contexto.Usuarios.ToList();
        }

        public void Remove(long id)
        {
            var entity = _contexto.Usuarios.First(u => u.UsuarioId == id);
            _contexto.Remove(id);
            _contexto.SaveChanges();

        }

        public void Update(Usuario user)
        {
            _contexto.Usuarios.Update(user);
        }
    }
}