using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class ProdStepDefinitions
    {
        Calci c=new Calci();
        string p;
        int q;
        [Given(@"prodname  as '([^']*)'")]
        public void GivenProdnameAs(string w)
        {
            p=w;
            //throw new PendingStepException();
        }
        [Given(@"qty as (.*)")]
        public void GivenQtyAs(int p0)
        {
            q=p0;
            //throw new PendingStepException();
        }

        [When(@"UserClicksSubmit")]
        public void WhenUserClicksSubmit()
        {
            Console.WriteLine($"{nameof(WhenUserClicksSubmit)}");
            //throw new PendingStepException();
        }

        [Then(@"SuccessfulLogIN")]
        public void ThenSuccessfulLogIN()
        {
            bool ans = c.res1(p, q);
            Assert.AreEqual(ans, true);
            Console.WriteLine("Success");
            //throw new PendingStepException();
        }
    }
}
