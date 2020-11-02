using Api.Model;
using Api.MyModels;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Services.Locations
{
    public class LocationService : ILocationService
    {
        private readonly ApiDbContext _context;
        public LocationService(ApiDbContext context)
        {
            _context = context;
        }

        public List<SubDistrict> GetSubDistrictsByDate(DateTime date)
        {
            List<SubDistrict> subDistricts = new List<SubDistrict>();

            var connection = _context.Database.GetDbConnection();
            var command = connection.CreateCommand();
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.CommandText = "dbo.GetSubDistrictsByDate";
            command.Connection = connection;
            command.Parameters.Add(new SqlParameter("@date", date));
            connection.Open();
            command.ExecuteNonQuery();
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    SubDistrict subDistrict = new SubDistrict()
                    {
                        SubDistrictId = Convert.ToInt32(reader["SubDistrictId"].ToString()),
                        DistrictId = Convert.ToInt32(reader["DistrictId"].ToString()),
                        Name = reader["Name"].ToString(),
                        RegionName = reader["RegionName"].ToString(),
                        CommunityName = reader["CommunityName"].ToString(),
                        Comment = reader["Comment"].ToString(),
                        EmployCount = Convert.ToInt32(reader["EmployCount"].ToString())
                    };
                    subDistricts.Add(subDistrict);
                }
            }
            command.Connection.Close();
            connection.Close();

            return subDistricts;
        }

        public List<SubDistrict> GetSubDistrictsByDateLocal(DateTime date)
        {
            List<SubDistrict> subDistricts = new List<SubDistrict>();

            var connection = _context.Database.GetDbConnection();
            var command = connection.CreateCommand();
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.CommandText = "cec.GetSubDistrictsByDate";
            command.Connection = connection;
            command.Parameters.Add(new SqlParameter("@date", date));
            connection.Open();
            command.ExecuteNonQuery();
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    SubDistrict subDistrict = new SubDistrict()
                    {
                        SubDistrictId = Convert.ToInt32(reader["SubDistrictId"].ToString()),
                        DistrictId = Convert.ToInt32(reader["DistrictId"].ToString()),
                        Name = reader["Name"].ToString(),
                        RegionName = reader["RegionName"].ToString(),
                        CommunityName = reader["CommunityName"].ToString(),
                        Comment = reader["Comment"].ToString(),
                        EmployCount = Convert.ToInt32(reader["EmployCount"].ToString())
                    };
                    subDistricts.Add(subDistrict);
                }
            }
            command.Connection.Close();
            connection.Close();

            return subDistricts;
        }
    }
}
