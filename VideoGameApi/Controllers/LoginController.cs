using VideoGameApi.Business.Interfaces;
using VideoGameApi.Business.Models;
using Microsoft.AspNetCore.Mvc;
namespace VideoGameApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IAuthenticationService _authenticationService;

        public LoginController(IAuthenticationService authenticationService, IUserService userService)
        {
            _authenticationService = authenticationService;
            _userService = userService;
        }

        [HttpPost]
        public async Task<IActionResult> Login([FromBody] LoginRequest loginRequest)
        {
            if (loginRequest == null || string.IsNullOrEmpty(loginRequest.Email) || string.IsNullOrEmpty(loginRequest.Password))
            {
                return BadRequest("Datos no proporcionados");
            }
            //Llamar al servicio de autnteicacion para el login
            var token = await _authenticationService.LoginAsync(loginRequest);

            //Verificar si el usuario fue autenticado

            if (token != null)
            {
                return Ok(token);
            }
            return NotFound("Usuario No encontrado");
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(RegisterRequest request)
        {
            await _userService.RegisterAsync(request);
            return Ok("Usuario registrado correctamente");
        }

    }
}
