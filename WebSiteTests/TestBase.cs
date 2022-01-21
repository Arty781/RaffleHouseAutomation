using NUnit.Allure.Core;
using NUnit.Framework;
using RaffleHouseAutomation.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaffleHouseAutomation.WebSiteTests
{
    public class TestBase : BaseWeb
    {
        [SetUp]
        

        public static void Initialize()
        {
            _Driver.Navigate().GoToUrl(Endpoints.host);
        }
    }
}
