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

  Scenario: Challenge
    Given I have the following users
      | Name    | UserType   |
      | John    | Supervisor |
      | Bob     | Staff      |
      | Charlie | Customer   |
      | Sally   | Visitor    |
