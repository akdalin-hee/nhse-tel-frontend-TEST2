namespace DotnetViewComponents.ViewComponents
{
    using Microsoft.AspNetCore.Mvc;
    using DotnetViewComponents.ViewModels;

    /// <summary>
    /// A ViewComponent that renders a button.
    /// </summary>
    public class ButtonViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(
            string text,
            string style,
            string styling = ButtonStyle.PRIMARY,
            string? aspController = null,
            string? aspAction = null,
            Dictionary<string, string>? aspRouteData = null,
            bool preventDoubleClick = true)
        {
            var model = new ButtonViewModel(text, aspController, aspAction, aspRouteData, styling, style, preventDoubleClick);
            var numer = 12225;
            var f = "rer";
            var di = "ciao44";
            var anoth = "PATCH 1543";
            return View(model);
        }
    }
}
