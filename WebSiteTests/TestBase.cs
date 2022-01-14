using NUnit.Allure.Core;
using NUnit.Framework;
using RaffleHouseTests.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaffleHouseTests.TESTS
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
