using NUnit.Allure.Steps;
using RaffleHouseAutomation.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaffleHouseAutomation.PageObjects
{
    public partial class Basket
    {
        [AllureStep("Click Add More button")]
        public Basket ClickAddMoreBtn()
        {
            WaitUntil.ElementIsVisibleAndClickable(_addMoreTicketsBtn);
            addMoreTicketsBtn.Click();

            return this;
        }

        [AllureStep("Apply coupon Code")]
        public Basket ApplyCouponCode(string coupon)
        {
            WaitUntil.ElementIsVisible(_couponInput);
            couponInput.SendKeys(coupon);
            applyCouponBtn.Click();

            return this;
        }

        [AllureStep("Click Checkout Now button")]
        public Basket ClickCheckoutNowBtn()
        {
            WaitUntil.ElementIsVisible(_checkOutNowBtn);
            checkOutNowBtn.Click();

            return this;
        }

        [AllureStep("Open Order summary")]
        public Basket OpenOrderSummary()
        {
            WaitUntil.ElementIsVisible(_orderSummaryBtn);
            orderSummaryBtn.Click();

            return this;
        }

        [AllureStep("Enter card details")]
        public Basket EnterCardDetails()
        {
            WaitUntil.ElementIsVisibleAndClickable(_cardNumberInput, 20);
            cardNumberInput.SendKeys("4242424242424242");
            WaitUntil.ElementIsVisibleAndClickable(_cardExpDate);
            cardExpDate.SendKeys("11/28");
            WaitUntil.ElementIsVisibleAndClickable(_cardCvvInpt);
            cardCvvInpt.SendKeys("100");

            return this;
        }

        [AllureStep("Click Pay Now button")]
        public Basket ClickPayNowBtn()
        {
            WaitUntil.ElementIsVisibleAndClickable(_payBtn, 20);
            payBtn.Click();
            WaitUntil.WaitSomeInterval(5);

            return this;
        }
    }
}
