﻿using OpenQA.Selenium;
using RaffleHouseAutomation.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaffleHouseAutomation.PageObjects
{
    public class CommonElements
    {
        public IWebElement enterBtn => BaseWeb._Driver.FindElement(_enterBtn);
        public readonly static By _enterBtn = By.XPath("//*/button[@class=\"enter-now__button\"]");
        
        public IWebElement confirmCookieBtn => BaseWeb._Driver.FindElement(_confirmCookieBtn);
        public readonly static By _confirmCookieBtn = By.XPath("//*/button[@class=\"rafflebtn primary\"][contains(text(), 'Got it')]");
        
        public IWebElement addOneTicketBtn => BaseWeb._Driver.FindElement(_selectOneTicketBtn);
        public readonly static By _selectOneTicketBtn = By.XPath("//*/ul[@class=\"ticket-selector__grid\"]/li[5]");

        public IWebElement addTenTicketBtn => BaseWeb._Driver.FindElement(_addTenTicketBtn);
        public readonly static By _addTenTicketBtn = By.XPath("//*/ul[@class=\"ticket-selector__grid\"]/li[6]");

        public IWebElement add25TicketBtn => BaseWeb._Driver.FindElement(_add25TicketBtn);
        public readonly static By _add25TicketBtn = By.XPath("//*/ul[@class=\"ticket-selector__grid\"]/li[7]");

        public IWebElement removeOneTicketBtn => BaseWeb._Driver.FindElement(_removeOneTicketBtn);
        public readonly static By _removeOneTicketBtn = By.XPath("//*/ul[@class=\"ticket-selector__grid\"]/li[3]");

        public IWebElement removeTenTicketBtn => BaseWeb._Driver.FindElement(_removeTenTicketBtn);
        public readonly static By _removeTenTicketBtn = By.XPath("//*/ul[@class=\"ticket-selector__grid\"]/li[2]");

        public IWebElement remove25TicketBtn => BaseWeb._Driver.FindElement(_remove25TicketBtn);
        public readonly static By _remove25TicketBtn = By.XPath("//*/ul[@class=\"ticket-selector__grid\"]/li[1]");
        
        public IWebElement addToBasketBtn => BaseWeb._Driver.FindElement(_addToBasketBtn);
        public readonly static By _addToBasketBtn = By.XPath("//*/button/span[@class=\"add-basket\"]");






    }
}
