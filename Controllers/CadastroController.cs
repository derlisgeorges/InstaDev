using Microsoft.AspNetCore.Mvc;

namespace InstaDev.Controllers
{
    [Route("Cadastro")]
    public class CadastroController : Controllers
    {
        public IActionResult index()
        {
            return View();
        }
    }
}