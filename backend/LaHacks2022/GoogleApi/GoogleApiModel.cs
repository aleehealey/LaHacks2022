

using RestSharp;
using RestSharp.Authenticators;

using Google.Apis.Auth;
using Google.Apis.Auth.OAuth2;

namespace GoogleApi
{
    public class GoogleApiModel
    {


        public async Task<string> ValidateToken(string token)
        {
            var client = new RestClient($"https://oauth2.googleapis.com/tokeninfo?id_token={token}");
            var request = new RestRequest();
            try
            {

                GoogleJsonWebSignature.Payload payload = await GoogleJsonWebSignature.ValidateAsync(token);
                return payload.Email;
            }
            catch (Exception ex)
            {
                throw new Exception("Bad Token!");
            }
        }
    }
}