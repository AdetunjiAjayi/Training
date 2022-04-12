using BlueSkyInternTraining.Hooks;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlueSkyInternTraining.PageObject
{
    class CookiesBannerPage

       {
        public IWebDriver driver;

        public CookiesBannerPage()
        {
            driver = BaseTest.driver;
        }

        private By Accept = By.CssSelector("#cookie_action_close_header");
        private By Logo = By.XPath("//*[@id='navigation']/div/div[1]/div/div/div[1]/div/div/div/a/img[1]");



        public void ClickAccept()
        {
            driver.FindElement(Accept).Click();
        }

        public bool ThenTheHomePageIsDisplayed()
        {
            return driver.FindElement(Logo).Displayed;
        }
            
        

    }
}
