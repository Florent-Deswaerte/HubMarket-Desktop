using System;
using System.IdentityModel.Tokens.Jwt;

namespace HubMarket_Desktop
{
    public class JwtToken
    {
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
