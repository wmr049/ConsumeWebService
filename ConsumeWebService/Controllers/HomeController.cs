using ConsumeWebService.Models;
using ConsumeWebService.Services;
using System.Web.Mvc;

namespace ConsumeWebService.Controllers
{
    public class HomeController : BaseController
    {
        private static WebService savieadService = new WebService("http://ws.saviead.aeduvirtual.com.br/webservice/soap/index.php");    // DEFAULT location of the WebService, containing the WebMethods

        public ActionResult Index()
        {
            return View();
        }        

        public ActionResult KeyValue(RequisicaoViewModel requisicao)
        {
            savieadService.PreInvoke();

            savieadService.AddParameter(requisicao.chave1, requisicao.valor1);
            savieadService.AddParameter(requisicao.chave2, requisicao.valor2);
            savieadService.AddParameter(requisicao.chave3, requisicao.valor3);
            savieadService.AddParameter(requisicao.chave4, requisicao.valor4);
            savieadService.AddParameter(requisicao.chave5, requisicao.valor5);
            savieadService.AddParameter(requisicao.chave6, requisicao.valor6);
            savieadService.AddParameter(requisicao.chave7, requisicao.valor7);
            savieadService.AddParameter(requisicao.chave8, requisicao.valor8);

            try
            {
                savieadService.Invoke("insertUser");
            }
            finally { savieadService.PosInvoke(); }

            return JsonNetResult(new { status = new { codigo = "ok", msg = savieadService.ResultString } });
        }
    }
}