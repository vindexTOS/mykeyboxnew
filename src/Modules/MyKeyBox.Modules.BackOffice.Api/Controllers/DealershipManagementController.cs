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
        => Ok(await dealerShipOfficeService.AddAsync(dealerShipRegistration));
    
    [HttpPut(nameof(UpdateDealership))]
    public async Task<IActionResult> UpdateDealership(DealershipUpdate dealerShipRegistration)
        =>Ok(await dealerShipOfficeService.UpdateAsync(dealerShipRegistration));

    
    [HttpDelete(nameof(DeleteDealerShip))]
    public async Task<IActionResult> DeleteDealerShip(DealerShipRegistration dealerShipRegistration)
        => Ok(await dealerShipOfficeService.DeleteAsync(dealerShipRegistration));
}