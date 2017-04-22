using System;

namespace ScoreService.API.Rules
{
    public class IncomeRule : IRule
    {
        public bool Validate(ApplicantRequest applicantRequest) => applicantRequest.Income > 10000 ? true : false;
    }
}