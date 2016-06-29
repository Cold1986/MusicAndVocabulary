using MusicAndVocabulary.Implement;
using MusicAndVocabulary.Interface;
using MusicAndVocabulary.Model;
using MusicAndVocabulary.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace MusicAndVocabulary.Controllers
{
    public class AccountController : AbstractController
    {
        private MusicAndVocabularyEntities db = new MusicAndVocabularyEntities();
        IValidCodeRule _validCodeBiz = new ValidCodeRule();
        IServiceRule _serviceRule = new ServiceRule();
        IUserBiz _userBiz = new UserBiz();

        // GET: Account
        public ActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        public ActionResult Register()
        {
            ViewBag.ImgValidCode = _validCodeBiz.CreateNewValidCode();
            return View();
        }

        //
        // GET: /Account/Login
        [AllowAnonymous]
        public ActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            ViewBag.ImgValidCode = _validCodeBiz.CreateNewValidCode();
            return View();
        }


        //
        // POST: /Account/Register
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = _validCodeBiz.CheckValidCode(model.ValidateCode);
                if (result.Succeeded)
                {
                    //to do 校验用户是否可注册
                    return RedirectToAction("Index", "Home");
                }

                //db.Roles.Select(f => f.Status == Enum.EnumStatus.InUse);
                //var user = new User { UserName = model.UserName, Email = model.Email, Password = model.Password, UserGId = Guid.NewGuid() };
                //var result = await AccountNotifyBiz.Register(user);

                //if (result.Succeeded)
                //{
                //    //    await SignInManager.SignInAsync(user, isPersistent: false, rememberBrowser: false);

                //    //    // For more information on how to enable account confirmation and password reset please visit http://go.microsoft.com/fwlink/?LinkID=320771
                //    //    // Send an email with this link
                //    //    // string code = await UserManager.GenerateEmailConfirmationTokenAsync(user.Id);
                //    //    // var callbackUrl = Url.Action("ConfirmEmail", "Account", new { userId = user.Id, code = code }, protocol: Request.Url.Scheme);
                //    //    // await UserManager.SendEmailAsync(user.Id, "Confirm your account", "Please confirm your account by clicking <a href=\"" + callbackUrl + "\">here</a>");

                //    return RedirectToAction("Index", "Home");
                //}
                ModelState.AddModelError("", result.Messages);

            }
            ViewBag.ImgValidCode = _validCodeBiz.CreateNewValidCode();
            // If we got this far, something failed, redisplay form
            return View(model);
        }


        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Login(LoginViewModel model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                var result = _validCodeBiz.CheckValidCode(model.ValidateCode);
                if (result.Succeeded)
                {
                    _serviceRule.ClearSessionAndCookie();
                    var res = _userBiz.MatchAccount(model.UserName, model.Password);
                    if (res.Succeeded)
                    {
                        string userData = model.UserName + "|" + model.Password + "|" + res.Userinfo.UserId;
                        _serviceRule.SetFormsAuthenticationTicket(1, model.UserName, DateTime.Now, DateTime.Now.AddDays(100)
                        , false, userData);
                        return RedirectToLocal(returnUrl);
                    }
                    ModelState.AddModelError("", res.Messages);
                }
                else
                {
                    ModelState.AddModelError("", result.Messages);
                }

            }
            ViewBag.ImgValidCode = _validCodeBiz.CreateNewValidCode();
            return View(model);
        }


        /// <summary>
        /// 注销
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [AllowAnonymous]
        //[ValidateAntiForgeryToken]
        public ActionResult Logout()
        {
            _serviceRule.ClearSessionAndCookie();
            return RedirectToAction("Login");
        }

        private ActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            return RedirectToAction("Index", "Home");
        }
    }
}