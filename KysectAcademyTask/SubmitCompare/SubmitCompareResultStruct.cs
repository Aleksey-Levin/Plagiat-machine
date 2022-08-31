namespace KysectAcademyTask;
internal class SubmitCompareResultStruct
{
    public List<FilePathInfo> FirstSubmit { get; private set; }
    public List<FilePathInfo> SecondSubmit { get; private set; }
    public float ValueCompare { get; private set; }

    public SubmitCompareResultStruct(List<FilePathInfo> firstSubmit, List<FilePathInfo> secondSubmit, float valueCompare)
    {
        FirstSubmit = firstSubmit;
        SecondSubmit = secondSubmit;
        ValueCompare = valueCompare;
    }
}
