Feature: ForgotPasswordTest
	In order to see Forgot Password Page
	As a User
	I want to be able to click Forgot Your Password

@Regression @ForgotPassword
Scenario: See Forgot Password Page
	Given I Navigate to EdgePetrol
	And I Click Login
	When I Click Forgot Your Password
	Then I see Forgot Your Password Page
