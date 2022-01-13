using OpenQA.Selenium;
using RaffleHouseTests.Helpers;
using RaffleHouseTests.PageObjects;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaffleHouseTests.PageObjects
{
    public class Pages
    {

        private static T GetPage<T>() where T : new()
        {
            var page = new T();
            IWebDriver driver = BaseWeb._Driver;
            PageFactory.InitElements(driver, page);

            return page;
        }

        public static SignInActions SignIn
        {
            get { return GetPage<SignInActions>(); }
        }

        public static ProfileActions Profile
        {
            get { return GetPage<ProfileActions>(); }
        }

        public static HeaderActions Header
        {
            get { return GetPage<HeaderActions>(); }
        }

        public static HomeActions Home
        {
            get { return GetPage<HomeActions>(); }
        }
    }
}
