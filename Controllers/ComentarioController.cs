using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.Sprint4.Carfel.Interfaces;
using Senai.Sprint4.Carfel.Models;
using Senai.Sprint4.Carfel.Repositorio;

namespace Senai.Sprint4.Carfel.Controllers {
    public class ComentarioController : Controller {

        private IComentario ComentarioRepositorio {get; set;}

        private IUsuario UsuarioRepositorio {get; set;}

        public ComentarioController()
        {
            ComentarioRepositorio = new ComentarioRepositorioCSV();
            UsuarioRepositorio = new UsuarioRepositorio();
        }

        

        //responsavel pelos comentarios
        [HttpGet]
        public ActionResult Comentar () {

            return View ();
        }

        [HttpPost]
        public ActionResult Comentar (IFormCollection form) {
            int idUsuario = int.Parse(HttpContext.Session.GetString ("idUsuario"));
            UsuarioModel usuario = UsuarioRepositorio.BuscarPorId(idUsuario);
            ComentarioModel comentario = new ComentarioModel (
                comentario: form["comentario"], 
                dataCriacao: DateTime.Now, 
                usuario: usuario);
            

            
            ComentarioRepositorio.Comentar (comentario);

            return View ();
        }

    }
}