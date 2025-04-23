namespace DotnetViewComponents.ViewModels
{
    public class ImageViewModel
    {
        public ImageViewModel(
            string src,
            string alt,
            string caption,
            string? additionalAttributes = null)
        {
            Src = src;
            Alt = alt;
            Caption = caption;
            AdditionalAttributes = additionalAttributes;
        }

        public string Src { get; set; }

        public string Alt { get; set; }

        public string Caption { get; set; }

        public string? AdditionalAttributes { get; set; }
    }


}
