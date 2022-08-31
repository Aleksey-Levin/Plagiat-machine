namespace KysectAcademyTask;
internal interface IFileWritter
{
    void Write(List<SubmitCompareResultStruct> content, string path = "");
}
