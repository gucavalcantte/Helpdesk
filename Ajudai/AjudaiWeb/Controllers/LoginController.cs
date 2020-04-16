using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ajudai.Modelo;
using Ajudai.DAL;
using System.Web.Security;

namespace AjudaiWeb.Controllers
{
    public class LoginController : Controller
    {
        //Login
        public ActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Cliente");
            }
            return View();
        }

        //Login - post
        [HttpPost]
        public ActionResult Index(ddCliente dadosTela)
        {
            bool valido = false;
            ddCliente novoCliente = new ddCliente();
            ClienteDAO cliente = new ClienteDAO();

            if (cliente.Acessar(dadosTela))
            {
                ddCliente dadosCliente = new ddCliente();
                dadosCliente.login = dadosTela.login;

                novoCliente = cliente.PesquisarClientePorLogin(dadosCliente);

                if (novoCliente.id != 0)
                {
                    valido = true;
                }
            }

            if (valido == true)
            {
                FormsAuthentication.SetAuthCookie(novoCliente.login, true);
                Session.Add("ssCodUsuario", novoCliente.id);
                Session.Add("ssLogin", novoCliente.login);                
                return RedirectToAction("Index", "Cliente");
            }
            else
            {
                TempData.Add("Mensagem-Erro", "Usuário e/ou senha inválido(s). Tente novamente.");
                return RedirectToAction("Index");
            }
        }

        //Cadastro
        public ActionResult Cadastro()
        {
            return View();
        }

        //Cadastro - post
        [HttpPost]
        public ActionResult Cadastro(ddCliente dadosTela)
        {
            ClienteDAO cliente = new ClienteDAO();
            if (ModelState.IsValid)
            {
                cliente.CadastrarCliente(dadosTela);
                TempData.Add("Mensagem-Sucesso", "Cadastrado com sucesso!");
                return RedirectToAction("Cadastro");
            }
            else
            {
                return View(dadosTela);
            }            
        }

        //Sair
        public ActionResult Sair()
        {
            FormsAuthentication.SignOut();
            Session.RemoveAll();
            TempData.Add("Mensagem-Sucesso", "Sessão encerrada com sucesso!! Até breve.");
            return RedirectToAction("Index");
        }
    }
}