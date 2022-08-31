using Newtonsoft.Json.Linq;

namespace KysectAcademyTask;
internal class WriteToJson : IFileWritter
{
    public void Write(List<SubmitCompareResultStruct> content, string path = "")
    {


        var result = new JArray();
        var dateArr = new JArray();
        var datetObj = new JObject();
        var dateCompareObj = new JObject();
        var dateCompareArr = new JArray();
        var valueObj = new JObject();

        string lastName = content[0].FirstSubmit[0].NameAuthor;
        string lastDate = content[0].FirstSubmit[0].DateLab;
        for (int i = 0; i < content.Count; i++)
        {
            SubmitCompareResultStruct filePath = content[i];
            if (filePath.FirstSubmit[0].DateLab != lastDate)
            {
                dateCompareObj[lastDate] = dateCompareArr;
                dateArr.Add(dateCompareObj);
                dateCompareArr = new JArray();
                dateCompareObj = new JObject();
                lastDate = filePath.FirstSubmit[0].DateLab; 
            }
            else
            {
                valueObj[filePath.SecondSubmit[0].DateLab] = filePath.ValueCompare;
                dateCompareArr.Add(valueObj);
                valueObj = new JObject();
            }
            if (filePath.FirstSubmit[0].NameAuthor != lastName)
            {
                datetObj[lastName] = dateArr;
                result.Add(datetObj);
                dateArr = new JArray();
                datetObj = new JObject();
                dateArr.Add(dateCompareObj);
                lastName = filePath.FirstSubmit[0].NameAuthor;
            }
        }
        result.Add(datetObj);
        datetObj[lastName] = dateArr;
        var firstLevelResultObj = new JObject();
        firstLevelResultObj["result"] = result;
        string json = firstLevelResultObj.ToString();
        using (var writer = new StreamWriter(path + ".json", false))
            writer.WriteLine(json);
    }
}