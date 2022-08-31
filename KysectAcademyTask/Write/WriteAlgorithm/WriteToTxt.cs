namespace KysectAcademyTask;
internal class WriteToTxt : IFileWritter
{
    public void Write(List<SubmitCompareResultStruct> content, string path = "")
    {
        using (var writer = new StreamWriter(path + ".txt", false))
        {
            foreach (SubmitCompareResultStruct result in content)
            {
                 writer.WriteLine($@"{result.FirstSubmit[0].NameAuthor}: {result.FirstSubmit[0].DateLab} and {result.SecondSubmit[0].NameAuthor}: {result.SecondSubmit[0].DateLab} have {result.ValueCompare}%");
            }
            writer.Close();
        }
    }
}
