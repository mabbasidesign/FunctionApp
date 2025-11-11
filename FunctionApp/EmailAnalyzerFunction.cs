using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;



namespace FunctionApp
{
    public class EmailAnalyzerFunction
    {
        private readonly ILogger<EmailAnalyzerFunction> _logger;

        public EmailAnalyzerFunction(ILogger<EmailAnalyzerFunction> logger)
        {
            _logger = logger;
        }


        [Function("EmailAnalyzer")]
        public static async Task<IActionResult> Run(
        [HttpTrigger(AuthorizationLevel.Function, "post")] HttpRequest req,
        ILogger log)
        {
            log.LogInformation("EmailAnalyzer function triggered.");

            string body = await new StreamReader(req.Body).ReadToEndAsync();

            var email = JsonConvert.DeserializeObject<EmailModel>(body);

            var summary = $"Subject: {email.Subject} | Length: {email.Body.Length} characters";

            return new OkObjectResult(new { message = "Processed", result = summary });
        }

    }

    public class EmailModel
    {
        public string Subject { get; set; }
        public string Body { get; set; }
    }
}
