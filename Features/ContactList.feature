Feature: Testing to Contact List Web

  @loginContac
  Scenario Outline: Access to Login Web
    Given the user access to url Contact List Web
    When add the  <user> and  <password> in the login form
    Then the user access to the home web success.

    Examples:
      | user   | password   |
      | martinezstiven815@gmail.com  | 1234567  |


  @addContact
  Scenario Outline: Add Contact
    Given the user click on add new contact button
    When the user add the contact information <firstname>,<lastname>,<date>,<email>,<phone>,<address>,<city>,<state>,<postalcode>,<country>
    Then click on the submit button and consult user in the grid home.

    Examples:
      | firstname | lastname | date       | email         | phone | address  | city      | state  | postalcode | country  |
      | geiner    | martinez | 2024/10/11 | geinr@jsj.com |  1223111111 | calle 24 | manizales | caldas |        213 | colombia |
