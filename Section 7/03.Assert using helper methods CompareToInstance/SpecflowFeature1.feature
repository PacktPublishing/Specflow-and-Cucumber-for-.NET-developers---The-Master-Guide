Feature: Shopping Basket
  In order to amend my purchase before checking out, as a customer, I want to be able to edit my shopping basket

  Background: 
    Given I have the following data
      | Product ID | StockQty | Basket |
      |          1 |        2 |      0 |
      |          2 |        0 |      0 |
      |          3 |        2 |      1 |
      |          4 |        5 |      1 |

  Scenario Outline: Testing functionality of basket
    Given I am on the product detail page of product <Product>
    When I click the Add to Basket button
    Then the quantities are
      | Stock   | Basket   |
      | <Stock> | <Basket> |
    And a message <Message> is displayed to the customer

    Examples: 
      | Test Description  | Product | Stock | Basket | Message               |
      | In stock          |       1 |     1 |      1 | 'Added to basket '    |
      | Not in stock      |       2 |     0 |      0 | 'Not in stock'        |
      | Already in basket |       3 |     2 |      1 | 'Limited to one only' |

  Scenario: Customer can add product to basket
    Given I have the following data
      | Field     | Value |
      | ProductId |     1 |
      | StockQty  |     2 |
      | Basket    |     0 |
    When I click the Add to Basket button
    Then the quantities are
      | StockQty | Basket |
      |        1 |      1 |
    And a message 'Added to basket' is displayed to the customer
