
namespace DataAccess.DBAccess
{
    public interface ISqlDataAccess
    {
        Task<IEnumerable<T>> LoadData<T, U>(string sql, U parameters);
        Task SaveData<T>(string sql, T data);
    }
}