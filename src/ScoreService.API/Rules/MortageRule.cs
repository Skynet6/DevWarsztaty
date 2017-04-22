using System;

namespace ScoreService.API.Rules
{
    public class MortageRule : IRule
    {
        public bool Validate(ApplicantRequest applicantRequest) => !applicantRequest.Mortage ? true : false;
    }
}