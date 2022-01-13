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

        public static AboutUsActions About => GetPage<AboutUsActions>();

        public static DreamhomeActions Dreamhome => GetPage<DreamhomeActions>();

        public static FixedOddsActions FixedOdds => GetPage<FixedOddsActions>();

        public static FooterActions Footer => GetPage<FooterActions>();

        public static FreeEntryActions FreeEntry => GetPage<FreeEntryActions>();

        public static HeaderActions Header => GetPage<HeaderActions>();

        public static HomeActions Home => GetPage<HomeActions>();

        public static ProfileActions Profile => GetPage<ProfileActions>();

        public static SignInActions SignInActions => GetPage<SignInActions>();
        public static SignInAssertions SignInAssertions => GetPage<SignInAssertions>();
        public static SignInActions SignInElements => GetPage<SignInActions>();

        public static SignUpActions SignUp => GetPage<SignUpActions>();

        public static WeeklyActions Weekly => GetPage<WeeklyActions>();

        public static WinnersActions Winners => GetPage<WinnersActions>();
    }
}
