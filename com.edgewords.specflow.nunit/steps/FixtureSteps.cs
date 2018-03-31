/*
 * Created by Ranorex
 * User: Tom
 * Date: 22/03/2018
 * Time: 15:29
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
using TechTalk.SpecFlow;
using Ranorex;

namespace com.edgewords.specflow.nunit.steps
{
    [Binding]
    public class FixtureSteps
    {
        [When("I open the Site")]
        public void GivenIHaveEnteredSomethingIntoTheCalculator()
        {
        	Report.Info("Opening The site");
        }


        [Then("it opens")]
        public void ThenTheResultShouldBe()
        {
            Report.Info("IT worked");
        }
    }
}
