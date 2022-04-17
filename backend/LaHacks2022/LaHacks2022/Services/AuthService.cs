using Model;

namespace LaHacks2022.Services
{
    public class AuthService
    {
        private LaHacksModelContainer _model;
        public AuthService(LaHacksModelContainer model)
        {
            _model = model;
        }

        public async Task<string> Login(string token)
        {
            // validate token
            // get email
            // check if email exists in db
            // if not, sign up
            // if yes return token
            return null;
        }
    }
}
