using System.Data;
using System.Reflection;

namespace buzzFizz.DividingRules
{
    public static class BaseRuleHelper
    {
        // I guess the reason of wanting to use reflection was to have it dynamic
        // this is not considering that is specif for that classtype

        public static IEnumerable<BaseRule> GetAllRules()
        {
            return Assembly
                .GetExecutingAssembly()
                .GetTypes()
                .Where(type => typeof(BaseRule).IsAssignableFrom(type) && !type.IsAbstract)
                .Select(type => (BaseRule)Activator.CreateInstance(type))
                .AsEnumerable();
        }
    }
}
