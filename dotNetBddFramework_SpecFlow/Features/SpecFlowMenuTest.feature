Feature: SpecFlowMenuTest
		As a user, I want to navigate to the SpecFlow
		Installation page using the website menu

@smoke
Scenario: Navigate to the Installation page using the menu
	Given SpecFlow website is loaded	
When I hover over the "Docs" menu item
And I select "SpecFlow"
And I click on the 'search docs' field
And I enter "Installation" in the popup window
And I select the result titled "Installation"
Then the page titled "Installation" opens
