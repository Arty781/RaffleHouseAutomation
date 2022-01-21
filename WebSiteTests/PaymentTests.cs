using NUnit.Framework;
using RaffleHouseAutomation.Helpers;
using RaffleHouseAutomation.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaffleHouseAutomation.WebSiteTests
{
    public class PaymentTests : TestBase
    {
        [Test]
        public void PurchaseWeeklyPrizes()
        {
            Pages.HeaderActions
                .OpenWeeklyPrizesPage();
            Pages.CommonActions
                .CloseCookiesPopUp();
            Pages.WeeklyActions
                .CloseWeeklyPopUp()
                .SelectCategory(Categories.category)
                .SelectSubCategory(SubCategories.subCategory)
                .SelectPrize("iPhone 12 Pro Max")
                .AddPrizeToBasket();

        }
    }
}
