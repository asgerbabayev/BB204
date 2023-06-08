using JwtExample.Data.Entities.Enums;
using JwtExample.Data.Entities.Identity;
using JwtExample.DTO_s.AuthDto_s;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using WebApp.Data.Entities.Identity;

namespace WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<AppRole> _roleManager;
        private readonly IConfiguration _configuration;

        public AuthController(UserManager<AppUser> userManager, RoleManager<AppRole> roleManager, IConfiguration configuration)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _configuration = configuration;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(RegisterDto registerDto)
        {
            AppUser newUser = new AppUser
            {
                FullName = registerDto.FullName,
                Email = registerDto.Email,
                UserName = registerDto.UserName,
            };
            IdentityResult result = await _userManager.CreateAsync(newUser, registerDto.Password);
            if (!result.Succeeded) return BadRequest(new
            {
                Title = result.Errors.Select(x => x.Code),
                Description = result.Errors.Select(x => x.Description)
            });
            IdentityResult resultRole = await _userManager.AddToRoleAsync(newUser, UserRoles.Admin.ToString());
            if (!resultRole.Succeeded) return BadRequest(new
            {
                Title = resultRole.Errors.Select(x => x.Code),
                Description = resultRole.Errors.Select(x => x.Description)
            });
            return Ok("Register Success");
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginDto loginDto)
        {
            AppUser existsUser = await _userManager.FindByNameAsync(loginDto.UserName);
            if (existsUser is null) return Unauthorized();
            bool result = await _userManager.CheckPasswordAsync(existsUser, loginDto.Password);
            if (!result) return Unauthorized();


            List<Claim> claims = new List<Claim>()
            {
                new Claim(ClaimTypes.NameIdentifier, existsUser.Id),
                new Claim(ClaimTypes.Name, existsUser.UserName),
                new Claim(ClaimTypes.Email, existsUser.Email),
                new Claim("FullName", existsUser.FullName),
            };

            var roles = await _userManager.GetRolesAsync(existsUser);

            claims.AddRange(roles.Select(role => new Claim(ClaimTypes.Role, role)));

            DateTime expires = DateTime.UtcNow.AddSeconds(double.Parse(_configuration["JWT:expireDate"]));

            SymmetricSecurityKey securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:securityKey"]));

            SigningCredentials signingCredentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            JwtSecurityToken securityToken = new JwtSecurityToken(
                issuer: _configuration["JWT:issuer"],
                audience: _configuration["JWT:audience"],
                claims: claims,
                expires: expires,
                signingCredentials: signingCredentials
                );

            var token = new JwtSecurityTokenHandler().WriteToken(securityToken);

            return Ok(new
            {
                token = token,
                expireDate = expires
            });
        }


        //[HttpGet("create-role")]
        //public async Task<IActionResult> CreateRole()
        //{
        //    foreach (var role in Enum.GetValues(typeof(UserRoles)))
        //    {
        //        await _roleManager.CreateAsync(new AppRole { Name = role.ToString() });
        //    }
        //    return Ok("Roles Created");
        //}
    }
}
