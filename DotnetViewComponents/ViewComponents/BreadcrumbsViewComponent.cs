namespace DotnetViewComponents.ViewComponents
{
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Mvc;
    using DotnetViewComponents.ViewModels;

    /// <summary>
    /// A ViewComponent that renders a breadcrumb navigation based on the provided links.
    /// </summary>
    public class BreadcrumbsViewComponent : ViewComponent
    {
        /// <summary>
        /// Invokes the ViewComponent and returns the view with the breadcrumb model.
        /// </summary>
        /// <param name="links">A list of tuples representing the breadcrumb links where each tuple contains a title and a URL.</param>
        /// <returns>An <see cref="IViewComponentResult"/> that renders the breadcrumb view.</returns>
        public IViewComponentResult Invoke(List<(string Title, string Url)> links)
        {
            var model = new BreadcrumbsViewModel(links);

            return View(model);
        }
    }
}
