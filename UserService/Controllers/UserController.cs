using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using DAL.Data;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.Extensions.Configuration;
using SharedModels.UserService;
using UserService.Models;

namespace UserService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly UserManager<IdentityUser> userManager;
        private readonly DataContext _context;

        public UserController(UserManager<IdentityUser> userManager, DataContext context)
        {
            _context = context;
            this.userManager = userManager;
        }

        //POST: REGISTRAR USER CLIENTE
        [HttpPost]
        [Route("Register/Cliente")]
        public async Task<IActionResult> RegisterClient([FromBody] UserDetails userDetails)
        {
            if (!ModelState.IsValid || userDetails == null)
            {
                return new BadRequestObjectResult(new { Message = "User Registration Failed" });
            }

            var identityUser = new IdentityUser() { UserName = userDetails.UserName, Email = userDetails.Email };
            var id = userManager.GetUserIdAsync(identityUser);
            var result = await userManager.CreateAsync(identityUser, userDetails.Password);
            if (!result.Succeeded)
            {
                var dictionary = new ModelStateDictionary();
                foreach (IdentityError error in result.Errors)
                {
                    dictionary.AddModelError(error.Code, error.Description);
                }

                return new BadRequestObjectResult(new { Message = "User Registration Failed", Errors = dictionary });
            }

            Cliente newClient = new Cliente
            {
                IdentityUsuario = identityUser,
                DateCreated = DateTime.Now,
                NombreCompleto = userDetails.NombreCompleto,
                CUIL = userDetails.CUIL,
                FechaNac = userDetails.FechaNac,
                Direccion = userDetails.Direccion,
                Provincia = userDetails.Provincia,
                Pais = userDetails.Pais
            };
            await PostCliente(newClient);
            var _empresa = await _context.Empresas.FindAsync(userDetails.IdEmpresa);

            UserEMPRESA UserEmpresa = new UserEMPRESA
            {
                Empresa = _empresa,
                Cliente = newClient

            };
            _context.userEMPRESA.Add(UserEmpresa);
            await _context.SaveChangesAsync();

            return Ok(new { Message = "Cliente Registration Successful" });
        }

        //REGISTRAR USER EMPRESA
        [HttpPost]
        [Route("Register/Empresa")]
        public async Task<IActionResult> RegisterEmp([FromBody] UserDetails userDetails)
        {
            if (!ModelState.IsValid || userDetails == null)
            {
                return new BadRequestObjectResult(new { Message = "User Registration Failed" });
            }

            var identityUser = new IdentityUser() { UserName = userDetails.UserName, Email = userDetails.Email };
            var id = userManager.GetUserIdAsync(identityUser);
            var result = await userManager.CreateAsync(identityUser, userDetails.Password);
            if (!result.Succeeded)
            {
                var dictionary = new ModelStateDictionary();
                foreach (IdentityError error in result.Errors)
                {
                    dictionary.AddModelError(error.Code, error.Description);
                }

                return new BadRequestObjectResult(new { Message = "User Registration Failed", Errors = dictionary });
            }

            Empresa newEmpresa = new Empresa
            {
                IdentityUsuario = identityUser,
                DateCreated = DateTime.Now,
                RazonSocial = userDetails.NombreCompleto,
                CUIT = userDetails.CUIL,
                FechaInicioActividades = userDetails.FechaNac,
                Direccion = userDetails.Direccion,
                Provincia = userDetails.Provincia,
                Pais = userDetails.Pais,
                Logo = userDetails.Foto
            };
            await PostEmpresa(newEmpresa);

            return Ok(new { Message = "Empresa Registration Successful" });
        }

        //POST: LOGEAR USER
        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> Login([FromBody] LoginCredentials credentials)
        {
            if (!ModelState.IsValid || credentials == null)
            {
                return new BadRequestObjectResult(new { Message = "Login failed" });
            }

            var identityUser = await userManager.FindByNameAsync(credentials.Username);
            if (identityUser == null)
            {
                return new BadRequestObjectResult(new { Message = "Login failed" });
            }

            var result = userManager.PasswordHasher.VerifyHashedPassword(identityUser, identityUser.PasswordHash, credentials.Password);
            if (result == PasswordVerificationResult.Failed)
            {
                return new BadRequestObjectResult(new { Message = "Login failed" });
            }

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Email, identityUser.Email),
                new Claim(ClaimTypes.Name, identityUser.UserName)
            };

            var claimsIdentity = new ClaimsIdentity(
                claims, CookieAuthenticationDefaults.AuthenticationScheme);

            await HttpContext.SignInAsync(
                CookieAuthenticationDefaults.AuthenticationScheme,
                new ClaimsPrincipal(claimsIdentity));

            return Ok(new { Message = "You are logged in" });
        }

        //POST: LOGOUT USER
        [HttpPost]
        [Route("Logout")]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return Ok(new { Message = "You are logged out" });
        }

        //POST DE CLIENTE LLAMADO EN EL POST DE REGISTRAR USUARIO
        public async Task<ActionResult<Cliente>> PostCliente(Cliente cliente)
        {
            _context.Clientes.Add(cliente);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCliente", new { id = cliente.IdentityUsuario.Id }, cliente);
        }

        //POST DE EMPRESA LLAMADO EN EL POST DE REGISTRAR USUARIO
        public async Task<ActionResult<Empresa>> PostEmpresa(Empresa empresa)
        {
            _context.Empresas.Add(empresa);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEmpresa", new { id = empresa.IdentityUsuario.Id }, empresa);
        }
    }
}