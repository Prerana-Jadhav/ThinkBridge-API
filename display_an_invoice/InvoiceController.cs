
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BuggyApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InvoiceController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetInvoice()
        {
            var items = new List<Item>
            {
                new Item { name = "Widget A", price = 19.99 },
                new Item { name = "Widget B", price = 9.99 },
                new Item { name = "Service Fee", price = 4.99 }
            };

            return Ok(new { items });
        }

        public class Item
        {
            public string name { get; set; } = string.Empty;
            public double price { get; set; }
        }
    }
}
