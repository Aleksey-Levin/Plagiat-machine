using Microsoft.Extensions.Configuration;
namespace KysectAcademyTask;
internal class FileSettings
{
    private string _filePath;

    public FileSettings(string pathFile)
    {
        _filePath = pathFile;
    }

    public IConfigurationSection ReadAppsettings()
    {
        IConfigurationRoot config = new ConfigurationBuilder()
        .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
        .AddJsonFile(_filePath).Build();

        IConfigurationSection section = config.GetSection(nameof(TextCompareConfig));

        return section;
    }

}
