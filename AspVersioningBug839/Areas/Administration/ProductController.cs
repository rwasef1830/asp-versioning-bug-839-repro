using Microsoft.AspNetCore.Mvc;

namespace AspVersioningBug839.Areas.Administration;

[Area(nameof(Administration))]
[Route("[area]/[controller]")]
public class ProductController : Controller
{
    public IActionResult Index()
    {
        return this.Content("Hello I am the administration ProductController");
    }
}
