using RaffleHouseTests.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaffleHouseTests.PageObjects
{
    public class ProfileActions : ProfileElements
    {
        public ProfileActions EditProfileData()
        {
            BaseWeb._Driver.Navigate().GoToUrl("https://staging.rafflehouse.com/profile");
            return Pages.Profile;
        }
    }
}
