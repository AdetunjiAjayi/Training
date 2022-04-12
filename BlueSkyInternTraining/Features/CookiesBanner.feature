Feature: CookiesBanner
	As a user on PrepMajor website
	I want to be able to view the cookies consent banner
	So that i can decide whether to accept all cookies or manage cookies


@workitem750
Scenario: Cookies Consent Banner
	Given I navigate to Prepmajor1 website
	When I click on Accept all Cookies
	Then the home page is displayed 
