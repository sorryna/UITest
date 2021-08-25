 using System;
using TechTalk.SpecFlow;

namespace UITest.Steps
{
    [Binding]
    public class LoginSteps
    {
        [Given(@"a logged out user")]
        public void GivenALoggedOutUser()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"the user add right username")]
        public void WhenTheUserAddRightUsername()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"the user add wrong username")]
        public void WhenTheUserAddWrongUsername()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"they log in successfully")]
        public void ThenTheyLogInSuccessfully()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the user is not logged in")]
        public void ThenTheUserIsNotLoggedIn()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"they see an error message")]
        public void ThenTheySeeAnErrorMessage()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
