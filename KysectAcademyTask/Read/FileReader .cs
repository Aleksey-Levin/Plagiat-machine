namespace KysectAcademyTask;
internal class FileReader
{
    private List<string> _texts;

    public FileReader()
    {
        _texts = new List<string>();
    }

    public List<string> ReadFilesWithParse(List<string> pathForFiles)
    {
        Console.WriteLine("Start read file");
        for (int i = 0; i < pathForFiles.Count; i++)
        {
            Console.WriteLine($"Read Files - {(((i + 0.0F) / (pathForFiles.Count) * 100))}%");
            _texts.Add(String.Concat(File.ReadAllLines(pathForFiles[i])));
        }

        return _texts;
    }
}
