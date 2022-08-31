using System.Text.RegularExpressions;
using static KysectAcademyTask.TextCompareConfig;

namespace KysectAcademyTask;
internal class FileFilter
{
    private List<string> _whiteList;
    private List<string> _folderBlackList;
    private List<string> _authorWhiteList;
    private List<string> _authorBlackList;
    private List<string> _workNamesBlackList;
    private List<string> _workNamesWhiteList;

    public FileFilter(FileFilters fileFilters, AuthorFilters authorFilters, WorkNames workNames)
    {
        _whiteList = fileFilters.ExtensionWhiteList;
        _folderBlackList = fileFilters.DirectoryBlackList;
        _workNamesBlackList = workNames.BlackList;
        _workNamesWhiteList = workNames.WhiteList;
        _authorBlackList = authorFilters.BlackList;
        _authorWhiteList = authorFilters.WhiteList;
    }

    public List<string> Filter(List<string> inputFiles)
    {
        Console.WriteLine("Filter start");

        var result = inputFiles.Where(file =>
        _whiteList.Any(crit => Regex.IsMatch(file, $@"\w*.{crit}", RegexOptions.IgnoreCase) || crit == "") &&
        _folderBlackList.Any(crit => file.IndexOf(crit) <= 0 || crit == "") &&
        _authorWhiteList.Any(crit => file.IndexOf(crit) > 0 || crit == "") &&
        _authorBlackList.Any(crit => file.IndexOf(crit) <= 0 || crit == "") &&
        _workNamesBlackList.Any(crit => file.IndexOf(crit) <= 0 || crit == "") &&
        _workNamesWhiteList.Any(crit => file.IndexOf(crit) > 0 || crit == "")
        ).ToList();

        Console.WriteLine("Filter end");
        return result;
    }
}
