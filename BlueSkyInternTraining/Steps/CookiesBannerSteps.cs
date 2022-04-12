using BlueSkyInternTraining.Hooks;
using BlueSkyInternTraining.PageObject;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace BlueSkyInternTraining.Steps
{
    [Binding]
    public class CookiesBannerSteps
    {
        public IWebDriver driver = BaseTest.driver;
        CookiesBannerPage _cookiesBannerPage = new CookiesBannerPage();

        

        [Given(@"I navigate to Prepmajor1 website")]
        public void GivenINavigateToPrepmajor1Website()
        {
            driver.Navigate().GoToUrl(@"https://user-68906616-work.colibriwp.com/prepmajor1com/");
        }
        
        [When(@"I click on Accept all Cookies")]
        public void WhenIClickOnAcceptAllCookies()
        {
            _cookiesBannerPage.ClickAccept();
        }
            
        
        [Then(@"the home page is displayed")]
        public void ThenTheHomePageIsDisplayed()
        {
            Assert.IsTrue(_cookiesBannerPage.ThenTheHomePageIsDisplayed());
        }
    }
}
