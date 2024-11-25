using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pages;
using OpenQA.Selenium;

namespace Sample.pages
{
    public class ContactPage: BasePage
    {
 private By btnAddNewContact = By.Id("add-contact");  
 private By txtFirstName = By.Id("firstName");
 private By txtLastName = By.Id("lastName");
  private By txtDate = By.Id("birthdate");
  private By txtEmail = By.Id("email");
  private By txtPhone = By.Id("phone");
  private By txtAddress = By.Id("street1");
  private By txtCity = By.Id("city");
 private By txtState = By.Id("stateProvince");
 private By txtPostalCode = By.Id("postalCode");
 private By txtCountry = By.Id("country");
  private By btnSubmit = By.Id("submit");
public void ClickAddNewContact()
{
    WaitForVisibilityAndClick(btnAddNewContact);
}
public void AddFirstName(String firstName){
    WaitForVisibilityAndWrite(txtFirstName, firstName);
}
public void AddLastName(String lastName){
    WaitForVisibilityAndWrite(txtLastName, lastName);
    }
    public void AddDate(String date){
        WaitForVisibilityAndWrite(txtDate, date);
    }
    public void AddEmail(String email){
        WaitForVisibilityAndWrite(txtEmail, email);
    }
    public void AddPhone(String phone){
        WaitForVisibilityAndWrite(txtPhone, phone);
    }
    public void AddAddress(String address){
        WaitForVisibilityAndWrite(txtAddress, address);
    }
    public void AddCity(String city){
        WaitForVisibilityAndWrite(txtCity, city);
    }
    public void AddState(String state){
        WaitForVisibilityAndWrite(txtState, state);
    }
    public void AddPostalCode(String postalCode){
        WaitForVisibilityAndWrite(txtPostalCode, postalCode);
    }
    public void AddCountry(String country){
        WaitForVisibilityAndWrite(txtCountry, country);
    }
    public void ClickSubmit(){
        WaitForVisibilityAndClick(btnSubmit);
    }
    }
}