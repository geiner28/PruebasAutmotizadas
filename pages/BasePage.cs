// MIT License

/* 
Copyright 2024 Yuliana Velásquez Restrepo

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the “Software”), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
*/


using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace Pages
{

    public class BasePage
    {

        protected static IWebDriver driver;
        public static WebDriverWait wait;
       


        static BasePage()
        {

            ChromeOptions chromeOptions = new ChromeOptions();
            driver = new ChromeDriver(chromeOptions);
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(200));
        }

        public static void NavigateTo(String url)
        {
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Maximize();

        }

        public void CloseBrowser()
        {
            driver.Quit();
        }

        public void MoveScrollDown()
        {
            IJavaScriptExecutor executor = driver as IJavaScriptExecutor;
            executor.ExecuteScript("window.scrollBy(0,10000)");
        }

        public void MoveScrollUp()
        {
            IJavaScriptExecutor executor = driver as IJavaScriptExecutor;
            executor.ExecuteScript("window.scrollBy(0,-1000)");
        }


        public IWebElement WaitForVisibility(By locator)
        {
            var element = wait.Until<IWebElement>(driver =>
            {
                try
                {
                    var elementToBeDisplayed = driver.FindElement(locator);
                    if (elementToBeDisplayed.Displayed)
                    {
                        return elementToBeDisplayed;
                    }
                    return null;
                }
                catch (StaleElementReferenceException)
                {
                    return null;
                }
                catch (NoSuchElementException)
                {
                    return null;
                }
            });
            return element;
        }

        public IWebElement WaitForVisibility(By locator, int index)
        {
            var element = wait.Until<IWebElement>(driver =>
            {
                try
                {
                    Console.WriteLine("Count = " + driver.FindElements(locator).Count);
                    var elementToBeDisplayed = driver.FindElements(locator)[index];
                    if (elementToBeDisplayed.Displayed)
                    {
                        return elementToBeDisplayed;
                    }
                    return null;
                }
                catch (StaleElementReferenceException)
                {
                    return null;
                }
                catch (NoSuchElementException)
                {
                    return null;
                }
            });
            return element;
        }


        public IWebElement WaitForVisibilityAndWrite(By locator, String textToWrite)
        {
            IWebElement element = WaitForVisibility(locator);
            element.Clear();
            element.SendKeys(textToWrite);

            return element;
        }

        public IWebElement WaitForVisibilityAndClick(By locator)
        {
            IWebElement element = WaitForVisibility(locator);
            element.Click();

            return element;
        }

        public IWebElement WaitForVisibilityAndClick(By locator, int index)
        {
            IWebElement element = WaitForVisibility(locator, index);
            element.Click();

            return element;
        }

        public IWebElement WaitForVisibilityAndClickJSE(By locator)
        {
            IJavaScriptExecutor executor = driver as IJavaScriptExecutor;
            IWebElement element = WaitForVisibility(locator);
            executor.ExecuteScript("arguments[0].click();", element);

            return element;
        }
        public void WaitForVisibilityAndSendTab(By locator, String textToWrite)
        {
            WaitForVisibilityAndWrite(locator, textToWrite);
            WaitForVisibility(locator).SendKeys(Keys.Tab);
        }

        public void WaitForVisibilityAndSendEnter(By locator, String textToWrite)
        {
            WaitForVisibilityAndWrite(locator, textToWrite);
            WaitForVisibility(locator).SendKeys(Keys.Enter);
        }

        public void WaitForVisibilitySelectByText(By locator, String valueToSelect)
        {
            IWebElement element = WaitForVisibility(locator);
            SelectElement dropdown = new SelectElement(element);
            dropdown.SelectByText(valueToSelect);
        }

        public void WaitForClickElementSwitchTo(By locator)
        {
            WaitForVisibilityAndClickJSE(locator);
            driver.SwitchTo().Alert().Accept();
        }

        public void MoveTabsBrowser()
        {

            driver.SwitchTo().Window(driver.WindowHandles[1]);
            driver.SwitchTo().Window(driver.WindowHandles[0]);
        }

        public void ForcedWait(int delayInMilliseconds)
        {
            try
            {
                Thread.Sleep(delayInMilliseconds);
            }
            catch (ThreadInterruptedException)
            {
                //throw new RuntimeException(e);
            }
        }
    }

}