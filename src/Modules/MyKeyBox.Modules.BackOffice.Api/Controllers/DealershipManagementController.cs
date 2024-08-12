using Microsoft.AspNetCore.Mvc;
using MyKeyBox.Modules.BackOffice.Core.DTO.DealerShip;
using MyKeyBox.Modules.BackOffice.Core.Services.DealerShipOffice;

namespace MyKeyBox.Modules.BackOffice.Api.Controllers;

[Route(BasePath)]
public class DealershipManagementController(IDealerShipOfficeService dealerShipOfficeService):BaseController
{
    [HttpGet(nameof(GetAllTemplateDealership))]
    public async Task<IActionResult> GetAllTemplateDealership()
    {
        await dealerShipOfficeService.GetAllTemplateAsync();
        return Ok();
    }
    
    [HttpGet("GetDealership/{id}")]
    public async Task<IActionResult> GetDealership(int id)
    {
        await dealerShipOfficeService.GetAsync(id);
        return Ok();
    }
    
    [HttpPost(nameof(AddDealership))]
    public async Task<IActionResult> AddDealership(DealerShipOfficeDto dealerShipOfficeDto)
    {
        await dealerShipOfficeService.AddAsync(dealerShipOfficeDto);
        return Ok();
    }
    
    [HttpPut(nameof(UpdateDealership))]
    public async Task<IActionResult> UpdateDealership(DealerShipOfficeDto dealerShipOfficeDto)
    {
        await dealerShipOfficeService.UpdateAsync(dealerShipOfficeDto);
        return Ok();
    }
    
    [HttpPut(nameof(DeleteDealerShip))]
    public async Task<IActionResult> DeleteDealerShip(DealerShipOfficeDto dealerShipOfficeDto)
    {
        await dealerShipOfficeService.DeleteAsync(dealerShipOfficeDto);
        return Ok();
    }
}