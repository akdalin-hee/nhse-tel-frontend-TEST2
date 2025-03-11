namespace DotnetViewComponents.ViewComponents
{
    using Microsoft.AspNetCore.Mvc;
    using DotnetViewComponents.ViewModels;

    public class PaginationViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(
            int currentPage,
            int totalPage,
            string prevUrl,
            string nextUrl)
        {
            var model = new PaginationViewModel(currentPage, totalPage, prevUrl, nextUrl);

            return View(model);
        }
    }
}
