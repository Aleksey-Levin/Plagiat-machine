using Microsoft.Extensions.Configuration;

namespace KysectAcademyTask;

internal class TextCompare
{
    public void RunApp()
    {

        IConfigurationSection section = (new FileSettings("appsettings.json").ReadAppsettings());
        TextCompareConfig textCompareClientConfig = section.Get<TextCompareConfig>();

        var fileFilter = new FileFilter(textCompareClientConfig.fileFilters, textCompareClientConfig.authorFilters, textCompareClientConfig.workNames);
        var textCompare = new TextCompareMethods(textCompareClientConfig.FilePaths, fileFilter);

        ITextCompare methodCompare = new AlgorithmSelection().AlgorithmCompareSelection(textCompareClientConfig.TypeOfComparison);

        Console.WriteLine("Start Compare");

        List<SubmitCompareResultStruct> _result = textCompare.CompareText(methodCompare, fileFilter);

        if (textCompareClientConfig.FilePaths == null) throw new ArgumentNullException();
        
        var fileWritter = new FileWritter();
        fileWritter.WriteAsync(textCompareClientConfig.report.Path, textCompareClientConfig.report.Type, _result);

    }
}
