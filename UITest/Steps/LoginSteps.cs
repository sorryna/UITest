using FluentAssertions;
using Microsoft.Playwright;
using System;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using UITest.PageObject;

namespace UITest.Steps
{
    [Binding]
    public class LoginSteps
    {
        private readonly LoginPageObject _pageObject;
        public LoginSteps(ScenarioContext scenarioContext)
        {
            _pageObject = scenarioContext.Get<LoginPageObject>();
        }

        [Given(@"a logged out user")]
        public async Task GivenALoggedOutUser()
        {
            await _pageObject.NavigateAsync();
        }
        
        [When(@"the user add right username")]
        public async Task WhenTheUserAddRightUsername()
        {
            await _pageObject.SetUsername("sorry@gmail.com");
            await _pageObject.SetPassword("1111");
            await _pageObject.ClickLoginButton();
        }
        
        [Then(@"they log in successfully")]
        public void ThenTheyLogInSuccessfully()
        {
            _pageObject.Page.Url.Should().EndWith("logged-in");
        }

        [When(@"the user add wrong username")]
        public async Task WhenTheUserAddWrongUsername()
        {
            await _pageObject.SetUsername("sorryna@gmail.com");
            await _pageObject.SetPassword("1234");
            await _pageObject.ClickLoginButton();
        }
        
        [Then(@"the user is not logged in")]
        public void ThenTheUserIsNotLoggedIn()
        {
            _pageObject.Page.Url.Should().NotEndWith("logged-in");
        }
        
        [Then(@"they see an error message")]
        public async Task ThenTheySeeAnErrorMessage()
        {
            var errorMessage = await _pageObject.GetErrorMessage();
            errorMessage.Should().Be("Wrong Username and Password");
        }
    }
}
