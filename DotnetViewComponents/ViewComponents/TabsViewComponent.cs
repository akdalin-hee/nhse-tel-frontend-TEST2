namespace DotnetViewComponents.ViewComponents
{
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Mvc;
    using DotnetViewComponents.ViewModels;

    public class TabsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(
            string title,
            List<TabViewModel> tabsList)
        {
            var model = new TabsViewModel(title, tabsList);

            return View(model);
        }
    }
}
