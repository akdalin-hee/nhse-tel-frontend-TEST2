namespace DotnetViewComponents.ViewComponents
{
    using Microsoft.AspNetCore.Mvc;
    using DotnetViewComponents.ViewModels;

    /// <summary>
    /// Represents a view component for rendering a character-count input.
    /// </summary>
    public class CharacterCountViewComponent : ViewComponent
    {
        /// <summary>
        /// Invokes the character count view component with the specified parameters.
        /// </summary>
        /// <param name="id">The unique identifier for the character count component.</param>
        /// <param name="maxLength">The maximum number of characters allowed.</param>
        /// <param name="maxWords">The optional maximum number of words allowed. Defaults to <c>null</c>.</param>
        /// <param name="threshold">The optional threshold for character count warnings. Defaults to <c>null</c>.</param>
        /// <param name="label">The label for the character count component. Optional.</param>
        /// <param name="hint">A hint or instruction for the user. Defaults to a predefined message.</param>
        /// <param name="errorMessage">An optional error message to display when validation fails. Defaults to <c>null</c>.</param>
        /// <param name="hasError">Indicates whether there is a validation error. Defaults to <c>false</c>.</param>
        /// <returns>An <see cref="IViewComponentResult"/> that renders the character count view.</returns>
        public IViewComponentResult Invoke(
            string id,
            int maxLength,
            int? maxWords = null,
            int? threshold = null,
            string? label = null,
            string hint = "Do not include personal information like your name, date of birth or NHS number.",
            string? errorMessage = null,
            bool hasError = false)
        {
            var model = new CharacterCountViewModel
            (
                id,
                maxLength,
                maxWords,
                threshold,
                label,
                hint,
                errorMessage,
                hasError
            );
            return View(model);
        }
    }
}
