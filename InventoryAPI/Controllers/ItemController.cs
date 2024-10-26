// Controllers.ItemController.cs

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;



[Route("api/[controller]")]
[ApiController]

public class ItemsController : ControllerBase {
    private readonly InventoryContext _context;

    public ItemsController(InventoryContext context) {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Item>>> GetItems() {
        return await _context.Items.ToListAsync();
    }

  

}