using Microsoft.AspNetCore.Mvc;

namespace MyKeyBox.Modules.BackOffice.Api.Controllers;

[Route(BasePath)]
internal class HomeController:BaseController
{
    [HttpGet]
    public IActionResult Get() => Ok();
}