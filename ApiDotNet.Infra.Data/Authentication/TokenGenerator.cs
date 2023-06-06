using ApiDotNet.Domain.Authentication;
using ApiDotNet.Domain.Entities;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace ApiDotNet.Infra.Data.Authentication
{
    public class TokenGenerator : ITokenGenerator
    {
        public dynamic Generator(User user)
        {
            var permission = string.Join(",", user.UserPermissions.Select(p => p.Permission.PermissionName).ToArray());
            var claims = new List<Claim>
            {
                new Claim("Email", user.Email),
                new Claim("Id", user.Id.ToString()),
                new Claim("Permissions", permission)
            };

            var expires = DateTime.UtcNow.AddDays(1);
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("ApiDotNet@2023-VictorBrambilla-SuperSeguro"));

            var tokenData = new JwtSecurityToken(
               signingCredentials: new SigningCredentials(key, SecurityAlgorithms.HmacSha256Signature),
               expires: expires,
                claims: claims
               );

            var token = new JwtSecurityTokenHandler().WriteToken(tokenData);
            return new
            {
                access_token = token,
                expires_in = expires
            };
        }
    }
}