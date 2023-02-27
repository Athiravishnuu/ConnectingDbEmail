using Microsoft.AspNetCore.Mvc;

namespace ConnectingDbEmail.Controllers;
public class EmailController : Controller
{
    public IActionResult Index()
    {
     return View();
    }

    [HttpPost]
    public String say()
    {
        return "hai";
    }

  











}



