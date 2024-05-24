using Dapper;
using Microsoft.Data.Sqlite;
using System.Configuration;
using System.Data;

namespace PayrollLibrary.Data_Access;

public class SqliteDataAccess<T>
{
    static SqliteDataAccess()
    {
        SqlMapper.AddTypeHandler(new DateOnlyTypeHandler());
    }

    private static string GetTableName()
    {
        return $"{typeof(T).Name}s";
    }

    private static List<string> GetColumnNames(bool excludeID = false)
    {
        List<string> properties = new List<string>();
        var currentType = typeof(T);
        if (currentType != null)
        {
            var customProperties = currentType.GetCustomProperties();
            foreach (var customProperty in customProperties)
            {
                var propertyName = customProperty.Name;
                if (propertyName == "ID" && excludeID)
                    continue;
                properties.Add(propertyName);
            }
        }
        return properties;
    }

    private static List<string> GetColumnPlaceholder(List<string> columnNames)
    {
        return columnNames.Select(s => $"@{s}").ToList();
    }

    public static int Update(T obj)
    {
        var columnNames = GetColumnNames(excludeID: true);
        var tableName = GetTableName();
        var assignedColumnNames = columnNames.Select(str => $"{str} = @{str}").ToList();


        string query = $"UPDATE {tableName} SET {string.Join(',', assignedColumnNames)} WHERE ID = @ID";
        return Execute(query, obj);
    }

    public static int Insert(T obj)
    {
        var columnNames = GetColumnNames(excludeID: true);
        var tableName = GetTableName();
        var columnPlaceholder = GetColumnPlaceholder(columnNames);

        string query = $"INSERT INTO {tableName}({string.Join(',', columnNames)}) VALUES({string.Join(',', columnPlaceholder)})";
        return Execute(query, obj);
    }

    public static int Delete(int id)
    {
        var tableName = GetTableName();
        return Execute($"DELETE FROM {tableName} WHERE ID = @ID", new { ID = id });
    }


    public static int Execute(string query, object? param)
    {
        using (IDbConnection connection = new SqliteConnection(LoadConnectionString()))
        {
            connection.Open();
            return connection.Execute(query, param);
        }
    }



    public static List<T> Query(string sql, object? param)
    {
        using (IDbConnection connection = new SqliteConnection(LoadConnectionString()))
        {
            connection.Open();
            return connection.Query<T>(sql, param).ToList();
        }
    }

    public static T? QueryFirstOrDefault(string sql, object? param)
    {
        string table = GetTableName();
        using (IDbConnection connection = new SqliteConnection(LoadConnectionString()))
        {
            connection.Open();
            return connection.QueryFirstOrDefault<T>(sql, param);
        }
    }

    public static List<T> GetAll()
    {
        string table = GetTableName();
        using (IDbConnection connection = new SqliteConnection(LoadConnectionString()))
        {
            connection.Open();
            return connection.Query<T>($"SELECT * FROM {table}").ToList();
        }
    }

    public static T? GetById(int id)
    {
        string table = GetTableName();
        using (IDbConnection connection = new SqliteConnection(LoadConnectionString()))
        {
            connection.Open();
            return connection.QueryFirstOrDefault<T>($"SELECT * FROM {table} WHERE id = @ID", new { ID = id });
        }
    }

    private static string LoadConnectionString(string id = "Default")
    {
        return ConfigurationManager.ConnectionStrings[id].ConnectionString;
    }
}
