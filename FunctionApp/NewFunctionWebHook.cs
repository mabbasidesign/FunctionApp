using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;
using System.Net;

namespace FunctionApp
{
    public class NewFunctionWebHook
    {
        private readonly ILogger<NewFunctionWebHook> _logger;

        public NewFunctionWebHook(ILogger<NewFunctionWebHook> logger)
        {
            _logger = logger;
        }

        [Function(nameof(NewFunctionWebHook))]
        public async Task<HttpResponseData> Run(
                [HttpTrigger(AuthorizationLevel.Function, "Get", Route = "Purchase")] HttpRequestData req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");

            // read body
            var body = await new StreamReader(req.Body).ReadToEndAsync();

            var name = req.Query.Get("name") ?? "Anonymous";
            Console.WriteLine($"Name: {name}, Body: {body}");

            // create response using the helper you wanted
            var response = req.CreateResponse(HttpStatusCode.OK);
            await response.WriteStringAsync("Welcome to Azure Functions!");

            response.Headers.Add("Content-Type", "text/plain");
            return response;
        }


        [Function(nameof(GetPurchase))]
        public async Task<HttpResponseData> GetPurchase(
                [HttpTrigger(AuthorizationLevel.Function, "post", Route = "Purchase")] HttpRequestData req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");

            // read body
            var body = await new StreamReader(req.Body).ReadToEndAsync();

            var name = req.Query.Get("name") ?? "Anonymous";
            Console.WriteLine($"Name: {name}, Body: {body}");

            // create response using the helper you wanted
            var response = req.CreateResponse(HttpStatusCode.OK);
            await response.WriteStringAsync("Welcome to Azure Functions!");

            response.Headers.Add("Content-Type", "text/plain");
            return response;
        }

    }
}
