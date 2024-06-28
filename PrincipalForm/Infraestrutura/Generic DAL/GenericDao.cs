using Microsoft.Data.SqlClient;
using Infraestrutura.Factory;
using System;
using System.Collections.Generic;
using System.Data;

namespace Infraestrutura.Generic_DAL
{
    public class GenericDAO<T>
    {
        protected readonly DbConnectionFactory dbConnectionFactory;

        public GenericDAO(DbConnectionFactory dbConnectionFactory)
        {
            this.dbConnectionFactory = dbConnectionFactory;
        }

        protected virtual T Map(IDataRecord record)
        {
            throw new NotImplementedException("Map method must be implemented in derived class.");
        }

        public virtual List<T> GetAll()
        {
            List<T> items = new List<T>();
            using (var connection = dbConnectionFactory.CreateConnection())
            {
                connection.Open();
                string tableName = GetTableName();
                string query = $"SELECT * FROM {tableName}";
                SqlCommand command = new SqlCommand(query, connection);
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        items.Add(Map(reader));
                    }
                }
            }
            return items;
        }

        public virtual T GetById(int id)
        {
            using (var connection = dbConnectionFactory.CreateConnection())
            {
                connection.Open();
                string tableName = GetTableName();
                string query = $"SELECT * FROM {tableName} WHERE Id = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return Map(reader);
                    }
                }
            }
            return default(T);
        }

        public virtual bool Delete(int id)
        {
            using (var connection = dbConnectionFactory.CreateConnection())
            {
                connection.Open();
                string tableName = GetTableName();
                string query = $"DELETE FROM {tableName} WHERE Id = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }

        public virtual bool Update(T entity, int id, string field)
        {
            using (var connection = dbConnectionFactory.CreateConnection())
            {
                connection.Open();
                string tableName = GetTableName();
                string query = $"UPDATE {tableName} SET {field} WHERE Id = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }

        public virtual T SelectWhereOne(string condition)
        {
            using (var connection = dbConnectionFactory.CreateConnection())
            {
                connection.Open();
                string tableName = GetTableName();
                string query = $"SELECT TOP 1 * FROM {tableName} WHERE {condition}";
                SqlCommand command = new SqlCommand(query, connection);
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return Map(reader);
                    }
                }
            }
            return default(T);
        }

        public virtual List<T> SelectWhere(string condition)
        {
            List<T> items = new List<T>();
            using (var connection = dbConnectionFactory.CreateConnection())
            {
                connection.Open();
                string tableName = GetTableName();
                string query = $"SELECT * FROM {tableName} WHERE {condition}";
                SqlCommand command = new SqlCommand(query, connection);
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        items.Add(Map(reader));
                    }
                }
            }
            return items;
        }

        protected virtual string GetTableName()
        {
            return typeof(T).Name;
        }
    }
}
