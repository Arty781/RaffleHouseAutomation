using RaffleHouseTests.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RaffleHouseTests.PageObjects.SignInPage;

namespace RaffleHouseTests.PageObjects
{
    public class SignInActions : SignInElements
    {
        
        public SignInActions EnterLoginAndPass(string login, string password)
        {
            BaseWeb._Driver.Navigate().GoToUrl(Endpoints.signin);
            WaitUntil.ElementIsClickable(InputLogin, 3);

            InputLogin.SendKeys(login);
            InputPassword.SendKeys(password);
            SignInBtn.Click();

            return Pages.SignIn;
        }
    }
}
