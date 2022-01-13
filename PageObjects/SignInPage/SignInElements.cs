using OpenQA.Selenium;
using RaffleHouseTests.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaffleHouseTests.PageObjects.SignInPage
{
    public class SignInElements
    {
        public IWebElement InputLogin => BaseWeb._Driver.FindElement(By.XPath("//*[@name='email']"));
        public IWebElement InputPassword => BaseWeb._Driver.FindElement(By.XPath("//*[@name='password']"));
        public IWebElement SignInBtn => BaseWeb._Driver.FindElement(By.XPath("//*[@class='rafflebtn primary full-width']"));
    }
}
