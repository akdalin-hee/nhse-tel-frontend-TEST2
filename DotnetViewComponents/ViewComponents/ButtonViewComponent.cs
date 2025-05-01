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
        /// <param name="aspController">The asp-controller to dynamically set the controller path of the link.</param>
        /// <param name="aspAction">The asp-action to dynamically set the action path of the link..</param>
        /// <param name="aspRouteData">The asp-all-route-data to dynamically set the extra parameters to the path of the link.</param>
        /// <param name="url">The url for the link.</param>
        /// <param name="style">The style attributes for the button.</param><param name="style">The style attributes for the button.</param>
        /// <param name="styling">The styling class for the button. Receives predefined styles from <see cref="ButtonStyle"/>. Defaults to <see cref="ButtonStyle.PRIMARY"/> if no input is passed to it.</param>
        /// <param name="preventDoubleClick">Indicates whether to prevent double-clicking the button. Defaults to <c>false</c>.</param>
        /// <returns>An <see cref="IViewComponentResult"/> that renders the button view.</returns>
        public IViewComponentResult Invoke(
            string text,
            string style,
            string styling = ButtonStyle.PRIMARY,
            string aspController = null,
            string aspAction = null,
            Dictionary<string, string> aspRouteData = null,
            bool preventDoubleClick = false)
        {
            var model = new ButtonViewModel(text, aspController, aspAction, aspRouteData, styling, style, preventDoubleClick);

            return View(model);
        }
    }
}
