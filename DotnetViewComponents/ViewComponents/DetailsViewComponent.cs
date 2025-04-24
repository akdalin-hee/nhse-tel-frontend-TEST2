namespace DotnetViewComponents.ViewComponents
{
    using Microsoft.AspNetCore.Mvc;
    using DotnetViewComponents.ViewModels;

    /// <summary>
    /// Represents a view component that displays details using a summary and content.
    /// </summary>
    public class DetailsViewComponent : ViewComponent
    {
        /// <summary>
        /// Invokes the view component with the specified summary and content.
        /// </summary>
        /// <param name="summary">The summary to be displayed.</param>
        /// <param name="content">The content to displayed.</param>
        /// <returns>An <see cref="IViewComponentResult"/> that renders details view.</returns>
        public IViewComponentResult Invoke(
            string summary,
            string content
        )
        {
            var model = new DetailsViewModel(summary, content);

            return View(model);
        }
    }
}
