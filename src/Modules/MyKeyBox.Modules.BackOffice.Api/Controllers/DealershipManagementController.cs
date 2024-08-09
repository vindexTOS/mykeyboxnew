using Microsoft.AspNetCore.Mvc;
using MyKeyBox.Modules.BackOffice.Core.DTO.DealerShip;

namespace MyKeyBox.Modules.BackOffice.Api.Controllers;

[Route(BasePath)]
internal class DealershipManagementController:BaseController
{
    [HttpPost(nameof(DealerRegistration))]
    public async Task<IActionResult> DealerRegistration(DealerShipOfficeDto dealerShipOfficeDto)
    {
        await Task.CompletedTask;
        return Ok();
    }
}