using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace DataLayer
{
    /// <summary>
    /// A helper class that allows interaction with the database.
    /// </summary>
    public static class Database
    {
        #region Private Fields

        private static SqlConnection _connection;

        #endregion

        #region Public Fields

        public static string ApplicationName { get; set; }

        public static string ConnectionString
        {
            get
            {
                // get the connection string for the App.config file
                string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ToString();

                // create a SQL connection string builder to allow easy modification
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(connectionString);

                // update the application name
                builder.ApplicationName = ApplicationName ?? builder.ApplicationName;

                // update the timeout setting
                builder.ConnectTimeout = ConnectionTimeout > 0 ? ConnectionTimeout : builder.ConnectTimeout;

                var workingDirectory = Environment.CurrentDirectory;

                var dbDirectory = workingDirectory.Substring(0, workingDirectory.IndexOf("bin", StringComparison.OrdinalIgnoreCase));

                builder.AttachDBFilename = Path.Combine(dbDirectory, "VehicleDatabase.mdf");

                // return the resulting connection string
                return builder.ToString();
            }
        }

        public static int ConnectionTimeout { get; set; }

        public static SqlConnection Connection
        {
            get
            {
                // check to see if the connection has not yet been created
                if (null == _connection)
                {
                    // create if not
                    _connection = new SqlConnection(ConnectionString);
                }

                // check to see if the connection is open
                if (ConnectionState.Open != _connection.State)
                {
                    // open if not
                    _connection.Open();
                }

                // return the connection
                return _connection;
            }
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Execute a create query.
        /// </summary>
        /// <param name="query">The query string</param>
        /// <returns>The number of records affected</returns>
        public static int Create(string query)
        {
            return ExecuteNonQuery(query);
        }

        /// <summary>
        /// Execute a read (SELECT) query.
        /// </summary>
        /// <typeparam name="T">The type of items expected to be loaded from the database</typeparam>
        /// <param name="query">The query as a string</param>
        /// <returns>A <see cref="List{T}"/> of the results</returns>
        public static List<T> Read<T>(string query)
            where T : ILoadable<T>, new()   // Note: we put constraints on the generic type,
                                            // it must implement ILoadable<T>
                                            // and have a default constructor (i.e. new()).
        {
            // create a list to hold the results
            List<T> results = new List<T>();

            // create an SqlCommand in a using block to ensure it is disposed
            // after use
            using (SqlCommand command = new SqlCommand(query, Connection))
            {
                // execute the command and capture the SqlDataReader in a using
                // block to ensure it is disposed after use
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    // while there are records (rows) to read...
                    while (reader.Read())
                    {
                        // create a new instance of the type specified
                        T instance = new T();

                        // add it the the results list
                        results.Add(instance.Load(reader));
                    }
                }
            }

            // return the results
            return results;
        }

        /// <summary>
        /// Execute and update query.
        /// </summary>
        /// <param name="query">The query as a string</param>
        /// <returns>The number of records affected</returns>
        public static int Update(string query)
        {
            return ExecuteNonQuery(query);
        }

        /// <summary>
        /// Execute and delete query.
        /// </summary>
        /// <param name="query">The query as a string</param>
        /// <returns>The number of records affected</returns>
        public static int Delete(string query)
        {
            return ExecuteNonQuery(query);
        }

        /// <summary>
        /// Call this method when done using the connection.
        /// </summary>
        public static void OnClosing()
        {
            // make sure the connection is not null
            if (null != _connection)
            {
                // close...
                _connection.Close();

                // ...and dispose
                _connection.Dispose();
            }
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Execute a SQL statement that does not return records.
        /// </summary>
        /// <param name="query">The query as a string</param>
        /// <returns>The number of records affected</returns>
        private static int ExecuteNonQuery(string query)
        {
            // create an SqlCommand in a using block to ensure it is disposed
            // after use
            using (SqlCommand command = new SqlCommand(query, Connection))
            {
                int recordsAffected = command.ExecuteNonQuery();

                return recordsAffected;
            }
        }

        #endregion
    }
}
