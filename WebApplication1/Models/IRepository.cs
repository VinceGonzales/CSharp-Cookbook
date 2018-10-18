using BusinessObjects;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public interface IRepository
    {
        List<IHero> GetHeroes();
        IHero GetHero(int id);
        string[] GetStates();
        string[] GetStreetDirection();
        string[] GetStreetSuffix();
    }
}
