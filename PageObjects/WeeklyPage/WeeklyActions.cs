using NUnit.Allure.Steps;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using RaffleHouseAutomation.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaffleHouseAutomation.PageObjects
{
    public class WeeklyActions : WeeklyElements
    {
        [AllureStep("Close Weekly PopUp")]
        public WeeklyActions CloseWeeklyPopUp()
        {
            WaitUntil.ElementIsVisible(_closeWeeklyPopUp, 10);
            closeWeeklyPopUp.Click();

            return this;
        }

        [AllureStep("Select Category {0}")]
        public WeeklyActions SelectCategory(string category)
        {
           WaitUntil.WaitSomeInterval(3);
            IReadOnlyCollection<IWebElement> catList = BaseWeb._Driver.FindElements(_categorySlider);
            foreach(var cat in catList)
            {
                if (cat.Displayed == true && cat.Text == category)
                {
                    cat.Click();
                    Console.WriteLine(cat.Text);
                }
            }
            categorySlider.Click();

            return this;
        }

        [AllureStep("Select SubCategory {0}")]
        public WeeklyActions SelectSubCategory(string subcategory)
        {
            subCategoryFilter.Click();

            WaitUntil.WaitSomeInterval(3);
            IReadOnlyCollection<IWebElement> subCatList = BaseWeb._Driver.FindElements(_selectSubCategory);
            foreach(var subCat in subCatList)
            {
                
                if(subCat.Displayed == true && subCat.Text == subcategory)
                {
                    subCat.Click();
                    Console.WriteLine(subCat.Text);
                }
            }
            
            return this;
        }

        [AllureStep("Select prize {0}")]
        public WeeklyActions SelectPrize(string title)
        {
            WaitUntil.WaitSomeInterval(3);
            IReadOnlyCollection<IWebElement> prizeList = BaseWeb._Driver.FindElements(_weeklyProductCardImg);
            foreach (var prize in prizeList)
            {
               
                
                if (prize.Displayed == true && prize.FindElement(_weeklyProductCardTitle).Text == title)
                    {
                        new Actions(BaseWeb._Driver)
                    .MoveToElement(prize)
                    .Build()
                    .Perform();
                        prize.Click();
                        break;
                    }
                
            }

            return this;
        }

        [AllureStep("Add prize to Basket")]
        public WeeklyActions AddPrizeToBasket()
        {
            WaitUntil.WaitSomeInterval(3);
            Pages.CommonElements
                .enterBtn.Click();
            WaitUntil.WaitSomeInterval(3);
            Pages.CommonElements
                .addTenTicketBtn.Click();
            WaitUntil.WaitSomeInterval(3);
            
            Pages.CommonElements
                .addToBasketBtn.Click();
            WaitUntil.WaitSomeInterval(3);

            return this;
        }
    }
}
