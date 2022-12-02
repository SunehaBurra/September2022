Feature: Profile
I would like to add  Data to Profile page successfully
Background:
Given I logged in QAMars Project successfully



@tag1
Scenario: Add and save name with valid credentials. 
	
    When I entered and save name
	Then profile page should show the added name successfully.


Scenario: Add Availability to profile page
    
    When I selected availability option
	Then profile page should show the selected availability

Scenario: Add number of hours to profile page
   
    When I selected hours option
	Then profile page should display the selected hours

Scenario: Add and save description to profile page
    
    When I entered and saved description
	Then profile page should show the added description

Scenario: Add and save languages to profile page
    
    When I entered and saved language 
	Then profile page should display the added language

Scenario: Add and save Skills to profile page
    
    When I entered and save Skill
	Then profile page should display added Skill

Scenario:Add and save Cetifications to profile page
    When  I added '< Certificate >', issued '<Institute>' and select option for '<Year>' of certification in profile page
	Then the profile page should show the added '<Certificate>', issued '<Institute>' along with selected  '<Year>' of certificationon profile page.
    
    Examples:
    | Certificate  | Institute  | Year |
    | Test Analyst | MVP Studio | 2022 |
