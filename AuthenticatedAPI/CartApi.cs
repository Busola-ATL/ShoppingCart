using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

[Authorize]
namespace MyApp.Namespace
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartApi : ControllerBase
    {
        
    }
}
