using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Extensions.OpenAI;
using Microsoft.Azure.Functions.Worker.Http;

namespace Demo.OpenAI.Functions.Extensions
{
    public class TextCompletion
    {

        [Function("TextCompletion")]
        public IActionResult Run([HttpTrigger(AuthorizationLevel.Function, Route = "citydescription/{city}")] HttpRequestData req,
        [TextCompletionInput("Give 250 words brief about {city}")] TextCompletionResponse response)
        {
            return new OkObjectResult(response.Content);
        }
    }
}
