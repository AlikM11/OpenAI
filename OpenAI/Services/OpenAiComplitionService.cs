using OpenAI.GPT3.Interfaces;
using OpenAI.GPT3.ObjectModels;
using OpenAI.GPT3.ObjectModels.RequestModels;

namespace OpenAI.Services
{
    internal class OpenAiComplitionService : BackgroundService
    {
        readonly IOpenAIService _service;

        public OpenAiComplitionService(IOpenAIService service)
        {
            _service = service;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (true)
            {
                Console.OutputEncoding = System.Text.Encoding.UTF8;
                Console.Write("::");
                var result = await _service.Completions.CreateCompletion(new CompletionCreateRequest()
                {
                    Prompt = Console.ReadLine(),
                    MaxTokens = 500
                },Models.TextDavinciV3);
                Console.WriteLine(result.Choices[0].Text);

            }
        }
    }
}
