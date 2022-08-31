namespace KysectAcademyTask;
internal class AlgorithmSelection
{
    public ITextCompare AlgorithmCompareSelection(string algorithm)
    {
        ITextCompare result = algorithm switch
        {
            "Symbol by Symbol" => new SymbolBySymbol(),
            "Word by Word" => new WordByWord(),
            _ => throw new Exception("Incorrect Compare alghoritm")
        };
        return result;
    }

    public IFileWritter AlgorithmWriteSelection(string algorithm)
    {
        IFileWritter result = algorithm switch
        {
            "JSON" => new WriteToJson(),
            "TXT" => new WriteToTxt(),
            "CONSOLE" => new WriteToConsole(),
            _ => throw new Exception("Incorrect Write alghoritm")
        };
        return result;
    }
}
