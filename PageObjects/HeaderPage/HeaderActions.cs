using RaffleHouseTests.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaffleHouseTests.PageObjects
{
    public class HeaderActions : HeaderElements
    {
        #region Opening links in header
        public HeaderActions OpenHomePage()
        {
            WaitUntil.ElementIsVisibleAndClickable(_logo);
            logo.Click();

            return this;
        }

        public HeaderActions OpenDreamhomePage()
        {
            WaitUntil.ElementIsClickable(liveCompetitionsList);
            liveCompetitionsList.Click();
            WaitUntil.ElementIsVisibleAndClickable(_liveCompetitionsList);
            dreamHomeLink.Click();

            return this;
        }

        public HeaderActions OpenWeeklyPrizesPage()
        {
            WaitUntil.ElementIsClickable(liveCompetitionsList);
            liveCompetitionsList.Click();
            WaitUntil.ElementIsVisibleAndClickable(_weeklyLink);
            weeklyLink.Click();

            return this;
        }
        public HeaderActions OpenFixedOddsPrizesPage()
        {
            WaitUntil.ElementIsClickable(liveCompetitionsList);
            liveCompetitionsList.Click();
            WaitUntil.ElementIsVisibleAndClickable(_fixedOddsLink);
            fixedOddsLink.Click();

            return this;
        }

        public HeaderActions OpenWinnersPage()
        {
            WaitUntil.ElementIsClickable(winnersLink);
            winnersLink.Click();

            return this;
        }

        public HeaderActions OpenFAQsPage()
        {
            WaitUntil.ElementIsClickable(faqsLink);
            faqsLink.Click();

            return this;
        }

        public HeaderActions OpenAboutPage()
        {
            WaitUntil.ElementIsClickable(aboutLink);
            aboutLink.Click();

            return this;
        }

        public HeaderActions OpenSignInPage()
        {
            WaitUntil.ElementIsClickable(signInBtn);
            signInBtn.Click();

            return this;
        }

        public HeaderActions OpenSignUpPage()
        {
            WaitUntil.ElementIsClickable(signUpBtn);
            signUpBtn.Click();

            return this;
        }

        public HeaderActions OpenFreeEntryPage()
        {
            WaitUntil.ElementIsClickable(freeEntryBtn);
            freeEntryBtn.Click();

            return this;
        }

        public HeaderActions OpenCartPage()
        {
            WaitUntil.ElementIsClickable(cartBtn);
            cartBtn.Click();

            return this;
        }
        #endregion
    }
}
