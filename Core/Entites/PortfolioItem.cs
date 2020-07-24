using System;

namespace Core.Entites
{
    public class PortfolioItem : EntityBase
    {
        public String ProjectName { get; set; }
        public String Description { get; set; }
        public String ImageUrl { get; set; }
    }
}
