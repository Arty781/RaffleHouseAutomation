using NUnit.Framework;
using RaffleHouseAutomation.Helpers;
using RaffleHouseAutomation.PageObjects;

namespace RaffleHouseAutomation.WebSiteTests
{
    public class AuthTests : TestBase
    {

       [Test]
        public void LoginByEmail()
        {
            Pages.HeaderActions
                .OpenSignInPage();
            Pages.SignInActions
                .EnterLoginAndPass(Credentials.login, Credentials.password);
            Pages.SignInAssertions
                .VerifyIsSignIn();
           
        }

        [Test]
        public void LoginByGoogle()
        {
            Pages.HeaderActions
                .OpenSignInPage();
            Pages.SignInActions
                .GoogleAuth(Credentials.login, Credentials.password);
            Pages.SignInAssertions
                .VerifyIsSignIn();

        }
    }
}