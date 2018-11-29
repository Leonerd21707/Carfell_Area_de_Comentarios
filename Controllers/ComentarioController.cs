using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.Sprint4.Carfel.Models;
using Senai.Sprint4.Carfel.Repositorio;

namespace Senai.Sprint4.Carfel.Controllers {
    public class ComentarioController : Controller {
        //responsavel pelos comentarios
        [HttpGet]
        public ActionResult Comentar () {
            
            return View ();
        }

        [HttpPost]
        public ActionResult Comentar (IFormCollection form) {
            ComentarioModel comentario = new ComentarioModel (nome: form["nome"], comentario: form["comentario"], dataCriacao: DateTime.Now);

            ComentarioRepositorio comentarioRepositorio = new ComentarioRepositorio ();
            comentarioRepositorio.Comentar (comentario);

         string idUsuario = HttpContext.Session.GetString ("idUsuario");

            return View ();
        }

    }
}