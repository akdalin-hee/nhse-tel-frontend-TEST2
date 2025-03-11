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
            TableViewModel table,
            bool isActive)
        {
            Name = name;
            Table = table;
            IsActive = isActive;
        }

        public string Name { get; set; }

        public TableViewModel Table { get; set; }

        public bool IsActive { get; set; }
    }
}
