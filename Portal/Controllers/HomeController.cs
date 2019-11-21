using Microsoft.AspNetCore.Mvc;
using Portal.Core;
using Portal.Services;
using System.Net.Http;
using System.Threading.Tasks;

namespace Portal.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITimeService _service;
        private static int _requestsCounter = 0;

        public HomeController(ITimeService service)
        {
            _service = service;
        }

        public  async Task<IActionResult> Index()
        {
            // Verifica se a API tem recursos para atender a requisição
            if (!Program.CheckIfThereIsThreadAvailable())
                return BadRequest(Messages.THREAD_IS_NO_THREAD_AVAILABLE);

            // Busca as informações de data da API TimeAPI
            var result = await _service.GetTime();

            //Aplica os Valores para View e informações de memória 
            ViewData.SetResult(result, HashKey.From(result))
                .Dump(++_requestsCounter);

            return View();
        }

        public IActionResult Information()
        {
            return View();
        }
    }
}