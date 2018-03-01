using ConsumeWebService.Extensions;
using Newtonsoft.Json;
using System.Web.Mvc;

namespace ConsumeWebService.Controllers
{
    public class BaseController : Controller
    {
        /// <summary>
        /// Método utilizado para serializar as respostas em Json. Corrige o problema de retorno de DateTime.
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        internal ActionResult JsonNetResult(object data)
        {
            JsonNetResult jsonNetResult = new JsonNetResult();
            jsonNetResult.Formatting = Formatting.Indented;
            jsonNetResult.Data = data;

            return jsonNetResult;
        }
    }
}