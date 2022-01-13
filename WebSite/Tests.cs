using NUnit.Framework;
using RaffleHouseTests.Helpers;
using RaffleHouseTests.PageObjects;
using RaffleHouseTests.TESTS;

namespace RaffleHouseTests.Tests
{
    public class Tests : TestBase
    {

       [Test]
        public void Test1()
        {
            Pages.SignIn
                .EnterLoginAndPass(Credentials.login, Credentials.password);
        }
    }
}