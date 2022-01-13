using NUnit.Framework;
using OpenQA.Selenium;
using RaffleHouseTests.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaffleHouseTests.PageObjects
{
    public partial class SignInAssertions
    {
        public SignInAssertions VerifyIsSignIn()
        {
            WaitUntil.ElementIsVisibleAndClickable(By.XPath("//*[@class='dropdownAccount ']/div[@class='header-drop-name']/span[1]"));
            
            Assert.IsTrue(Pages.Header.UserFirstNameBtn.Displayed);
            Console.WriteLine(Pages.Header.UserFirstNameBtn.Displayed);

            return this;
        }
    }
}
