namespace DotnetViewComponents.ViewComponents
{
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Mvc;
    using DotnetViewComponents.ViewModels;

    public class InsetTextViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(
            string text,
            string cssClass = null
        )
        {
            var model = new InsetTextViewModel(text, string.IsNullOrEmpty(cssClass) ? null : cssClass);
            return View(model);
        }
    }
}
