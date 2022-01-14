using NUnit.Allure.Core;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaffleHouseTests.Helpers
{
    [TestFixture]
    [AllureNUnit]
    public class BaseWeb
    {
        public static IWebDriver _Driver = new ChromeDriver();
        [OneTimeSetUp]

            public static void Initialize()
        {
             
            _Driver.Manage().Window.Maximize();
            _Driver.Manage().Cookies.DeleteAllCookies();
            
        }
        
        
        
        [OneTimeTearDown]
        public static void OneTimeTearDown()
        {
            if (_Driver != null)
            {
                _Driver.Quit();
            }
        }

        [TearDown]
        public static void TearDown()
        {
            if (_Driver != null)
            {
                _Driver.Close();
            }
        }
    }
}
