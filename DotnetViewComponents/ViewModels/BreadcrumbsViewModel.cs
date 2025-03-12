namespace DotnetViewComponents.ViewModels
{
    public class BreadcrumbsViewModel
    {
        public BreadcrumbsViewModel(List<(string Title, string Url)> links)
        {
            Links = links;
        }

        public List<(string Title, string Url)> Links { get; set; }

    }
}
