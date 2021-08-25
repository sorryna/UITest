
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Playwright;
using System.Threading.Tasks;

namespace UITest.PageObject
{
    public abstract class BasePageObject
    {
        public abstract string PagePath { get; }
        public abstract IPage Page { get; set; }
        public abstract IBrowser Browser { get; }
        public async Task NavigateAsync()
        {
            Page = await Browser.NewPageAsync();
            await Page.GotoAsync(PagePath);
        }
    }
}
 