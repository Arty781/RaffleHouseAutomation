using NUnit.Framework;
using RaffleHouseTests.Helpers;
using RaffleHouseTests.PageObjects;
using RaffleHouseTests.TESTS;

namespace RaffleHouseTests.Tests
{
    public class Tests : TestBase
    {

       [Test]
        public void LoginByEmail()
        {
            Pages.Header
                .OpenSignInPage();
            Pages.SignInActions
                .EnterLoginAndPass(Credentials.login, Credentials.password);
            Pages.SignInAssertions
                .VerifyIsSignIn();
           
        }

        [Test]
        public void LoginByGoogle()
        {
            Pages.Header
                .OpenSignInPage();
            Pages.SignInActions
                .GoogleAuth(Credentials.login, Credentials.password);
            Pages.SignInAssertions
                .VerifyIsSignIn();

        }
    }
}