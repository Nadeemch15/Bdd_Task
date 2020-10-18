Feature: DisplaySummerDress
As a user I want to select summer dress option from the navigation menu 
so I can view item from summer collection.
	@SummerDresses
Scenario: Display summer dresses 
   Given I am on Search Page
	When I mouse hover on WOMEN Tab and click Summer dresses
	Then Summer dresses are displayed
	
