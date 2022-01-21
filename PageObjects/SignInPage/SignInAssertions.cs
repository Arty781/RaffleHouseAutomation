using NUnit.Framework;
using OpenQA.Selenium;
using RaffleHouseAutomation.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaffleHouseAutomation.PageObjects
{
    public partial class SignInAssertions
    {
        public SignInAssertions VerifyIsSignIn()
        {
            WaitUntil.ElementIsVisibleAndClickable(By.XPath("//*[@class='dropdownAccount ']/div[@class='header-drop-name']/span[1]"));
            
            Assert.IsTrue(Pages.HeaderActions.UserFirstNameBtn.Displayed);
            Console.WriteLine(Pages.HeaderActions.UserFirstNameBtn.Displayed);

            return this;
        }
    }
}
