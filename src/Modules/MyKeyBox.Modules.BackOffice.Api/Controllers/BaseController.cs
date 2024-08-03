using Microsoft.AspNetCore.Mvc;

namespace MyKeyBox.Modules.BackOffice.Api.Controllers;

[ApiController]
[Route(BasePath +"/[controller]")]
internal abstract class BaseController:ControllerBase
{
    protected const string BasePath = "backoffice-module";
}