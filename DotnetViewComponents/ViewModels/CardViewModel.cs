namespace DotnetViewComponents.ViewModels
{
    public class CardViewModel
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="CardViewModel"/> class.
        /// </summary>
        /// <param name="title">The title of the card.</param>
        /// <param name="description">The content description of the card. Optional</param>
        /// <param name="imageSrc">The source URL of the image to be displayed on the card. Optional.</param>
        /// <param name="headingLevel">The HTML heading level for the title. Defaults to <c>2</c>, which results in h2.</param>
        /// <param name="hasArrow">Indicates whether the card should display an arrow. Defaults to <c>false</c>.</param>
        /// <param name="isSecondary">Indicates whether the card is styled as a secondary card. Defaults to <c>false</c>.</param>
        /// <param name="isClickable">Indicates whether the card is clickable. Defaults to <c>true</c>.</param>
        public CardViewModel(
            string title,
            string? description = null,
            string? imageSrc = null,
            int headingLevel = 2,
            bool hasArrow = false,
            bool isSecondary = false,
            bool isClickable = true)
        {
            Title = title;
            Description = description;
            ImageSrc = imageSrc;
            HeadingLevel = headingLevel;
            HasArrow = hasArrow;
            IsSecondary = isSecondary;
            IsClickable = isClickable;
        }

        public string Title { get; set; }

        public string? Description { get; set; }

        public string? ImageSrc { get; set; }

        public int HeadingLevel { get; set; }

        public bool HasArrow { get; set; }

        public bool IsSecondary { get; set; }

        public bool IsClickable { get; set; }
    }
}
