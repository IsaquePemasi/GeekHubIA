using GeekHubIA.Shared;
using OpenAI_API;
using OpenAI_API.Completions;

namespace GeekHubIA.Services
{

    public class AnswerGeneratorService : IAnswerGeneratorService
    {
         
        public async Task<string> GenerateAnswer(string prompt)
        {

            string apiKey = "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";
            string answer = string.Empty;

            var openai = new OpenAIAPI(apiKey);
            CompletionRequest completion = new CompletionRequest();
            completion.Prompt = prompt;
            completion.MaxTokens = 4000;
            var result = await openai.Completions.CreateCompletionsAsync(completion);
            if (result != null)
            {
                foreach (var item in result.Completions)
                {
                    answer = item.Text;
                }
            }
            return answer;


        }

    }
   
    
}
