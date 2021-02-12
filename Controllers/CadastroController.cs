using Microsoft.AspNetCore.Mvc;

namespace InstaDev.Controllers
{
    public class CadastroController : Controllers
    {
        public IActionResult index()
        {
            return View();
        }
    }
}