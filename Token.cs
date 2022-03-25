using System;
using System.IdentityModel.Tokens.Jwt;
using System.Text.Json;
using Newtonsoft.Json;

namespace HubMarket_Desktop
{
    public class JwtToken
    {
        [JsonProperty(PropertyName = "token")]
        public string Token { get; set; }

        public static string DecodeToken(string tokenToDecode)
        {
            var handler = new JwtSecurityTokenHandler();
            var jwtSecurityToken = handler.ReadJwtToken(tokenToDecode);
            var jwtSecurityTokenPayload = jwtSecurityToken.Payload;
            string jwtSecurityTokenPayloadJson = jwtSecurityTokenPayload.SerializeToJson();
            return jwtSecurityTokenPayloadJson;
        }
    }
}
