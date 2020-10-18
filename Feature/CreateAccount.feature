Feature: CreateAccount
	

@CreatAccount
Scenario: Create an account
	Given I am on login page of create account
	And I entered the email address
	And I entered the personal details
	When I click the Register Button
	Then the user account is created