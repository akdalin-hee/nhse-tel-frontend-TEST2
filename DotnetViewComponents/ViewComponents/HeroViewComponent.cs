namespace DotnetViewComponents.ViewComponents
{
    using Microsoft.AspNetCore.Mvc;
    using DotnetViewComponents.ViewModels;

    public class HeroViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(
            string imageSrc = null,
            string heading = null,
            string textContent = null)
        { 
            var model = new HeroViewModel(imageSrc, heading, textContent);

            return View(model);
        }
    }
}
