Feature: Registration


@workitem101
Scenario: Valid Registration
  Given I Navigate to longrichway.com
  When I click on Register button
  And I enter First Name "Tester"
  And I enter Last Name "Bluesky"
  And I enter Email Address "Tester1@yahoo.com"
  And I enter Phone number "0795646660066"
  And I enter Password "London12345"
  And I enter Confirm Password "London12345"
  And I enter Address "99 Ikeja Lagos"
  And I enter Town "Surulere"
  And I enter State "Lagos"
  And I click on create Account Button
  Then the message "Registration successful,Login to your Account" is displayed on the page



 Scenario: Invalid Registration
  Given I Navigate to longrichway.com
  When I click on Register button
  And I enter First Name "Tester"
  And I enter Last Name ""
  And I enter Email Address "Tester1@yahoo.com"
  And I enter Phone number "0795646660066"
  And I enter Password "London12345"
  And I enter Confirm Password "London12345"
  And I enter Address "99 Ikeja Lagos"
  And I enter Town "Surulere"
  And I enter State "Lagos"
  And I click on create Account Button
  Then the Error message "The Lastname is Required" is displayed on the page


