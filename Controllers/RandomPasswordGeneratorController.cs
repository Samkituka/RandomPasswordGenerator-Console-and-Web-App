using Microsoft.AspNetCore.Mvc;
using RandomPasswordGeneratorApp.Models;


namespace RandomPasswordGeneratorApp.Controllers
{
    public class RandomPasswordGeneratorController : Controller
    {
        private RandomPasswordModels Pmodels = new RandomPasswordModels();

        public IActionResult Index()
        {
            return View(Pmodels);
        }
        public IActionResult GetPassword(bool upperCase, bool specialCharacter, int length)
        {
            const string Signs = "@#()$%^-*%=&!_+<>.?|[]{}";
            const string PasswordGenerate = "abcdefghijklmnopqrstuvwxyz01234567899876543210";
            const string CapitalLetters = "ABCDEFGHIJKLMOPQRSTUVWXYZ";

            string RDPassword= "";
            string Pword = "";
            Random random = new Random();

            if (specialCharacter && upperCase) RDPassword = PasswordGenerate + CapitalLetters + Signs;

            else if (upperCase) RDPassword = PasswordGenerate + CapitalLetters;

           else if (specialCharacter) RDPassword = PasswordGenerate + Signs;

            else RDPassword = PasswordGenerate;

            for (int i = 0; i < length; i++)
            {
                char chars = RDPassword[random.Next(0, RDPassword.Length)];
                Pword += chars;
            }
            Pmodels.Password = Pword;
            return View("Index", Pmodels);
        }
    }
}
