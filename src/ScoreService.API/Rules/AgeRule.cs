using System;

namespace ScoreService.API.Rules
{
    public class AgeRule : IRule
    {
        public bool Validate(ApplicantRequest applicantRequest) => applicantRequest.Age > 21 ? true : false;
    }
}