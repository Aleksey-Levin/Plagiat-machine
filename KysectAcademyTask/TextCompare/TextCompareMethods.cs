namespace KysectAcademyTask;

internal class TextCompareMethods
{
    private string _filePath;
    private List<string> _content;
    private List<string> _paths;
    private FileFilter _filter;

    public TextCompareMethods(string filePath, FileFilter fileFilter)
    {
        if (filePath == null) throw new ArgumentNullException();
        _filePath = filePath;
        _paths = new List<string>();
        _content = new List<string>();
        _filter = fileFilter;
    }
    public List<SubmitCompareResultStruct> CompareText(ITextCompare ItextCompare, FileFilter fileFilter)
    {

        var fileReader = new FileReader();
        _paths = fileFilter.Filter(Directory.EnumerateFiles(_filePath, "", SearchOption.AllDirectories).ToList());
        _content = fileReader.ReadFilesWithParse(_paths);

        var filePathGenerator = new FilePathsGenerator(_paths);
        var textCompareAlghoritmManager = new SeparatePath(filePathGenerator.Generate());
        List<SubmitInfo> resulrAgorithmManager = textCompareAlghoritmManager.Manage();
        var submitCompare = new SubmitCompare(ItextCompare, resulrAgorithmManager);
        List<SubmitCompareResultStruct> result = submitCompare.Compare();
        return result;
    }
}
