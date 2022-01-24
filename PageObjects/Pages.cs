using OpenQA.Selenium;
using RaffleHouseAutomation.Helpers;
using RaffleHouseAutomation.PageObjects;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaffleHouseAutomation.PageObjects
{
    public class Pages
    {

        private static T GetPage<T>() where T : new()
        {
            var page = new T();
            IWebDriver driver = Browser._Driver;
            PageFactory.InitElements(driver, page);

            return page;
        }

        public static AboutUs About => GetPage<AboutUs>();
        public static Common Common => GetPage<Common>();
        public static Dreamhome Dreamhome => GetPage<Dreamhome>();
        public static FixedOdds FixedOdds => GetPage<FixedOdds>();
        public static Footer Footer => GetPage<Footer>();
        public static FreeEntry FreeEntry => GetPage<FreeEntry>();
        public static Header Header => GetPage<Header>();
        public static Home Home => GetPage<Home>();
        public static Profile Profile => GetPage<Profile>();
        public static SignIn SignIn => GetPage<SignIn>();
        public static SignUp SignUp => GetPage<SignUp>();
        public static Weekly Weekly => GetPage<Weekly>();
        public static Winners Winners => GetPage<Winners>();
    }
}
