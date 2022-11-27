@setup_feature
Feature: XYZ_Bank
	Sort customers last name


Scenario: Implement the sort of customers last name
	Given open XYZ_Bank site 
	And click on the Bank Manager  button
	And click on the Customers button
	When click on the Last Name 
	Then customers should be sorted in descending order