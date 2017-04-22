using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using ScoreService.API.Rules;

namespace ScoreService.API
{
    public class ScoresModule
    {
        public Task GetScore(HttpContext context)
        {
            var applicantRequst = DeserializeAsync<ApplicantRequest>(context);
            var rulesService = new RulesService();

            if (rulesService.ValidateAll(applicantRequst))
            {
                return context.Response.WriteAsync($"You are allowed: {applicantRequst.Name} :)");
            }

            return context.Response.WriteAsync($"You are not allowed: {applicantRequst.Name}");
        }

        public T DeserializeAsync<T>(HttpContext context) where T : class
        {
            if (context.Request.Body.CanRead)
            {
                using (var sr = new StreamReader(context.Request.Body))
                using (var jr = new JsonTextReader(sr))
                {
                    return new JsonSerializer().Deserialize<T>(jr);
                }
            }
            else
            {
                return null;
            }
        }
    }

    public class ApplicantRequest
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Country { get; set; }
        public int Income { get; set; }
        public bool Mortage { get; set; }
        public int Age { get; set; }
    }
}