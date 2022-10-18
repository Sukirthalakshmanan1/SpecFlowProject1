using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class LoginStepDefinitions
    {
        Calci c=new Calci();
        string u;
        string pass;
        [Given(@"User gives userid as '([^']*)'")]
        public void GivenUserGivesUseridAs(string p0)
        {
            u = p0;
            //throw new PendingStepException();
        }

        [Given(@"User gives password as '([^']*)'")]
        public void GivenUserGivesPasswordAs(string p0)
        {
            pass = p0;
            //throw new PendingStepException();
        }

        [When(@"UserClicksLogin")]
        public void WhenUserClicksLogin()
        {

            Console.WriteLine($"{nameof(WhenUserClicksLogin)}");
            //throw new PendingStepException();
        }

        [Then(@"SuccessfulLogIN message should display")]
        public void ThenSuccessfulLogINMessageShouldDisplay()
        {
            bool answer = c.res(u, pass);
            Assert.AreEqual(answer, true);
            Console.WriteLine("Successfully logged in");
            //throw new PendingStepException();
        }
    }
}
