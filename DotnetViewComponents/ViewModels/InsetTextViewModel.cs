namespace DotnetViewComponents.ViewModels
{
    public class InsetTextViewModel
    {
        public InsetTextViewModel(string contentHtml)
        {
            ContentHtml = contentHtml;
        }

        public string ContentHtml { get; set; }
    }
}
