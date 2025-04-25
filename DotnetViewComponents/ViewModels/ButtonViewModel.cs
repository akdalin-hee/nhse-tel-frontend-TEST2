namespace DotnetViewComponents.ViewModels
{
    public class ButtonViewModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ButtonViewModel"/> class.
        /// </summary>
        /// <param name="text">The text to be displayed on the button.</param>
        /// <param name="url">The url for the link.</param>
        /// <param name="style">The style attributes for the button.</param>
        /// <param name="styling">The styling class for the button. Defaults to <see cref="ButtonStyle.PRIMARY"/>.</param>
        /// <param name="preventDoubleClick">Indicates whether to prevent double-clicking the button. Defaults to <c>false</c>.</param>
        public ButtonViewModel(
            string text,
            string url,
            string styling,
            string style,
            bool preventDoubleClick)
        {
            Text = text;
            Url = url;
            Styling = styling;
            Style = style;
            PreventDoubleClick = preventDoubleClick;
        }

        /// <summary>
        /// Gets or sets the text displayed on the button.
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// Gets or sets the url of the link.
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets the styling for the button.
        /// </summary>
        public string Styling { get; set; }

        /// <summary>
        /// Gets or sets the style attributes on the button.
        /// </summary>
        public string Style { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to prevent double-clicking the button.
        /// </summary>
        public bool PreventDoubleClick { get; set; }

    }

    public static class ButtonStyle
    {
        public const string PRIMARY = "nhsuk-button";
        public const string SECONDARY = "nhsuk-button nhsuk-button--secondary";
        public const string REVERSE = "nhsuk-button nhsuk-button--reverse";
        public const string WARNING = "nhsuk-button nhsuk-button--warning";
    }
}
