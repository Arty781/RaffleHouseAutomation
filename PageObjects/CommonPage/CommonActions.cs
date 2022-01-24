using RaffleHouseAutomation.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaffleHouseAutomation.PageObjects
{
    public partial class Common
    {
        public Common CloseCookiesPopUp()
        {
            WaitUntil.ElementIsVisibleAndClickable(_confirmCookieBtn);
            confirmCookieBtn.Click();

            return this;
        } 
                
    }
}
