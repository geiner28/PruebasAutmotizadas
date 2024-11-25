    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using OpenQA.Selenium;
    using Pages;

    namespace Sample.pages
    {
        public class LoginPage:BasePage
        {
            private By txtUserName=By.Id("email");
            private By txtPassword = By.Id("password");
            private By btnSubmit = By.Id("submit");
            private String url = "https://thinking-tester-contact-list.herokuapp.com";   


            public void NavigateToWeb()
            {
                NavigateTo(url);
            }

            public void AddUserName(String user)
            {
                WaitForVisibilityAndWrite(txtUserName, user);
            }

            public void AddPassword(String password)
            {
                WaitForVisibilityAndWrite(txtPassword, password);
            }

            public void ClickSubmit()
            {
                WaitForVisibilityAndClick(btnSubmit);
            }


        }
    }