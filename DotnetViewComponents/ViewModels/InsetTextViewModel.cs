namespace DotnetViewComponents.ViewModels
{
    public class InsetTextViewModel
    {
        public InsetTextViewModel(string text, string? cssClass = null)
        {
            Text = text;
            CssClass = cssClass;
        }

        public string Text { get; set; }

        public string? CssClass { get; set; }
    }
}
