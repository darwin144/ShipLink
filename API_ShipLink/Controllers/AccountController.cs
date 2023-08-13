using API_ShipLink.Contract;
using API_ShipLink.Models;
using API_ShipLink.Repository;
using API_ShipLink.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Net;
using System.Security.Claims;
using System.Text;

namespace API_ShipLink.Controllers
{
    public class AccountController : BaseController<Account, AccountVM>
    {
        private readonly IAccountRepository _accountRepository;
        private readonly IConfiguration _configuration;
        private readonly IMapper<Account, AccountVM> _mapper;
        public AccountController(IMapper<Account, AccountVM> mapper, IAccountRepository accountRepository, IConfiguration configuration) 
         : base(accountRepository, mapper)
        {
            _accountRepository = accountRepository;
            _configuration = configuration;
        }

        [HttpPost("Register")]
        public async Task<IActionResult> Register(RegisterVM register) {

            var result = await _accountRepository.Register(register);
            switch (result)
            {
                case 0:
                    return BadRequest(new ResponseVM<RegisterVM>
                    {
                        Code = StatusCodes.Status400BadRequest,
                        Status = HttpStatusCode.BadRequest.ToString(),
                        Message = "Registration Failed",
                    });
                case 1:
                    return BadRequest(new ResponseVM<RegisterVM>
                    {
                        Code = StatusCodes.Status400BadRequest,
                        Status = HttpStatusCode.BadRequest.ToString(),
                        Message = "Email Already Exist",
                    });
                case 2:
                    return BadRequest(new ResponseVM<RegisterVM>
                    {
                        Code = StatusCodes.Status400BadRequest,
                        Status = HttpStatusCode.BadRequest.ToString(),
                        Message = "Phone Number Already Exist",
                    });
                case 3:
                    return Ok(new ResponseVM<RegisterVM>
                    {
                        Code = StatusCodes.Status200OK,
                        Status = HttpStatusCode.OK.ToString(),
                        Message = "Proses Register Berhasil",
                    });
            }
            return Ok();
        }

        [HttpPost("login")]
        public async Task<ActionResult> Login(LoginVM loginVM)
        {
            try
            {
                var result = await _accountRepository.Login(loginVM);
                if (!result)
                {
                    return NotFound(new ResponseVM<LoginVM>
                    {
                        Code = StatusCodes.Status404NotFound,
                        Status = HttpStatusCode.NotFound.ToString(),
                        Message = "Data Akun Tidak Ditemukan",
                    });
                }

                var userdata = await _accountRepository.GetUserData(loginVM.Email);
                var claims = new List<Claim>()
                {
                    new Claim(ClaimTypes.PrimarySid, userdata.User_Id),
                    new Claim(ClaimTypes.Email, userdata.Email),
                    new Claim(ClaimTypes.Name, userdata.FullName)
                };

                var getRoles = await _accountRepository.GetRoles(loginVM.Email);
                foreach (var item in getRoles)
                {
                    claims.Add(new Claim(ClaimTypes.Role, item));
                }

                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:Key"]));
                var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
                var token = new JwtSecurityToken(
                    issuer: _configuration["JWT:Issuer"],
                    audience: _configuration["JWT:Audience"],
                    claims: claims,
                    expires: DateTime.Now.AddMinutes(10),
                    signingCredentials: signIn
                    );

                var generateToken = new JwtSecurityTokenHandler().WriteToken(token);

                return Ok(new ResponseVM<string>
                {
                    Code = StatusCodes.Status200OK,
                    Status = HttpStatusCode.OK.ToString(),
                    Message = "Berhasil Login",
                    Data = generateToken

                });
            }
            catch (Exception ex)
            {

                return BadRequest(new ResponseVM<LoginVM>
                {
                    Code = StatusCodes.Status400BadRequest,
                    Status = HttpStatusCode.BadRequest.ToString(),
                    Message = ex.Message,
                });

            }
        }
    }
}
