using System.Data.SqlClient;

namespace DataLayer
{
    /// <summary>
    /// An interface that describes a type (class) that can accept a data
    /// reader instance (assuming the class has been modeled based on records
    /// in the table the data has been extracted from) and populate its own
    /// fields with the fields from the current position of the reader.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface ILoadable<out T>
    {
        T Load(SqlDataReader reader);
    }
}
