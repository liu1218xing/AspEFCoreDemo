using System.Collections.Generic;

namespace AspEFCore.Domain
{
    public class Province
    {
        public Province()
        {
            Cites = new List<City>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Population { get; set; }
        public List<City> Cites { get; set; }
    }
}