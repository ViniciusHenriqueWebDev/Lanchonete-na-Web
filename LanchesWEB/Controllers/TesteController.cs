using Microsoft.AspNetCore.Mvc;

namespace LanchesWEB.Controllers
{
    public class TesteController : Controller
    {
        public string Index()
        {
            return $"Testando o método Index de TesteController : {DateTime.Now} "; 
        }
    }
}
