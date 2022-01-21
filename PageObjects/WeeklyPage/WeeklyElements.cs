using OpenQA.Selenium;
using RaffleHouseAutomation.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaffleHouseAutomation.PageObjects
{
    public class WeeklyElements
    {
        public IWebElement counterPop => BaseWeb._Driver.FindElement(_counterPop);
        public readonly static By _counterPop = By.XPath("//*/div[contains(text(), \"Next Winner Draw In: \")]");

        public IWebElement mainPageBannerInf => BaseWeb._Driver.FindElement(_mainPageBannerInf);
        public readonly static By _mainPageBannerInf = By.XPath("//*/div[@class='lifestyle-prizes-banner__info']");


        public IWebElement categorySlider => BaseWeb._Driver.FindElement(_categorySlider);
        public readonly static By _categorySlider = By.XPath("//*/ul/li[contains(@class,\"react-multi-carousel-item\")][contains(@class,\"active\")]/div/div");

        public IWebElement subCategoryFilter => BaseWeb._Driver.FindElement(_subCategoryFilter);
        public readonly static By _subCategoryFilter = By.XPath("//*[contains(text(), 'View subcategories')]");
        
        public IWebElement selectSubCategory => BaseWeb._Driver.FindElement(_selectSubCategory);
        public readonly static By _selectSubCategory = By.XPath("//*/ul[@class=\"filter-select__list\"]/li");

        public IWebElement weeklyProductCardImg => BaseWeb._Driver.FindElement(_weeklyProductCardImg);
        public readonly static By _weeklyProductCardImg = By.XPath("//*/article");

        public IWebElement weeklyProductCardTitle => BaseWeb._Driver.FindElement(_weeklyProductCardTitle);
        public readonly static By _weeklyProductCardTitle = By.XPath("//*/article/div[2]/h3");


        public IWebElement closeWeeklyPopUp => BaseWeb._Driver.FindElement(_closeWeeklyPopUp);
        public readonly static By _closeWeeklyPopUp = By.XPath("//*/button[contains(text(), 'OK')]");

    }
}
