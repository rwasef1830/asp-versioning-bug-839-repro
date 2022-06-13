using System.Diagnostics.CodeAnalysis;
using Microsoft.AspNetCore.Mvc;

namespace AspVersioningBug839.Areas.Api;

[Area(nameof(Api))]
[ApiController]
[Route("[area]/v{version:apiVersion}/[controller]")]
[SuppressMessage("ReSharper", "RouteTemplates.RouteParameterConstraintNotResolved")]
public class ProductController : Controller
{
    public IActionResult Index()
    {
        return this.Json(new { message = "Hello I am the public API ProductController" });
    }
}
