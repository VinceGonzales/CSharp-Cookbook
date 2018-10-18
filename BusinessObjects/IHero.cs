using System;

namespace BusinessObjects
{
    public interface IHero
    {
        int Id { get; set; }
        string Name { get; set; }
        int Stars { get; set; }
        int Level { get; set; }
        string Description { get; set; }
        string HeroClass { get; set; }
    }
}
