using System;
using Pages;
using TechTalk.SpecFlow;


namespace AutoForm.Hooks
{
    [Binding]
    public class Hooks : BasePage
    {
         [BeforeTestRun]
        public static void OpenBrowserTest()
        {
            Console.WriteLine("Open BrowserTest");
        }

        [AfterTestRun]
        public static void CloseBrowserTest()
        {
           // driver.Quit();
        }
    }
}