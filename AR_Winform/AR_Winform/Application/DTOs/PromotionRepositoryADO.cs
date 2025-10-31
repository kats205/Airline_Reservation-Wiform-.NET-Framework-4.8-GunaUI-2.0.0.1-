using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AR_Winform.Application.DTOs
{
    public class Promotion
    {
        public string PromoCode { get; set; }
        public string Description { get; set; }
        public decimal DiscountPercent { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
    internal class PromotionRepositoryADO
    {
        private readonly string _connectionString;

        public PromotionRepositoryADO()
        {
            // Lấy connection string từ app.config
            _connectionString = ConfigurationManager.ConnectionStrings["MyDbContext"].ConnectionString;
        }

        public List<Promotion> GetRandomPromotions(int count)
        {
            var promotions = new List<Promotion>();

            string sql = $@"
                SELECT TOP {count} PromoCode, Description, DiscountPercent, StartDate, EndDate
                FROM Promotions
                WHERE Status = 'Active'
                ORDER BY NEWID();";

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        promotions.Add(new Promotion
                        {
                            PromoCode = reader.GetString(0),
                            Description = reader.GetString(1),
                            DiscountPercent = reader.GetDecimal(2),
                            StartDate = reader.GetDateTime(3),
                            EndDate = reader.GetDateTime(4)
                        });
                    }
                }
            }

            return promotions;
        }

    }
}
