namespace DotnetViewComponents.ViewComponents
{
    using Microsoft.AspNetCore.Mvc;
    using DotnetViewComponents.ViewModels;

    /// <summary>
    /// Represents a view component for rendering a card.
    /// </summary>
    public class CardViewComponent : ViewComponent
    {
        /// <summary>
        /// Invokes the card view component with the specified parameters.
        /// </summary>
        /// <param name="title">The title of the card.</param>
        /// <param name="description">The content description of the card. Optional.</param>
        /// <param name="imageSrc">The source URL of the image to be displayed on the card. Optional.</param>
        /// <param name="headingLevel">The HTML heading level for the title. Defaults to <c>2</c>, which results in h2.</param>
        /// <param name="hasArrow">Indicates whether the card should display an arrow. Defaults to <c>false</c>.</param>
        /// <param name="isSecondary">Indicates whether the card is styled as a secondary card. Defaults to <c>false</c>.</param>
        /// <param name="isClickable">Indicates whether the card is clickable. Defaults to <c>true</c>.</param>
        /// <returns>An <see cref="IViewComponentResult"/> that renders the card view.</returns>
        public IViewComponentResult Invoke(
            string title,
            string? description = null,
            string? imageSrc = null,
            int headingLevel = 2,
            bool hasArrow = false,
            bool isSecondary = false,
            bool isClickable = true)
        {
            var model = new CardViewModel
            (
                title,
                description,
                imageSrc,
                headingLevel,
                hasArrow,
                isSecondary,
                isClickable
            );
            return View(model);
        }
    }
}
