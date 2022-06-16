using Microsoft.AspNetCore.Mvc;
using MiniCommerce.UI.Extentions;
using MiniCommerce.UI.Filter;
using MiniCommerce.UI.Models;
using MiniCommerce.UI.Services;
using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MiniCommerce.UI.Controllers
{
    public class UserController : Controller
    {
        private readonly IAuthService _authService;

        public UserController(IAuthService authService)
        {
            _authService = authService;
        }


        #region SignIn

        [HttpGet]
        public IActionResult SignIn()
        {
            if (HttpContext.HasCookie("Authorization"))
            {
                //Kullanıcı daha önce giriş yapmış ise yapılacak işlemler
                return RedirectToAction("Category", "Product");
            }

            return View();


        }


        [HttpPost]
        public async Task<IActionResult> SignIn(SignInModel signInModal)
        {

            if (ModelState.IsValid == false)
            {
                return View(signInModal).ShowMessage(Status.BadRequest, "Uyarı", "Eksik veya hatalı bilgiler mevcut!");
            }

            var result = await _authService.SignIn(signInModal);
            if (result is not null)
            {

                try
                {
                    var myCookie = JsonConvert.DeserializeObject<ServiceResponse<LoginModel>>(result);
                    HttpContext.SetCookie("Authorization", result, TimeSpan.FromDays(1));
                    TempData["UserName"] = myCookie.Data.FirstName + " " + myCookie.Data.LastName;
                    return RedirectToAction("Category", "Product");

                }
                catch (JsonException)
                {
                    TempData["ErrorMessages"] = String.Join(", ", result);
                    return View(signInModal).ShowMessage(Status.Error, "Hata", "Kullanıcı adı veya şifre hatalı");

                }
            }

            return View(signInModal).ShowMessage(Status.Error, "Hata", "Kullanıcı adı veya şifre hatalı");


            }

        #endregion

        #region SignUp

        [HttpGet]
        public IActionResult SignUp()
        {
            return View();

        }

        [HttpPost]
        public async Task<IActionResult> SignUp(SignUpModel signUpModel)
        {

            if (ModelState.IsValid == false)
            {
                return View(signUpModel).ShowMessage(Status.BadRequest, "Uyarı", "Eksik veya hatalı bilgiler mevcut!");
            }

            var result = await _authService.SignUp(signUpModel);
            //if (result is not null)
            //{
            //    HttpContext.SetCookie("Authorization", result, TimeSpan.FromDays(1));
            //    var myCookie = JsonConvert.DeserializeObject<ServiceResponse<LoginModel>>(result);
            //    TempData["UserName"] = myCookie.Data.FirstName + " " + myCookie.Data.LastName;

            //    //return RedirectToAction("Index", "Home");
            //}


            TempData["AlertMessage"] = "Kayıt Yapıldı";
            return RedirectToAction("SignIn");

        }

        #endregion

        #region LogOut

        public IActionResult LogOut()
        {

            HttpContext.DeleteCookie("Authorization");
            return RedirectToAction("SignIn");
        }


        #endregion

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }

}


