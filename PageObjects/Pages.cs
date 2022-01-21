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
            IWebDriver driver = BaseWeb._Driver;
            PageFactory.InitElements(driver, page);

            return page;
        }

        public static AboutUsActions AboutActions => GetPage<AboutUsActions>();
        public static AboutUsAssertions AboutAssertions => GetPage<AboutUsAssertions>();
        public static AboutUsElements AboutElements => GetPage<AboutUsElements>();

        public static CommonActions CommonActions => GetPage<CommonActions>();
        public static CommonAssertions CommonAssertions => GetPage<CommonAssertions>();
        public static CommonElements CommonElements => GetPage<CommonElements>();

        public static DreamhomeActions DreamhomeActions => GetPage<DreamhomeActions>();
        public static DreamhomeAssertions DreamhomeAssertions => GetPage<DreamhomeAssertions>();
        public static DreamhomeElements DreamhomeElements => GetPage<DreamhomeElements>();

        public static FixedOddsActions FixedOddsActions => GetPage<FixedOddsActions>();
        public static FixedOddsAssertions FixedOddsAssertions => GetPage<FixedOddsAssertions>();
        public static FixedOddsElements FixedOddsElements => GetPage<FixedOddsElements>();

        public static FooterActions FooterActions => GetPage<FooterActions>();
        public static FooterAssertions FooterAssertions => GetPage<FooterAssertions>();
        public static FooterElements FooterElements => GetPage<FooterElements>();

        public static FreeEntryActions FreeEntry => GetPage<FreeEntryActions>();

        public static HeaderActions HeaderActions => GetPage<HeaderActions>();
        public static HeaderAssertions HeaderAssertions => GetPage<HeaderAssertions>();
        public static HeaderElements HeaderElements => GetPage<HeaderElements>();

        public static HomeActions HomeActions => GetPage<HomeActions>();
        public static HomeAssertions HomeAssertions => GetPage<HomeAssertions>();
        public static HomeElements HomeElements => GetPage<HomeElements>();

        public static ProfileActions ProfileActions => GetPage<ProfileActions>();
        public static ProfileAssertions ProfileAssertions => GetPage<ProfileAssertions>();
        public static ProfileElements ProfileElements => GetPage<ProfileElements>();

        public static SignInActions SignInActions => GetPage<SignInActions>();
        public static SignInAssertions SignInAssertions => GetPage<SignInAssertions>();
        public static SignInActions SignInElements => GetPage<SignInActions>();

        public static SignUpActions SignUpActions => GetPage<SignUpActions>();
        public static SignUpAssertions SignUpAssertions => GetPage<SignUpAssertions>();
        public static SignUpActions SignUpElements => GetPage<SignUpActions>();

        public static WeeklyActions WeeklyActions => GetPage<WeeklyActions>();
        public static WeeklyAssertions WeeklyAssertions => GetPage<WeeklyAssertions>();
        public static WeeklyElements WeeklyElements => GetPage<WeeklyElements>();

        public static WinnersActions WinnersActions => GetPage<WinnersActions>();
        public static WinnersAssertions WinnersAssertions => GetPage<WinnersAssertions>();
        public static WinnersElements WinnersElements => GetPage<WinnersElements>();
    }
}
