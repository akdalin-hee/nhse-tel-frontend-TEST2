namespace DotnetViewComponents.ViewModels
{
    public class DoDontListViewModel
    {
        public DoDontListViewModel(
            bool isDo,
            List<string> ruleSet)
        {
            IsDo = isDo;
            RuleSet = ruleSet;
        }

        public bool IsDo { get; set; }

        public List<string> RuleSet { get; set; }
    }
}
