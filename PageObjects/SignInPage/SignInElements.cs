using OpenQA.Selenium;
using RaffleHouseAutomation.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaffleHouseAutomation.PageObjects
{
    public partial class SignInElements
    {
        public IWebElement InputLogin => BaseWeb._Driver.FindElement(_InputLogin);
        public readonly static By _InputLogin = By.XPath("//*[@name='email']");

        public IWebElement InputPassword => BaseWeb._Driver.FindElement(_InputPassword);
        public readonly static By _InputPassword = By.XPath("//*[@name='password']");

        public IWebElement SignInBtn => BaseWeb._Driver.FindElement(_SignInBtn);
        public readonly static By _SignInBtn = By.XPath("//*[@class='rafflebtn primary full-width']");

        public IWebElement SignInGoogleBtn => BaseWeb._Driver.FindElement(_SignInGoogleBtn);
        public readonly static By _SignInGoogleBtn = By.XPath("//*[@class='social-btn social-g-btn']");

        public IWebElement SignInFacebookBtn => BaseWeb._Driver.FindElement(_SignInFacebookBtn);
        public readonly static By _SignInFacebookBtn = By.XPath("//*[@class='social-btn social-g-btn']");

        public IWebElement PolicyCheckbox => BaseWeb._Driver.FindElement(_PolicyCheckbox);
        public readonly static By _PolicyCheckbox = By.XPath("//*[@type='checkbox']");

        public IWebElement ForgotPassword => BaseWeb._Driver.FindElement(_ForgotPassword);
        public readonly static By _ForgotPassword = By.XPath("//*/span[contains(text(), 'Forgot password?')]");

        public IWebElement GoogleEmailInput => BaseWeb._Driver.FindElement(_GoogleEmailInput);
        public readonly static By _GoogleEmailInput = By.XPath("//*[@id='identifierId']");

        public IWebElement GooglePasswordInput => BaseWeb._Driver.FindElement(_GooglePasswordInput);
        public readonly static By _GooglePasswordInput = By.XPath("//*[@name='password']");

        public IWebElement GoogleNextBtn => BaseWeb._Driver.FindElement(_GoogleNextBtn);
        public readonly static By _GoogleNextBtn = By.XPath("//*/div/div[2]/div/div[1]/div/div/button/div[3]");

        


    }
}
