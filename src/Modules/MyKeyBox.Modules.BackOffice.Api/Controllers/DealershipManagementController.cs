using Microsoft.AspNetCore.Mvc;
using MyKeyBox.Modules.BackOffice.Core.DTO.DealerShip.Request;
using MyKeyBox.Modules.BackOffice.Core.Services.DealerShipOffice;

namespace MyKeyBox.Modules.BackOffice.Api.Controllers;

[Route(BasePath)]
public class DealershipManagementController(IDealerShipOfficeService dealerShipOfficeService):BaseController
{
    [HttpGet(nameof(GetAllTemplateDealership))]
    public async Task<IActionResult> GetAllTemplateDealership()
        => Ok(await dealerShipOfficeService.GetAllTemplateAsync());
        
    
    [HttpGet("GetDealership/{id}")]
    public async Task<IActionResult> GetDealership(int id)
        =>Ok( await dealerShipOfficeService.GetAsync(id));
    
    
    [HttpPost(nameof(AddDealership))]
    public async Task<IActionResult> AddDealership(DealerShipRegistration dealerShipRegistration)
    {
        await dealerShipOfficeService.AddAsync(dealerShipRegistration);
        return Ok();
    }
    
    [HttpPut(nameof(UpdateDealership))]
    public async Task<IActionResult> UpdateDealership(DealershipUpdate dealerShipRegistration)
    {
        await dealerShipOfficeService.UpdateAsync(dealerShipRegistration);
        return Ok();
    }
    
    [HttpDelete(nameof(DeleteDealerShip))]
    public async Task<IActionResult> DeleteDealerShip(DealerShipRegistration dealerShipRegistration)
    {
        await dealerShipOfficeService.DeleteAsync(dealerShipRegistration);
        return Ok();
    }
}