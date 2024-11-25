using System;
using TechTalk.SpecFlow;
using Sample.pages;

namespace MyNamespace
{
	[Binding]
	public class ContactStepDefinitions
	{

		ContactPage contactPage = new ContactPage();



		[Given(@"the user click on add new contact button")]
		public void ClickAddNewContact()
		{
			contactPage.ClickAddNewContact();
		}



		[When(@"the user add the contact information (.*),(.*),(.*),(.*),(.*),(.*),(.*),(.*),(.*),(.*)")]
		public void AddContactInformation(string firstName, string lastName, string date, string email, string phone, string address, string city, string state, string postalCode, string country)
		{
			contactPage.AddFirstName(firstName);
			contactPage.AddLastName(lastName);
			contactPage.AddDate(date);
			contactPage.AddEmail(email);
			contactPage.AddPhone(phone);
			contactPage.AddAddress(address);
			contactPage.AddCity(city);
			contactPage.AddState(state);
			contactPage.AddPostalCode(postalCode);
			contactPage.AddCountry(country);

		}


[Then(@"click on the submit button and consult user in the grid home.")]
		public void SaveContactSuccessfully()
		{
			contactPage.ClickSubmit();
		}



	} 
    }
