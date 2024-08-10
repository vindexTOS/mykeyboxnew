using Microsoft.AspNetCore.Mvc;

namespace MyKeyBox.Modules.BackOffice.Api.Controllers;

[Route(BasePath)]
public class HomeController:BaseController
{
    [HttpGet]
    public IActionResult Get() => Ok();
}