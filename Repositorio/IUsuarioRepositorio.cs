using System.Collections.Generic;
using ApiUsuario.Models;

namespace ApiUsuario.Repositorio
{
    public interface IUsuarioRepositorio
    {
         void Add(Usuario user);
          IEnumerable<Usuario> getAll();
          Usuario Find(long id);
          void Remove(long id);
          void Update(Usuario user);
    }
}