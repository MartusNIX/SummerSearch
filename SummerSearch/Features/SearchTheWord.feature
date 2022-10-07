Feature: SearchTheWord

Search some word that is displayed in header after 

@header
Scenario: Perform compearing searched word and header word
	Given I launch the page
	And I insert word in searchfield <Entered word>
	When I click on magnifier
	Then I see the same words <Expected heder word>

Examples: 
		| Entered word | Expected heder word |
     	| Summer       | SUMMER              |
