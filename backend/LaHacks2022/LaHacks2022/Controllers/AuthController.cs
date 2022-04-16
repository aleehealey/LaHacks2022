using Microsoft.AspNetCore.Mvc;


namespace LaHacks2022.Controllers
{
    public class AuthController : ControllerBase
    {

        // login - validates user token returns user object
        // to login - require user google token
        // use this url to verify token https://oauth2.googleapis.com/tokeninfo?id_token=
        //      if use dne, sign up and return new user
        //          if exists, send back user
    }
}
