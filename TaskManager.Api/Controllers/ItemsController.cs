using Microsoft.AspNetCore.Mvc;
using TaskManager.Api.Core.DTO;

namespace TaskManager.Api.Controllers;
public class ItemsController : ControllerBase
{
    public ItemsController()
    {
        
    }
    [HttpPost("create_item")]
    public async Task CreateItem([FromBody]ItemDTO item)
    {
        await Task.Delay(1);
    }

    [HttpGet("items")]
    public async Task<IEnumerable<ItemDTO>> GetItems([FromQuery]int boardId)
    {
        await Task.Delay(1);
        return Enumerable.Empty<ItemDTO>();
    }
}