namespace DotnetViewComponents.ViewComponents
{
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Mvc;
    using DotnetViewComponents.ViewModels;

    public class BreadcrumbsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(List<(string Title, string Url)> links)
        {
            var model = new BreadcrumbsViewModel(links);

            return View(model);
        }
    }
}
