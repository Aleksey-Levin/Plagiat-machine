namespace KysectAcademyTask;

internal class TextCompareConfig
{
    public string FilePaths { get; set; }
    public string TypeOfComparison { get; set; }
    public bool IncludeSpace { get; set; }
    public FileFilters fileFilters { get; set; }
    public AuthorFilters authorFilters { get; set; }
    public WorkNames workNames { get; set; }
    public Report report { get; set; }
    public class FileFilters
    {
        public List<string> ExtensionWhiteList { get; set; }
        public List<string> DirectoryBlackList { get; set; }
    }

    public class AuthorFilters
    {
        public List<string> WhiteList { get; set; }
        public List<string> BlackList { get; set; }
    }

    public class Report
    {
        public string Path { get; set; }
        public string Type { get; set; }
    }

    public class WorkNames
    {
        public List<string> WhiteList { get; set; }
        public List<string> BlackList { get; set; }
    }
}
