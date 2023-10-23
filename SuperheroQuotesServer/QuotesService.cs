
using System.Text.Json;

internal class QuotesService
{
    private static Random random = new Random();

    private readonly IEnumerable<Quote> Quotes = InitializeQuotes<Quote>();

    private static IEnumerable<T> InitializeQuotes<T>() {
        
        string text = File.ReadAllText("quotes.json");
        IEnumerable<T>? result = JsonSerializer.Deserialize<IEnumerable<T>>(text);

        if (result == null)
            throw new Exception("Deserialization returned null");

        return result;
    }

    internal Quote GetRandomQuote()
    {
        return new Quote(
            "Batman" + random.Next(1, 100),
            "I'm Batman" + random.Next(1, 100)
        );
    }
}
