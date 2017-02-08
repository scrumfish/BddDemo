Feature: EmployeeFeature
	As a manager
	I want to get an employee
	So I can plan a work schedule

@mytag
Scenario: Get one employee by id
	Given I select employee 38 from the website
	When I get
	Then the resulting first name will be Kim
	And the last name will be Abercrombie
	And the id is 38

Scenario Outline: Search by employee last name
	Given I search on employee
	When I get <lastName>
	Then the resulting collection will contain exactly 1 of <id>
	And the resulting collection will contain last name <lastName>
	And the resulting collection will contain first name <firstName>

Examples: 
	| lastName | firstName | id |
	| Baker    | Bryan     | 41 |
	| Benshoof | Wanida    | 20 |


Scenario: Search by employee last name only gets requested
	Given I search on employee
	When I get Baker
	Then the resulting collection will have exactly 2 items for Last name of Baker
	And the resulting collection contains no items that are not Baker

