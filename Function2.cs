using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace AzureFunctionTest
{
    public static class Function2
    {
        [FunctionName("Function2")]
        public static void Run([TimerTrigger("0 */1 * * * *")]TimerInfo myTimer, ILogger log)
        {
            log.LogInformation($"2. C# Timer trigger function executed at: {DateTime.Now}");
        }
    }
}
