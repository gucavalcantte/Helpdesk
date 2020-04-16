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
    public class ChamadoController : Controller
    {
        ChamadoDAO chamado = new ChamadoDAO();
        ProdutoDAO produtos = new ProdutoDAO();

        //Abrir Chamado
        public ActionResult AbrirChamado()
        {
            ViewBag.ListarProdutos = new SelectList(produtos.ddListarProdutos().Select(p => new SelectListItem
            {
                Value = p.id.ToString(),
                Text = p.nome + " - " + p.descricao
            }), "Value", "Text");

            return View();
        }

        //Abrir Chamado - post
        [HttpPost]
        public ActionResult AbrirChamado(ddChamado dadosTela)
        {
            dadosTela.idCliente = Convert.ToInt32(Session["ssCodUsuario"]);
            dadosTela.idFuncionario = 1;//código fixo do administrador, este receberá o chamado
            dadosTela.txStatus = "Aberto";//status pendente
            chamado.CadastrarChamado(dadosTela);

            TempData.Add("Mensagem-Sucesso", "Chamado aberto com sucesso");
            return RedirectToAction("Index", "Cliente");
        }

        //Consultar o chamado
        public ActionResult ConsultarChamado(int cdChamado)
        {
            ddChamado dadosChamado = new ddChamado();

            dadosChamado = chamado.PesquisarChamadoPorId(cdChamado);
            
            return View(dadosChamado);
        }

        //grava o posicionamento do cliente
        [HttpPost]
        public ActionResult CadastrarPosicionamento(ddChamado dadosTela)
        {
            chamado.CadastrarPosicionamentoCliente(dadosTela);

            TempData.Add("Mensagem-Sucesso", "Posicionamento salvo com sucesso");
            return RedirectToAction("ConsultarChamado", new { cdChamado = dadosTela.id });
        }

        //grava a avaliação
        [HttpPost]
        public ActionResult CadastrarAvaliacao(ddChamado dadosTela)
        {
            chamado.CadastrarAvaliacao(dadosTela);

            TempData.Add("Mensagem-Sucesso", "Avaliado com sucesso");
            return RedirectToAction("ConsultarChamado", new { cdChamado = dadosTela.id });
        }
    }
}