namespace DotnetViewComponents.ViewModels
{
    public class SummaryListItemViewModel
    {
        public SummaryListItemViewModel(
            string title,
            string description,
            string? actionName = null,
            string? aspAction = null,
            string? aspController = null,
            Dictionary<string, string>? aspRouteData = null)
        {
            Title = title;
            Description = description;
            ActionName = actionName;
            AspAction = aspAction;
            AspController = aspController;
            AspRouteData = aspRouteData;
        }

        public string Title { get; set; }

        public string Description { get; set; }

        public string? ActionName { get; set; }

        public string? AspAction { get; set; }

        public string? AspController { get; set; }

        public Dictionary<string, string>? AspRouteData { get; set; }
    }
}
