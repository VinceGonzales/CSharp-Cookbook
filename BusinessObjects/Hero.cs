using System;

namespace BusinessObjects
{
    public class Hero : IHero
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Stars { get; set; }
        public int Level { get; set; }
        public string Description { get; set; }
        public string HeroClass { get; set; }
    }
}
