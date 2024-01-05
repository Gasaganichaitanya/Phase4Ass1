using CalcLib;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProjectAss1Calc.StepDefinitions
{
    [Binding]
    public class CalculatorStepDefinitions
    {
        private readonly ScenarioContext scenarioContext;
        private readonly Calculator calc;
        private int result;
        public CalculatorStepDefinitions(ScenarioContext scenariocontext, Calculator calc)
        {
            this.scenarioContext = scenariocontext;
            this.calc = calc;
        }
        [Given(@"the first number is (.*)")]
        public void GivenTheFirstNumberIs(int p0)
        {
            calc.Fnum = p0;
        }

        [Given(@"the second number is (.*)")]
        public void GivenTheSecondNumberIs(int p0)
        {
            calc.Snum = p0;
        }

        [When(@"the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            result = calc.Add();
        }

        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            result.Should().Be(result);
        }

        [When(@"the two numbers are subtracted")]
        public void WhenTheTwoNumbersAreSubtracted()
        {
            result = calc.Sub();
        }

        [When(@"the two numbers are Multiplied")]
        public void WhenTheTwoNumbersAreMultiplied()
        {
            result = calc.Mul();
        }

        [When(@"the two numbers are divided")]
        public void WhenTheTwoNumbersAreDivided()
        {
            result = calc.Div();
        }
    }
}
