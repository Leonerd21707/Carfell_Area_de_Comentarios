using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.Sprint4.Carfel.Models;
using Senai.Sprint4.Carfel.Repositorio;

namespace Senai.Sprint4.Carfel.Controllers {
    public class AdministradorController : Controller {

        //Responsavel pelo cadastramento do Administrador
         [HttpGet]
        public ActionResult Cadastrar () {
            return View ();
        }

        [HttpPost]
        public ActionResult Cadastrar (IFormCollection form) {
            AdministradorModel admin = new AdministradorModel (nome: form["nome"], email: form["email"], senha: form["senha"], dataCriacao: DateTime.Now);

            AdministradorRepositorio adminRep = new AdministradorRepositorio ();
            adminRep.Cadastrar (admin);

            ViewBag.Mensagem = "Administrador Cadastrado";

            return RedirectToAction ("Login");
        }

        //responsavel pelo login do administrador
        [HttpGet]
        public ActionResult Login () {
            return View ();
        }

        [HttpPost]
        public ActionResult Login (IFormCollection form) {
            AdministradorRepositorio adminRep = new AdministradorRepositorio ();
            AdministradorModel admin = adminRep.Login (form["email"], form["senha"]);

            if (admin != null) {
                HttpContext.Session.SetString ("idAdministrador", admin.Id.ToString ());

                return RedirectToAction ("Comentar", "Comentario");
            }

            ViewBag.Mensagem = "Administrador inválido";
            return View ();

        }
    }
}