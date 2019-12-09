using System.Collections.Generic;
using System.ComponentModel;
using ApiUsuario.Models;
using ApiUsuario.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace ApiUsuario.Controllers
{
    [Route("api/[Controller]")]
    public class UsuariosController : Controller
    {
        private readonly IUsuarioRepositorio _usuarioRep ;
        public UsuariosController(IUsuarioRepositorio userRepo)
        {
            _usuarioRep = userRepo;
        }
        [HttpGet]
        public IEnumerable<Usuario> GetAll(){
            return _usuarioRep.getAll();
        }

        [HttpGet("{id}", Name = "GetUsuario")]
        public IActionResult getByID(long id){
            var usuario = _usuarioRep.Find(id);
            if(usuario == null){
                return NotFound();
            }
            return new ObjectResult(usuario);
        }

    }

}