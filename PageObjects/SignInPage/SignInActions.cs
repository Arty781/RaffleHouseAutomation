using RaffleHouseTests.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RaffleHouseTests.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace RaffleHouseTests.PageObjects
{
    public partial class SignInActions : SignInElements
    {
        
        public SignInActions EnterLoginAndPass(string login, string password)
        {
            
            WaitUntil.ElementIsClickable(InputLogin, 3);

            InputLogin.SendKeys(login);
            InputPassword.SendKeys(password);
            SignInBtn.Click();

            return this;
        }

        public SignInActions GoogleAuth(string login, string password)
        {

            WaitUntil.ElementIsClickable(SignInGoogleBtn, 3);

            SignInGoogleBtn.Click();
            SwitchWindow();
            WaitUntil.ElementIsClickable(GoogleEmailInput, 3);
            GoogleEmailInput.SendKeys(login);
            new Actions(BaseWeb._Driver)
                .SendKeys(Keys.Enter)
                .Build()
                .Perform();
            /*GoogleNextBtn.SendKeys(Keys.Enter);*/
            WaitUntil.ElementIsVisibleAndClickable(_GooglePasswordInput, 10);
            GooglePasswordInput.SendKeys(password);
            new Actions(BaseWeb._Driver)
                .SendKeys(Keys.Enter)
                .Build()
                .Perform();
            /*GoogleNextBtn.SendKeys(Keys.Enter);*/


            return this;
        }



        public SignInActions SwitchWindow()
        {
            WaitUntil.WaitSomeInterval(5);
            BaseWeb._Driver.SwitchTo().Window(BaseWeb._Driver.WindowHandles.ToList().Last());
            return this;
        }
    }
}
