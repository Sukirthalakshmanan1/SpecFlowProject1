Feature: prod

A short summary of the feature

@tag1
Scenario: AddProductToCart
	Given prodname  as 'Wheet'
    Given qty as 12
	When UserClicksSubmit
	Then SuccessfulLogIN
