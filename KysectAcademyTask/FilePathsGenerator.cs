namespace KysectAcademyTask;
internal class FilePathsGenerator
{
    private List<string> _paths;

    public FilePathsGenerator(List<string> paths)
    {
        _paths = paths;
    }

    public List<FilePathInfo> Generate()
    {
        var filePaths = new List<FilePathInfo>();
        foreach(string path in _paths)
        {
            filePaths.Add(new FilePathInfo(path, String.Concat(File.ReadAllLines(path))));
        }
        return filePaths;
    }
}
