using BusinessObjects;
using ORM;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public class Repository : IRepository
    {
        private IGenericContext db;

        public Repository(IGenericContext dbContext)
        {
            db = dbContext;
        }

        public List<IHero> GetHeroes()
        {
            return db.GetHeroes();
        }
        public IHero GetHero(int id)
        {
            return db.GetHero(id);
        }
        public string[] GetStates()
        {
            return new string[] { "AK", "AL", "AR", "AZ", "CA", "CO", "CT", "DC", "DE", "FL", "GA", "HI", "IA", "ID", "IL", "IN", "KS", "KY", "LA", "MA", "MD", "ME", "MI", "MN", "MO", "MS", "MT", "NC", "ND", "NE", "NH", "NM", "NJ", "NV", "NY", "OH", "OK", "OR", "PA", "RI", "SC", "SD", "TN", "TX", "UT", "VA", "VT", "WA", "WI", "WV", "WY" };
        }
        public string[] GetStreetDirection()
        {
            return new string[] { "N", "NE", "NW", "S", "SE", "SW", "E", "W" };
        }
        public string[] GetStreetSuffix()
        {
            return new string[] { "AL", "AVE", "BLVD", "CIR", "CK", "CL", "COVE", "CRES", "CT", "CYN", "DR", "GLEN", "GRN", "HILL", "HWY", "LANE", "LN", "LOOP", "MALL", "N", "PARK", "PASS", "PK", "PKWY", "PL", "PT", "PZ", "RD", "RE", "ROAD", "ROW", "S", "SQ", "ST", "TER", "TR", "VIEW", "W", "WALK", "WAY" };
        }
    }
}