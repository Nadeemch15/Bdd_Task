Feature: TakeScreenshot
	of OUR STORES map page

@TakeScreenshot
Scenario: Take Screenshot 
	Given I am on the Automation website
	When I click the Our store link and take screenshot
	Then I am able to take the screenshot