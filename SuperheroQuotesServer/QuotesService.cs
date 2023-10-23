
internal class QuotesService
{
    private static Random random = new Random();

    internal Quote GetRandomQuote()
    {
        return new Quote(
            "Batman" + random.Next(1, 100),
            "I'm Batman" + random.Next(1, 100)
        );
    }
}
