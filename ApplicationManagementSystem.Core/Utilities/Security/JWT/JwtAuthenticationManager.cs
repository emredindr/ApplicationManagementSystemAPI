using ApplicationManagementSystem.Core.DbModels;
using ApplicationManagementSystem.Core.Extensions;
using ApplicationManagementSystem.Core.Utilities.Security.Encryption;
using ApplicationManagementSystem.Core.Utilities.Security.JWT.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace ApplicationManagementSystem.Core.Utilities.Security.JWT
{
    public class JwtAuthenticationManager : IJwtAuthenticationManager
    {
        private readonly IJwtConfiguration _jwtConfiguration;

        private DateTime _accessTokenExpiration;
        public JwtAuthenticationManager(IJwtConfiguration jwtConfiguration)
        {
            _jwtConfiguration = jwtConfiguration;
        }
        public AccessToken CreateToken(User user)
        {
            _accessTokenExpiration = DateTime.Now.AddMinutes(_jwtConfiguration.AccessTokenExpiration);
            var securityKey = SecurityKeyHelper.CreateSecurityKey(_jwtConfiguration.SecurityKey);
            var signingCredentials = SigningCredentialsHelper.CreateSigningCredentials(securityKey);
            var jwt = CreateJwtSecurityToken(_jwtConfiguration, user, signingCredentials);
            var jwtSecurityTokenHandler = new JwtSecurityTokenHandler();
            var token = jwtSecurityTokenHandler.WriteToken(jwt);

            return new AccessToken
            {
                Token = token,
                ExprationTime = _accessTokenExpiration
            };
        }

        private JwtSecurityToken CreateJwtSecurityToken(IJwtConfiguration jwtConfiguration, User user,
            SigningCredentials signingCredentials)
        {
            var jwt = new JwtSecurityToken(
                jwtConfiguration.Issuer,
                jwtConfiguration.Audience,
                expires: _accessTokenExpiration,
                notBefore: DateTime.Now,
                claims: SetClaims(user),
                signingCredentials: signingCredentials
            );
            return jwt;
        }

        //To-Do User ile ilgili başka bir bilgi tutulmak istenirse buraya ekleme yapılır.
        private IEnumerable<Claim> SetClaims(User user)
        {
            var claims = new List<Claim>();
            claims.AddNameIdentifier(user.Id.ToString());
            claims.AddEmail(user.Email);
            claims.AddName($"{user.Name} {user.Surname}");
            //claims.AddPermissions(operationClaims.Select(c => c.Code).ToArray());
            return claims;
        }
    }
}
