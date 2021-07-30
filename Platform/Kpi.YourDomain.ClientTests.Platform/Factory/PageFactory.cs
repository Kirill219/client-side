using System;
using Kpi.UkrNet.ClientTests.Model.Platform.Drivers;
using Kpi.UkrNet.ClientTests.Model.Platform.Page;
using Kpi.UkrNet.ClientTests.Platform.Element;

namespace Kpi.UkrNet.ClientTests.Platform.Factory
{
    public static class PageFactory
    {
        public static TPage Get<TPage>(IWebDriver driver) 
            where TPage : IWebPage
        {
            IWebPage page = (TPage)Activator.CreateInstance(typeof(TPage), driver);
            InitPage(page);
            return (TPage)page;
        }

        private static void InitPage(IWebPage page)
        {
            if (page.GetType().HasUrlAttribute())
            {
                page.Address = page.GetType().GetUrlAttribute().Url;
            }

            ElementFactory.InitProperties(page);
        }
    }
}
