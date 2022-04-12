using BlueSkyInternTraining.Hooks;
using OpenQA.Selenium;

namespace BlueSkyInternTraining.PageObject
{
    class RegistrationPage
    {
       public IWebDriver  driver;

        public RegistrationPage()
        {
            driver = BaseTest.driver;
        }

        private By Register = By.XPath("//*[@id='header']/div[2]/div[1]/div/div[1]/div[2]/div[4]/div[2]/a/span");
        private By Firstname = By.CssSelector("#firstname");
        private By Lastname = By.CssSelector("#lastname");
        private By Email = By.CssSelector("#emailaddressreg");
        private By Number = By.CssSelector("#telephone");
        private By Password = By.CssSelector("#passwordreg");
        private By Confirmpassword = By.CssSelector("#cnpassword");
        private By Address = By.CssSelector("#address");
        private By Town = By.CssSelector("#city");
        private By State = By.CssSelector("#state");
        private By RegisterButton = By.CssSelector("#btn_register");
        private By SuccessMessage = By.CssSelector("#modal_panel > button");
        private By ErrorMessage = By.CssSelector("#modal_panel > button");

        public void ClickRegister()
        {
            driver.FindElement(Register).Click();
        }

        public void EnterFirstName(string name)
        {
            driver.FindElement(Firstname).SendKeys(name);
        }

        public void EnterLastName(string name)
        {
            driver.FindElement(Lastname).SendKeys(name);
        }

        public void EnterEmailAddress(string email)
        {
            driver.FindElement(Email).SendKeys(email);
        }

        public void EnterPhoneNumber(string number)
        {
            driver.FindElement(Number).SendKeys(number);
        }

        public void EnterPassWord(string pwd)
        {
            driver.FindElement(Password).SendKeys(pwd);
        }

        public void EnterConfirmPassWord(string confirmPwd)
        {
            driver.FindElement(Confirmpassword).SendKeys(confirmPwd);
        }

        public void EnterAddress(string address)
        {
            driver.FindElement(Address).SendKeys(address);
        }

        public void EnterTown(string town)
        {
            driver.FindElement(Town).SendKeys(town);
        }

        public void EnterState(string state)
        {
            driver.FindElement(State).SendKeys(state);
        }

        public void ClickRegisterButton()
        {
            driver.FindElement(RegisterButton).Click();
        }


        public bool ThenSuccessfulMessageDisplayed()
        {
            return driver.FindElement(SuccessMessage).Displayed;
        }


        public bool ThenErrorMessageDisplayed()
        {
            return driver.FindElement(ErrorMessage).Displayed;
        }



    }
}
