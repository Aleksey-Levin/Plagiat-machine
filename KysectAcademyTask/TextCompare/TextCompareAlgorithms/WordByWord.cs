namespace KysectAcademyTask;

internal class WordByWord : ITextCompare
{
    public float CompareTextAlgorithm(string firstString, string secondString)
    {
        string[] wordsOfFirstText;
        string[] wordsOfSecondText;

        wordsOfFirstText = firstString.Split(' ');
        wordsOfSecondText = secondString.Split(' ');

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
