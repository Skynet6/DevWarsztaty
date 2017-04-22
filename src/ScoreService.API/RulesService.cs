using System.Collections.Generic;
using System.Linq;
using ScoreService.API.Rules;

namespace ScoreService.API
{
    public class RulesService
    {
        private List<IRule> rules;
        public RulesService()
        {
            rules = new List<IRule> { new IncomeRule(), new CountryRule(), new MortageRule(), new AgeRule() };
        }
        public bool ValidateAll(ApplicantRequest applicantRequest) => rules.All(rule => rule.Validate(applicantRequest));
    }
}