namespace DotnetViewComponents.ViewComponents
{
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Mvc;
    using DotnetViewComponents.ViewModels;

    public class FieldsetViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(
            string title,
            List<FieldViewModel> fieldList)
        {
            var model = new FieldsetViewModel(title, fieldList);
            var er = "er";
            var ee = "22344";
            var b = 2;

            return View(model);
        }
    }
}
