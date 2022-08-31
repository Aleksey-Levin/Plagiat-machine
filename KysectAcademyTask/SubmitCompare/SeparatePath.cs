namespace KysectAcademyTask;
internal class SeparatePath
{
    private List<FilePathInfo> _filePaths;
    public SeparatePath(List<FilePathInfo> filePaths)
    {
        _filePaths = filePaths;
    }

    public List<SubmitInfo> Manage()
    {
        var result = new List<SubmitInfo>();
        IEnumerable<IEnumerable<FilePathInfo>> tempResult = _filePaths
                            .GroupBy(file => file.DateLab);

        foreach (IEnumerable<FilePathInfo> files in tempResult)
        {
            var temp = new SubmitInfo(files.ToList()[0].NameAuthor);
            Console.WriteLine(files.ToList()[0].NameAuthor);
            foreach (FilePathInfo file in files)
            {
                temp.Submits.Add(file);
            }
            result.Add(temp);
        }

        return result;
    }
}
