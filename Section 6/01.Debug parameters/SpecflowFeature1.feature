Feature: Shopping Basket
In order to amend my purchase before checking out, as a customer, I want to be able to edit my shopping basket

Scenario: As a customer I can add an item to my shopping basket
Given I am on the product detail page of product "1"
And product "1" has a stock level of "2"
And product "1" basket quantity is "0"
When I click the Add to Basket button
Then product "1" basket quantity is "1"
And a message is displayed to the customer
And product "1" has a stock level of "1"
