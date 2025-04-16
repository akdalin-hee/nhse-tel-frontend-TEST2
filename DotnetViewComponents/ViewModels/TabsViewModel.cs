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
            object  contentModel,
            bool isActive)
        {
            Name = name;
            ContentModel = contentModel;
            IsActive = isActive;
        }

        public string Name { get; set; }

        public object ContentModel { get; set; }

        public bool IsActive { get; set; }
    }
}
