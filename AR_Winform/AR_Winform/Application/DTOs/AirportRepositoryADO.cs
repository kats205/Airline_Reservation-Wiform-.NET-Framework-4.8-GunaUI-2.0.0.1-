using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AR_Winform.Application.DTOs
{
    public class Airport
    {
        public string AirportCode { get; set; }
        public string AirportName { get; set; }
        public string CityName { get; set; }
        public string Country { get; set; }
    }

    public class AirportRepositoryADO
    {
        public class AirportRepository
        {
            private readonly string _connectionString;

            public AirportRepository()
            {
                _connectionString = ConfigurationManager.ConnectionStrings["MyDbContext"].ConnectionString;

            }

            public List<Airport> GetAirports(int page, int pageSize, string excludeCode = null)
            {
                var list = new List<Airport>();
                string sql = @"
                            SELECT AirportCode, AirportName, City, Country
                            FROM Airports
                            WHERE (@Exclude IS NULL OR AirportCode <> @Exclude)
                            ORDER BY City
                            OFFSET @Skip ROWS FETCH NEXT @Take ROWS ONLY;";

                using (SqlConnection conn = new SqlConnection(_connectionString))
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Exclude", (object)excludeCode ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Skip", (page - 1) * pageSize);
                    cmd.Parameters.AddWithValue("@Take", pageSize);

                    conn.Open();
                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            list.Add(new Airport
                            {
                                AirportCode = rd.GetString(0),
                                AirportName = rd.GetString(1),
                                CityName = rd.GetString(2),
                                Country = rd.GetString(3)
                            });
                        }
                    }
                }
                return list;
            }

            public AR_Winform.Domain.Entities.Airport GetByCode(string airportCode)
            {
                AR_Winform.Domain.Entities.Airport airport = null;

                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    string sql = "SELECT AirportCode, IATA, AirportName, City, Country " +
                                 "FROM Airports WHERE AirportCode = @code";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@code", airportCode);
                        conn.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                airport = new AR_Winform.Domain.Entities.Airport
                                {
                                    AirportCode = reader["AirportCode"].ToString(),
                                    IATA = reader["IATA"].ToString(),
                                    AirportName = reader["AirportName"].ToString(),
                                    City = reader["City"].ToString(),
                                    Country = reader["Country"].ToString()
                                };
                            }
                        }
                    }
                }

                return airport;
            }


        }
    }
}
