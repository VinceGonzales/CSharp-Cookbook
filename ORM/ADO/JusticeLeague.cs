using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM.ADO
{
    public class JusticeLeague : IGenericContext
    {
        protected string _connectionString;
        public JusticeLeague(string connectionString)
        {
            _connectionString = connectionString;
        }
        public List<IHero> GetHeroes()
        {
            List<IHero> heroes = new List<IHero>();
            using(SqlConnection con = new SqlConnection(_connectionString))
            {
                string sql = "SELECT * FROM Heroes";
                SqlCommand cmd = new SqlCommand(sql, con);
                //cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Hero hero = new Hero
                    {
                        Id = (int)reader["Id"],
                        Name = (string)reader["Name"],
                        Stars = (int)reader["Stars"],
                        Level = (int)reader["Level"],
                        Description = (string)reader["Description"],
                        HeroClass = (string)reader["HeroClass"]
                    };
                    heroes.Add(hero);
                }
                reader.Close();
            }
            return heroes;
        }
        public IHero GetHero(int id)
        {
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                SqlCommand cmd = new SqlCommand("GetHero", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                //cmd.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int, id));
                cmd.Parameters.AddWithValue("@Id", id);
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.SingleRow);

                if (!reader.HasRows) return null;

                reader.Read();
                Hero hero = new Hero
                {
                    Id = (int)reader["Id"],
                    Name = (string)reader["Name"],
                    Stars = (int)reader["Stars"],
                    Level = (int)reader["Level"],
                    Description = (string)reader["Description"],
                    HeroClass = (string)reader["HeroClass"]
                };
                reader.Close();
                return hero;
            }
        }
    }
}
