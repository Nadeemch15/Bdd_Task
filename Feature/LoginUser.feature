Feature: Login as User
	As a user, I want to Login to the website successfully

@LoginUser
Scenario: Login User
	Given I am on login page
	And I entere the login details <Email>, <Password>
	When I click the SignIn Button
	Then I logged in successfully
	Examples:
| Email				| Password |
| Answer01@email.com  | 123qwe  |