using System;
using ScoreService.API;
using ScoreService.API.Rules;
using Xunit;

namespace ScoreService.Tests
{
    public class RulesTests
    {
        [Fact]
        public void GivenValidateWhenIncomeLessThan10000ThenReturnFalse()
        {
            var incomeRule = new IncomeRule();
            var applicantRequest = new ApplicantRequest
            {
                Income = 900
            };

            var result = incomeRule.Validate(applicantRequest);

            Assert.False(result);
        }
    }
}
