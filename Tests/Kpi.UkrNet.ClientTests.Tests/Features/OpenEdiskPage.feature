@Regression
@EdiskPage
Feature: Opening Edisk page
	The possibility to open Edisk page

@Smoke
Scenario: 1. Verify the possibility to open Edisk page from Mailbox
	Given I have 'ValidUser' as existing user
	When I login as existing user
	And I clicking the Edisk button
	Then I see user login in header