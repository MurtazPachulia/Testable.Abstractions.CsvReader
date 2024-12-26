namespace Testable.Abstractions.CsvReader;

public interface ICsvReaderWrapper
{
    List<T> GetRecords<T>(string path);
}
