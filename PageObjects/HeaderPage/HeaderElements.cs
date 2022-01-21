using OpenQA.Selenium;
using RaffleHouseAutomation.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaffleHouseAutomation.PageObjects
{
    public class HeaderElements
    {
        public IWebElement logo => BaseWeb._Driver.FindElement(_logo);
        public readonly static By _logo = By.XPath("//*[@class='headerLogo']");

        public IWebElement liveCompetitionsList => BaseWeb._Driver.FindElement(_liveCompetitionsList);
        public readonly static By _liveCompetitionsList = By.XPath("//*[@class='toggle-live-btn toggle-live-btn-desk false']");

        public IWebElement dreamHomeLink => BaseWeb._Driver.FindElement(_dreamHomeLink);
        public readonly static By _dreamHomeLink = By.XPath("//a/span[contains(text(), 'Dream Home')]");

        public IWebElement weeklyLink => BaseWeb._Driver.FindElement(_weeklyLink);
        public readonly static By _weeklyLink = By.XPath("//a/span[contains(text(), 'Weekly Prizes')]");

        public IWebElement fixedOddsLink => BaseWeb._Driver.FindElement(_fixedOddsLink);
        public readonly static By _fixedOddsLink = By.XPath("//a/span[contains(text(), 'Fixed Odds')]");

        public IWebElement winnersLink => BaseWeb._Driver.FindElement(_winnersLink);
        public readonly static By _winnersLink = By.XPath("//*[@class='headerNav']/a[1]");

        public IWebElement faqsLink => BaseWeb._Driver.FindElement(_faqsLink);
        public readonly static By _faqsLink = By.XPath("//*[@class='headerNav']/a[2]");

        public IWebElement aboutLink => BaseWeb._Driver.FindElement(_aboutLink);
        public readonly static By _aboutLink = By.XPath("//*[@class='headerNav']/a[3]");

        public IWebElement signInBtn => BaseWeb._Driver.FindElement(_signInBtn);
        public readonly static By _signInBtn = By.XPath("//*[@class='headerAuth']/div/button[1]");

        public IWebElement signUpBtn => BaseWeb._Driver.FindElement(_signUpBtn);
        public readonly static By _signUpBtn = By.XPath("//*[@class='headerAuth']/div/a");

        public IWebElement freeEntryBtn => BaseWeb._Driver.FindElement(_freeEntryBtn);
        public readonly static By _freeEntryBtn = By.XPath("//*[@class='headerAuth']/div/button[1]");

        public IWebElement cartBtn => BaseWeb._Driver.FindElement(_cartBtn);
        public readonly static By _cartBtn = By.XPath("//*[@class='headerBtnCart']");

        public IWebElement UserFirstNameBtn => BaseWeb._Driver.FindElement(_UserFirstNameBtn);
        public readonly static By _UserFirstNameBtn = By.XPath("//*[@class='dropdownAccount ']/div[@class='header-drop-name']/span[1]");

        public IWebElement UserLastNameBtn => BaseWeb._Driver.FindElement(_UserLastNameBtn);
        public readonly static By _UserLastNameBtn = By.XPath("//*[@class='dropdownAccount ']/div[@class='header-drop-name']/span[2]");

    }
}
