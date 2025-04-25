namespace DotnetViewComponents.ViewComponents
{
    using Microsoft.AspNetCore.Mvc;
    using DotnetViewComponents.ViewModels;

    /// <summary>
    /// Represents a view component for rendering a button.
    /// </summary>
    public class ButtonViewComponent : ViewComponent
    {
        /// <summary>
        /// Invokes the button view component with the specified parameters.
        /// </summary>
        /// <param name="text">The text to be displayed on the button.</param>
        /// <param name="url">The url for the link.</param>
        /// <param name="style">The style attributes for the button.</param><param name="style">The style attributes for the button.</param>
        /// <param name="styling">The styling class for the button. Receives predefined styles from <see cref="ButtonStyle"/>. Defaults to <see cref="ButtonStyle.PRIMARY"/> if no input is passed to it.</param>
        /// <param name="preventDoubleClick">Indicates whether to prevent double-clicking the button. Defaults to <c>false</c>.</param>
        /// <returns>An <see cref="IViewComponentResult"/> that renders the button view.</returns>
        public IViewComponentResult Invoke(
            string text,
            string style,
            string styling = ButtonStyle.PRIMARY,
            string? url = null,
            bool preventDoubleClick = false)
        {
            var model = new ButtonViewModel(text, url, styling, style, preventDoubleClick);

            return View(model);
        }
    }
}
