using Microsoft.AspNetCore.Mvc;

namespace MyKeyBox.Modules.BackOffice.Api.Controllers;

[Route(BasePath)]
internal class ResourceRegistrationController:BaseController
{
    [HttpPost(nameof(DealerRegistration))]
    public async Task<IActionResult> DealerRegistration()
    {
        return Ok();
    }
}