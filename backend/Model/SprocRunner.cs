using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class SprocRunner
    {
        private SqlConnection _connection;
        public SprocRunner(string connectionString)
        {
            _connection = new SqlConnection(connectionString);
            _connection.Open();
        }

        public async Task<T> RunQueryAsync<T>(string sprocName, SqlParameter[] sqlParams, Func<SqlDataReader, T> func)
        {
            var command = new SqlCommand(sprocName, _connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            foreach (var sqlParam in sqlParams)
            {
                command.Parameters.Add(sqlParam);
            }
            var reader = await command.ExecuteReaderAsync();
            var result = func(reader);
            reader.Close();
            return result;
        }

        public T RunQuery<T>(string sprocName, SqlParameter[] sqlParams, Func<SqlDataReader, T> func)
        {
            var command = new SqlCommand(sprocName, _connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            foreach (var sqlParam in sqlParams)
            {
                command.Parameters.Add(sqlParam);
            }
            var reader = command.ExecuteReader();
            var result = func(reader);
            reader.Close();
            return result;
        }

        ~SprocRunner()
        {
            _connection.Close();
        }
    }
}
