namespace KysectAcademyTask;
internal class WriteToConsole : IFileWritter
{
    public void Write(List<SubmitCompareResultStruct> _result, string path = "")
    {

        foreach (SubmitCompareResultStruct result in _result)
        {
            Console.WriteLine($@"{result.FirstSubmit[0].NameAuthor}: {result.FirstSubmit[0].DateLab} and {result.SecondSubmit[0].NameAuthor}: {result.SecondSubmit[0].DateLab} have {result.ValueCompare}%"); ;
        }
    }
}
