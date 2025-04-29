namespace DotnetViewComponents.ViewModels
{
    public class HeroViewModel
    {
        public HeroViewModel(
            string? imageSrc,
            string? heading,
            string? textContent)
        {
            ImageSrc = imageSrc;
            Heading = heading;
            TextContent = textContent;
        }

        public string? ImageSrc { get; set; }


        public string? Heading { get; set;}


        public string? TextContent { get; set;}
    }
}
