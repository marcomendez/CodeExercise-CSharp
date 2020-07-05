Feature: Test

Scenario: Validate that Product item are displayed on Summary
	Given I go to 'Index' page
	When I click BEST SELLERS on Index
	Then I verify that 'Printed Chiffon Dress' contains '-20%'
	When I hover on Printed Chiffon Dress and click on Add to cart
	And  I click Continue shopping
	And I hover on Blouse and click on Add to cart
	And  I click Continue shopping
	And I hover on Cart and click on Check out
	Then I verify that the following values are displayed on table
	| Description           | Avail    |
	| Printed Chiffon Dress | In stock |
	| Blouse                | In stock |
	When I click Remove Blouse on Summary
	Then I verify that the following values are not displayed on table
	| Description | Avail    |
	| Blouse      | In stock |
	And I verify that 'Total Amount to Pay' contains '$18.40'