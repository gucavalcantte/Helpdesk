using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ajudai.Modelo;
using Ajudai.DAL;

namespace AjudaiWeb.Controllers
{    
    [Authorize]
    [AccessSessions]
    public class ClienteController : Controller
    {
        //Área do Cliente Index
        public ActionResult Index()
        {
            ddCliente cliente = new ddCliente();
            cliente.id = Convert.ToInt32(Session["ssCodUsuario"]);//código do cliente logado

            ClienteDAO chamados = new ClienteDAO();

            List<ddChamado> ListaChamados = chamados.ListarChamadosDoCliente(cliente);

            return View(ListaChamados);
        }

        //Alterar Dados
        public ActionResult AlterarDados()
        {
            return View();
        }
    }
}