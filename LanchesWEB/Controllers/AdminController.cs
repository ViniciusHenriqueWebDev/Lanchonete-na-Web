using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanchesWEB.Controllers
{
    public class AdminController : Controller
    {
        public string Index()
        {
            return $"Testando o método Index de TesteController : {DateTime.Now} ";
        }

        public string Demo()
        {
            return $"testando o método Demo de AdminController : {DateTime.Now} "; 
        }
    }
}
