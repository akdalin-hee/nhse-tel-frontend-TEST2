using Microsoft.AspNetCore.Html;

namespace DotnetViewComponents.ViewModels
{
    public class TabsViewModel
    {
        public TabsViewModel(
            string title,
            List<TabViewModel> tabsList)
        {
            Title = title;
            TabsList = tabsList;
        }

        public string Title { get; set; }
        public List<TabViewModel> TabsList { get; set; }

    }

    public class TabViewModel
    {
        public TabViewModel(
            string name,
            Func<object, IHtmlContent> content,
            bool isActive)
        {
            Name = name;
            Content = content;
            IsActive = isActive;
        }

        public string Name { get; set; }

        public Func<object, IHtmlContent> Content { get; set; }

        public bool IsActive { get; set; }
    }
}
