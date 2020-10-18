Feature: Select Slider to set the price
	
@Selectslider
Scenario: Select Slider
	Given I am on Slider Page
	When I set the price rang on slider
	Then the price has set on slider