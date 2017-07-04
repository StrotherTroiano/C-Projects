using DataLayer;
using System;
using System.Data.SqlClient;

namespace DataModel
{
    /// <summary>
    /// A data model representing a vehicle from the Vehicle table.
    /// </summary>
    public class Vehicle : ILoadable<Vehicle>
    {
        #region Private Fields

        private const char Delimiter = '\t';

        #endregion

        #region Public Properties

        public int Id { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }

        public int Year { get; set; }

        public string Color { get; set; }

        public int Cylinders { get; set; }

        #endregion

        #region ILoadable<Vehicle> Implementation

        /// <summary>
        /// Create an instance of a <see cref="Vehicle"/> given a <see cref="SqlDataReader"/>.
        /// </summary>
        /// <param name="reader">A <see cref="SqlDataReader"/> containing query results from the vehicle database.</param>
        /// <returns>An instance of a <see cref="Vehicle"/></returns>
        public Vehicle Load(SqlDataReader reader)
        {
            Vehicle vehicle = new Vehicle
            {
                // load the fields from the reader using the vehicle database schema
                Id = (int)reader[VehicleTableSchema.IdField],
                Make = reader[VehicleTableSchema.MakeField].ToString(),
                Model = reader[VehicleTableSchema.ModelField].ToString(),
                Year = (int)reader[VehicleTableSchema.YearField],
                Color = reader[VehicleTableSchema.ColorField].ToString(),
                Cylinders = (int)reader[VehicleTableSchema.CylindersField]
            };

            return vehicle;
        }

        #endregion

        #region Public Static Helper Methods

        /// <summary>
        /// Given a string formatted via the <see cref="Vehicle"/> ToString
        /// method, parse and create an instance.
        /// </summary>
        /// <param name="fromString">A string formatted via the <see cref="Vehicle"/> ToString method</param>
        /// <returns>An instance of a <see cref="Vehicle"/></returns>
        public static Vehicle ToVehicle(string fromString)
        {
            string[] elements = fromString.Split(Delimiter);

            Vehicle vehicle = new Vehicle
            {
                Id = Int32.Parse(elements[0]),
                Make = elements[1],
                Model = elements[2],
                Year = Int32.Parse(elements[3]),
                Color = elements[4],
                Cylinders = Int32.Parse(elements[5])
            };

            return vehicle;
        }

        #endregion

        #region Public String Methods

        /// <summary>
        /// Convert an instance of a <see cref="Vehicle"/> to a delimited string.
        /// </summary>
        /// <returns>The string representation</returns>
        public override string ToString()
        {
            return $"{Id}{Delimiter}" +
                   $"{Make}{Delimiter}" +
                   $"{Model}{Delimiter}" +
                   $"{Year}{Delimiter}" +
                   $"{Color}{Delimiter}" +
                   $"{Cylinders}";
        }

        /// <summary>
        /// Convert an instance of a <see cref="Vehicle"/> to a string for use in an UPDATE query.
        /// 
        /// For example:
        /// 
        /// UPDATE [dbo].[Vehicles]
        /// SET Make='Toyota',Model='Corolla',Year=2004,Color='White',Cylinders=4
        /// WHERE Id=6
        /// 
        /// </summary>
        /// <returns>The string representation</returns>
        public string ToUpdateString()
        {
            // example return value -> "Make='Toyota',Model='Corolla',Year=2004,Color='White',Cylinders=4"
            return $"{VehicleTableSchema.MakeField}='{Make}'," +
                   $"{VehicleTableSchema.ModelField}='{Model}'," +
                   $"{VehicleTableSchema.YearField}={Year}," +
                   $"{VehicleTableSchema.ColorField}='{Color}'," +
                   $"{VehicleTableSchema.CylindersField}={Cylinders}";
        }

        /// <summary>
        /// Convert an instance of a <see cref="Vehicle"/> to a string for use in an INSERT query.
        /// 
        /// For Example:
        /// 
        /// INSERT [dbo].[Vehicles]
        /// (Make,Model,Year,Color,Cylinders)
        /// VALUES('Audi','A8',2016,'Navy',12)
        /// 
        /// </summary>
        /// <returns>The string representation</returns>
        public string ToValuesString()
        {
            // example return value -> "'Audi','A8',2016,'Navy',12"
            return $"'{Make}'," +
                   $"'{Model}'," +
                   $"{Year}," +
                   $"'{Color}'," +
                   $"{Cylinders}";
        }

        public string ToWhereClause(bool matchAll)
        {
            bool conditionAdded = false;

            string query = string.Empty;

            if (!string.IsNullOrWhiteSpace(Make))
            {
                query += $"{VehicleTableSchema.MakeField}='{Make}'";

                conditionAdded = true;
            }

            if (!string.IsNullOrWhiteSpace(Model))
            {
                if (conditionAdded)
                {
                    query += matchAll ? " AND " : " OR ";
                }

                query += $"{VehicleTableSchema.ModelField}='{Model}'";

                conditionAdded = true;
            }

            if (-1 != Year)
            {
                if (conditionAdded)
                {
                    query += matchAll ? " AND " : " OR ";
                }

                query += $"{VehicleTableSchema.YearField}={Year}";

                conditionAdded = true;
            }

            if (!string.IsNullOrWhiteSpace(Color))
            {
                if (conditionAdded)
                {
                    query += matchAll ? " AND " : " OR ";
                }

                query += $"{VehicleTableSchema.ColorField}='{Color}'";

                conditionAdded = true;
            }

            if (-1 != Cylinders)
            {
                if (conditionAdded)
                {
                    query += matchAll ? " AND " : " OR ";
                }

                query += $"{VehicleTableSchema.CylindersField}={Cylinders}";
            }

            return query;
        }

        #endregion
    }
}
