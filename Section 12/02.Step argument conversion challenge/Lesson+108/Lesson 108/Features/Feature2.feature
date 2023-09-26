Feature: Feature2

  Scenario: Test
    Given I have the following clothes size data
      | Name           | Size |
      | Test Product 1 | XXL  |
      | Test Product 2 | L    |
      | Test Product 3 | S    |
    Then the clothing data is translated as the following
      | Name           | Size            |
      | Test Product 1 | ExtraExtraLarge |
      | Test Product 2 | Large           |
      | Test Product 3 | Small           |

  Scenario: Stores
    Given I have the following stores
      | StoreName   | GeoLocation |
      | Southampton |  3.14, 5.43 |
      | London      |      5.4321 |
      | Bristol     |  5.43, 3.23 |
