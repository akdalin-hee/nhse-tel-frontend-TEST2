namespace DotnetViewComponents.ViewModels
{
    public class BreadcrumbsViewModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BreadcrumbsViewModel"/> class.
        /// It receives a list of of string tuples containing the name/title of the link and the url path to it.
        /// </summary>
        /// <param name="links">A list of tuples representing the breadcrumb links where each tuple contains a title and a URL.</param>
        public BreadcrumbsViewModel(List<(string Title, string Url)> links)
        {
            Links = links;
        }

        public List<(string Title, string Url)> Links { get; set; }

    }
}
