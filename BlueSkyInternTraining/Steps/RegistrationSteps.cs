using BlueSkyInternTraining.Hooks;
using BlueSkyInternTraining.PageObject;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace BlueSkyInternTraining.Features
{
    [Binding]
    public class RegistrationSteps
    {
        public IWebDriver driver = BaseTest.driver;
        RegistrationPage _registrationPage = new RegistrationPage();



        [Given(@"I Navigate to longrichway\.com")]
        public void GivenINavigateToLongrichway_Com()
        {
            driver.Navigate().GoToUrl(@"https://longrichway.com/");
        }


        [When(@"I click on Register button")]
        public void WhenIClickOnRegisterButton()
        {
            _registrationPage.ClickRegister();
        }

        [When(@"I enter First Name ""(.*)""")]
        public void WhenIEnterFirstName(string name)
        {
            _registrationPage.EnterFirstName(name);
        }

        [When(@"I enter Last Name ""(.*)""")]
        public void WhenIEnterLastName(string name)
        {
            _registrationPage.EnterLastName(name);
        }

        [When(@"I enter Email Address ""(.*)""")]
        public void WhenIEnterEmailAddress(string email)
        {
            _registrationPage.EnterEmailAddress(email);
        }

        [When(@"I enter Phone number ""(.*)""")]
        public void WhenIEnterPhoneNumber(Decimal number)
        {
            _registrationPage.EnterPhoneNumber("0795646660066");
        }

        [When(@"I enter Password ""(.*)""")]
        public void WhenIEnterPassword(string pwd)
        {
            _registrationPage.EnterPassWord(pwd);
        }

        [When(@"I enter Confirm Password ""(.*)""")]
        public void WhenIEnterConfirmPassword(string confirmPwd)
        {
            _registrationPage.EnterConfirmPassWord(confirmPwd);
        }

        [When(@"I enter Address ""(.*)""")]
        public void WhenIEnterAddress(string address)
        {
            _registrationPage.EnterAddress(address);
        }

        [When(@"I enter Town ""(.*)""")]
        public void WhenIEnterTown(string town)
        {
            _registrationPage.EnterTown(town);
        }

        [When(@"I enter State ""(.*)""")]
        public void WhenIEnterState(string state)
        {
            _registrationPage.EnterState(state);
        }

        [When(@"I click on create Account Button")]
        public void WhenIClickOnCreateAccountButton()
        {
            _registrationPage.ClickRegisterButton();
        }

        [Then(@"the message ""(.*)"" is displayed on the page")]
        public void ThenTheMessageIsDisplayedOnThePage(string message)
        {
            Assert.IsTrue(_registrationPage.ThenSuccessfulMessageDisplayed());

        }

        [Then(@"the Error message ""(.*)"" is displayed on the page")]
        public void ThenTheErrorMessageIsDisplayedOnThePage(string p0)
        {
            Assert.IsTrue(_registrationPage.ThenErrorMessageDisplayed());
        }


    }
}
