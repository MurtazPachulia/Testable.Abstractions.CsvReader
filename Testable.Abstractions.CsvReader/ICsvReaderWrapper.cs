namespace Testable.Abstractions.CsvReader;

public interface ICsvReaderWrapper
{
    IEnumerable<T> GetRecords<T>(string path);
}
