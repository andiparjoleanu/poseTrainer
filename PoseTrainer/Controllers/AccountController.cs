using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PoseTrainer.ViewModels;
using PoseTrainerLibrary.Models;

namespace PoseTrainer.Controllers
{
    [Route("api/account")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;

        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
       
        [HttpGet("getUser")]
        public async Task<UserVM> GetUser()
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);
            return new UserVM
            {
                UserName = user.UserName
            };
        }

        [HttpPost("login")]
        public async Task<ResultVM> Login(object userModel)
        {
            var model = JsonConvert.DeserializeObject<LoginVM>(userModel.ToString());

            var user = await _userManager.FindByNameAsync(model.Username);

            if (user != null && await _userManager.CheckPasswordAsync(user, model.Password))
            {
                await _signInManager.SignInAsync(user, false);

                return new ResultVM
                {
                    Status = Status.Success,
                    Message = "Autentificare reușită"
                };

            }

            return new ResultVM
            {
                Status = Status.Error,
                Message = "Autentificare nereușită"
            };
        }

        [HttpPost("register")]
        public async Task<ResultVM> Register(object userModel)
        {
            var model = JsonConvert.DeserializeObject<RegisterVM>(userModel.ToString());

            IdentityResult result = null;
            var user = await _userManager.FindByNameAsync(model.UserName);

            if (user != null)
            {
                return new ResultVM
                {
                    Status = Status.Error,
                    Message = "Utilizatorul există deja în sistem",
                };
            }

            user = new User
            {
                Id = Guid.NewGuid().ToString(),
                UserName = model.UserName
            };

            result = await _userManager.CreateAsync(user, model.Password);

            if (result.Succeeded)
            {
                await _signInManager.SignInAsync(user, false);
                    
                return new ResultVM
                {
                    Status = Status.Success,
                    Message = "Utilizator creat"
                };
            }
            else
            {
                var resultErrors = result.Errors.Select(e => e.Description);
                return new ResultVM
                {
                    Status = Status.Error,
                    Message = string.Join(";", resultErrors)
                };
            }
            
        }

        [HttpGet("logout")]
        public async Task<ResultVM> Logout()
        {
            await _signInManager.SignOutAsync();
            return new ResultVM
            {
                Status = Status.Success,
                Message = "Deconectare reușită"
            };
        }
    }
}