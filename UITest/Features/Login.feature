Feature: Login 
	User can login website

Scenario: User use right username and password
	Given a logged out user
	When the user add right username
	Then they log in successfully

Scenario: User use wrong username and password
	Given a logged out user
	When the user add wrong username
	Then the user is not logged in
	And they see an error message