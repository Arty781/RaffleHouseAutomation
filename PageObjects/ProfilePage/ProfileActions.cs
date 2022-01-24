﻿using RaffleHouseAutomation.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaffleHouseAutomation.PageObjects
{
    public partial class Profile
    {
        public Profile EditProfileData()
        {
            Browser._Driver.Navigate().GoToUrl("https://staging.rafflehouse.com/profile");
            return this;
        }
    }
}
