Feature: HomeTabsTest
	In order to view Home tabs
	As a User
	I want to click Home tabs

@Regression @HomeTabs
Scenario Outline: Click HomeTabs
	Given I navigate to EdgePetrol
	When I click tabs
	Then I see corresponding tabs pages

	Examples: 
	| tabs				|
	| Product			|
	| Knowledge Centre	|
	| Partners			|			
	| The Team			|
	| Careers			|
	| Contact			|