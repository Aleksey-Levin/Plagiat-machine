namespace KysectAcademyTask;

internal class SymbolBySymbol : ITextCompare
{
    private bool _includeSpace;

    public SymbolBySymbol(bool includeSpace = false)
    {
        _includeSpace = includeSpace;
    }
    public float CompareTextAlgorithm(string firstString, string secondString)
    {
        char[] wordsOfFirstText;
        char[] wordsOfSecondText;

        if (!_includeSpace)
        {
            wordsOfFirstText = firstString.Replace(" ", String.Empty).ToArray();
            wordsOfSecondText = secondString.Replace(" ", String.Empty).ToArray();

        }
        else
        {
            wordsOfFirstText = firstString.ToArray();
            wordsOfSecondText = secondString.ToArray();
        }

        float diffCount = 0;
        float minLength = Math.Min(wordsOfFirstText.Length, wordsOfSecondText.Length);
        for (int i = 0; i < minLength; i++)
        {
            if (wordsOfFirstText[i] == wordsOfSecondText[i]) continue;
            diffCount++;
        }
        float coincidencePercent = ((minLength - diffCount) / Math.Max(wordsOfFirstText.Length, wordsOfSecondText.Length)) * 100;
        return coincidencePercent;
    }
}
