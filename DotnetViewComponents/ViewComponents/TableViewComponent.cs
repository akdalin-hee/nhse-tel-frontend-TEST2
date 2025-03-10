namespace DotnetViewComponents.ViewComponents
{
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Mvc;
    using DotnetViewComponents.ViewModels;

    public class TableViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(
            string title,
            List<string> headers,
            List<List<TableColumnModel>> rows,
            bool isResponsive = false,
            bool hasNumericData = false)
        {
            var model = new TableViewModel(title, headers, rows, isResponsive, hasNumericData);

            return View(model);
        }
    }
}
