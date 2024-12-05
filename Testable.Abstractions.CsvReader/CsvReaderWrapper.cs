using System.Globalization;

namespace Testable.Abstractions.CsvReader;

public class CsvReaderWrapper : ICsvReaderWrapper
{
    public IEnumerable<T> GetRecords<T>(string path)
    {
        var streamReader = new StreamReader(path);
        var csv = new CsvHelper.CsvReader(streamReader, CultureInfo.InvariantCulture);
        return csv.GetRecords<T>();
    }
}
