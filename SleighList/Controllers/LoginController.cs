using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SleighList.Models;
using SleighList.Contexts;


namespace SleighList.Controllers;

    [Route("[controller]")]
    public class LoginController : Controller
    {
        private readonly ILogger<LoginController> _logger;

        public LoginController(ILogger<LoginController> logger)
        {
            _logger = logger;
        }

        Context context = new Context();

        public IActionResult Index()
        {
            return View();
        }

        [Route("Logar")]
        public IActionResult Logar(IFormCollection form){
            // Criar duas variaveis para armazenar as informacoes do formulario
            string emailInformado = form["Email"].ToString();
            string senhaInformado = form["Senha"].ToString();

            // Busca no banco de dados
            Usuario usuarioBuscado = context.Usuario.FirstOrDefault(usuario => usuario.Email == emailInformado && usuario.Senha == senhaInformado)!;

            
            if(usuarioBuscado == null){
                Console.WriteLine($"Dados inválidos!");
                return LocalRedirect("~/Login");
            }else{
                Console.WriteLine($"Eba você entrou!");
                HttpContext.Session.SetString("UsuarioID", usuarioBuscado.UsuarioID.ToString());
                return LocalRedirect("~/Usuario");
            }
        }

        // [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        // public IActionResult Error()
        // {
        //     return View("Error!");
        // }

    }

