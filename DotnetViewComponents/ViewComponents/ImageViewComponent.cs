namespace DotnetViewComponents.ViewComponents
{
    using Microsoft.AspNetCore.Mvc;
    using DotnetViewComponents.ViewModels;

    public class ImageViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(
            string src,
            string alt,
            string caption,
            string? additionalAttributes = null)
        {
            var model = new ImageViewModel(src, alt, caption, additionalAttributes);

            return View(model);
        }
    }
}
