@Regression
@SendingPage
Feature: Opening Sending Form
	The possibility to see email sending form

@Smoke
Scenario: 1. Verify the possibility to see email sending form
	Given I have 'ValidUser' as existing user
	When I login as existing user
	And I opening email sending form
	Then I see button with 'Надіслати' text