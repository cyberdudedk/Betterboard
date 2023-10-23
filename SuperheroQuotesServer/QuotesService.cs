
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
        var index = random.Next(0, Quotes.Count());
        return Quotes.ElementAt(index);
    }
}
