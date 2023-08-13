using Client_Shiplink.Repository.Data;
using Client_Shiplink.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace Client_Shiplink.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        private readonly HomeRepository _repository;

        public HomeController(HomeRepository repository)
        {
            _repository = repository;
        }
    

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginVM login)
        {
            var jwtToken = await _repository.Logins(login);

            if (jwtToken == null || jwtToken.Data == null)
            {
                TempData["ErrorMessage"] = "Email or password is incorrect.";
                return RedirectToAction("Login", "Home");
            }
            var token = jwtToken.Data;
            var claim = ExtractClaims(token);
            var role = claim.Where(c => c.Type == "http://schemas.microsoft.com/ws/2008/06/identity/claims/role").Select(a => a.Value).LastOrDefault();
            var idClaim = claim.FirstOrDefault(c => c.Type == "http://schemas.microsoft.com/ws/2008/06/identity/claims/primarysid");
            var id = idClaim != null ? idClaim.Value : null;
            if (token == null)
            {
                return RedirectToAction("forgotpassword", "Home");
            }

            HttpContext.Session.SetString("JWToken", token);
            HttpContext.Session.SetString("id", id);

            if (role.Contains("Admin")) return RedirectToAction("Index", "Home");
            else return RedirectToAction("Dashboard", "Home");

        }


        public IActionResult Register()
        {
            return View();
        }
        
        [HttpPost]
        public async Task<IActionResult> Register(RegisterVM registerVM)
        {
            var result = await _repository.Registers(registerVM);

            if (result is null)
            {
                return RedirectToAction("Error", "Home");
            }
            else if (result.Code == 409)
            {
                ModelState.AddModelError(string.Empty, result.Message);
                TempData["Error"] = $"Something Went Wrong! - {result.Message}!";
                return View();
            }
            else if (result.Code == 200)
            {
                TempData["Success"] = $"Data has been Successfully Registered! - {result.Message}!";
                return RedirectToAction("Login", "Home");
            }
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Dashboard()
        {
            return View();
        }

        public IEnumerable<Claim> ExtractClaims(string jwtToken)
        {
            JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();
            JwtSecurityToken securityToken = (JwtSecurityToken)tokenHandler.ReadToken(jwtToken);
            IEnumerable<Claim> claims = securityToken.Claims;
            return claims;
        }

    }
}