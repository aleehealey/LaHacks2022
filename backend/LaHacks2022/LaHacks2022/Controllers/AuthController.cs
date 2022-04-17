using LaHacks2022.Services;
using Microsoft.AspNetCore.Mvc;


namespace LaHacks2022.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {
        private AuthService _authService;
        public AuthController(AuthService service)
        {
            _authService = service;
        }


        // login - validates user token returns user object
        // to login - require user google token
        // use this url to verify token https://oauth2.googleapis.com/tokeninfo?id_token=
        //      if use dne, sign up and return new user
        //          if exists, send back user
        [HttpPost("Login")]
        public async Task<IActionResult> Login([FromQuery] string token)
        {
            try
            {
                var ourJwt = await _authService.Login(token);
            }
            catch (Exception ex)
            {

            }
            return null;
        }




    }
}
