using Microsoft.AspNetCore.Mvc;

namespace SwaggerApiNet5.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        public IActionResult Products() => Ok(new { Id = 1, Name = "Smartphone" });
    }
}
