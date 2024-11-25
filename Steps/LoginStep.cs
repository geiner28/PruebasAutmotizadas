using System;
using Sample.pages;
using TechTalk.SpecFlow;
	
	namespace MyNamespace
	{
		[Binding]
		public class StepDefinitions
		{
			
		LoginPage login = new LoginPage();
	
			
			
[Given(@"the user access to url Contact List Web")]
public void NavigateToWeb()
{
	login.NavigateToWeb();

}

[When(@"add the  (.*) and  (.*) in the login form")]
public void AddUserNameAndPassword(String user, String password)
{
	login.AddUserName(user);
	login.AddPassword(password);
}


[Then(@"the user access to the home web success.")]
public void ClickSubmit()
{
	login.ClickSubmit();
}

	


		}
	}