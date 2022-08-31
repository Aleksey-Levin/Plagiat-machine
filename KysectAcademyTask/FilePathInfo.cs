namespace KysectAcademyTask;
internal class FilePathInfo
{
    public string NumberGroup { get; private set; }
    public string NameAuthor { get; private set; }
    public string NameLab { get; private set; }
    public string DateLab { get; private set; }
    public string NameFile { get; private set; }
    public string Path { get; private set; }
    public string Content { get; private set; }
    public FilePathInfo(string path, string content)
    {
        NumberGroup = splitPath(path, "NumberGroup");
        NameAuthor = splitPath(path, "NameAuthor");
        NameLab = splitPath(path, "nameLab");
        DateLab = splitPath(path, "dateLab");
        NameFile = splitPath(path, "nameFile");
        Path = path;
        Content = content;
    }

    private string splitPath(string path, string needed)
    {
        var partsPath = path.Split(@"\").ToList();
        string result = needed switch
        {
            "NumberGroup" => partsPath[partsPath.Count - 5],
            "NameAuthor" => partsPath[partsPath.Count - 4],
            "nameLab" => partsPath[partsPath.Count - 3],
            "dateLab" => partsPath[partsPath.Count - 2],
            "nameFile" => partsPath[partsPath.Count - 1],
            _ => throw new Exception("Incorrect split param")
        };
        return result;
    }
}
