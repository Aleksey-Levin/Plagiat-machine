namespace KysectAcademyTask;
internal class SubmitCompare
{
    private ITextCompare _iTextCompare;

    private List<SubmitInfo> _contentList;

    public SubmitCompare(ITextCompare iTextCompare, List<SubmitInfo> contentList)
    {
        _iTextCompare = iTextCompare;
        _contentList = contentList;
    }

    public List <SubmitCompareResultStruct> Compare()
    {
        var result = new List<SubmitCompareResultStruct>();
        for (int i = 0; i < _contentList.Count; i++)
        {
            for (int j = 0; j < _contentList.Count; j++)
            {
                Console.WriteLine($"Процент выполнения - {((((i * _contentList.Count + j + 0.0F) / (_contentList.Count * _contentList.Count)) * 100))}%");
                if (_contentList[i].AuthorName != _contentList[j].AuthorName) result.Add(_pairCompare(_contentList[i].Submits, _contentList[j].Submits));
            }
        }
        return result;
    }

    private SubmitCompareResultStruct _pairCompare(List<FilePathInfo> submit1, List<FilePathInfo> submit2)
    {
        float tempProc = 0;
        float result;
        for (int i = 0; i < submit1.Count; i++)
        {
            for (int j = 0; j < submit2.Count; j++)
            {
                tempProc += _iTextCompare.CompareTextAlgorithm(submit1[i].Content, submit2[j].Content);
            }
        }
        result = (tempProc) / (submit1.Count + submit2.Count);
        var submitCompareResult = new SubmitCompareResultStruct(submit1, submit2, result);
        return submitCompareResult;
    }
}
