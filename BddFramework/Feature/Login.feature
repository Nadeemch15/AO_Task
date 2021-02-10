Feature: Login
	As a user, I want to Login to the website successfully

@LoginUser
Scenario: Login User
	Given I am on login page
	When I entere the login details <Email>, <Password> and I click the SignIn Button	
	Then I logged in successfully
	Examples:
| Email			| Password |
| CDS@email.com | 123qwe   |