using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using Microsoft.AspNetCore.Mvc;

namespace MiApi.AddControllers;

[ApiController]
[Route("api/[controller]")]
public class MCDController : ControllerBase
{
   [HttpGet("MCD/{dividiendo:int}/{divisor:int}")] 
   public IActionResult Mcd(int dividiendo, int divisor)
    {

        while(divisor != 0)
        {
            int residuo = dividiendo % divisor;
            dividiendo = divisor;
            divisor = residuo;
            
        }

        return Ok(dividiendo);
    }
}