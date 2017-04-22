using System;

namespace ScoreService.API.Rules
{
    public class CountryRule : IRule
    {
        public bool Validate(ApplicantRequest applicantRequest) => applicantRequest.Country == "Poland" ? true : false;
    }
}