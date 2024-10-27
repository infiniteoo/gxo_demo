// Controllers/ItemController.cs
using Microsoft.AspNetCore.Mvc;
using InventoryAPI.Data;
using InventoryAPI.Models; // This line is crucial

namespace InventoryAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ItemController : ControllerBase
    {
        private readonly InventoryContext _context;

        public ItemController(InventoryContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<List<Item>> GetItems()
        {
            var items = _context.Items.ToList();
            return Ok(items);
        }
    }
}
