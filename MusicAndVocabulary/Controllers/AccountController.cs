using MusicAndVocabulary.Model;
using MusicAndVocabulary.ViewModels;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace MusicAndVocabulary.Controllers
{
    public class AccountController : Controller
    {
        private MusicAndVocabularyEntities db = new MusicAndVocabularyEntities();

        // GET: Account
        public ActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        public ActionResult Register()
        {
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
                db.Roles.Select(f => f.Status == Enum.EnumStatus.InUse);
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
                AddErrors(new string[] { "测试返回异常" });
            }

            // If we got this far, something failed, redisplay form
            return View(model);
        }

        private void AddErrors(string[] result)
        {
            foreach (var error in result)
            {
                ModelState.AddModelError("", error);
            }
        }
    }
}