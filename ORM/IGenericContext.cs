using BusinessObjects;
using System.Collections.Generic;

namespace ORM
{
    public interface IGenericContext
    {
        List<IHero> GetHeroes();
        IHero GetHero(int id);
    }
}
