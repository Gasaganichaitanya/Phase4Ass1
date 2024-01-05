Feature: Calculator
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](SpecFlowProjectAss1Calc/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@mytag
Scenario: Add two numbers
	Given the first number is 50
	And the second number is 70
	When the two numbers are added
	Then the result should be 120

	Scenario: Sub two numbers
	Given the first number is 40
	And the second number is 30
	When the two numbers are subtracted
	Then the result should be 10

	Scenario: Mul two numbers
	Given the first number is 10
	And the second number is 20
	When the two numbers are Multiplied
	Then the result should be 200

	Scenario: Div two numbers
	Given the first number is 20
	And the second number is 10
	When the two numbers are divided
	Then the result should be 2