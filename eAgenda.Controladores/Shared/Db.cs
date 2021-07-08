using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.SQLite;

namespace eAgenda.Controladores.Shared
{
    public delegate T ConverterDelegate<T>(IDataReader reader);

    public static class Db
    {
        private static string connectionString = "";
        private static string banco = "";
        private static IDbCommand command;
        private static IDbConnection connection;

        static Db()
        {
            banco = ConfigurationManager.AppSettings["bancoParaUso"];
            connectionString = ConfigurationManager.ConnectionStrings[banco].ConnectionString;

            if (banco == "SQLite")
            {
                connection = new SQLiteConnection(connectionString);
                SQLiteConnection.ClearAllPools();
            }
            else
            {
                connection = new SqlConnection(connectionString);
                SqlConnection.ClearAllPools();
            }
        }

        public static IDbCommand CriaSql(string sql, IDbConnection connection)
        {
            IDbCommand comando;

            if (banco == "SQLite")
            {
                comando = new SQLiteCommand(sql, (SQLiteConnection)connection);
            }
            else
            {
                comando = new SqlCommand(sql, (SqlConnection)connection);
            }

            return comando;
        }

        public static int Insert(string sql, Dictionary<string, object> parameters)
        {
            command = CriaSql(sql.AppendSelectIdentity(), connection);
            foreach (var parameter in parameters)
            {
                string name = parameter.Key;

                object value = parameter.Value.IsNullOrEmpty() ? DBNull.Value : parameter.Value;

                if (banco == "SQLite")
                {
                    SQLiteParameter dbParameter = new SQLiteParameter(name, value);
                    command.Parameters.Add(dbParameter);
                }
                else
                {
                    SqlParameter dbParameter = new SqlParameter(name, value);
                    command.Parameters.Add(dbParameter);
                }
            }
            connection.Open();
            int id = Convert.ToInt32(command.ExecuteScalar());
            connection.Close();
            return id;
        }

        public static void Update(string sql, Dictionary<string, object> parameters = null)
        {
            command = CriaSql(sql, connection);

            connection.Open();

            if (parameters != null)
            {
                foreach (var parameter in parameters)
                {
                    string name = parameter.Key;

                    object value = parameter.Value.IsNullOrEmpty() ? DBNull.Value : parameter.Value;

                    if (banco == "SQLite")
                    {
                        SQLiteParameter dbParameter = new SQLiteParameter(name, value);
                        command.Parameters.Add(dbParameter);
                    }
                    else
                    {
                        SqlParameter dbParameter = new SqlParameter(name, value);
                        command.Parameters.Add(dbParameter);
                    }
                }
            }

            command.ExecuteNonQuery();

            connection.Close();
        }

        public static void Delete(string sql, Dictionary<string, object> parameters)
        {
            Update(sql, parameters);
        }

        public static List<T> GetAll<T>(string sql, ConverterDelegate<T> convert, Dictionary<string, object> parameters = null)
        {
            command = CriaSql(sql, connection);

            connection.Open();

            var list = new List<T>();

            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                var obj = convert(reader);
                list.Add(obj);
            }
            reader.Close();
            connection.Close();
            return list;
        }

        public static T Get<T>(string sql, ConverterDelegate<T> convert, Dictionary<string, object> parameters)
        {
            command = CriaSql(sql, connection);

            if (parameters != null)
            {
                foreach (var parameter in parameters)
                {
                    string name = parameter.Key;

                    object value = parameter.Value.IsNullOrEmpty() ? DBNull.Value : parameter.Value;

                    if (banco == "SQLite")
                    {
                        SQLiteParameter dbParameter = new SQLiteParameter(name, value);
                        command.Parameters.Add(dbParameter);
                    }
                    else
                    {
                        SqlParameter dbParameter = new SqlParameter(name, value);
                        command.Parameters.Add(dbParameter);
                    }
                }
            }

            connection.Open();

            T t = default;

            var reader = command.ExecuteReader();

            if (reader.Read())
                t = convert(reader);

            reader.Close();
            connection.Close();
            return t;
        }

        public static bool Exists(string sql, Dictionary<string, object> parameters)
        {
            command = CriaSql(sql, connection);

            foreach (var parameter in parameters)
            {
                string name = parameter.Key;

                object value = parameter.Value.IsNullOrEmpty() ? DBNull.Value : parameter.Value;

                if(banco == "SQLite")
                    {
                    SQLiteParameter dbParameter = new SQLiteParameter(name, value);
                    command.Parameters.Add(dbParameter);
                }
                    else
                {
                    SqlParameter dbParameter = new SqlParameter(name, value);
                    command.Parameters.Add(dbParameter);
                }
            }

            connection.Open();

            int numberRows = Convert.ToInt32(command.ExecuteScalar());

            connection.Close();

            return numberRows > 0;
        }

        private static string AppendSelectIdentity(this string sql)
        {   
            if(banco == "SQLite")
                return sql + ";SELECT last_insert_rowid()";
            else
                return sql + ";SELECT SCOPE_IDENTITY()";
        }

        public static bool IsNullOrEmpty(this object value)
        {
            return (value is string && string.IsNullOrEmpty((string)value)) ||
                    value == null;
        }

    }
}
