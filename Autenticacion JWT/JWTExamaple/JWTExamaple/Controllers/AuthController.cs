using JWTExamaple.Helpers;
using JWTExamaple.Requests;
using Microsoft.AspNetCore.Authorization;

using Microsoft.AspNetCore.Mvc;

namespace JWTExamaple.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        [HttpPost]
        public ActionResult Login(AuthorizationRequest authorizationRequest)
        {
            if (authorizationRequest.User != "UsuarioApi")
                return BadRequest("El usuario no existe");

            if (authorizationRequest.Password != "1234")
                return BadRequest("La contraseña es incorrecta");

            string token = JWTHelper.CreateToken("askljbsinglsnvhlbanjkvbosenonandnankñfblñandñoanm noan", "1", authorizationRequest.User, 900);

            return Ok(token);
        }
    }
}
