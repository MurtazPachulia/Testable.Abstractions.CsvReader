using CsvHelper.Configuration;
using System.Globalization;

namespace Testable.Abstractions.CsvReader;

public class CsvReaderWrapper : ICsvReaderWrapper
{
    public List<T> GetRecords<T>(string path)
    {
        var config = new CsvConfiguration(CultureInfo.InvariantCulture)
        {
            HasHeaderRecord = true,
        };

        var streamReader = new StreamReader(path);
        var csv = new CsvHelper.CsvReader(streamReader, config);
        return csv.GetRecords<T>().ToList();
    }
}
