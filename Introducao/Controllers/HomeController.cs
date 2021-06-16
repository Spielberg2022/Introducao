using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Introducao.Models;

namespace Introducao.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var pessoa = new Introducao.Models.Pessoa()
            {
                PessoaID = 1,
                Nome = "Wesley Silveira",
                Tipo = "Administrador"
            };

            return View(pessoa);
        }

        public ActionResult Contatos()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Lista(Pessoa pessoa)
        {
            return View(pessoa);
        }
    }
}