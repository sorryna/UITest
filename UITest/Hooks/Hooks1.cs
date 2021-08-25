using BoDi;
using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using UITest.PageObject;

namespace UITest.Hooks
{
    [Binding]
    public sealed class Hooks1
    {
        private readonly ScenarioContext scenarioContext;

        public Hooks1(ScenarioContext scenarioContext)
        {
            this.scenarioContext = scenarioContext;
        }

        [BeforeScenario("login")]
        public async Task BeforeScenario()
        {
            var playwright = await Playwright.CreateAsync();
            var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions 
            {
                Headless = false,
                Timeout = 2000
            });
            scenarioContext.Set(browser);
            scenarioContext.Set(playwright);

            var loginPage = new LoginPageObject(browser);
            scenarioContext.Set(loginPage);
        }

        [AfterScenario]
        public async Task AfterScenario()
        {
            var xxx = scenarioContext.Get<IBrowser>();
            await xxx.CloseAsync();
            var playwright = scenarioContext.Get<IPlaywright>();
            playwright.Dispose();
        }
    }
}
