using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AdoNet_Example
{
    internal class AdonetUtility
    {
        private readonly string _connectionString;
        public AdonetUtility(string connectionString)
        {
            _connectionString = connectionString;
        }
        public void RunSql(string sql, Dictionary<string, object> parameters)
        {
            using SqlConnection sqlConnection = new SqlConnection(_connectionString);
            using SqlCommand sqlCommand = new SqlCommand(sql,sqlConnection);

            foreach (var parameter in parameters)
            {
                sqlCommand.Parameters.Add(new SqlParameter(parameter.Key, parameter.Value));
            }

            if (sqlConnection.State != System.Data.ConnectionState.Open)
            {
                sqlConnection.Open();
            }
            
            int rowExpected = sqlCommand.ExecuteNonQuery();
        }

        public List<Dictionary<string, object>> GetData(string sql, Dictionary<string,object> parameters)
        {
            using SqlConnection sqlConnection = new SqlConnection(_connectionString);
            using SqlCommand sqlCommand = new SqlCommand( sql,sqlConnection);

            foreach (var parameter in parameters)
            {
                sqlCommand.Parameters.Add(new SqlParameter(parameter.Key,parameter.Value));
            }
            

            if (sqlConnection.State != System.Data.ConnectionState.Open)
            {
                sqlConnection.Open();
            }
            SqlDataReader reader =  sqlCommand.ExecuteReader();
            List<Dictionary<string,object>> result = new List<Dictionary<string, object>>();
            while(reader.Read())
            {
                Dictionary<string, object> row = new Dictionary<string, object>();
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    string name = reader.GetName(i);
                    object value = reader.GetValue(i);
                    row.Add(name, value);
                }
                result.Add(row);
            }
            return result;
        }
    }
}
