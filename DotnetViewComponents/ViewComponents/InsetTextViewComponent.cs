namespace DotnetViewComponents.ViewComponents
{
    using Microsoft.AspNetCore.Mvc;
    using DotnetViewComponents.ViewModels;

    public class InsetTextViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(string contentHtml)
        {
            var model = new InsetTextViewModel(contentHtml);
            return View(model);
        }
    }
}
