
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CERAXLAN.Core.CrossCuttingConcerns.Exceptions.HttpProblemDetails
{
    internal static class ProblemDetailsExtensions
    {
        public static string AsJson(this ProblemDetails details)
        {
            return JsonConvert.SerializeObject(details);
        }
    }
}
