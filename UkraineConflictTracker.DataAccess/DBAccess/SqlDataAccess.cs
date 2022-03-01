using Dapper;
using System.Data;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace DataAccess.DBAccess;
public class SqlDataAccess : ISqlDataAccess
{
    private readonly string _dbConName = "Default";
    private readonly IConfiguration _config;
    public SqlDataAccess(IConfiguration config)
    {
        _config = config;
    }

    public async Task<IEnumerable<T>> LoadData<T, U>(string sql, U parameters)
    {
        var connectionString = _config.GetConnectionString(_dbConName);

        using (var connection = new MySqlConnection(connectionString))
        {
            return await connection.QueryAsync<T>(sql, parameters);
        }
    }

    public async Task SaveData<T>(string sql, T data)
    {
        var connectionString = _config.GetConnectionString(_dbConName);

        using (var connection = new MySqlConnection(connectionString))
        {
            await connection.ExecuteAsync(sql, data);
        }
    }
}
