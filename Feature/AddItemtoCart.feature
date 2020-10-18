Feature: AddItemtoCart
	
@AddItem
Scenario: User can Add Item to Cart
	Given I am on the Website
	And I select the summer dress
	When I click proceed to the Checkout
	Then Item added to the cart