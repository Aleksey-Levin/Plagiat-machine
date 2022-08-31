namespace KysectAcademyTask;
internal class FileWritter
{
    public void WriteAsync(string path, string type, List<SubmitCompareResultStruct> content)
    {

        IFileWritter MethodCompare = new AlgorithmSelection().AlgorithmWriteSelection(type);

        MethodCompare.Write(content, path);
    }
}
