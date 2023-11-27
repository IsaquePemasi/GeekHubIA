namespace GeekHubIA.Services
{
    public interface IAnswerGeneratorService
    {
        Task<string> GenerateAnswer(string prompt);
    }
}
