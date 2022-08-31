namespace KysectAcademyTask;
internal class SubmitInfo
{
    public List<FilePathInfo> Submits { get; set; }
    public string AuthorName { get; private set; }
    public SubmitInfo(string authorName)
    {
        Submits = new List<FilePathInfo>();
        AuthorName = authorName;
    }
}
