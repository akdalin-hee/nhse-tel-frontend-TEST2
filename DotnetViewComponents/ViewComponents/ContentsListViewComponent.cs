namespace DotnetViewComponents.ViewComponents
{
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Mvc;
    using DotnetViewComponents.ViewModels;

    public class ContentsListViewComponent : ViewComponent
    {
        /// <summary>
        /// Invokes the contents list view component with the specified parameters.
        /// </summary>
        /// <param name="name">The title of the contents list.</param>
        /// <param name="listItems">The set of items in the contents list.</param>
        /// <returns>An <see cref="IViewComponentResult"/> that renders the contents-list view.</returns>
        public IViewComponentResult Invoke(
            string name,
            IEnumerable<ContentsListItemViewModel> listItems)
        {
            var model = new ContentsListViewModel(name, listItems);

            return View(model);
        }
    }
}
