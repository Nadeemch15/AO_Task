Feature: SearchItem



@SearchWashingMachine
Scenario: Search Washing Machines
	Given I am on AO website
	And I search for washing machines and click search button
	And I Select Hotpoint washing machine
	When I Select wash load large
	Then the list of Hotpoint Large washing machine displayed 