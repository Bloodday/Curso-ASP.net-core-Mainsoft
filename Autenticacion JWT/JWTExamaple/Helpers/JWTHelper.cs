using Microsoft.IdentityModel.Tokens;

using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace JWTExamaple.Helpers
{
    public class JWTHelper
    {
        public static string CreateToken(string secret, string UserId,string UserName, int ExpirationInSeconds = 60)
        {
            if (secret.Length < 32)
                throw new Exception("El secreto necesita tener al menos 32 caracteres");

            var secretBytes = System.Text.Encoding.UTF8.GetBytes(secret);
            var claims = new ClaimsIdentity();
            claims.AddClaim(new Claim(ClaimTypes.NameIdentifier, UserId));
            claims.AddClaim(new Claim(ClaimTypes.Name, UserName));

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = claims,
                Expires = DateTime.Now.AddSeconds(ExpirationInSeconds),
                NotBefore = DateTime.Now,
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(secretBytes), SecurityAlgorithms.HmacSha256)
            };
            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}
