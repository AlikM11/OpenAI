using OpenAI.GPT3.Extensions;
using OpenAI.Services;

namespace OpenAI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IHost host = Host.CreateDefaultBuilder(args)
                .ConfigureServices(services =>
                {
                    services.AddOpenAIService(settings => settings.ApiKey = "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");
                    //services.AddHostedService<OpenAiComplitionService>();
                    services.AddHostedService<OpenAiImageService>();
                })
                .Build();

            host.Run();
        }
    }
}