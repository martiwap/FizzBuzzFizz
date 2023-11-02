using buzzFizz.DividingRules;

namespace buzzFizz
{
    public class BuzzFizzService : IBuzzFizzService
    {
        public IEnumerable<BaseRule> dividingRules;

        public BuzzFizzService()
        {
            dividingRules = BaseRuleHelper.GetAllRules();
        }

        public List<string> ShowDividedResults(int inputNum)
        {
            List<string> result = new List<string>();

            for (int i = 1; i <= inputNum; ++i)
            {
                foreach (BaseRule rule in this.dividingRules)
                {
                    // the fact that I didive by both 3 and 5 makes the string returned duplicated
                    var processed = rule.ProcessInput(i);
                    int x = 0;

                    // hence the check if it;s contained or not (only for int)
                    if (!result.Contains(processed) && Int32.TryParse(processed, out x)
                        || !Int32.TryParse(processed, out x))
                    {
                        result.Add(processed);
                    }
                }
            }

            return result;
        }
    }
}
