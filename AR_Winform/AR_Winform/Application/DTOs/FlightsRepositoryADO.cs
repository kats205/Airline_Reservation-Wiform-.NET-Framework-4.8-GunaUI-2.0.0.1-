using AR_Winform.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;


namespace AR_Winform.Application.DTOs
{
    internal class FlightsRepositoryADO
    {

        private readonly string _connectionString;

        public FlightsRepositoryADO(string connString)
        {
            // Lấy connection string từ app.config
            _connectionString = ConfigurationManager.ConnectionStrings["MyDbContext"].ConnectionString;
        }

        public List<(Flight flight, AR_Winform.Domain.Entities.Airport from, AR_Winform.Domain.Entities.Airport to)> GetFlights(string fromCode, string toCode, DateTime depDate)
        {
            var result = new List<(Flight, AR_Winform.Domain.Entities.Airport, AR_Winform.Domain.Entities.Airport)>();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                string sql = @"
                    SELECT f.FlightID, f.FlightCode, f.AircraftID, f.FromAirport, f.ToAirport,
                           f.DepartureTime, f.ArrivalTime, f.Status, f.BasePrice,
                           af.AirportCode, af.IATA, af.AirportName, af.City, af.Country,
                           at.AirportCode, at.IATA, at.AirportName, at.City, at.Country
                    FROM Flights f
                    JOIN Airports af ON f.FromAirport = af.AirportCode
                    JOIN Airports at ON f.ToAirport = at.AirportCode
                    WHERE f.FromAirport = @from AND f.ToAirport = @to
                          AND CAST(f.DepartureTime AS DATE) = @depDate";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@from", fromCode);
                    cmd.Parameters.AddWithValue("@to", toCode);
                    cmd.Parameters.AddWithValue("@depDate", depDate.Date);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var flight = new Flight
                            {
                                FlightID = reader.GetInt32(0),
                                FlightCode = reader.GetString(1),
                                AircraftID = reader.GetInt32(2),
                                FromAirport = reader.GetString(3),
                                ToAirport = reader.GetString(4),
                                DepartureTime = reader.GetDateTime(5),
                                ArrivalTime = reader.GetDateTime(6),
                                Status = reader.GetString(7),
                                BasePrice = reader.GetDecimal(8)
                            };

                            var from = new AR_Winform.Domain.Entities.Airport
                            {
                                AirportCode = reader.GetString(9),
                                IATA = reader.GetString(10),
                                AirportName = reader.GetString(11),
                                City = reader.GetString(12),
                                Country = reader.GetString(13)
                            };

                            var to = new AR_Winform.Domain.Entities.Airport
                            {
                                AirportCode = reader.GetString(14),
                                IATA = reader.GetString(15),
                                AirportName = reader.GetString(16),
                                City = reader.GetString(17),
                                Country = reader.GetString(18)
                            };

                            result.Add((flight, from, to));
                        }
                    }
                }
            }

            return result;
        }

    }
}