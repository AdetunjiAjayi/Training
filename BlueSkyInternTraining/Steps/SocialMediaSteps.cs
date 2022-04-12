using BlueSkyInternTraining.Hooks;
using BlueSkyInternTraining.PageObject;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace BlueSkyInternTraining.Steps
{
    [Binding]
    public class SocialMediaSteps
    {
        public IWebDriver driver = BaseTest.driver;
        SocialMediaPage _socialMediaPage = new SocialMediaPage();
        

        [Given("I navigate to PrepMajor Website")]
        public void GivenThatINavigateToPrepMajorwebsite()
        {
           driver.Navigate().GoToUrl(@"https://user-68906616-work.colibriwp.com/prepmajor1com/");
        }
        
        [When(@"i click on accept all cookies on cookies consent banner")]
        public void WhenIClickOnAcceptAllCookies()
        {
            _socialMediaPage.
        }
        
        [When(@"i click on facebook icon")]
        public void WhenIClickOnFacebookIcon()
        {
            _socialMediaPage,ClickAccept();
        }

        private void ClickAccept()
        {
            throw new NotImplementedException();
        }

        [When(@"I click on Instagram icon")]
        public void WhenIClickOnInstagramIcon()
        {
            _socialMediaPage,ClickAccept();
        }
        
        [When(@"i click on twitter icon")]
        public void WhenIClickOnTwitterIcon()
        {
            _socialMediaPage.ClickAccept();
        }
        
        [When(@"i click on Linkedin icon")]
        public void WhenIClickOnLinkedinIcon()
        {
            _socialMediaPage.ClickAccept();
        }
        
        [Then(@"all social media icons are displayed on the page")]
        public void ThenAllSocialMediaIconsAreDisplayedOnThePage()
        {
            Assert.IsTrue(_socialMediaPage.ThenAllSocialMediaIconsAreDisplayedOnThePage);
        }
    }
}
