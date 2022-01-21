using RaffleHouseAutomation.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaffleHouseAutomation.PageObjects
{
    public class CommonActions : CommonElements
    {
        public CommonActions CloseCookiesPopUp()
        {
            WaitUntil.ElementIsVisibleAndClickable(_confirmCookieBtn);
            confirmCookieBtn.Click();

            return this;
        } 
                
    }
}
