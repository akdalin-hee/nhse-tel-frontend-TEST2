namespace DotnetViewComponents.ViewModels
{
    /// <summary>
    /// Represents the view model for an individual item in a contents list.
    /// </summary>
    public class ContentsListItemViewModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContentsListItemViewModel"/> class.
        /// </summary>
        /// <param name="title">The title of the contents-list item.</param>
        /// <param name="url">The URL associated with the contents-list item.</param>
        /// <param name="isActive">Indicates whether the item is currently active. Defaults to <c>false</c>.</param>
        public ContentsListItemViewModel(
            string title,
            string url,
            bool isActive = false)
        {
            Title = title;
            Url = url;
            IsActive = isActive;
        }

        /// <summary>
        /// Gets or sets the title of the contents-list item.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the URL associated with the contents-list item.
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the item is currently active.
        /// </summary>
        public bool IsActive { get; set; }
    }

}
