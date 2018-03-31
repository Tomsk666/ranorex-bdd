/*
 * Created by Ranorex
 * User: Tom
 * Date: 22/03/2018
 * Time: 14:46
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
using TechTalk.SpecFlow;
using NUnit.Framework;
using Ranorex;


namespace com.edgewords.specflow.nunit.steps
{
    [Binding]
    public class WebSiteSteps
    {

        [When("I log into the web site")]
        public void WhenIPressAdd()
        {
        	Recording1.Start();
        }

        [Then("it appears OK")]
        public void ThenTheResultShouldBe()
        {
            var repo = com_edgewords_specflow_nunitRepository.Instance;

            Assert.That(repo.AutomatedToolsTestSite.titleInfo.Exists());
            Delay.Seconds(1);
            repo.AutomatedToolsTestSite.Self.Close();
        }
    }
}
