using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using DomeWarsDomain.Entities;

namespace DomeWarsAPI.Tools
{
    public class TokenGenerator
    {
        private readonly string _secretkey;
        public TokenGenerator(IConfiguration config)
        {
            _secretkey = config.GetSection("TokenInfo").GetSection("secretKey").Value;
        }

        public string GenerateToken(Player player)
        {
            //Generation de la Verify Signature
            SymmetricSecurityKey securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_secretkey));
            SigningCredentials credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha512);

            //Generation du Payload (Data)
            Claim[] myClaims = new[]
            {
                new Claim(ClaimTypes.Email, player.Email),
                new Claim("Username", player.Username),
                new Claim("Id", player.Id.ToString())
            };

            //Generation du token
            JwtSecurityToken jwt = new JwtSecurityToken(
                claims: myClaims,
                signingCredentials: credentials,
                issuer: "https://monapi.com", //Emetteur du token
                audience: "https://monclient.com", //Consommateur
                expires: DateTime.Now.AddDays(8)
                );

            //Produire le token sous forme de string
            JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();

            return handler.WriteToken(jwt);

        }
    }
}
